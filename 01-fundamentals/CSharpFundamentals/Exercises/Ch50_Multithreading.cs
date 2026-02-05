using System;
using System.Threading;

namespace CSharpFundamentals.Exercises;

public static class Ch50_Multithreading
{
    public static void Run()
    {
        // Chapter 50: Multithreading
        // thread = an excecution path of a program 
        // we can use multuple threads to perform different tasks of our program at the same time
        // current thread running is "main" thread using System.Threading

        Thread mainThread = Thread.CurrentThread; //assigns the currnent thread to the local variable named mainthread
        mainThread.Name = "Main Thread";
        // Console.WriteLine((mainThread.Name);


        /* CountDown();  using these methods will only make them run on the same trhead aka, timer 1 needs to be fully completed
        CountUp(); */ // before the second one initiates

        //DO THIS INSTEAD
        Thread thread1 = new Thread(() => CountDown("Timer #1")); //use lamda expression when methods have parameters
        Thread thread2 = new Thread(() => CountUp("Timer #2")); // like in this case (String name)
        thread1.Start();
        thread2.Start();

        Console.WriteLine(mainThread.Name + " is complete!");

        Console.ReadKey();  
    }
    public static void CountDown(String name) //method
    {
        for (int i = 10; i >=0; i--)
        {
            Console.WriteLine("Timer #1 : " + i + " seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Tiemr #1 is complete!");
    }

    public static void CountUp(String name)
    {
        for(int i =0; i <=10; i++)
        {
            Console.WriteLine("Timer #2 : " + i + " seconds");
            Thread.Sleep(1000);

        }
        Console.WriteLine("Tiemr #2 is complete!");
    }
}
