namespace RefactroingCode
{
    public class Program
    {
        static void Main( string[] args )
        {
            const int a = 5;
            const int b = 10;
            int sum = Add( a, b );

            PrintSum( a, b, sum );

            Console.WriteLine( IsPositive( sum ) ? "Die Summe ist positiv." : "Die Summe ist nicht positiv." );

            PrintLoop( 5 );

            var fruits = new string[3];
            fruits[0] = "Apfel";
            fruits[1] = "Orange";
            fruits[2] = "Banane";

            PrintFruits( fruits );

            ChooseFruit( fruits, 2 ); // Beispielaufruf
        }

        public static int Add( int x, int y ) => x + y;

        public static void PrintSum( int a, int b, int sum ) => Console.WriteLine( $"Die Summe von {a} und {b} ist: {sum}" );

        public static bool IsPositive( int num ) => num > 0;

        public static void PrintLoop( int count )
        {
            for( var i = 0; i < count; i++ )
            {
                Console.WriteLine( $"Schleife {i} ist aktiv." );
            }
        }

        public static void PrintFruits( string[] fruits )
        {
            for( var i = 0; i < fruits.Length; i++ )
            {
                Console.WriteLine( $"Frucht {i}: {fruits[i]}" );
            }
        }

        public static void ChooseFruit( string[] fruits, int numbers )
        {
            if( numbers >= 1 && numbers <= fruits.Length )
            {
                Console.WriteLine( $"Frucht {numbers}: {fruits[numbers - 1]}" );
            }
            else
            {
                Console.WriteLine( "Ungültige Fruchtnummer." );
            }
        }
    }
}