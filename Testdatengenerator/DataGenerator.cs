using TestDatenGenerator.DataGenerators;

namespace TestDatenGenerator
{
    internal class DataGenerator
    {
        internal List<double> DataSet;

        private IDataGenerator dataGenerator;

        internal DataGenerator( IDataGenerator dataGenerator )
        {
            DataSet = [];
            this.dataGenerator = dataGenerator;
        }

        internal void CreateData( double min, double max, int amount )
        {
            Random random = new Random();
            for( int i = 0; i < amount; i++ )
            {
                DataSet.Add( random.Next( (int)min, (int)max + 1 ) );
            }
        }

        internal void CreateData( int min, int max ) => CreateData( min, max, 100 );

        internal void SaveData() => dataGenerator.SaveData( DataSet );
    }
}