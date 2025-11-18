namespace Dictionary
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var dictionary = new Dictionary<string, string>()
                             {
                                 { "DNS", "Domain Name System" },
                                 { "HTTPS", "Hypertext Transfer Protocol Secure" },
                                 { "HTML", "Hypertext Markup Language" },
                                 { "CSS", "Cascading Style Sheets" },
                                 { "API", "Application Programming Interface" },
                                 { "RAM", "Random Access Memory" },
                                 { "CPU", "Central Processing Unit" },
                             };

            Console.WriteLine( "Could add RAM: " + dictionary.TryAdd( "RAM", "tsete" ) );
            dictionary.Remove( "CPU" );
            dictionary.TryGetValue( "API", out string api );
            Console.WriteLine( api );
            dictionary["RAM"] = "Arbeitsspeicher";
            Console.WriteLine( dictionary["RAM"] );

            foreach( var value in dictionary )
            {
                Console.WriteLine( value );
            }
        }
    }
}