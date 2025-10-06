using System.Globalization;
using System.Xml;

namespace TestDatenGenerator
{
    internal class DataGeneratorXML : DataGenerator
    {
        internal override void saveData()
        {
            
            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine(tempfile, "testDatenXML.xml");

            using var xml = XmlWriter.Create(tempfile);
            xml.WriteStartElement("Temperatures");
            foreach (var item in DataSet)
            {
                xml.WriteElementString("Temperature", item.ToString( CultureInfo.InvariantCulture ));
            }
            xml.WriteEndElement();
            xml.Close();
        }

    }
}
