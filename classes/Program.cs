using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        // Create a public property for holding a list of current employees
        public List<Employee> CurrentEmployees {get; set;}
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime CreatedOn){
            this.Name = name;
            this.CreatedOn = CreatedOn;
        }

        public void ListEmployee(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName}{employee.LastName} has worked for {this.Name} as {employee.Title} since {employee.StartDate}");
        }
    }

        
    public class Employee
    {

        // Some readonly properties (let's talk about gets, baby)
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Employee(string firstname,string lastname,string title, DateTime startdate){
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Title = title;
            this.StartDate = startdate;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            DateTime companyCreationDate = new DateTime(2008, 9, 22, 14, 30, 0);
            Company forestLodge = new Company("Forest Lodge Inn", companyCreationDate);
            forestLodge.CurrentEmployees = new List<Employee>();

            DateTime angelaJoined = new DateTime(2010, 5, 12, 14, 30, 0);
            Employee angela = new Employee("Angela", "Peters", "Platform Engineer", angelaJoined);
            DateTime markJoined = new DateTime(2012, 10, 04, 14, 30, 0);
            Employee mark = new Employee("Mark", "Robers", "Platform Engineer", markJoined);
            DateTime rebeccaJoined = new DateTime(2009, 11, 19, 14, 30, 0);
            Employee rebecca = new Employee("Rebecca", "Cole", "Platform Engineer", angelaJoined);

            forestLodge.CurrentEmployees.Add(angela);
            forestLodge.CurrentEmployees.Add(mark);
            forestLodge.CurrentEmployees.Add(rebecca);

            foreach (Employee person in forestLodge.CurrentEmployees) {
                forestLodge.ListEmployee(person);
            }



        }
    }
}
