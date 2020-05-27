using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab28Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            // NUMBERS LINQ
            var min = nums.Min();
            var max = nums.Max();
            var maxUnder10000 = nums.Where(x => x < 10000).Max();
            var over10Under100 = nums.Where(x => x > 10 && x < 100);
            var range100000To999999 = nums.Where(x => x >= 100000 && x <= 999999);
            var evenNumberCount = nums.Count(x => x % 2 == 0);

            // STUDENTS LINQ
            var canDrink = students.Where(x => x.Age >= 21);
            var oldestStudent = students.OrderByDescending(x => x.Age).First();
            var youngestStudent = students.OrderByDescending(x => x.Age).Last();
            var oldestUnder25 = students.Where(x => x.Age < 25).OrderByDescending(x => x.Age).First();
            var over21Even = students.Where(x => x.Age > 21 && x.Age % 2 == 0);
            var teenagers = students.Where(x => x.Age >= 13 && x.Age <= 19);
            var vowelStart = students.Where(x => "aeiou".Contains(x.Name.ToLower().Substring(0,1)));

            // NUMBERS TEST
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(maxUnder10000);
            foreach (var num in over10Under100)
            {
                Console.WriteLine(num);
            }
            foreach (var num in range100000To999999)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(evenNumberCount);

            // STUDENTS TEST
            Console.WriteLine("Can drink:");
            foreach (var stu in canDrink)
            {
                Console.WriteLine(stu.Name);
            }
            Console.WriteLine("oldest " + oldestStudent.Name);
            Console.WriteLine("youngest " + youngestStudent.Name);
            Console.WriteLine("oldest under 25" + oldestUnder25.Name);
            Console.WriteLine("Over 21 and Even");
            foreach (var stu in over21Even)
            {
                Console.WriteLine(stu.Name);
            }
            Console.WriteLine("Teens:");
            foreach (var stu in teenagers)
            {
                Console.WriteLine(stu.Name);
            }
            Console.WriteLine("Vowel start:");
            foreach (var stu in vowelStart)
            {
                Console.WriteLine(stu.Name);
            }
        }

    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
