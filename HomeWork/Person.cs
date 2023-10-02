using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HomeWork
{
    class AgeValidationAttribute : Attribute
    {
        public int Age { get; }
        public AgeValidationAttribute() { }
        public AgeValidationAttribute(int age) => Age = age;
    }

    [AgeValidation(18)]
    public class Person
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
