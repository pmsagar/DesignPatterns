using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadSafetySingletonDemo
{
    //3. Class is sealed to avoid instantiating an object by using nested classes/sub classes
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj = new  object();
        // 2. Defined a public property to access the single instance
        public static Singleton GetInstance
        {
            get 
            {
                // Ensures only when thread enters
                // Locks are very expensive, therefore it is unncessary to check for lock for every condition
                // It is recommended to use lock only when instance is null
                // This is call double checked locking
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)// If the instance is not available
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        //1. Declared private to restrict direct instantiation
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
