using System;
using System.Collections.Generic;
using System.Text;

// Lazy loading  - Improves performance; avoids unnecessary loads till the point object is accessed
// Reduces memory footprint on start-up
// Faster Application Load


// Eager loading - preinstantiation of the object
// Commonly used in lower memory footprint


namespace SingletonDemo
{
    //3. Class is sealed to avoid instantiating an object by using nested classes/sub classes
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        // 2. Defined a public property to access the single instance
        public static Singleton GetInstance
        {
            get 
            {
                if(instance == null)// If the instance is not available
                    instance =  new Singleton();
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
