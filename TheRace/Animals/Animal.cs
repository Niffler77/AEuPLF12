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
            }
            var moveDistance = random.Next( (int)MinSpeed, (int)(MaxSpeed + 1) );

            var staminaRemove = moveDistance / 2;
            if (CurrentStamina - staminaRemove >= 0  )
            {
                CurrentStamina -= staminaRemove;
                return moveDistance;
            }
            else
            {
                return moveDistance / 10 ;
            }
        }

        internal abstract void makeNoise();
    }
}
