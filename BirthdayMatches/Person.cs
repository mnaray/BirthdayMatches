using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMatches
{
    internal class Person
    {
        public DateTime _birthday { get; set; }





        public Person()
        {
            
        }




        // method returns a random day of the year 2000
        private DateTime RandomDay()
        {
            // every person born in 2000 as default, year has no relevance
            Random gen = new Random();
            DateTime start = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
