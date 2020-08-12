using System;

namespace InClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Practice Class
            ListPractice lPractice = new ListPractice();
            // exercise 1
            lPractice.ex1();
            // exercise 2
            lPractice.ex2();
            // exercise 3
            lPractice.ex3();
            // exercise 4
            lPractice.ex4();
            // exercise 5
            lPractice.ex5();

            // Class Exercise
            Console.WriteLine("================ Class Exercises ================");
            Employee employee = new Employee();
            employee.employeePosition();

            Accountant accountant = new Accountant();
            accountant.employeePosition();

            Developer developer = new Developer();
            developer.employeePosition();


        }
    }
}
