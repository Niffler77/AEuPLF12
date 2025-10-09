namespace TheRace.Animals
{
    internal abstract class Animal : IRacer
    {
        internal string Name { get; set; }

        public float MaxSpeed { get; set; }

        public float MinSpeed { get; set; }

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

        public float Move()
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

        public void WinningAction() => makeNoise();
        internal abstract void makeNoise();

        protected string GetName() => $"{Name} |";
    }
}
