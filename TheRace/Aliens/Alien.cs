namespace TheRace.Aliens
{
    internal class Alien( string name, string planet, int stamina, float minSpeed, float maxSpeed )
        : IRacer
    {
        private string Name { get; set; } = name;

        private string Planet { get; set; } = planet;

        private int Stamina { get; set; } = stamina;

        public float MinSpeed { get; set; } = minSpeed;

        public float MaxSpeed { get; set; } = maxSpeed;

        public float Move() => MaxSpeed;

        public void WinningAction()
        {
            Console.WriteLine($"{Name} HUHRA");
        }
    }
}
