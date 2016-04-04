using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Contacts
{
    public enum Type
    {
        Home,
        Workplace,
        Mobile    
    }

    public struct Person
    {
        public string name;
        public string address;
        public int age;
        public string telephoneNumber;
        public Type Type;

        public Person(string name, string address, int age, string telephoneNumber, Type type)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.telephoneNumber = telephoneNumber;
            Type = type;
        }

        public override string ToString()
        {
            return $"Name: {name}, Address: {address}, Age: {age}, Number: {telephoneNumber}, Type: {Type}";
        }
    }
}
