namespace TheRace
{
    internal interface IRacer
    {
        internal float MinSpeed { get; set; }

        internal float MaxSpeed { get; set; }

        internal float Move();

        internal void WinningAction();
    }
}