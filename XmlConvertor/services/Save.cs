namespace XmlConvertor.services
{
    public class Save
    {
        public static void SaveToFile(string text, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, filename);

                var fileExists = File.Exists(filePath);
                
                File.WriteAllText(filePath, text);
                Console.WriteLine(". . .. . .. . .. . .. . .. . .. . .. . .. . .. . .. . .. . .. . .. . .");
                Console.WriteLine($"A file named {filename} was {(fileExists ? "updated" : "created")} in {desktopPath}");
                Console.WriteLine(". . .. . .. . .. . .. . .. . .. . .. . .. . .. . .. . .. . .. . .. . .");
            }
        }
    }
}
