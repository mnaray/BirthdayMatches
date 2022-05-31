using System;
using System.Collections.Generic;

namespace BirthdayMatches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of people to check: ");
            int amountOfPeople = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount of repetitions to calculate the average from: ");
            int amountOfRepetitions = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfRepetitions; i++)
            {
                BirthdayMatcher(amountOfPeople);
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(Environment.NewLine);
            }



            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }

        public static void BirthdayMatcher(int amountOfPeople)
        {
            IDictionary<DateTime, int> people = new Dictionary<DateTime, int>();

            for (int i = 0; i < amountOfPeople; i++)
            {
                Person person = new Person();

                if (people.ContainsKey(person.birthday))
                {
                    people[person.birthday]++;
                }
                else
                {
                    people.Add(person.birthday, 1);
                }

                Console.WriteLine(person.birthday + "   ||   " + people[person.birthday]);
            }
        }

    }

    class Person
    {
        private Random gen = new Random();
        public DateTime birthday
        {
            get;
            set;
        }
        public Person()
        {
            birthday = RandomDay();
        }

        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

    }
}
