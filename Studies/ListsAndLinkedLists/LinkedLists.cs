namespace Studies.ListsAndLinkedLists;

// === Step 1: The Node Class ===
// A Node just holds a value and a pointer to the next node.
public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
        this.Value = value;
        this.Next = null; // Next is null by default
    }
}

// === Step 2: The LinkedList Class ===
// This class manages the nodes and only holds a reference to the Head.
public class SinglyLinkedList
{
    public Node Head { get; private set; }

    // Add a new node to the front (O(1))
    public void AddFirst(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = this.Head; // Point the new node to the old head
        this.Head = newNode;      // Make the new node the new head
    }

    // Add a new node to the end (O(n))
    public void AddLast(int value)
    {
        Node newNode = new Node(value);

        // If list is empty, new node is the head
        if (this.Head == null)
        {
            this.Head = newNode;
            return;
        }

        // Else, traverse to the end
        Node current = this.Head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        // At the last node, link the new node
        current.Next = newNode;
    }

    // Print all values (O(n))
    public void PrintList()
    {
        Node current = this.Head;
        while (current != null)
        {
            Console.Write($"{current.Value} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

public class LinkedLists
{
    public static void LinkedListsFunction()
    {
        // Example usage
        SinglyLinkedList myList = new();
        myList.AddFirst(10);
        myList.AddLast(20);
        myList.AddFirst(5);
        myList.PrintList(); // Output: 5 -> 10 -> 20 -> null
    }
}

// --- How to use it: ---
// SinglyLinkedList myList = new SinglyLinkedList();
// myList.AddFirst(10);
// myList.AddLast(20);
// myList.AddFirst(5);
// myList.PrintList(); // Output: 5 -> 10 -> 20 -> null

//3. Linked Lists
//A Linked List is a completely different implementation.It does not use a contiguous block of memory. Instead, it's a chain of objects.

//How it's Implemented:

//A Linked List is made of Nodes.

//Each Node object contains two pieces of information:

//The Value (the data itself).

//A Pointer(a reference) to the Next node in the chain.

//The list itself just keeps a reference to the Head (the first node) and sometimes the Tail(the last node).

//To find the 5th element, you must start at the Head, follow its Next pointer to the 2nd node, follow its Next pointer to the 3rd, and so on.

//Linked List Complexity(Singly-Linked)
//Access(Lookup) : O(n)

//This is the biggest drawback.You cannot jump to myList[42]. You must traverse the list from the Head, one node at a time.

//Search: O(n)

//Same as an array, you have to check each element.

//Insertion (at beginning): O(1)

//This is its superpower.To add a new Head, you just:

//Create a new Node.

//Set its Next pointer to the current Head.

//Update the list's Head pointer to this new node.

//No shifting, no copying. Just repointing.

//Insertion (at end): O(1) (Only if you store a Tail pointer)

//If you have a pointer to the last node(Tail), you just set Tail.Next to the new node and update Tail.

//If you don't store a Tail, it becomes O(n) because you have to traverse the whole list to find the end.

//Deletion (at beginning): O(1)

//Almost as easy as insertion.Just update the Head pointer to be Head.Next.The old Head is now "orphaned" and will be garbage collected.

//Deletion (at end): O(n)

//This is tricky.Even with a Tail pointer, you must find the node before the tail to update its Next pointer to null. This requires an O(n) traversal.

//Doubly-Linked Lists
//A quick variant: a Doubly-Linked List. Each node has the Value, a Next pointer, AND a Previous pointer. This makes some operations (like deleting from the end) more efficient, but it takes up more memory(an extra pointer per node).

//In C#, the built-in implementation is LinkedList<T>, which is a doubly-linked list.

//4. 🎯 Common Technical Interview Questions
//This comparison is a classic.

//Question 1: "When would you use an Array/List over a Linked List?"

//Answer: "You should use an Array or List when your primary need is fast random access (lookup) by index. If you are doing a lot of myList[i] operations, an array's O(1) access is unbeatable. Use it when you are mostly reading or iterating, or only adding to the end."

//Question 2: "When would you use a Linked List over an Array/List?"

//Answer: "You should use a Linked List when your primary need is fast insertion or deletion at the beginning (or middle) of the sequence. If you have a collection where you are constantly adding new items to the front (like a queue or stack), a linked list's O(1) insertion/deletion is far more efficient than the O(n) cost of shifting all elements in an array."

//Question 3: "What are the memory-related trade-offs?"

//Answer: "Arrays are more memory-efficient in one way: they are contiguous. This makes them 'cache-friendly' because the CPU can pre-fetch nearby elements.

//"Linked Lists have memory overhead. Each element requires extra memory for its pointer(s) (e.g., Next and Previous). They are also scattered in memory, which can be slower for the CPU cache."

//Question 4: (Implementation) "How would you implement adding a new node to the head of a singly-linked list?"

//Answer: "I would define a Node class with Value and Next properties. In my MyLinkedList class, which holds a Head pointer, the AddHead method would:

//Create a newNode with the given value.

//Set newNode.Next to the current Head.

//Set Head to point to the newNode."