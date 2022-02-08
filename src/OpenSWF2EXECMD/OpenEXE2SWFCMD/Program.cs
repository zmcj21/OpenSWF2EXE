//Reference:http://www.nullsecurity.org/article/extracting_swf_from_flash_projector
//#define TEST

string inputEXEName;
string inputEXEPath;

Console.Title = "OpenEXE2SWF Converter";
Console.WriteLine("Welcome to Open exe to swf converter!");

if (args.Length == 1)
{
    inputEXEPath = Path.Combine(new string[] { Environment.CurrentDirectory, args[0] });
}
else
{
#if !TEST
    Console.WriteLine("Please input executable file name:");
    inputEXEPath = Path.Combine(new string[] { Environment.CurrentDirectory, Console.ReadLine() });
#else
    inputEXEPath = Path.Combine(new string[] { Environment.CurrentDirectory, "boxhead2play.exe" });
#endif
}

int dashIndex = inputEXEPath.LastIndexOf('\\');
inputEXEName = inputEXEPath.Substring(dashIndex + 1, inputEXEPath.LastIndexOf('.') - dashIndex - 1);

bool inputEXEExecutable = false;

byte[] checkValueArray = new byte[4];
byte[] swfLengthArray = new byte[4];
byte[] data = File.ReadAllBytes(inputEXEPath);

for (int i = 0; i < 4; i++)
{
    checkValueArray[i] = data[data.Length - 8 + i];
    swfLengthArray[i] = data[data.Length - 4 + i];
}

uint checkValue = BitConverter.ToUInt32(checkValueArray, 0);
uint swfLength = BitConverter.ToUInt32(swfLengthArray, 0);

if (checkValue == 0xFA123456)
{
    inputEXEExecutable = true;
}
if (!inputEXEExecutable)
{
    Console.WriteLine("executable file is invalid");
    return;
}

byte[] flashPlayerData = new byte[data.Length - 8 - swfLength];
byte[] swfData = new byte[swfLength];
for (int i = 0; i < flashPlayerData.Length; i++)
{
    flashPlayerData[i] = data[i];
}
for (int i = 0; i < swfData.Length; i++)
{
    swfData[i] = data[i + data.Length - 8 - swfLength];
}

DirectoryInfo outputDir = Directory.CreateDirectory(Environment.CurrentDirectory + "\\" + $"{inputEXEName}_output");

FileStream flashPlayerFile = File.Create(outputDir.FullName + "\\FlashPlayer.exe");
FileStream swfFile = File.Create(outputDir.FullName + $"\\{inputEXEName}.swf");

flashPlayerFile.Write(flashPlayerData,0, flashPlayerData.Length);
swfFile.Write(swfData, 0, swfData.Length);

flashPlayerFile.Close();
swfFile.Close();

Console.WriteLine("Work success!");
Console.ReadLine();