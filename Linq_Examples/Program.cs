using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Linq_Examples {
    internal class Program {
        public static void Main(string[] args) {
           People people = new People();
           int old = 200;

           Person James = people.PeopleList.FirstOrDefault(FirstNameFind);

           if(James != null)
            Console.WriteLine(James.GetInfo());
           else {
               Console.WriteLine("Not Found");
           }

           var oldies = people.PeopleList.Where(OldPerson).ToList();
           List<Person> oldies2 = people.PeopleList.FindAll(person => person.GetAge() > old);
           
           Console.ReadKey();
        }


        public static bool FirstNameFind(Person p) {
            return p.FirstName == "James".ToUpper();
        }
        
        public static bool LastNameFind(Person p) {
            return p.LastName == "Dracula";
        }


        public static bool OldPerson(Person p) {
            return p.GetAge() > 100;
        }
         
        
    }
}