using System;
using System.Collections.Generic;
using System.Data;

namespace Models {
    public class Person {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        
        public Person(string firstName, string lastName, DateTime dob) {
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
        }

        public string GetInfo() {
            return $"{FirstName} {LastName} : {Dob.Day}/{Dob.Month}/{Dob.Year}";
        }

        public int GetAge() {
            int monthsOld = DateTime.Now.Month - Dob.Month;
            int yearsOld = monthsOld<0 ? DateTime.Now.Year - Dob.Year-1 : DateTime.Now.Year - Dob.Year;
            monthsOld = monthsOld<0 ? monthsOld+12 : monthsOld;

            return yearsOld;
        }
    }

    public class People {
        public List<Person> PeopleList { get; set; }

        public People() {
            Random rand = new Random();
            PeopleList = new List<Person>();
            
            PeopleList.Add(new Person("John", "Smith", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("Peter", "Brown", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("Cindy", "White", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("James", "Hallinan", new DateTime(1620, 1, 6)));
            PeopleList.Add(new Person("Fatima", "Akbar", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("Bill", "Wakanda", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("Vikesh", "Viloo", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("Rone", "Smet", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("Crystal", "Summers", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("Howard", "Duck", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
            PeopleList.Add(new Person("Pepper", "Salt", new DateTime(rand.Next(1950,2010), rand.Next(1,12), rand.Next(1, 28))));
        }
        
    }
}