namespace TheRace.Animals
{
    internal abstract class Animal
    {
        internal string Name { get; set; }

        private float MaxSpeed { get; set; }

        private float MinSpeed { get; set; }

        private int MaxStamina { get; set; }

        private int CurrentStamina { get; set; }

        private int StaminaRegen { get; set; }

        internal Animal( string name, float min, float max, int maxStamina )
        {
            Name = name;
            MaxSpeed = max;
            MinSpeed = min;
            MaxStamina = maxStamina;
            CurrentStamina = maxStamina;
            StaminaRegen = maxStamina / 2;
        }

        internal float Move()
        {
            var random = new Random();
            if( CurrentStamina != MaxStamina && 
                (CurrentStamina + StaminaRegen) <= MaxStamina)
            {
                CurrentStamina += StaminaRegen;
                Console.WriteLine($"{GetName()} Regained Stamina {StaminaRegen} | Stamina {CurrentStamina}/{MaxStamina}");
            }
            var moveDistance = random.Next( (int) MinSpeed, (int)(MaxSpeed + 1) );

            var staminaDrain = moveDistance / 2;
            if (CurrentStamina - staminaDrain >= 0  )
            {
                CurrentStamina -= staminaDrain;
                Console.WriteLine( $"{GetName()} Moved: {moveDistance} | Lost Stamina: {staminaDrain}"   );
            }
            else
            {
                Console.WriteLine($"{GetName()} Not Enough Stamina Needed: {staminaDrain} | Stamina: {CurrentStamina}/{MaxStamina}");
                moveDistance = 0;
            }

            Console.WriteLine( $"{GetName()} Stamina: {CurrentStamina}/{MaxStamina}" );
            return moveDistance;
        }

        internal abstract void makeNoise();

        protected string GetName() => $"{Name} |";
    }
}
