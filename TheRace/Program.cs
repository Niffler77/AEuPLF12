using TheRace.Aliens;
using TheRace.Animals;
using TheRace.Cars;
using TheRace.Humans;

namespace TheRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var isGameRunning = true;
            var race = new Dictionary<IRacer, double>
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
                           {
                               new Human("Jean", 10, 10,1.0f,4.0f),0
                           },
                           {
                               new Alien("ET", "Earth", 10, 0, 1000), 0
                           },
                           {
                               new Car("MC Queen", "ka", 10, 10, 500), 0
                           }
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
