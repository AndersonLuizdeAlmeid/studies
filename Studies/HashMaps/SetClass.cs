namespace Studies.HashMaps;
public class SetClass
{
    public void SetFunction()
    {
        // 1. Initialization
        var uniqueNames = new HashSet<string>();

        // 2. Add (O(1) average)
        uniqueNames.Add("Alice");
        uniqueNames.Add("Bob");

        // 3. Add a duplicate
        bool wasAdded = uniqueNames.Add("Alice"); // Returns 'false', set is unchanged
                                                  // uniqueNames is still {"Alice", "Bob"}

        // 4. Check for existence (O(1) average)
        // This is the main superpower!
        if (uniqueNames.Contains("Bob"))
        {
            Console.WriteLine("Bob is in the set.");
        }

        // 5. Remove (O(1) average)
        uniqueNames.Remove("Alice");
    }
}

/*
 3. Sets (e.g., HashSet<T>)
A Set is a data structure that stores a collection of unique items. It enforces uniqueness.

You can think of a Set as a Dictionary where you only care about the Key. There is no Value.

Its primary job is to tell you, "Have I seen this item before?"

How it's Implemented in C#
HashSet<T> is also implemented using a Hash Table.

You Add(5).

It calculates hash(5) → index 2.

It stores 5 in the bucket at index 2.

You Add(15).

It calculates hash(15) → index 2 (a collision).

It stores 15 in the linked list at index 2.

You Add(5) again.

It calculates hash(5) → index 2.

It walks the linked list at index 2, finds that 5 is already there, and does nothing. The Add method returns false.
 */