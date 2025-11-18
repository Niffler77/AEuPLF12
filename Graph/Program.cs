namespace Graph
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var lasse = new User();
            var svenjamin = new User();
            var testjamin = new User();
            lasse.AddFriend( svenjamin );
            lasse.AddFriend( testjamin );

            svenjamin.AddFriend( testjamin );
        }
    }
}