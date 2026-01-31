namespace CSharpFundamentals.Exercises;

public static class Ch40_MethodOverriding
{
    public static void Run()
    {
        // Chapter 40: MethodOverriding
        // provides a new version of a method inherited from a parent class
        // inherited method must be: abstract, virtual,or already overriden
        // used with ToString(), polymorphism
        Cat cat = new Cat();
        Dog dog = new Dog();

        cat.Speak();
        dog.Speak();


        Console.ReadKey();  
    }

    class Animal // Superclass or Base Class
    {
        public virtual void Speak() // Virtual version
        {
            Console.WriteLine("The animal goes *brrr*.");
        }

       /* if we were to use an Abstract method, then we would need the following instead:
        public abstract void Speak(); // remove the body */
    }

    class Cat  : Animal
    {
        public override void Speak()
        {  // to create an overriding a method, the method inherited must be virtual, 
           // abstract or already overriden
            Console.WriteLine("The cat goes *meow*.");
        }
    }

    class Dog : Animal  // if we were to leave Dog empty, it would still inherit the method from the parent
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*.");
        }
    }
}
