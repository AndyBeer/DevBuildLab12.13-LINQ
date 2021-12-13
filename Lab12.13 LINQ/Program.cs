using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab12._13_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {10, 2330, 112233, 10, 949, 3764, 2942 };

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

            Console.WriteLine("Nums Questions:\n\n1. Find minimum value:");
            int minNum = nums.Min();
            Console.WriteLine(minNum);

            Console.WriteLine("\n2. Find maximum value:");
            int maxNum = nums.Max();
            Console.WriteLine(maxNum);

            Console.WriteLine("\n3. Find maximum value less than 10,000:");
            int maxUnder10k = nums.Where(x => x < 10000).Max();
            Console.WriteLine(maxUnder10k);

            Console.WriteLine("\n4. Find values between 10 and 100 (guessing exclusive):"); // by the look of the list, nothing should print
            List<int> numsBtwn10and100 = nums.Where(x => x < 100 && x > 10).ToList();
            if (numsBtwn10and100.Count() > 0)
            {
                foreach (int n in numsBtwn10and100)
                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("hey buddy, your filtered list is empty.\n");
            }
            Console.WriteLine("\n5. Find values between 100,000 and 999,999 (inclusive):");
            List<int> anotherListOfRangedNums = nums.Where(x => x <= 999999 && x >= 100000).ToList();
            if (anotherListOfRangedNums.Count() > 0)
            {
                foreach (int n in anotherListOfRangedNums)
                {
                    Console.WriteLine(n);
                }
            }
            else 
            {
                Console.WriteLine("You ain't got no values, Lt. Dan!\n");
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("Student list questions!");
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("1. Find all students who are 21 or older:");
            List<Student> partyStus = students.Where(x => x.Age >= 21).ToList();
            foreach (Student s in partyStus)
            {
                Console.WriteLine("- " +s.Name + "\n  Age: " +s.Age +"\n");
            }

            Console.WriteLine("\n2. Find most aged student:");
            int highestAge = students.Max(x => x.Age);
            List<Student> mostAgedStus = students.Where(x => x.Age == highestAge).ToList();

            foreach (Student s in mostAgedStus)
            {
                Console.WriteLine($"- {s.Name}\n  Age: {s.Age}\n");
            }

            Console.WriteLine("\n3. Find least aged student:");
            int lowestAge = students.Min(x => x.Age);
            List<Student> leastAgedStus = students.Where(x => x.Age == lowestAge).ToList();

            foreach (Student s in leastAgedStus)
            {
                Console.WriteLine($"- {s.Name}\n  Age: {s.Age}\n");
            }

            Console.WriteLine("\n4. Find most aged student under the age of 25:");
                       
            List<Student> mostAgedStusUnder25 = students.Where(x => x.Age < 25).ToList();
            int highestAge2 = mostAgedStusUnder25.Max(x => x.Age);
            List<Student> mostAgedStus2 = students.Where(x => x.Age == highestAge2).ToList();
            foreach (Student student1 in mostAgedStus2)
            {
                Console.WriteLine(student1.Name + " is not able to rent a car, but they are SO CLOSE!!\n -Age: " + student1.Age);
            }
            //I am sure there is a better way to get exactly 1 result, but by saying age == (highest age), it is kinda doing that already.

            Console.WriteLine("\n5. Find students over 21 with even ages:");
            List<Student> evensOver21 = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();

            foreach (Student student in evensOver21)
            {
                Console.WriteLine($"- {student.Name}\n  Age: {student.Age}\n");
            }

            Console.WriteLine("\n6. Find students of ages 13-19 (inclusive):");
            List<Student> teenStudents = students.Where(x => x.Age < 20 && x.Age > 12).ToList();

            foreach (Student student in teenStudents)
            {
                Console.WriteLine($"- {student.Name}\n  Age: {student.Age}\n");
            }

            Console.WriteLine("\n7. Find students whose names start with a vowel:");
            List<Student> vowelStudents = students.Where(x => 
            x.Name.StartsWith('A')
            || x.Name.StartsWith('E') 
            || x.Name.StartsWith('I') 
            || x.Name.StartsWith('O') 
            || x.Name.StartsWith('U')).ToList();

            foreach (Student student in vowelStudents)
            {
                Console.WriteLine($"- {student.Name}, because that starts with an \"{student.Name.Substring(0,1)}\".\n");
            }
        }
    }
}
