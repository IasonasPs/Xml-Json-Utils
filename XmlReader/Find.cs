namespace XmlReader
{
    public class Find
    {
        public static string FindFile(string path,string name)
        {
            try
            {
                var p = path+@"\"+name;
                string text = File.ReadAllText(p );
                return text;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
