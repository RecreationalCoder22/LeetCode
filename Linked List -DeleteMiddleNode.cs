
namespace _2._3_DeleteMiddleNode
{
    //This was Leet code daily challenge question, solution accepted
    class ListNode
    {
        public int Data;
        public ListNode Next;
    }
    class LinkedList
    {
        public ListNode Head;

        public void AddNodeToLast(int Value)
        {
            ListNode newNode = new ListNode();
            newNode.Data = Value;
            newNode.Next = null;
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                ListNode nextNode = Head;
                while (nextNode.Next != null)
                {
                    nextNode = nextNode.Next;
                }
                nextNode.Next = newNode;
            }
        }

        public void Display()
        {
            ListNode nextNode = Head;
            while (nextNode != null)
            {
                System.Console.Write(nextNode.Data);
                nextNode = nextNode.Next;
            }
        }

        public void deleteMiddleNode(ListNode node)
        {
            ListNode nodeToDelete = node;
            if(nodeToDelete != null)
            {
                nodeToDelete.Data = nodeToDelete.Next.Data;
                nodeToDelete.Next = nodeToDelete.Next.Next;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myLinkedList = new LinkedList();
            myLinkedList.AddNodeToLast(2);
            myLinkedList.AddNodeToLast(3);
            myLinkedList.AddNodeToLast(4);
           // deleteMiddleNode()
            myLinkedList.Display();
            System.Console.Read();
        }
    }
}
