using Tree;

namespace FileCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = @"C:\Users\Benjamin";
            var rootnode = new Node<string>(root);

            FileCrawler(rootnode, root);

            Console.WriteLine( rootnode.PrintPretty("",false));
        }

        static void FileCrawler(Node<string> parent, string location)
        {
            var folders = new List<string>();
            try
            {
                folders = Directory.GetDirectories(location).ToList();
            }
            catch (Exception)
            {
                return;
            }
            
            foreach (var folder in folders)
            {
                var currentNode = parent.AddNode(folder);
                if (Directory.Exists(folder));
                {
                    FileCrawler(currentNode, folder);
                }

            }

            var files = Directory.GetFiles(location);
            foreach (var node in files)
            {
                parent.AddNode(node);
            }
        }
    }
}
