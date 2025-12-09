using System.Xml;
using System.Xml.Serialization;

namespace Dateneinlesen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CSVImport();
            //CSVPokemonImport();
            //JSONImport();
            XMLImport();

        }

        private static void CSVPokemonImport()
        {
            string path = "pokemon_data.csv";

            var lines = File.ReadAllLines(path);
            Dictionary<string,Pokemon> pokemons = [];
            foreach (string line in lines)
            {
                var items = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                if (items.Length < 7)
                {
                    continue;
                }

                var ishp = long.TryParse(items[3], out long hp);
                long.TryParse(items[4], out long attack);
                long.TryParse(items[5], out long defense);
                bool.TryParse(items[6], out bool legendary);

                if (ishp == false)
                {
                    continue;
                }

                pokemons.Add(items[0], new Pokemon()
                {
                    Name = items[0],
                    Type1 = items[1],
                    Type2 = items[2],   
                    Hp = hp,
                    Attack = attack,
                    Defense = defense,
                    Legendarys = legendary
                });
            }

            foreach (var kvp in pokemons)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value.Name}, {kvp.Value.Type1}, {kvp.Value.Type2}, {kvp.Value.Hp}, {kvp.Value.Attack}, {kvp.Value.Defense}, {kvp.Value.Legendarys}");
            }
            Console.WriteLine();
        }

        private static void XMLImport()
        {
            string path = "catalog.xml";
            var xmlImport = XmlReader.Create(path);

            XmlSerializer serializer = new XmlSerializer(typeof(catalog));
            catalog liste = (catalog)serializer.Deserialize(xmlImport);

            foreach (var song in liste.songs)
            {
                Console.WriteLine($"ID: {song.Id}");
                Console.WriteLine($"Titel: {song.Title}");
                Console.WriteLine($"Artist: {song.Artist}");
                Console.WriteLine($"Preis: {song.Price}");
                Console.WriteLine($"Jahr: {song.Year}");
                Console.WriteLine("-----------");
            }

        }

        private static void JSONImport()
        {
            string path = "friends.json";
            var jsonImport = File.ReadAllText(path);
            var friends = System.Text.Json.JsonSerializer.Deserialize<List<string>>(jsonImport);
            foreach (var friend in friends)
            {
                //Console.WriteLine($"{friend.Name}, {friend.Age}, {friend.City}");
            }
            Console.WriteLine();
        }
        private static void CSVImport()
        {
            string path = "friends.csv";

            var csvImport = File.ReadAllText(path);
            var lines = csvImport.Split('\n');
            List<string[]> csv = [];
            foreach (string line in lines)
            {
                var items = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                csv.Add(items);
            }

            foreach (string[] stringse in csv)
            {
                foreach (string s in stringse)
                {
                    Console.Write(" " + s + ";");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
