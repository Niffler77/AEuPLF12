namespace TheRace.Cars
{
    internal class Car( string name, string model, int tank, float minSpeed, float maxSpeed )
        : IRacer
    {
        private string Name { get; set; } = name;

        private string Model { get; set; } = model;

        private int Tank { get; set; } = tank;

        public float MinSpeed { get; set; } = minSpeed;

        public float MaxSpeed { get; set; } = maxSpeed;

        public float Move() => MaxSpeed;

        public void WinningAction()
        {
            Console.WriteLine($"{Name} HUB");
        }
    }
}
