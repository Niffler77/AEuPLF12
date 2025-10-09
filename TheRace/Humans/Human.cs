namespace TheRace.Humans
{
    internal class Human( string name, int age, int stamina, float minSpeed, float maxSpeed )
        : IRacer
    {
        private string Name { get; set; } = name;

        private int Age { get; set; } = age;

        private int Stamina { get; set; } = stamina;

        public float MinSpeed { get; set; } = minSpeed;

        public float MaxSpeed { get; set; } = maxSpeed;

        public float Move() => MinSpeed;

        public void WinningAction()
        {
            Console.WriteLine( $"{Name} HUHRA" );
        }
    }
}
