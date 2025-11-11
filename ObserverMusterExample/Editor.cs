using ObserverMusterExample.EventListeners;

namespace ObserverMusterExample
{
    internal class Editor
    {
        public EventManager EventManager { get; } = new();

        internal Editor()
        {
            EventManager.Subscribe( EventType.Open, new EmailAlertsListener() );
            EventManager.Subscribe( EventType.Open, new LoggingListener() );
        }

        public void OpenFile()
        {
            Console.WriteLine( "OpenFile" );
            EventManager.Notify( EventType.Open, "file" );
        }

        public void SaveFile()
        {
            Console.WriteLine( "SaveFile" );
            EventManager.Notify( EventType.Save, "file" );
        }
    }
}