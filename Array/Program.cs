namespace Array
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Hello, World!" );

            var test = new Kinosaal( "Haupt", 1 );

            test.Reserviern( 1, 3 );
            test.Reserviern( 2, 3 );
            test.Status();
        }
    }
}