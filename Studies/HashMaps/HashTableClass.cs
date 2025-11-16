namespace Studies.HashMaps;
public class HashTableClass
{
}

/*
 1. Hash Tables (The Core Implementation)
To understand Set and Dictionary, you must understand the Hash Table. This is how they are implemented.

A Hash Table combines an array with a hash function.

The Array: It's just a regular array, often called "buckets" or "slots."

The Hash Function: This is a function that takes your data (e.g., the string "Alice") and converts it into an integer. This integer is the hash code.

The Modulo Operator: To make sure this hash code fits into the array, we use the modulo operator (%). The index is hash_code % array_length.

How it works (Example):

You want to store "Alice".

The hash function runs: hash("Alice") → 75263

Your internal array has a size of 10.

You find the index: 75263 % 10 → 3.

You store "Alice" at index 3 of the array.

Now, when you want to check if "Alice" exists:

You run the exact same process: hash("Alice") → 75263 → index 3.

You jump directly to index 3 of the array and check if the item is there.

This is an O(1) operation. You don't scan the array; you jump straight to the correct "bucket."

The "Collision" Problem
What if you also want to store "Bob" and hash("Bob") → 85243? 85243 % 10 is also 3.

This is a collision. Both "Alice" and "Bob" want to go into the same bucket (index 3).

The most common solution is "Separate Chaining." Instead of storing the item itself in the array, each array slot holds a Linked List of all the items that hash to that index.

To add "Alice," you go to index 3, see an empty list, and add an "Alice" node.

To add "Bob," you go to index 3, see a list with "Alice," and add a "Bob" node to that list.

This is why hash table operations are O(1) on average, but O(n) in the worst case.

Average Case O(1): The hash function spreads items out evenly. Each linked list (bucket) has only 1 or 2 items.

Worst Case O(n): A terrible hash function puts all n items into the same bucket. Your hash table degrades into one giant Linked List, and lookups become O(n).
 */