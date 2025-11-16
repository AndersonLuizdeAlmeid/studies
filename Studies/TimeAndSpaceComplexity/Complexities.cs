namespace Studies.TimeAndSpaceComplexity;
public class Complexities
{
}

/*
2. 📊 The Most Common Complexities
Here are the common Big O "buckets," from fastest to slowest.

O(1) - Constant Time
What it means: The algorithm takes the same amount of time, regardless of the input size (n).

Analogy: Accessing a single mailbox (by its number). It doesn't matter if there are 10 mailboxes or 10 million; finding mailbox #42 takes the same, instant amount of time.

Examples:

Accessing an array element by index (myArray[5]).

Push or Pop on a Stack.

Add or Contains in a HashSet (average case).

O(log n) - Logarithmic Time
What it means: The time it takes grows very slowly. Every time you double the input size (n), the number of operations only increases by one.

Analogy: Finding a name in a physical phone book. You open to the middle, decide if the name is in the first or second half, and throw away half the problem. You repeat this, cutting the problem in half each time.

Examples:

Binary Search (this is the classic example).

Finding an item in a balanced Binary Search Tree.

O(n) - Linear Time
What it means: The runtime grows directly proportional to the input size (n). If n doubles, the runtime doubles.

Analogy: Looking for your lost car key in a single line of 100 people. In the worst case, you have to check all 100 people.

Examples:

Looping through an array or list (for or foreach).

Searching for a value in an unsorted array.

Contains in a List<T>.

Finding the middle of a Linked List (fast/slow pointers).

O(n log n) - "Log-Linear" Time
What it means: This is the "gold standard" for efficient sorting. It means you are doing an O(log n) operation for each of the n items.

Analogy: Going through a phone book (n) and for each person, looking up their number (which is O(log n)).

Examples:

Merge Sort (guaranteed).

Quick Sort (average case).

C#'s Array.Sort().

O(n²) - Quadratic Time
What it means: The runtime grows by the square of the input size. If n = 10, it's 100 operations. If n = 100, it's 10,000 operations. This gets slow, fast.

Analogy: Checking if anyone in a room of n people has the same birthday. You (person 1) have to ask all n-1 people. Then person 2 has to ask all n-2 people, and so on.

Examples:

A nested loop: for (int i = 0...n) { for (int j = 0...n) { ... } }.

Bubble Sort, Insertion Sort (average/worst case).

O(2ⁿ) - Exponential Time
What it means: The runtime doubles with every new element added to the input. This is extremely slow and unusable for anything but the smallest n.

Analogy: A "brute force" password cracker. For a 1-character password, it tries a-z. For a 2-character password, it tries aa, ab, ac... zz.

Examples:

Recursive Fibonacci calculation (the simple, non-optimized version).
*/