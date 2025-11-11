using System.Data;
using System.Globalization;
using System.Xml;

using TestDatenGenerator;
using TestDatenGenerator.DataGenerators;

namespace Testdatengenerator.DataGenerators
{
    internal class DataGeneratorXML : IDataGenerator
    {
        public void SaveData( List<double> input )
        {
            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine( tempfile, "testDatenXML.xml" );

            using var xml = XmlWriter.Create( tempfile );
            xml.WriteStartElement( "Temperatures" );
            foreach( var item in input )
            {
                xml.WriteElementString( "Temperature", item.ToString( CultureInfo.InvariantCulture ) );
            }

            xml.WriteEndElement();
            xml.Close();
        }
    }
}