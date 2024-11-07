using XmlConvertor.services;
using XmlReader;


namespace XmlConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var input = ValidateInput(  );
            Menu(desktop, input);

            #region
            //string filename = "xml.txt";
            //string path = @"..\..\..\..\XmlReader\XmlFiles";
            //var fullPath = Path.GetFullPath(path);


            //string xml = Find.FindFile(path, filename);
            //string result = Convertor.XmlToJson(xml);
            //Save.SaveToFile(result, "jsonfromXml.json", true);


            //string json = Find.FindFile(desktop, "jsonfromXml.json");
            //result = Convertor.JsonToXml(json);
            //Save.SaveToFile(result, "XmlFromJson.xml", true);

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("All files (should there be any files..) saved successfully!!");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");
            #endregion
        }

        private static void Menu(string workingDirectory, string? input)
        {
            if (input == "1") //Json to XML 
            {
                Console.WriteLine("Enter the name of the json file you want to convert to XML");
                var name = Console.ReadLine();

                string filename = name + ".json";
                try
                {
                    string json = Find.FindFile(workingDirectory, filename);
                    string result = Convertor.JsonToXml(json);
                    Save.SaveToFile(result, name + ".xml", true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else //XML to Json
            {
                Console.WriteLine("Enter the name of the XML file you want to convert to Json");
                var name = Console.ReadLine();

                string filename = name + ".xml";
                try
                {
                    string xml = Find.FindFile(workingDirectory, filename);
                    string result = Convertor.XmlToJson(xml);
                    Save.SaveToFile(result, name + ".json", true);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        #region Input Validation
        private static string? ValidateInput(string? input = " ")
        {
            while (!Validate(input, "1", "2"))
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("Press 1 for converting a json file to xml or " + "Press 2 for converting an xml file to json :");
                input = Console.ReadLine();
            }

            return input;
        }

        private static bool Validate(string? input, string x, string y)
        {
            return (input == x || input == y) ? true : false;
        }
        #endregion 
    }

}