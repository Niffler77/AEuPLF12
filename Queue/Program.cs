namespace Queue
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Queue<(int, string)> orders = new Queue<(int, string)>();
            orders.Enqueue( (111, "Pizza") );
            orders.Enqueue( (323, "Hotdog") );
            orders.Enqueue( (499, "BigMac") );
            orders.Enqueue( (555, "Donut") );
            var test = orders.Dequeue();
            Console.WriteLine( test );

            foreach( var item in orders )
            {
                Console.WriteLine( item );
            }
        }
    }
}