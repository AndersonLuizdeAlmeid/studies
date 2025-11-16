namespace Studies.HashMaps;
public class DictionaryClass
{
    public void HashMapFunction()
    {
        // 1. Initialization
        var userScores = new Dictionary<string, int>();

        // 2. Add (O(1) average)
        userScores.Add("Alice", 100);
        userScores.Add("Bob", 85);

        // You can also use the indexer syntax
        userScores["Charlie"] = 92;

        // 3. Access (O(1) average)
        int bobsScore = userScores["Bob"]; // 85

        // 4. Check for existence (O(1) average) - VERY important
        if (userScores.ContainsKey("Alice"))
        {
            Console.WriteLine("Alice's score exists!");
        }

        // 5. Update (O(1) average)
        userScores["Alice"] = 110;

        // 6. Remove (O(1) average)
        userScores.Remove("Bob");
    }
}

/*
 2. Dictionaries (e.g., Dictionary<TKey, TValue>)
A Dictionary (also called a Hash Map or Associative Array) is a direct implementation of a Hash Table. It stores Key-Value Pairs.

The Key is used to generate the hash code (e.g., "Alice").

The Value is the data associated with that key (e.g., "Software Engineer").

How it's Implemented in C#
In C#, Dictionary<TKey, TValue> uses a Hash Table. When you add a pair ("Alice", "Engineer"):

It calculates the hash of the Key ("Alice").

It finds the bucket index (e.g., index 3).

It stores the Key AND Value (as a pair) in the linked list at that bucket.

C# Usage (Dictionary<string, int>)
 */