namespace TheRace.Animals
{
    internal class Lion( string name, float min, float max, int maxStamina )
        : Animal( name, min, max, maxStamina )
    {
        internal override void makeNoise()
        {
            Console.WriteLine( Name + " brüllen" );
        }
    }
}
