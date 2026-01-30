namespace CSharpFundamentals.Exercises;

public static class Ch35_OverloadedConstructors
{
    public static void Run()
    {
        // Chapter 35: OverloadedConstructors
        // technique to create multiple constructors, with a different set of parameters
        // name + parameters = signature

        Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella"/*, "pepperoni"*/);
        // if we wish for some of the ingredient categories to be missing eg toppings, we need to use overloaded constructors

        Console.ReadKey();
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce; 
            this.cheese = cheese;
            this.topping = topping;
        }

    }
}
