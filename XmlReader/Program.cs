using System.Xml;

namespace XmlReader
{
    public class Program
    {
        static readonly string? desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();

            Console.WriteLine("Enter the name of the XML file you want to read");
            var name = Console.ReadLine();

            string filename = name + ".xml";
            string filetext = null;
            try
            {
                filetext = Find.FindFile(desktop, filename);
                Console.WriteLine("*******************************************");
                Console.WriteLine($"FileName : {filename} ............\n");
                Console.WriteLine(filetext);
                Console.WriteLine("*******************************************");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
