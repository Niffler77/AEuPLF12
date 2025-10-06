namespace OOPVererbungUA1
{
    public class Lehrer : Person
    {

        public Lehrer() { }

        public Lehrer(string Haputfach, string Name, string GebOrt, string GebDat) 
            : base(Name, GebOrt, GebDat)
        {
            this.Hauptfach = Hauptfach;
        }

        public string Hauptfach { get; set; }
    }
}
