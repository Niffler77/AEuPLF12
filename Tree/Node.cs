using System.Text;

namespace Tree
{
    internal class Node<T>
    {
        private T Data;

        private Node<T> parent;

        private List<Node<T>> children = [];

        public Node( T data )
        {
            Data = data;
            parent = null;
        }

        public Node( T data, Node<T> parent )
        {
            Data = data;
            parent = parent;
        }

        public Node<T> AddNode( T data )
        {
            var node = new Node<T>( data )
                       {
                           parent = this,
                       };
            children.Add( node );
            return node;
        }

        public Node<T> AddNode( Node<T> node )
        {
            node.parent = this;
            children.Add( node );
            return node;
        }

        public void RemoveNode( Node<T> node )
        {
            children.Remove( node );
        }

        public override string ToString() => PrintPretty( "", true );

        public string PrintPretty( string indent, bool last )
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( indent );
            if( last )
            {
                sb.Append( "\\-" );
                indent += "  ";
            }
            else
            {
                sb.Append( "|-" );
                indent += "| ";
            }

            sb.AppendLine( Data.ToString() );

            for( int i = 0; i < children.Count; i++ )
            {
                sb.Append( children[i].PrintPretty( indent, i == children.Count - 1 ) );
            }

            return sb.ToString();
        }
    }
}