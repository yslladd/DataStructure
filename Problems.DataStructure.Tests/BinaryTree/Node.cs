
namespace Problems.DataStructure.Tests.BinaryTree
{
    public class Node
    {
        public int Data;
        public Node Left, Right, Next, Parent;

        public Node(int data)
        {
            Data = data;
            Left = Right = Next = Parent = null;
        }
    }
}
