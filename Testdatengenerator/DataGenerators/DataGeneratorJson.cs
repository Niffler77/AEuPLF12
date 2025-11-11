using System.Text.Json;

using TestDatenGenerator;
using TestDatenGenerator.DataGenerators;

namespace Testdatengenerator.DataGenerators
{
    internal class DataGeneratorJson : IDataGenerator
    {
        public void SaveData( List<double> input )
        {
            var json = JsonSerializer.Serialize( input );
            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine( tempfile, "testDatenJSON.json" );
            File.WriteAllText( tempfile, json );
        }
    }
}