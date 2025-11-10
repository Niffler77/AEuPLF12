using System.Text;

using TestDatenGenerator.DataGenerators;

namespace Testdatengenerator.DataGenerators
{
    internal class DataGeneratorCSV : IDataGenerator
    {
        public void saveData( List<double> input )
        {
            var csv = new StringBuilder();

            foreach( var item in input )
            {
                csv.Append( item + ";" );
            }

            var tempfile = Path.GetTempPath();
            tempfile = Path.Combine( tempfile, "testDatenCSV.csv" );

            File.WriteAllText( tempfile, csv.ToString() );
        }
    }
}