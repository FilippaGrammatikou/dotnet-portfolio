using System;

namespace CSharpFundamentals
{
    class Human
    {
        public string name; //not safe to make these public but just for learning porpuses
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }

        public void Sleeping()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }
}


