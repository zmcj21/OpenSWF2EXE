namespace OpenSWF2EXE
{
    public static class Config
    {
        private static string configPath;

        static Config()
        {
            configPath = Path.Combine(new string[] { Environment.CurrentDirectory, "s2e_config.txt" });
            if (!File.Exists(configPath))
            {
                FileStream fileStream = File.Create(configPath);
                fileStream.Close();
            }
        }

        public static int GetLanguage()
        {
            string value = GetString("language", "2");
            return int.Parse(value);
        }

        public static void SetLanguage(int value)
        {
            SetString("language", value.ToString());
        }

        public static string GetString(string key, string defaultVal)
        {
            string[] lines = File.ReadAllLines(configPath);

            foreach (string line in lines)
            {
                int signIndex = line.IndexOf('=');
                if (signIndex == -1) continue;

                string keyStr = line.Substring(0, signIndex);
                string keyStrWithoutSpace = keyStr.Trim();

                //return first key
                if (keyStrWithoutSpace.Equals(key))
                {
                    string valueStr = line.Substring(signIndex + 1, line.Length - 1 - keyStr.Length);
                    string valueStrWithoutSpace = valueStr.Trim();
                    return valueStrWithoutSpace;
                }
            }

            return defaultVal;
        }

        public static void SetString(string key, string value)
        {
            string[] lines = File.ReadAllLines(configPath);

            //If the file is empty, just write!
            if (lines.Length == 0 || (lines.Length == 1 && string.IsNullOrWhiteSpace(lines[0])))
            {
                string content = key + " = " + value;
                File.WriteAllText(configPath, content);
                return;
            }

            bool keyExists = false;
            bool needToWrite = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                int signIndex = line.IndexOf('=');
                if (signIndex == -1) continue;

                string keyStr = line.Substring(0, signIndex);
                string keyStrWithoutSpace = keyStr.Trim();
                //Find first key
                if (keyStrWithoutSpace.Equals(key))
                {
                    keyExists = true;
                    string valueStr = line.Substring(signIndex + 1, line.Length - 1 - keyStr.Length);
                    string valueStrWithoutSpace = valueStr.Trim();
                    //If value changed
                    if (valueStrWithoutSpace != value)
                    {
                        needToWrite = true;
                        lines[i] = keyStrWithoutSpace + " = " + value;
                    }
                    break;
                }
            }

            if (needToWrite)
            {
                File.WriteAllLines(configPath, lines);
            }
            else if (!keyExists)
            {
                string newLine = "\n" + key + " = " + value;
                List<string> newLines = new List<string>();
                newLines.AddRange(lines);
                newLines.Add(newLine);
                File.WriteAllLines(configPath, newLines.ToArray());
            }
        }
    }
}