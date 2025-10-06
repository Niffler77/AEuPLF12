namespace OOPVererbungUA1
{
    public class Azubi : Mitarbeiter
    {
        public Azubi() { }

        public Azubi(int Lehrjahr, int PersonalNummer, bool Führungskraft, double Gehalt, string Name, string GebOrt, string GebDat) 
            : base(PersonalNummer, Führungskraft, Gehalt, Name, GebOrt, GebOrt)
        {
            this.Lehrjahr = Lehrjahr;
        }

        public int Lehrjahr { get; set; }
    }
}
