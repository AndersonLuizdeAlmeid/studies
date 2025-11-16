using System.Text;

namespace Studies.Strings;
public class StringClass
{
    public void StringFunction()
    {
        string s = "hello";

        // This loop creates 10 new string objects in memory!
        for (int i = 0; i < 10; i++)
        {
            s = s + "!";
            // "hello!" (new string)
            // "hello!!" (new string)
            // "hello!!!" (new string)
            // ...and so on.
        }
        /*
         This is a O(n²) operation. Why? Because to add one character, the program has to copy all n existing characters into a new string. Doing this n times results in 1 + 2 + 3 + ... + n copies, which is O(n²).
         */
    }

    public void StringBuilderFunction()
    {
        // 1. Initialize the builder
        StringBuilder sb = new StringBuilder("hello");

        // 2. Append in a loop (this is fast, O(1) amortized)
        for (int i = 0; i < 10; i++)
        {
            sb.Append("!"); // Modifies the builder in-place
        }

        // 3. Get the final string (only one new string is created at the end)
        string finalString = sb.ToString();

        // finalString is "hello!!!!!!!!!!"

        /*
         2. StringBuilder: The Solution to Immutability
        When you need to build a string, especially in a loop, do not use string concatenation (+). Use the StringBuilder class.

        StringBuilder is a mutable (changeable) string.

        It works like a List<char> internally. It uses a resizable array and appends characters in-place.

        This makes "building" a string an O(n) operation (or O(1) amortized for each append), not O(n²).

        Example: This is the correct, efficient way to build a string.
         */
    }

    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
        /*
         Problem 1: Palindrome Check
Problem: Check if a string reads the same forwards and backward (e.g., "racecar").

Technique: Two Pointers.

Solution: Use one pointer (left) at the start of the string (0) and one (right) at the end (Length - 1). In a while loop, check if myString[left] equals myString[right]. If not, return false. If they do, move both pointers toward the center (left++, right--). If the loop finishes, return true.

Complexity: O(n) time, O(1) space.         
         */
    }

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var counts = new Dictionary<char, int>();

        // Count characters in the first string
        foreach (char c in s)
        {
            counts.TryAdd(c, 0); // Add if not present
            counts[c]++;
        }

        // Decrement counts using the second string
        foreach (char c in t)
        {
            // If char is not in map or its count is 0, it's not an anagram
            if (!counts.ContainsKey(c) || counts[c] == 0)
            {
                return false;
            }
            counts[c]--;
        }

        // If we get here, they are anagrams
        return true;
        /*
         Problem 2: Check for Anagrams
Problem: Check if two strings are anagrams (contain the same characters in any order, e.g., "listen" and "silent").

Technique: Hash Map (Dictionary).

Solution: Create a Dictionary<char, int> to count the characters in the first string. Then, loop through the second string, decrementing the counts. If you ever find a character not in the dictionary or its count is already zero, return false.

Complexity: O(n) time (where n is the length of the strings), O(k) space (where k is the number of unique characters, e.g., 26 for the alphabet).
         */
    }

}

/*
 
This is a very common topic in interviews. String problems are not just about the string data type; they are a way to test your understanding of arrays, hash maps (dictionaries), and time/space efficiency.

1. 🔑 The Most Important Concept: Immutability
In C# (and Java, Python), the string type is immutable. This is the most critical concept to understand.

Immutable means that once a string object is created, it cannot be changed.

When you "modify" a string, you are actually creating a new string object in memory.
 
3. Strings are Arrays of char
A string is, at its core, a read-only array of characters (char). This means:

You can access characters by index: char c = myString[2]; (This is O(1)).

You can get its length: int len = myString.Length; (This is O(1)).

You can iterate over it: foreach (char c in myString) { ... }
 */