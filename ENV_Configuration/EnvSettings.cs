namespace ENV_Configuration
{
    public class EnvSettings
    {
        public string Path { get; set; }

        public EnvSettings(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Invalid path provided.");

            if (!File.Exists(path))
            {
                File.Create(path).Dispose(); // Create an empty file if it doesn't exist
            }

            Path = path;
        }

        // Reads the value of the given key from the .env file
        public string ReadValue(string key, string defaultValue = "")
        {
            try
            {
                var lines = File.ReadAllLines(Path);

                foreach (var line in lines)
                {
                    var trimmedLine = line.Trim();
                    if (trimmedLine.StartsWith("#") || string.IsNullOrEmpty(trimmedLine)) continue; // Ignore comments or empty lines

                    var keyValuePair = trimmedLine.Split('=', 2);
                    if (keyValuePair.Length == 2 && keyValuePair[0].Trim() == key)
                        return keyValuePair[1].Trim();
                }

                return defaultValue;
            }
            catch (Exception ex)
            {
                LogMessage($"Error reading .env file: {ex.Message}");
                return defaultValue;
            }
        }

        // Writes or updates the value of the given key in the .env file
        public void WriteValue(string key, string value)
        {
            try
            {
                var lines = File.Exists(Path) ? File.ReadAllLines(Path).ToList() : new List<string>();
                bool found = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    var line = lines[i];
                    var keyValuePair = line.Split('=', 2);
                    if (keyValuePair.Length == 2 && keyValuePair[0].Trim() == key)
                    {
                        lines[i] = $"{key}={value}";
                        found = true;
                        break;
                    }
                }

                if (!found)
                    lines.Add($"{key}={value}");

                File.WriteAllLines(Path, lines);
            }
            catch (Exception ex)
            {
                LogMessage($"Error writing to .env file: {ex.Message}");
            }
        }

        // Deletes a key from the .env file
        public void DeleteKey(string key)
        {
            try
            {
                var lines = File.ReadAllLines(Path).ToList();
                lines.RemoveAll(line => line.StartsWith($"{key}="));

                File.WriteAllLines(Path, lines);
            }
            catch (Exception ex)
            {
                LogMessage($"Error deleting key from .env file: {ex.Message}");
            }
        }

        // Utility method for logging errors
        private void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}
