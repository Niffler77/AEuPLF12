namespace ObserverMusterExample
{
    internal class EventManager
    {
        private List<IEventListeners> listeners = [];

        public void subscribe( IEventListeners listener )
        {
            listeners.Add( listener );
        }

        public void unsubscribe( IEventListeners listener )
        {
            listeners.Remove( listener );
        }

        public void notify( string data )
        {
            foreach( var listener in listeners )
            {
                listener.update( data );
            }
        }
    }
}