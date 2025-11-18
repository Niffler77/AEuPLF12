namespace List
{
    internal class Program
    {
        static void Main( string[] args )
        {
            List<string> names = ["Müller", "Schmidt", "Wagner", "Meier", "Becker", "Weber", "Schmitt", "Lehmann", "Keller", "Schwarz", "Braun", "Richter", "Berger", "Schulz", "Zimmermann", "Koch", "Schäfer", "Zimmer", "Schneider", "Fischer", "Krause", "Bauer",];

            Console.WriteLine( names[0] );
            Console.WriteLine( names[4] );
            Console.WriteLine( names[^1] );

            names[4] = "Svenjamin";
            Console.WriteLine( names[4] );

            Console.WriteLine();
            names.Sort();
            foreach( string name in names )
            {
                Console.WriteLine( name );
            }
        }
    }
}