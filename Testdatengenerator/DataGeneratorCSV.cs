using System.Text;

namespace TestDatenGenerator 
{
    internal class DataGeneratorCSV : DataGenerator
    {
       
        internal override void saveData()
        {
            var csv = new StringBuilder();

            foreach (var item in DataSet)
            {
                csv.Append(item + ";");
            }
            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine(tempfile, "testDatenCSV.csv");

            File.WriteAllText(tempfile, csv.ToString());
        }

    }
}
