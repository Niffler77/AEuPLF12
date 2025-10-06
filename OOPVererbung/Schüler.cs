namespace OOPVererbungUA1
{
    public class Schüler : Person
    {
        public Schüler() 
        {

        }

        public Schüler(string Bildungsabschluss, float Notendurchschnitt, string Name, string GebOrt, string GebDat) : base(Name, GebOrt, GebDat)
        {
            this.Bildungsabschluss = Bildungsabschluss;
            this.Notendurchschnitt = Notendurchschnitt;
        }

        public string Bildungsabschluss { get; set; }

        public float Notendurchschnitt { get; set; }
    }
}
