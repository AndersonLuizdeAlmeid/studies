/*
 1. The Core Concept 🏦
The best analogy is "paying rent."

Imagine you pay $10 for every day you use your apartment. This is O(1).

But, once a month (every 30 days), you also have to pay a $300 "service fee." This single operation is expensive (O(n) where n=30).

If you just looked at the worst case, you would say, "The cost of living in my apartment is $310 per day!" That's true for one day, but it's not representative.

Amortized analysis is like saving up. You know the $300 fee is coming. So, every day, you put aside an extra $10 ($300 / 30 days) in addition to your $10 rent.

Your "amortized" or "spread-out" cost is $20 per day ($10 rent + $10 saved-for-fee).

This is a constant cost. O(1).

By spreading the cost of the rare, expensive operation over all the cheap operations, you get a more accurate and realistic O(1) cost per operation.

2. The Classic Technical Example: List<T>.Add
This is the exact example from your list that this concept explains.

As we discussed, a List<T> (dynamic array) has an internal array with a certain Capacity. Let's say the capacity is 4.

myList.Add(10): [10, _, _, _]

Cost: O(1).

myList.Add(20): [10, 20, _, _]

Cost: O(1).

myList.Add(30): [10, 20, 30, _]

Cost: O(1).

myList.Add(40): [10, 20, 30, 40]

Cost: O(1).

The list is now full.

myList.Add(50): Uh oh, list is full!

The List<T> must perform an expensive resize.

Create a new array of Capacity = 8.

Copy 10, 20, 30, 40 to the new array. (This is O(n) where n=4).

Add the new item 50.

[10, 20, 30, 40, 50, _, _, _]

Cost: O(n).

This is where amortized analysis comes in.

You had 4 "cheap" O(1) operations.

Then you had 1 "expensive" O(n) operation.

The total cost for n adds was not O(n*n).

The total cost was (n-1) * O(1) + 1 * O(n), which is just O(n).

The total cost to add n items is O(n).

Therefore, the average cost per operation is Total Cost / Total Operations = O(n) / n = O(1).

The O(n) resize operation happens so rarely (it doubles in size each time) that its cost, when "spread" or "amortized" over all the cheap O(1) adds, doesn't change the overall constant-time O(1) complexity.

3. 🎯 Common Technical Interview Questions
Question 1: "What is amortized analysis?"

Answer: "It's a way to analyze algorithms where an expensive operation happens only occasionally. It calculates the average cost per operation over a sequence of operations, 'spreading' the cost of the rare, expensive operation over all the more frequent, cheap operations."

Question 2: "What is the time complexity of List<T>.Add() in C#?"

Answer: "The amortized time complexity is O(1).

Follow-up: "But what is the worst-case complexity?"

Answer: "The worst-case for a single add operation is O(n). This happens when the list's internal array is full and a resize is triggered, requiring all n elements to be copied to a new, larger array."

This concept is key to explaining why we can say List.Add is O(1) even though we know it sometimes does a lot of work.
 */