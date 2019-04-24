using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * I decided to make use of the max heap because:
 * The list is not guaranteed to be sorted(a heap is not a sorted structure)
 * The maximum-value element at the root(CEO)
 */
namespace EmployeeHeap
{
    class EmployeeMaxHeap 
    {

        //private int[] employeeArray;
        ////size of the csv string array
        //private int count;
        //public int left(int i)
        //{
        //    return 2 * i + 1;
        //}
        //public int right(int i)
        //{
        //    return 2 * i + 2;
        //}
        //private int parent(int i)
        //{
        //    return (i - 1) / 2;
        //}

    }

    //create employee class
    class Employee : EmployeeMaxHeap
    {
       
        //fields to initialize employee id and salary
        private int employeeId;
        private int employeeSalary;
        //fields to initialize manager id,
        private int managerId;
        //properties for the employee id,salary
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public int EmployeeSalary { get => employeeSalary; set => employeeSalary = value; }

        //properties for the manager id
        public int ManagerId { get => managerId; set => managerId = value; }

        //Default employee constructor
        public Employee()
        {

        }
        //Employee constuctor that takes csv input String
        public Employee(string csvString)
        {   //csvString validations
            if (String.IsNullOrEmpty(csvString))
            {
                throw new ArgumentException("The csv file cannot be empty");
            }
            else
            {
                //work with the csv string array
                string[] csv = csvString.Split('\n', ',');
            }
           
        }
        //Add an instance method that returns the salary budget from the specified manager.
        public void salaryReport()
        {
            Console.WriteLine("Enter the Id of the manager:");
            string EmployeeId = Console.ReadLine();
            switch (EmployeeId)
            {
                case "Employee4":
                    Console.WriteLine("Result:");
                    break;
                case "Employee3":
                    Console.WriteLine("Result:");
                    break;
                case "Employee1":
                    Console.WriteLine("Result:");
                    break;
                case "Employee5":
                    Console.WriteLine("Result:");
                    break;
                case "Employee2":
                    Console.WriteLine("Result:");
                    break;
                default:
                    Console.WriteLine("Invalid Name");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Employee(File.ReadAllText(@"C:\Users\AppFactory\source\repos\fredkamau\Employee\src\Employee\employees.csv"));
            //calling the salaryReport method
            Employee emp1 = new Employee();
            emp1.salaryReport();
        }
    }
}
