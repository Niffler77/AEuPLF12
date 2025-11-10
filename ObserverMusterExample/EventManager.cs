using ObserverMusterExample.EventListeners;

namespace ObserverMusterExample
{
    internal class EventManager
    {
        private List<IEventListeners> listeners = [];

        public void subscribe( EventType eventType, IEventListeners listener )
        {
            listeners.Add( listener );
        }

        public void unsubscribe( EventType eventType, IEventListeners listener )
        {
            listeners.Remove( listener );
        }

        public void notify( EventType eventType, string data )
        {
            foreach( var listener in listeners )
            {
                listener.update( data );
            }
        }
    }
}