/*
 
🌎 Mock Interview Questions
1. The Two Sum Problem (LeetCode #1)
This is a classic "warm-up" question.

Problem: Given an array of integers nums and an integer target, return the indices of the two numbers such that they add up to target. You may assume that each input has exactly one solution, and you may not use the same element twice.

Example: nums = [2, 7, 11, 15], target = 9

Output: [0, 1] (because nums[0] + nums[1] == 9)

Topics Tested: Array, Dictionary (Hash Map), Time/Space Trade-off.

The "Brute Force" Solution
The first answer is to use a nested loop.

Loop i from 0 to n.

Loop j from i + 1 to n.

If nums[i] + nums[j] == target, return [i, j].

Time Complexity: O(n²). (Too slow).

Space Complexity: O(1).

The "Optimal" Solution
You can trade space for time using a Dictionary.

Create a Dictionary<int, int> to store (value, index).

Loop through the array once. For each number nums[i]:

Calculate the complement you need: complement = target - nums[i].

Check if your dictionary already contains the complement as a key.

If YES: You've found the pair! Return [dictionary[complement], i].

If NO: Add the current number and its index to the dictionary: myMap.Add(nums[i], i).

Time Complexity: O(n). (You only loop once, and Dictionary lookups are O(1)).

Space Complexity: O(n). (In the worst case, you store all n numbers in the dictionary).

2. Detect a Cycle in a Linked List (LeetCode #141)
This question has two common solutions and is a fantastic test of the time/space trade-off.

Problem: Given the head of a singly-linked list, determine if the list has a cycle (i.e., a node's Next pointer points back to a previous node).

Topics Tested: Linked Lists, Hash Sets, Pointers (Two-Pointer Technique).

Solution 1: Using a HashSet
Create a HashSet<Node>.

Start a current pointer at the head.

Loop while current != null:

Try to add the entire current node to the set: seenNodes.Add(current).

If Add() returns false, it means that node was already in the set. You've found a cycle! Return true.

If Add() returns true, move to the next node: current = current.Next.

If the loop finishes, you've hit null, so there is no cycle. Return false.

Time Complexity: O(n).

Space Complexity: O(n).

Solution 2 (Optimal): The "Fast & Slow Pointer"
This is the "in-place" solution that interviewers love.

Create two pointers, slow and fast, both starting at head.

In a loop, move them at different speeds:

slow = slow.Next (moves 1 step)

fast = fast.Next.Next (moves 2 steps)

If fast (or fast.Next) ever becomes null, the list has an end. Return false.

If slow == fast at any point, it means the fast pointer has "lapped" the slow pointer. This is only possible in a cycle. Return true.

Time Complexity: O(n).

Space Complexity: O(1). This is the big win.

3. Find the k-th Largest Element (LeetCode #215)
This problem tests your knowledge of sorting and "Divide and Conquer."

Problem: Given an integer array nums and an integer k, return the k-th largest element in the array.

Example: nums = [3, 2, 1, 5, 6, 4], k = 2

Output: 5 (6 is the 1st largest, 5 is the 2nd largest)

Topics Tested: Array, Sorting, Divide and Conquer, Quick Sort.

Solution 1: The Simple Sort
Sort the array: Array.Sort(nums).

Return the element at nums[nums.Length - k].

Time Complexity: O(n log n). (This is the cost of sorting).

Space Complexity: O(1) or O(log n) (depending on the sort algorithm's implementation).

This is a good, valid answer. But the interviewer might ask: "Can you do it faster?"

Solution 2 (Optimal): "QuickSelect"
This uses the partitioning logic from Quick Sort (a "Divide and Conquer" technique).

Pick a random pivot and partition the array (move all smaller to the left, all larger to the right).

The pivot is now in its final sorted position, pivotIndex.

You want to find the element that would be at index targetIndex = nums.Length - k.

Compare:

If pivotIndex == targetIndex, you're done! Return nums[pivotIndex].

If pivotIndex < targetIndex, you know the k-th element must be in the right sub-array. Recursively search only the right side.

If pivotIndex > targetIndex, you know the k-th element must be in the left sub-array. Recursively search only the left side.

Because you discard half the array each time, you don't do the full O(n log n) sort.

Time Complexity: O(n) on average. (Worst case is O(n²), but this is rare with a good pivot).

Space Complexity: O(log n) (for the recursion stack). 

 */