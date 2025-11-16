




using Studies.Arrays;
using Studies.ListsAndLinkedLists;

public class Program
{
    public static void Main(string[] args)
    {
        //ArrayStudies.ArrayFunction();
        Node head = new Node(1);
        head.Next = new Node(2);
        head.Next.Next = new Node(3);
        head.Next.Next.Next = new Node(4);
        head.Next.Next.Next.Next = new Node(5);

        ReverseALinkedListChallenge.ReverseList(head);
    }
}
