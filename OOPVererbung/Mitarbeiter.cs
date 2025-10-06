namespace OOPVererbungUA1
{
    public class Mitarbeiter : Person
    {
        public Mitarbeiter() { }

        public Mitarbeiter(int PersonalNummer, bool Führungskraft, double Gehalt, string Name, string GebOrt, string GebDat) 
            : base(Name, GebOrt, GebDat)
        {
            this.PersonalNummer = PersonalNummer;
            this.Führungskraft = Führungskraft;
            this.Gehalt = Gehalt;
        }

        public int PersonalNummer { get; set; }

        public bool Führungskraft { get; set; }

        public double Gehalt { get; set; }

    }
}
