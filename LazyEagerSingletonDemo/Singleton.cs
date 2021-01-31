using System;
using System.Collections.Generic;
using System.Text;

// Lazy loading  - Improves performance; avoids unnecessary loads till the point object is accessed
// Reduces memory footprint on start-up
// Faster Application Load


// Eager loading - preinstantiation of the object
// Commonly used in lower memory footprint
namespace LazyEagerSingletonDemo
{
    //3. Class is sealed to avoid instantiating an object by using nested classes/sub classes
    public sealed class EagerSingleton
    {
        private static int counter = 0;
        // To facilitate eager loading
        private static readonly EagerSingleton instance = new EagerSingleton();
        // 2. Defined a public property to access the single instance
        public static EagerSingleton GetInstance
        {
            get 
            {
                return instance;
            }
        }

        //1. Declared private to restrict direct instantiation
        private EagerSingleton()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }



    public sealed class LazySingleton
    {
        private static int counter = 0;
        // To facilitate lazy loading
        // By default lazy keyword is thread safe 
        private static readonly Lazy<LazySingleton> instance = new Lazy<LazySingleton>(() => new LazySingleton());
        // 2. Defined a public property to access the single instance
        public static LazySingleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        //1. Declared private to restrict direct instantiation
        private LazySingleton()
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
