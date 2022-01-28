namespace OpenSWF2EXE
{
    public class SWF_TO_EXE
    {
        //ref:http://www.nullsecurity.org/article/extracting_swf_from_flash_projector
        public static bool CheckFlashPlayer(string flashPlayerPath)
        {
            using (FileStream file = new FileStream(flashPlayerPath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(file))
                {
                    byte[] signature = reader.ReadBytes(2);
                    if (signature[0] == 'M' && signature[1] == 'Z')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        //ref:https://stackoverflow.com/questions/55534865/cant-manage-to-extract-or-convert-swf-file-because-they-seem-to-be-corrupted
        public static bool CheckSwfFile(string swfFilePath)
        {
            using (FileStream file = new FileStream(swfFilePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(file))
                {
                    byte[] signature = reader.ReadBytes(3);
                    if (signature[0] == 'F' && signature[1] == 'W' && signature[2] == 'S')
                    {
                        return true;
                    }
                    else if (signature[0] == 'C' && signature[1] == 'W' && signature[2] == 'S')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static void BindSwfAndExe()
        {

        }
    }
}