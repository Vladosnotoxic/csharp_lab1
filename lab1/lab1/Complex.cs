using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }
        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }
        public void Substract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }
        public void Multiply(Complex x)
        {
            Real *= x.Real;
            Imag *= x.Imag;
        }
        public void Divide(Complex x)
        {
            Real /= x.Real;
            Imag /= x.Imag;
        }
    }
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string hobby { get; set; }
        public int Age { get; set; }
        public int GroupNumber { get; set; }

        public void Add(Student s)
        {
            Id += s.Id;
            Name += s.Name;
            hobby += s.hobby;
            Age += s.Age;
            GroupNumber += s.GroupNumber;
        }
        public void AddMore(Student s1, Student s2)
        {
            Id += s1.Id;
            Name += s1.Name;
            hobby += s1.hobby;
            Age += s1.Age;
            GroupNumber += s1.GroupNumber;
            Id += s2.Id;
            Name += s2.Name;
            hobby += s2.hobby;
            Age += s2.Age;
            GroupNumber += s2.GroupNumber;

        }
    }
}


