using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    internal class Person
    {
        private string name;
        private int age;
        private string address;

        public void SetName(string name = "")
        {
            this.name = name;
        }
        public void SetAge(int age = 0)
        {
            this.age = age;
        }
        public void SetAddress(string address = "-")
        {
            this.address = address;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public string GetAddress()
        {
            return this.address;
        }
    }
}
