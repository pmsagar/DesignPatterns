using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("This is first message.");
            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("This is second message.");
        }
    }
}
