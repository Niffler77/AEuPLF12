using System.Data;
using System.Text.Json.Serialization;

namespace Testdatengenerator
{
    [JsonSerializable(typeof(DataGenerator))]
    internal class DataGenerator
    {
        [JsonInclude()]
        internal List<double> DataSet;

        internal DataGenerator()
        {
            DataSet = new List<double>();
        }

        internal void createData(double min, double max, int amount)
        {
            Random random = new Random();
            for (int i = 0; i < amount; i++)
            {
                DataSet.Add(random.Next((int)min, (int) max + 1));
            }
        }

        internal void createData(int min, int max) => createData(min, max, 100);

        internal virtual void saveData()
        {

        }
    }
}
