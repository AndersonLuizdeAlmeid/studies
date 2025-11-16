namespace Studies.SortingAlgorithms;
public class SimpleSorts
{
}

/*
 1. Simple Sorts (O(n²) - Generally Slow)
These are good to know conceptually but are too slow for large datasets.

Bubble Sort
This is the simplest, most inefficient sort.

How it Works: It repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The largest elements "bubble" to the end of the array with each pass.

Time Complexity:

Best Case: O(n) (If the array is already sorted and we use a flag to check if any swaps were made).

Average Case: O(n²)

Worst Case: O(n²) (e.g., a reverse-sorted array).

Space Complexity: O(1) (It's an "in-place" sort; it doesn't need extra memory).

When to Use: Almost never. It's a teaching tool.

Insertion Sort
This is a more intuitive simple sort.

How it Works: It builds the final sorted array one item at a time. It's like sorting a hand of playing cards: you take one unsorted card (key) and "insert" it into its correct position within the sorted part of your hand.

Time Complexity:

Best Case: O(n) (If the array is already sorted).

Average Case: O(n²)

Worst Case: O(n²)

Space Complexity: O(1) (In-place).

When to Use: This is its superpower: it's very fast on small or nearly-sorted datasets. Because of this, it's often used as a helper for more complex algorithms.
 */