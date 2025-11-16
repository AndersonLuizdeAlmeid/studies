/*
 1. 🎯 The Core Concept
The "Divide and Conquer" strategy involves three steps, almost always implemented using recursion:

Divide: Break the main problem down into two or more smaller, similar sub-problems.

Conquer: Solve the small sub-problems recursively. If a sub-problem is small enough (the "base case"), solve it directly.

Combine: Take the solutions from the sub-problems and "merge" or "combine" them to get the solution for the original, large problem.

Analogy: Imagine you're in charge of counting every single book in a massive, multi-story library (the "problem").

Divide: You don't do it yourself. You give each floor supervisor (sub-problem) the task: "Count the books on your floor." They, in turn, give each librarian (sub-sub-problem) a section: "Count the books in your section."

Conquer: A single librarian can easily count the books in their one section (the "base case"). They report their count (e.g., "500 books") to their supervisor.

Combine: The floor supervisor adds up the counts from all their librarians to get the total for the floor. They report this "combined" number to you. You then add up the totals from each floor to get the grand total for the entire library.

You solved a massive problem by breaking it down and combining the results.

2. Classic Examples
Merge Sort
This is the perfect example of Divide and Conquer.

Divide: Split the array in half. ([8, 3, 1, 7] becomes [8, 3] and [1, 7]).

Conquer: Recursively call Merge Sort on the two halves until you have arrays of size 1 (which are "solved" or sorted).

Combine: This is the Merge step. You take the two sorted sub-arrays (e.g., [3, 8] and [1, 7]) and combine them into one new sorted array ([1, 3, 7, 8]).

Quick Sort
Also Divide and Conquer, but the "work" is in a different step.

Divide: This is the Partition step. You choose a pivot and rearrange the array around it. This divides the problem into two sub-problems (the "left" and "right" sub-arrays).

Conquer: Recursively call Quick Sort on the left and right sub-arrays.

Combine: There is no combine step! This is the key difference. Because the partitioning step puts the pivot in its final correct place and ensures all items are on the correct side, the array is sorted "in-place" as soon as the recursive calls finish. The work is all done in the "Divide" step.

Binary Search (also a D&C algorithm)
Divide: Check the middle element of a sorted array. By comparing it to your target, you can eliminate half of the array. This is "dividing" the problem.

Conquer: Recursively search the remaining (and much smaller) half.

Combine: No "combine" step is needed. Once you find the item (or run out of array), you're done.

3. 🎯 Common Technical Interview Questions
Question 1: "What is the 'Divide and Conquer' paradigm?"

Answer: "It's a problem-solving strategy where you recursively break a problem into smaller, similar sub-problems, solve those sub-problems, and then combine their solutions to solve the original problem."

Question 2: "You mentioned Merge Sort and Quick Sort both use this. What's the main difference in how they apply it?"

Answer: "The main difference is where the 'work' is done.

Merge Sort does its main work in the Combine step (the Merge function). The Divide step is very simple (just splitting the array).

Quick Sort does its main work in the Divide step (the Partition function). The Combine step is non-existent because the array is sorted in-place."

Question 3: "How does 'Divide and Conquer' relate to time complexity?"

Answer: "It's the reason we get O(n log n) complexity.

The log n part comes from the Divide step. You are repeatedly splitting the problem in half (like a phone book), which is a logarithmic operation.

The n part comes from the Combine (or Partition) step. For each level of the recursion, you still have to do O(n) work (e.g., merging all the elements)."

This strategy is fundamental to many of the most efficient algorithms.
 */