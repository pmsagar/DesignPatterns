using System;
using System.Threading.Tasks;

namespace LazyEagerSingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
    () => PrintStudentDetailsEagerSingleton(),
    () => PrintEmployeeDetailsEagerSingleton()
    );

            Parallel.Invoke(
() => PrintStudentDetailsLazySingleton(),
() => PrintEmployeeDetailsLazySingleton()
);
        }


        private static void PrintStudentDetailsEagerSingleton()
        {
            EagerSingleton student = EagerSingleton.GetInstance;
            student.PrintDetails("This is student message.");
        }

        private static void PrintEmployeeDetailsEagerSingleton()
        {
            EagerSingleton employee = EagerSingleton.GetInstance;
            employee.PrintDetails("This is employee message.");
        }

        private static void PrintStudentDetailsLazySingleton()
        {
            LazySingleton student = LazySingleton.GetInstance;
            student.PrintDetails("This is student message.");
        }

        private static void PrintEmployeeDetailsLazySingleton()
        {
            LazySingleton employee = LazySingleton.GetInstance;
            employee.PrintDetails("This is employee message.");
        }
    }

}
