using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_ToStringMethode
{
    public class Employee
    {
        private int id;
        private string name;
        private string address;

        public Employee(int id, string name, string address)
        {
            this.id = id;//this is used for parameter
            this.name = name;
            this.address = address;


        }
        public override string ToString()
        {
            return "empid " + id + "empname " + name + "emp address " + address;
        }
    }
}
