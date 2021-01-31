using System;
using System.Threading.Tasks;

namespace ThreadSafetySingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=> PrintEmployeeDetails(),
                ()=> PrintStudentDetails()
                );
        }

        private static void PrintStudentDetails()
        {
            Singleton student = Singleton.GetInstance;
            student.PrintDetails("This is student message.");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton employee = Singleton.GetInstance;
            employee.PrintDetails("This is employee message.");
        }
    }
}
