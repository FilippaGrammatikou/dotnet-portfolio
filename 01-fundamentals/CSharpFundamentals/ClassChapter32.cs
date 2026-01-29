using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    class Human
    {
        public String name; //not safe to make these public but just for learning porpuses
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
