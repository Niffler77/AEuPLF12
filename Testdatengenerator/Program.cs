namespace Testdatengenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Word!");

            Console.WriteLine("Pick the Type of the DataGenerator:" +
                "\n - 1. CSV" +
                "\n - 2. XML" +
                "\n - 3. Json");

            var input = Console.ReadLine();

            if (input is null)
            {
                return;
            }

            DataGenerator dataGenerator;
            if (int.TryParse(input, out int result))
            {

                dataGenerator = result switch
                {
                    1 => new DataGeneratorCSV(),
                    2 => new DataGeneratorXML(),
                    3 => new DataGeneratorJson(),
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
            else
            {
                var lowerCaseInput = input?.ToLower();
                dataGenerator = lowerCaseInput switch
                {
                    "csv" => new DataGeneratorCSV(),
                    "xml" => new DataGeneratorXML(),
                    "json" => new DataGeneratorJson(),
                    _ => throw new ArgumentOutOfRangeException()
                };
            }

            dataGenerator.createData(0, 100);
            dataGenerator.saveData();
        }



    }
}
