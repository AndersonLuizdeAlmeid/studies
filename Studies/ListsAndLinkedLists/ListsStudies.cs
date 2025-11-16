namespace Studies.ListsAndLinkedLists;
public class ListsStudies
{
    public static void ListFunction()
    {
        List<string> animals = new();

        animals.Add("Dog");
        animals.Add("Cat");
        animals.Add("Mouse");

        string firstAnimal = animals[0]; // "Dog"

        // 4. Insert (O(n)) - This is expensive!
        animals.Insert(1, "Bird"); // List is now ["Dog", "Bird", "Cat", "Mouse"]
                                   // "Cat" and "Mouse" had to be shifted right.
        // 5. Remove (O(n))
        animals.Remove("Cat"); // List is now ["Dog", "Bird", "Mouse"]
                               // "Mouse" had to be shifted left.

        // 6. Iteration (O(n))
        foreach (string animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

}

//2. Lists(Dynamic Arrays)
//In C#, when we say "List," we are almost always referring to List<T>.

//As mentioned, a List<T> is not a new type of data structure.It's an abstraction built on top of an array. It's a "dynamic array" or "resizable array."

//How it's Implemented:

//List<T> internally manages a private array(let's call it _items).

//It also keeps track of two numbers:
//Count: The number of elements you've actually added.
//Capacity: The total length of the internal _items array.
//When you Add() an item, it just puts it at _items[Count] and increments Count.This is an O(1) operation.
//The "Magic": What happens when Count equals Capacity? The list is full.If you try to Add() one more item, the List<T> performs a resize:
//It creates a new, larger array(typically double the size).
//It copies all n elements from the old array to the new one.
//It adds the new element.
//This copying operation is O(n). This is where Amortized Analysis(on your list) comes in, but we'll get to that.

//List<T> Complexity(The "Amortized" Part)
//Access: O(1) (It's just an array lookup).

//Search: O(n) (You have to check each element).

//Insertion(at end) : O(1) (Amortized)
//It's O(1) most of the time, but sometimes it's O(n) (when it resizes). Averaged out, it's considered O(1).

//Insertion(at beginning/middle) : O(n)
//Just like a regular array, it must shift all subsequent elements.

//Deletion(at end): O(1)
//Deletion(at beginning/middle) : O(n)
//Must shift all elements to the left to fill the gap.



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