namespace ObserverMusterExample
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Hello, World!" );
            var editor = new Editor();

            editor.OpenFile();
            editor.SaveFile();
        }
    }
}