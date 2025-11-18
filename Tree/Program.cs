namespace Tree
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var root = new Node<string>( "root" );
            var user = root.AddNode( "user" );
            user.AddNode( "TreeJamin" );
            user.AddNode( "Lassjamin" );
            var top = root.AddNode( "top" );
            top.AddNode( "Lasse" );

            Console.WriteLine( "Hello, World!" );
            Console.Write( root.ToString() );
        }
    }
}