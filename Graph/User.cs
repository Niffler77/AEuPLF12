namespace Graph
{
    internal class User
    {
        private List<User> friends = [];

        public User()
        {
        }

        public User AddFriend( User user )
        {
            if( user.equals(this) )
            {
                return;
            }

            friends.Add( user );
            return user;
        }

        public void RemoveFriend( User user )
        {
            friends.Remove( user );
        }
    }
}