namespace Studies.ListsAndLinkedLists;
public static class ReverseALinkedListChallenge
{
    public static Node ReverseList(Node head)
    {
        // 'previous' will track the new head (starts as null)
        Node previous = null;

        // 'current' is our main iterator
        Node current = head;

        while (current != null)
        {
            // 1. Store the next node before we break the link
            Node nextTemp = current.Next;

            // 2. Reverse the link: point current.Next "backwards"
            current.Next = previous;

            // 3. Move our pointers one step forward
            previous = current;
            current = nextTemp;
        }

        // When the loop finishes, 'current' is null and 'previous'
        // is the last node we visited, which is the new head.
        return previous;
    }
}