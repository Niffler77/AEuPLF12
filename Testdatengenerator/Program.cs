using Testdatengenerator.DataGenerators;

namespace TestDatenGenerator
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Hello, Word!" );

            Console.WriteLine( "Pick the Type of the DataGenerator:" + "\n - 1. CSV" + "\n - 2. XML" + "\n - 3. Json" );

            var input = Console.ReadLine();

            if( input is null )
            {
                return;
            }

            DataGenerator dataGenerator;
            if( int.TryParse( input, out int result ) )
            {
                dataGenerator = result switch
                {
                    1 => new DataGenerator( new DataGeneratorCSV() ),
                    2 => new DataGenerator( new DataGeneratorXML() ),
                    3 => new DataGenerator( new DataGeneratorJson() ),
                    _ => throw new ArgumentOutOfRangeException(),
                };
            }
            else
            {
                var lowerCaseInput = input?.ToLower();
                dataGenerator = lowerCaseInput switch
                {
                    "csv"  => new DataGenerator( new DataGeneratorCSV() ),
                    "xml"  => new DataGenerator( new DataGeneratorXML() ),
                    "json" => new DataGenerator( new DataGeneratorJson() ),
                    _      => throw new ArgumentOutOfRangeException(),
                };
            }

            dataGenerator.CreateData( 0, 100 );
            dataGenerator.SaveData();
        }
    }
}