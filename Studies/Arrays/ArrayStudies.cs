namespace Studies.Arrays;
public static class ArrayStudies
{
    public static void ArrayFunction()
    {
        int[] myNumbers = new int[5];

        string[] names = { "Alice", "Bob", "Charlie" };
        string firstName = names[0]; // "Alice"

        names[1] = "Barbara"; // Array is now {"Alice", "Barbara", "Charlie"}

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Index {i} has value: {names[i]}");
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}

//1. Arrays(The Core Concept)
//An array is the simplest and most common data structure.Its defining characteristic is that it stores a collection of items in a single, contiguous block of memory.

//Think of it like a row of mailboxes, all connected.Each mailbox has an "address" (an index), and you can instantly access any mailbox just by knowing its index number.

//Here are the key properties:

//Contiguous Memory: All elements are stored one after another in memory.This is the most important concept to understand.

//Index-Based: Elements are accessed using an index, which is an integer representing the element's position. In C# (and most languages), arrays are 0-indexed, meaning the first element is at index 0, the second at index 1, and so on.

//Fixed Size: In their purest form(like in C# int[]), arrays have a fixed size that is defined when they are created. You cannot add more elements than the array's capacity without creating a new, larger array and copying the old elements over.

//2. Big O: Time & Space Complexity
//This is why arrays are chosen for certain tasks. Because all elements are in one continuous block, the computer can perform a very simple calculation to find any element:

//memory_address = starting_address + (index * element_size)

//Since this calculation takes the same amount of time regardless of whether the array has 10 elements or 10 million, we get:

//Access (Lookup): O(1) (Constant Time)

//Explanation: Getting the element at myArray[42] is instantaneous.The computer doesn't have to walk through elements 0-41; it just does the math and jumps directly to the correct memory address. This is the array's superpower.

//Search: O(n) (Linear Time)

//Explanation: If you're looking for a specific value (e.g., "find the number 50"), and the array is unsorted, you have to check each element one by one. In the worst case, you check all n elements.

//Insertion: O(n) (Linear Time)

//Explanation: This one is tricky.If you just add an element to the end of an array (and there's space), it's O(1).

//However, if you insert an element at the beginning(index 0), you must shift all other n elements one spot to the right to make room.This is an O(n) operation.The same applies to inserting in the middle.

//Deletion: O(n) (Linear Time)

//Explanation: Similar to insertion.Deleting from the end is O(1).

//But if you delete the element at the beginning, you must shift all subsequent elements one spot to the left to fill the gap.This is also an O(n) operation.

//Space Complexity: O(n)

//Explanation: The amount of memory required is directly proportional to the number of elements(n) you store.


//4. 🎯 Common Technical Interview Questions
//Here are questions you might be asked, ranging from basic to more complex.

//Question 1: "What is the primary advantage of an array?"

//Answer: "Its O(1) (constant time) access by index. Because elements are stored contiguously, the computer can calculate the memory address of any element instantly, making lookups very fast."

//Question 2: "What is the difference between an Array (e.g., string[]) and a List<T> (e.g., List<string>) in C#?"

//Answer: "An Array has a fixed size that is set upon creation. A List<T> is dynamic; its size can grow or shrink. Internally, List<T> uses an array for storage, and when it reaches capacity, it performs a resizing operation by creating a new, larger array and copying the old elements."

//Question 3: "Why is inserting an element at the beginning of an array an O(n) operation?"

//Answer: "Because arrays are contiguous, you can't just 'stick' a new element at index 0. You must first shift every existing element in the array one position to the right to make space. The time this takes is directly proportional to n, the number of elements."

//Question 4: (Coding Challenge) "How would you reverse an array in-place? What is its time and space complexity?"

//Answer: "You would use a two-pointer technique. One pointer starts at the beginning (index 0) and one at the end (index n-1). You swap the elements at these pointers, then move the start pointer forward and the end pointer backward, stopping when they meet or cross.

//Time Complexity: O(n), because you touch each element roughly once (specifically, n/2 swaps).

//Space Complexity: O(1) (constant space), because 'in-place' means you are not allowed to create a new array.You are only using a few extra variables for the pointers and the temporary variable for the swap."

//This covers the fundamentals of arrays.

//Would you like to move on to the next items, Lists and Linked Lists, or would you prefer to dive deeper into Big O Notation and Time Complexity first?