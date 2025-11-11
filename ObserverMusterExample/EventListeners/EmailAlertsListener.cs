namespace ObserverMusterExample.EventListeners
{
    public class EmailAlertsListener : IEventListeners
    {
        public void Update( string filename )
        {
            Console.WriteLine( "E-Mail: " + filename );
        }
    }
}