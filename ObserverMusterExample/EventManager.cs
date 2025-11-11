using ObserverMusterExample.EventListeners;

namespace ObserverMusterExample
{
    internal class EventManager
    {
        private List<IEventListeners> listeners = [];

        public void Subscribe( EventType eventType, IEventListeners listener )
        {
            listeners.Add( listener );
        }

        public void Unsubscribe( EventType eventType, IEventListeners listener )
        {
            listeners.Remove( listener );
        }

        public void Notify( EventType eventType, string data )
        {
            foreach( var listener in listeners )
            {
                listener.Update( data );
            }
        }
    }
}