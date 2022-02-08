//Reference:http://www.nullsecurity.org/article/extracting_swf_from_flash_projector
//#define TEST

string flashPlayerPath;
string flashSWFPath;
string outputPath;

Console.Title = "OpenSWF2EXE Converter";
Console.WriteLine("Welcome to Open swf to exe converter!");

if (args.Length == 2)
{
    flashPlayerPath = Path.Combine(new string[] { Environment.CurrentDirectory, args[0] });
    flashSWFPath = Path.Combine(new string[] { Environment.CurrentDirectory, args[1] });
    outputPath = Path.Combine(new string[] { Environment.CurrentDirectory, $"{args[1].Substring(0, args[1].LastIndexOf('.'))}.exe" });
}
else
{
#if !TEST
    Console.WriteLine("Please input flashPlayerPath:");
    flashPlayerPath = Path.Combine(new string[] { Environment.CurrentDirectory, Console.ReadLine() });
    Console.WriteLine("Please input flashSWFPath:");
    flashSWFPath = Path.Combine(new string[] { Environment.CurrentDirectory, Console.ReadLine() });
#else
    flashPlayerPath = Path.Combine(new string[] { Environment.CurrentDirectory, "FlashPlayer8.exe" });
    flashSWFPath = Path.Combine(new string[] { Environment.CurrentDirectory, "boxhead2play.swf" });
#endif
    outputPath = Path.Combine(new string[] { Environment.CurrentDirectory, $"{flashSWFPath.Substring(0, flashSWFPath.LastIndexOf('.'))}.exe" });
}

bool flashPlayerExecutable = false;
bool flashSWFExecutable = false;

//open files:
FileStream flashPlayerFile = new FileStream(flashPlayerPath, FileMode.Open, FileAccess.Read);
FileStream flashSWFFile = new FileStream(flashSWFPath, FileMode.Open, FileAccess.Read);
FileStream outputFile = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
BinaryReader flashPlayerReader = new BinaryReader(flashPlayerFile);
BinaryReader flashSWFReader = new BinaryReader(flashSWFFile);
BinaryWriter outputWriter = new BinaryWriter(outputFile);

byte[] playerSignature = flashPlayerReader.ReadBytes(2);
if (playerSignature[0] == 'M' && playerSignature[1] == 'Z')
{
    flashPlayerExecutable = true;
}
if (!flashPlayerExecutable)
{
    Console.WriteLine("flashPlayer is invalid");
    return;
}

byte[] flashSignature = flashSWFReader.ReadBytes(3);
if ((flashSignature[0] == 'F' && flashSignature[1] == 'W' && flashSignature[2] == 'S') ||
    (flashSignature[0] == 'C' && flashSignature[1] == 'W' && flashSignature[2] == 'S'))
{
    flashSWFExecutable = true;
}
if (!flashSWFExecutable)
{
    Console.WriteLine("flash swf is invalid");
    return;
}

//-----combine flashPlayer and flashSWF-----
flashPlayerReader.BaseStream.Position = 0;
flashSWFReader.BaseStream.Position = 0;
//copy flashPlayer:
for (int i = 0; i < flashPlayerReader.BaseStream.Length; i++)
{
    outputWriter.Write((byte)flashPlayerReader.BaseStream.ReadByte());
}
//copy flashSWF:
for (int i = 0; i < flashSWFReader.BaseStream.Length; i++)
{
    outputWriter.Write((byte)flashSWFReader.BaseStream.ReadByte());
}
//write 0xFA123456(Flash Projector "check" value):
outputWriter.Write(0xFA123456);
//write Size of the original SWF file:
outputWriter.Write((uint)flashSWFReader.BaseStream.Length);

//close files:
flashPlayerReader.Close();
flashSWFReader.Close();
outputWriter.Close();
flashPlayerFile.Close();
flashSWFFile.Close();
outputFile.Close();

Console.WriteLine("Work success!");
Console.ReadLine();