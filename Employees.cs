using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Employees
    {
        public enum Days { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Satuerday }

        public static int employeeCounter;

        //data fields:
        string name;
        int age;
        int id;
        Days day;

        //constructor
        public Employees (string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            if (id > 0)
                this.id = id;
            else
                this.id = -1;
            employeeCounter++;
        }

        //property:
        public string Name 
        {
            get;
            set;
        }
        public int Age 
        {
            get;
            set;
        }
        public Days Day
        {
            get;
            set;
        }

        public int GetId //read only        
        {
            get { return id; }
        }
        public static int EmployeeCount { get => employeeCounter}

        //methods:
        public void PrintDetails()
        {
            Console.WriteLine("Worker details:");
            Console.WriteLine("Name: " + this.name + "\nAge: " + this.age + "\nID: " + this.id + "\nDays: " + this.day);
        }
        public void PrintEmployee()
        { //withuot days of work
            Console.WriteLine("Worker details:");
            Console.WriteLine("Name: " + this.name + "\nAge: " + this.age + "\nID: " + this.id);
        }
    }
}
