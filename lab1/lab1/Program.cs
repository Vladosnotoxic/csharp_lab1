using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("Студент группы ВИС-31 Солтанов Владислав");
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };
            a.Add(b);
            Console.WriteLine($"a = {a.Real} + {a.Imag}i");
            a.Substract(b);
            Console.WriteLine($"a = {a.Real} + {a.Imag}i");
            b.Multiply(a);
            Console.WriteLine($"b = {b.Real} + {b.Imag}i");
            b.Divide(a);
            Console.WriteLine($"b = {b.Real} + {b.Imag}i");

            Student student1 = new Student() { Age = 18, Id = 1, GroupNumber = 31, Name = "Александр", hobby = "Футбольчик" };
            Student student2 = new Student() { Age = 19, Id = 2, GroupNumber = 32, Name = "Алексей", hobby = "Xоккейчик" };

            student1.Add(student2);
            student2.AddMore(student1, student2);
            Console.WriteLine("Student1:");
            Console.WriteLine($"Id = {student1.Id}, Age = {student1.Age}, Name = {student1.Name}, Hobby = {student1.hobby}, GroupNumber = {student1.GroupNumber}");
            Console.WriteLine("Student2:");
            Console.WriteLine($"Id = {student2.Id}, Age = {student2.Age}, Name = {student2.Name},  Hobby= {student2.hobby}, GroupNumber = {student2.GroupNumber}");
        }
    }
}
