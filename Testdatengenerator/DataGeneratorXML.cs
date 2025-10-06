using System.Xml;
using System.Xml.Linq;

namespace Testdatengenerator
{
    internal class DataGeneratorXML : DataGenerator
    {
        internal override void saveData()
        {
            
            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine(tempfile, "testdatenxml.xml");

            using var xml = XmlWriter.Create(tempfile);
            xml.WriteStartElement("Temperatures");
            foreach (var item in DataSet)
            {
                xml.WriteElementString("Temperature", item.ToString());
            }
            xml.WriteEndElement();
            xml.Close();
        }

    }
}
