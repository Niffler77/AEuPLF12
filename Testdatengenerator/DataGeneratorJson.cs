using System.Text.Json;

namespace TestDatenGenerator
{
    internal class DataGeneratorJson : DataGenerator
    {

        internal override void saveData()
        {
            var json = JsonSerializer.Serialize<DataGenerator>(this);
            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine(tempfile, "testDatenJSON.json");
            File.WriteAllText(tempfile, json);
        }
    }
}
