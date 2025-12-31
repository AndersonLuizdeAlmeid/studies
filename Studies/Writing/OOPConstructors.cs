/*
    
    Constructors are special methods to define values for an object's properties when the object is created, ensuring the object starts in a valid state.
    They have the same name as the class and do not have a return type.
    They can take parameters to allow setting initial values for the object's properties.
    Here's an example of a class with a constructor in C#:
    public class Person
    {
        -- Properties --
        public string Name;
        public int Age;
        -- Constructor --
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Method
        public void Speak()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    So constructors are essencial for initializing objects and simplifying the process of creating instancecs of classes with specific starting values.

 */