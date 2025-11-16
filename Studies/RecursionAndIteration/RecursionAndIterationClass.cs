namespace Studies.RecursionAndIteration;
public class RecursionAndIterationClass
{
    public int RecursionMethod(int n)
    {
        // 1. Base Case (the smallest doll)
        if (n == 1)
        {
            return 1;
        }

        // 2. Recursive Step (call itself with a smaller problem)
        return n * RecursionMethod(n - 1);
    }

    /*
     Let's tackle Recursion vs. Iteration.

    This is a fundamental concept in programming. They are two different ways to accomplish the same goal: repeating a task.

    Iteration: Uses a loop (for, while) to repeat a block of code.

    Recursion: A function calls itself to repeat a task.

    1. 🔁 Recursion (The "Matryoshka Doll")
    A recursive function is like a set of Russian Matryoshka dolls. You open one (a function call), and there's a slightly smaller version of the same doll inside (the recursive call). This continues until you reach the smallest doll that can't be opened (the base case).

    A recursive function must have two parts:

    Base Case: The condition that stops the recursion. Without this, you get an infinite loop and a Stack Overflow Error.

    Recursive Step: The part where the function calls itself, but with a "smaller" or "simpler" version of the problem.

    C# Example: Factorial (Recursive)
    Let's calculate Factorial(4) (which is 4 * 3 * 2 * 1 = 24).
     */

    public int IterationMethod(int n)
    {
        int total = 1;

        // Use a loop to repeat the multiplication
        for (int i = n; i > 1; i--)
        {
            total = total * i;
        }

        return total;
    }
}

/*
 
2. 🔄 Iteration (The "Assembly Line")
An iterative approach uses a loop to build up the answer step-by-step. It's like an assembly line, where a variable is modified at each "station" (loop iteration) until it's complete.
 
Let's tackle Recursion vs. Iteration.This is a fundamental concept in programming. They are two different ways to accomplish the same goal: repeating a task.Iteration: Uses a loop (for, while) to repeat a block of code.Recursion: A function calls itself to repeat a task.1. 🔁 Recursion (The "Matryoshka Doll")A recursive function is like a set of Russian Matryoshka dolls. You open one (a function call), and there's a slightly smaller version of the same doll inside (the recursive call). This continues until you reach the smallest doll that can't be opened (the base case).A recursive function must have two parts:Base Case: The condition that stops the recursion. Without this, you get an infinite loop and a Stack Overflow Error.Recursive Step: The part where the function calls itself, but with a "smaller" or "simpler" version of the problem.C# Example: Factorial (Recursive)Let's calculate Factorial(4) (which is 4 * 3 * 2 * 1 = 24).C#public int FactorialRecursive(int n)
{
    // 1. Base Case (the smallest doll)
    if (n == 1)
    {
        return 1;
    }
    
    // 2. Recursive Step (call itself with a smaller problem)
    return n * FactorialRecursive(n - 1);
}

// How it runs for FactorialRecursive(4):
// 1. return 4 * FactorialRecursive(3)
// 2.    -> return 3 * FactorialRecursive(2)
// 3.       -> return 2 * FactorialRecursive(1)
// 4.          -> return 1 (Base Case hit!)
//
// Now it "unwinds":
// 4.          -> 1
// 3.       -> 2 * 1 = 2
// 2.    -> 3 * 2 = 6
// 1. return 4 * 6 = 24
2. 🔄 Iteration (The "Assembly Line")An iterative approach uses a loop to build up the answer step-by-step. It's like an assembly line, where a variable is modified at each "station" (loop iteration) until it's complete.C# Example: Factorial (Iterative)C#public int FactorialIterative(int n)
{
    int total = 1;
    
    // Use a loop to repeat the multiplication
    for (int i = n; i > 1; i--)
    {
        total = total * i;
    }
    
    return total;
}

// How it runs for FactorialIterative(4):
// i = 4, total = 1 * 4 = 4
// i = 3, total = 4 * 3 = 12
// i = 2, total = 12 * 2 = 24
// i = 1, loop stops.
// return 24
3. ⚖️ The Comparison: Pros and ConsThis is the trade-off interviewers want to hear.FeatureRecursionIterationCode ClarityOften more elegant and easier to read for problems that are naturally recursive (e.g., Divide & Conquer, tree traversal).Can be more "cluttered" with loop variables (i, total, etc.).Space ComplexityO(n) (Bad!) Each function call adds a "frame" to the call stack. Too many calls (e.g., Factorial(100000)) will cause a Stack Overflow Error.O(1) (Good!) Uses a few fixed variables. Can run forever without running out of stack memory.Time ComplexityOften the same as iteration, but can be much worse if not written carefully (e.g., simple recursive Fibonacci is O(2ⁿ)).Often the most straightforward way to get an efficient O(n) solution.


4. 🎯 Common Technical Interview Questions
Question 1: "What is the primary danger of using recursion?"

Answer: "The Stack Overflow Error. Because each recursive call uses space on the call stack, a deep recursion (a large n) can exhaust that memory, crashing the program. Iteration avoids this by using O(1) space."

Question 2: "If recursion is dangerous, why use it at all?"

Answer: "For certain problems, it makes the code dramatically simpler and more readable. Problems like traversing a tree or file system, or implementing 'Divide and Conquer' algorithms like Merge Sort, are naturally recursive. An iterative solution for those can be much more complex to write and understand."

Question 3: "Can every recursive function be rewritten as an iterative one?"

Answer: "Yes. Any recursive algorithm can be converted to an iterative one, though it sometimes requires using your own explicit Stack or Queue data structure to simulate the function calls. Iteration is generally more space-efficient."

The main takeaway: Recursion is a trade-off. You are trading space efficiency and safety for code elegance and simplicity (on complex problems).
 */