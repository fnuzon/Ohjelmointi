using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkilöRekisteri
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Persons(collection)
            Persons myFriends = new Persons();

            // create a few Person objects
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "12221-1212" };
            Person person2 = new Person { Firstname = "Matti", Lastname = "Raivio", SocialSecurityNumber = "12421-1212" };
            Person person3 = new Person { Firstname = "Kalle", Lastname = "Kilo", SocialSecurityNumber = "16521-1212" };

            // add Person objects to Persons (myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("There is no person at that position");
            }

            // print collection
            myFriends.PrintData();

            // find person

            string socialSecurityNumber = "12421-1212";
            Console.WriteLine("Find person with socialsecuritynumber: " + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Can't find person with that ssn");
            }
        }
    }
}
