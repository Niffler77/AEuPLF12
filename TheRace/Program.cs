using TheRace.Animals;

namespace TheRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var isGameRunning = true;
            var race = new Dictionary<Animal, double>
                       {
                           {
                               new Lion("Lion", 5 , 60, 60 ), 0
                           },
                           {
                               new Horse("Horse", 2, 80, 100 ), 0
                           },
                           {
                               new Wolf("Wolf", 8, 70, 50), 0
                           },
                           {
                               new Antilope("Antilop", 20 ,80 ,40), 0 
                           },
                       };
            do
            {
                foreach( var racer in race )
                {
                    var currentAnimal = racer.Key;


                    race[currentAnimal] += currentAnimal.Move();
                    if (race[currentAnimal] > 1000 )
                    {
                        isGameRunning = false;
                        Congratulation(currentAnimal);
                        break;
                    }
                }
            }
            while( isGameRunning );
            
        }

        internal static void Congratulation(Animal animal)
        {
            animal.makeNoise();
        }
    }
}
