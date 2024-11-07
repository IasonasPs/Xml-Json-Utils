using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace XmlConvertor.services
{
    public class Convertor
    {
        public static string XmlToJson(string xml)
        {
            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xml);

            string json = JsonConvert.SerializeObject(doc);
            return json;
        }
        private static readonly XDeclaration _defaultDeclaration = new("1.0", null, null);
        public static string JsonToXml(string text)
        {
            //Console.WriteLine("----------------------------------------------------------------");
            XDocument doc;

            try
            {
                doc = JsonConvert.DeserializeXNode(text)!;
            }
            catch (Exception e)
            {
                var xmldoc = JsonConvert.DeserializeXmlNode(text, "root") ;

                XmlNodeReader nodeReader = new XmlNodeReader(xmldoc);
                nodeReader.MoveToContent();
                doc = XDocument.Load(nodeReader); 
            }

            var declaration = doc.Declaration ?? _defaultDeclaration;

            string xml = $"{declaration}{Environment.NewLine}{doc}";

            return xml;
        }
    }
}
