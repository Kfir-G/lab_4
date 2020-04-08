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

        public static int workersCounter;

    }
}
