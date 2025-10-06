namespace OOPVererbungUA1
{
    public class Person
    {

        public Person() { }

        public Person(string Name, string GebOrt, string GebDat) 
        {
            this.Name = Name;
            this.GebOrt = GebOrt;
            this.GebDat = GebDat;
        }
        public string Name { get; set; }

        public string GebOrt { get; set; }

        public string GebDat { get; set; }
    }
}
