using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Testdatengenerator 
{
    internal class DataGeneratorCSV : DataGenerator
    {
       
        internal override void saveData()
        {
            var csv = new StringBuilder();

            foreach (var item in DataSet)
            {
                csv.Append(item.ToString() + ";");
            }
            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine(tempfile, "testdatencsv.csv");

            File.WriteAllText(tempfile, csv.ToString());
        }

    }
}
