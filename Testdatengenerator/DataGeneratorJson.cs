using System.Data;
using System.Text.Json;

namespace Testdatengenerator
{
    internal class DataGeneratorJson : DataGenerator
    {

        internal override void saveData()
        {
            var json = JsonSerializer.Serialize<DataGenerator>(this);
            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine(tempfile, "testdatenjson.json");

            File.WriteAllText(tempfile, json);
        }
    }
}
