class P
{
    static void Main(string[] args)
    {
        Node root = new Node(30);
        /*Node n1 = new Node(15);
        Node n2 = new Node(45);
        Node n3 = new Node(6);
        Node n4 = new Node(41);
        Node n5 = new Node(54);

        root.left = n1;
        root.right = n2;
        n1.right = n3;
        n2.left = n4;
        n2.right = n5;*/

        Node bst = BSTree.Insert(root,15);
        Console.Write(bst.left.value);
    }
    class Node
    {
      public int value;
      public Node left ;
      public Node right ;

      public Node(int value)
      {
         this.value = value;
      }
    }
    class BSTree
    {
        public static Node Insert(Node root,int value)
        {
            if (root.value == value)
            {
                return root;
            }
            else if(value < root.value)
            {
                if (root.left != null)
                {
                    Insert(root.left,value);
                }
                else{
                    Node newNode = new Node(value);
                    root.left = newNode;
                }
            }
            else if(value > root.value)
            {
                if (root.right != null)
                {
                    Insert(root.right,value);
                }
                else{
                    Node newNode = new Node(value);
                    root.right = newNode;
                }
            }
            return root;
        }

        public static Node Find(Node root ,int value)
        {
            if (root.value == value )
            {
                return root;
            }
            else if (value < root.value)
            {
                root.left = Find(root.left,value);
            }
            else if (value>root.value)
            {
                root.right = Find(root.left,value);
            }
            return root;
        }

        public static Node Delete(Node root, int value)
        {
            Node eliminateNode= BSTree.Find(root,value);
            return root;
        }

        public static Node Update(Node root, int value)
        {
            Node element = BSTree.Find(root,value);
            element.value = value;
            return root;
        }
    }
}