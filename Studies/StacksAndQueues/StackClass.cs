namespace Studies.StacksAndQueues;
public class StackClass
{
    public void StackFunction()
    {
        // 1. Initialization
        var myStack = new Stack<string>();

        // 2. Push items on (LIFO)
        myStack.Push("First");
        myStack.Push("Second");
        myStack.Push("Third"); // "Third" is now at the top

        // 3. Peek (see the top item)
        string topItem = myStack.Peek(); // Returns "Third"
                                         // Stack is still ["First", "Second", "Third"]

        // 4. Pop (remove the top item)
        string removedItem = myStack.Pop(); // Returns "Third"
                                            // Stack is now ["First", "Second"]

        removedItem = myStack.Pop(); // Returns "Second"
                                     // Stack is now ["First"]
    }
}
/*
 5. Stacks (LIFO - Last-In, First-Out)
A Stack is a "Last-In, First-Out" (LIFO) structure. The last item you add is the first one you can remove.

Analogy: Think of a stack of plates. You add a new plate to the top, and you can only remove a plate from the top. You can't take one from the bottom.

Key Operations
Push(item): Adds a new item to the top of the stack.

Pop(): Removes and returns the item from the top of the stack.

Peek(): Returns the item from the top without removing it.

How Stacks are Implemented
You can implement a stack in two main ways:

Using a Dynamic Array (List<T>) (Most Common):

This is the simplest way. The "top" of the stack is just the "end" of the list.

Push(item) is just myList.Add(item). This is O(1) (amortized).

Pop() is myList.RemoveAt(myList.Count - 1). This is O(1).

Peek() is myList[myList.Count - 1]. This is O(1).

Using a Linked List:

This provides a true O(1) for all operations (no amortized resizing).

The "top" of the stack is the Head of the linked list.

Push(item) is just myLinkedList.AddFirst(item). This is O(1).

Pop() is myLinkedList.RemoveFirst(). This is O(1).

Peek() is myLinkedList.Head.Value. This is O(1).
 */