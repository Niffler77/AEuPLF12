namespace Array
{
    internal class Kinosaal( string name, int saalNummer )
    {
        public string Name { get; set; } = name;

        public int SaalNummer { get; set; } = saalNummer;

        public bool[,] SitzPlan { get; set; } =  new bool[10, 20];

        public void Reserviern( int Reihe, int Platz )
        {
            if( Reihe >= SitzPlan.GetLength( 0 ) || Platz >= SitzPlan.GetLength( 1 ) )
            {
                return;
            }

            if( SitzPlan[Reihe, Platz] == true )
            {
                Console.WriteLine( $"Platz: R{Reihe} P{Platz} ist bereits Reserviert" );
                return;
            }

            SitzPlan[Reihe, Platz] = true;
            Console.WriteLine( $"Platz: R{Reihe} P{Platz} wurde Reserviert " );
        }

        public void Status()
        {
            Console.WriteLine( $"Kinoname: {Name}, SaalNumer:  {SaalNummer}" );
            for( int i = 0; i < SitzPlan.GetLength( 0 ); i++ )
            {
                Console.WriteLine( "Reihe:" + i );
                for( int j = 0; j < SitzPlan.GetLength( 1 ); j++ )
                {
                    Console.Write( $"Platz: P{j} Status: {SitzPlan[i, j]} \t" );
                }
            }
        }
    }
}