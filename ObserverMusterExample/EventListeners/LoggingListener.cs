namespace ObserverMusterExample.EventListeners
{
    internal class LoggingListener : IEventListeners
    {
        public void Update( string filename )
        {
            Console.WriteLine( "Logging File:" + filename );
        }
    }
}