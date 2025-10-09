namespace TheRace.Animals
{
    internal class Wolf( string name, float min, float max, int maxStamina )
        : Animal( name, min, max, maxStamina )
    {
        internal override void makeNoise()
        {
            Console.WriteLine( $"{GetName()} Woof" );
        }
    }
}