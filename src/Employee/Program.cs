using System;
using EmployeeHeap;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHeap
{
    //create employee class
    class Employee 
    {      
        //fields to initialize employee id and salary
        private string employeeId;
        private string employeeSalary;
        //fields to initialize manager id,
        private string managerId;
        //properties for the employee id,salary
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeSalary { get => employeeSalary; set => employeeSalary = value; }

        //properties for the manager id
        public string ManagerId { get => managerId; set => managerId = value; }

        //Default employee constructor
        public Employee()
        {

        }
        //Employee constuctor that takes csv input String
        public Employee(string csvString)
        {
            //csvString validations
            if (String.IsNullOrEmpty(csvString))
            {
                throw new ArgumentException("The csv file cannot be empty");
            }
            else
            {
                //Convert the csv string to csv array             
                string[] csv = csvString.Split('\n', ',');
                //map the csv array into Employee class properties
                Action<string>[] PropertyMappings =
                {
                x=>this.EmployeeId=x,
                x=>this.ManagerId=x,
                x=>this.EmployeeSalary=x
                
                };
                //for (int i = 0; i < csv.Count(); i++)
                //{
                //    PropertyMappings[i](csv[i]);
                //}

            }
            
        }
                  
        //Add an instance method that returns the salary budget from the specified manager.
        public void salaryReport()
        {
            //Store the array data in a dictionary
            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            //Hard code data for testing
            Employee employee4 = new Employee { EmployeeId = "4", ManagerId="2", EmployeeSalary="500"};
            Employee employee3 = new Employee { EmployeeId = "3", ManagerId = "1", EmployeeSalary = "800" };
            Employee employee1 = new Employee { EmployeeId = "1", ManagerId = "empty", EmployeeSalary = "1000" };
            Employee employee5 = new Employee { EmployeeId = "5", ManagerId = "1", EmployeeSalary = "500" };
            Employee employee2 = new Employee { EmployeeId = "2", ManagerId = "1", EmployeeSalary = "500" };

            Console.WriteLine("Enter the Id of the manager:");
            string EmployeeIdSelection = Console.ReadLine();

            if (EmployeeIdSelection.ToUpper() == "Employee4")
            {
                //add the selected employee into the employeedictionary
                employeeDictionary.Add(employee4.EmployeeId, employee4);           
            }
            else if (EmployeeIdSelection.ToUpper() == "Employee3")
            {
                employeeDictionary.Add(employee3.employeeSalary, employee3);
            }
            else if (EmployeeIdSelection.ToUpper() == "Employee1")
            {
                employeeDictionary.Add(employee1.employeeSalary, employee1);

            }
            else if (EmployeeIdSelection.ToUpper() == "Employee5")
            {
                employeeDictionary.Add(employee5.employeeSalary, employee5);
            }
            else if (EmployeeIdSelection.ToUpper() == "Employee2")
            {
                employeeDictionary.Add(employee2.employeeSalary, employee2);
            }

            foreach (KeyValuePair<string, Employee> employeeList in employeeDictionary)
            {
                Console.WriteLine($"EmployeeId selected:{employeeList.Value.EmployeeId}");
                Console.WriteLine($"Salary Budget:{employeeList.Value.EmployeeSalary}");
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

