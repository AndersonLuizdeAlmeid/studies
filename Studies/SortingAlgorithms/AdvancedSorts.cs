namespace Studies.SortingAlgorithms;
public class AdvancedSorts
{
}

/*
 2. Advanced Sorts (O(n log n) - Efficient)
These are the "divide and conquer" algorithms. They are much faster and are the standard for large datasets.

Merge Sort
This is the most reliable, efficient "go-to" sort.

How it Works (Divide and Conquer):

Divide: Recursively split the array in half until you have arrays of size 1 (which are, by definition, sorted).

Conquer (Merge): Merge the sorted sub-arrays back together, in order, until you have one single sorted array. The "merge" step is the key: you take two sorted arrays (e.g., [1, 5] and [2, 4]) and combine them efficiently.

Time Complexity:

Best, Average, & Worst Case: O(n log n). This is its main advantage. It's always fast and predictable, no matter the input.

Space Complexity: O(n). This is its main disadvantage. It's not in-place. It requires a temporary "helper" array of the same size (n) to perform the merge.

Stable: Yes. (A "stable" sort means that two items with the same value will keep their original relative order).

Quick Sort
This is often the fastest in practice, but it's more complex and has a bad worst-case.

How it Works (Divide and Conquer):

Pick a "Pivot": Choose an element from the array to be the "pivot" (e.g., the last element).

Partition: Reorder the array so that all elements smaller than the pivot are on its left, and all elements larger are on its right. The pivot is now in its final sorted position.

Recurse: Recursively apply the same steps to the sub-array on the left and the sub-array on the right.

Time Complexity:

Best Case: O(n log n)

Average Case: O(n log n) (This is why it's so popular).

Worst Case: O(n²). This is its main disadvantage. It happens if you consistently pick the worst possible pivot (like the smallest or largest element) on an already-sorted array.

Space Complexity: O(log n) (This is the memory used by the recursion call stack. It is considered "in-place" for the data itself).

Stable: No.
 */