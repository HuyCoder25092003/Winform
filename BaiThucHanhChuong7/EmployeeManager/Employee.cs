using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    [Serializable]
    class Employee
    {
        string name, address;
        int age;

        public String Name
        { get { return name; } set { name = value; } }

        public String Address
        { get { return address; } set { address = value; } }

        public int Age
        { get { return age; } set { age = (value<18?18:value); } }

        public Employee()
        {
        }

        public Employee(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            this.age = age < 18 ? 18 : age;
        }
    }
}
