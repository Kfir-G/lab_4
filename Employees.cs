using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Employees
    {
        public enum Days { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Satuerday }

        //data fields:
        string name;
        int age;
        int id;
        Days day;

        public static int employeeCounter;

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
    }
}
