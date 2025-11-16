namespace Studies.TimeAndSpaceComplexity;
public class TimeVsSpaceTradeOffs
{
}
/*
 3. ⚖️ Time vs. Space Trade-offs
This is a critical concept in interviews. You can often make an algorithm faster by using more memory, or make it use less memory by making it slower.

Example 1: The "Contains Duplicate" problem.

Slow Time, Constant Space (O(n²), O(1)): Take the first number, and loop through the rest of the array to see if it matches. Repeat for the second, third, etc. This is a O(n²) nested loop, but it uses O(1) space (no extra memory).

Fast Time, Linear Space (O(n), O(n)): Iterate the array once. As you go, add each number to a HashSet. If Add() ever returns false, you found a duplicate. This is O(n) time, but it requires O(n) space for the HashSet.

Example 2: Merge Sort vs. Quick Sort.

Merge Sort: Guarantees O(n log n) time, but needs O(n) extra space.

Quick Sort: Averages O(n log n) time and only needs O(log n) space (for the stack).

The Trade-off: Do you need the guaranteed speed of Merge Sort? Or is the risk of Quick Sort's O(n²) worst-case acceptable in exchange for saving memory?
 */
