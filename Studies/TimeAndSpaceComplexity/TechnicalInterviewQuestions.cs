/*
 4. 🎯 Common Technical Interview Questions
Question 1: "This function has two for loops, one after the other. What's the time complexity?"

Answer: "If both loops run n times, the complexity is O(n) + O(n), which simplifies to O(n). We drop the constants because Big O only cares about the rate of growth."

Question 2: "This function has two nested for loops. What's the complexity?"

Answer: "It's O(n²), because for every one iteration of the outer loop, the inner loop runs n times. This is n * n operations."

Question 3: "What is the space complexity of this recursive function?"

Answer: "You have to look at two things:

Any data structures being created (e.g., new lists).

The recursion call stack. A recursive function that calls itself n times deep (like a recursive linked list traversal) will use O(n) space on the stack, even if it's not creating any other data."

Question 4: "Can you make this O(n²) algorithm faster?"

Answer: "This is a prompt to see if you can identify a trade-off. The answer is usually 'Yes, if I can use a HashSet or Dictionary. This will use O(n) space, but it should lower the time complexity to O(n).'"
 */