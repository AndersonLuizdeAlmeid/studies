namespace Studies.StacksAndQueues;
public class QueuesClass
{
    public void QueueFunction()
    {
        // 1. Initialization
        var myQueue = new Queue<string>();

        // 2. Enqueue items (FIFO)
        myQueue.Enqueue("First");  // "First" is at the front
        myQueue.Enqueue("Second");
        myQueue.Enqueue("Third");  // "Third" is at the back

        // 3. Peek (see the front item)
        string frontItem = myQueue.Peek(); // Returns "First"
                                           // Queue is still ["First", "Second", "Third"]

        // 4. Dequeue (remove the front item)
        string removedItem = myQueue.Dequeue(); // Returns "First"
                                                // Queue is now ["Second", "Third"]

        removedItem = myQueue.Dequeue(); // Returns "Second"
                                         // Queue is now ["Third"]
    }
}

/*
 6. Queues (FIFO - First-In, First-Out)
A Queue is a "First-In, First-Out" (FIFO) structure. The first item you add is the first one you can remove.

Analogy: Think of a line at a grocery store (a "queue"). The first person to get in line is the first person to be served.

Key Operations
Enqueue(item): Adds a new item to the back (or "end") of the queue.

Dequeue(): Removes and returns the item from the front (or "head") of the queue.

Peek(): Returns the item from the front without removing it.

How Queues are Implemented
Implementing a queue is trickier than a stack.

Using a Linked List (Ideal Implementation):

This is the most natural fit. The list needs a pointer to the Head (front) and the Tail (back).

Enqueue(item) is myLinkedList.AddLast(item). This is O(1).

Dequeue() is myLinkedList.RemoveFirst(). This is O(1).

Peek() is myLinkedList.Head.Value. This is O(1).

Using an Array (More Complex):

You cannot just use a List<T>. Why?

If Enqueue is list.Add(item) (adds to end, O(1)), then Dequeue is list.RemoveAt(0) (removes from start).

list.RemoveAt(0) is an O(n) operation because all other n-1 elements must be shifted left. This is very inefficient for a queue.

The solution is a Circular Array (or "Circular Buffer"). It's an array where two pointers keep track of the head and tail indices. When a pointer reaches the end of the array, it "wraps around" to the beginning.
 */