using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        private static void Main(string[] args)
        {

            List<int> array = new List<int>() {10, 12, 13, 14, 15, 16};

            var array1 = new List<int>() {11, 12, 13, 14, 15, 16, 1, 7};

            //array.Add(12);
            //array.Add(13);
            //array.Add(14);
            //array.Add(15);
            //array.Add(16);

            foreach (var number in array)
            {
                Console.WriteLine(number);
            }

            // List Example with declarations

            // var aperson = new Person() {FirstName="Ram Babu",MiddleName="Prasad", LastName="Kushwaha"};

            // list Collection Example

            var personList = new List<Person>()
            {
                new Person() {FirstName = "Rambabu", MiddleName = "Prasad", LastName = "Kushwaha"},
                new Person() {FirstName = "Rajesh", MiddleName = "Prasad", LastName = "Kushwaha"},
                new Person() {FirstName = "Ramesh", MiddleName = "Prasad", LastName = "Kushwaha"},
                new Person() {FirstName = "Suresh", MiddleName = "Prasad", LastName = "Kushwaha"},
                new Person() {FirstName = "Ganshyam", MiddleName = "Prasad", LastName = "Kushwaha"}

            };

            //   Console.WriteLine(aperson.LastName);

            foreach (var person in personList)
            {
                Console.WriteLine(person.FirstName + " " + person.MiddleName + " " + person.LastName);
            }



            // Anonymous Variable

            var p = new[]
                          { new {Name="Ram", Address = "Noakhali", Age = "25"},
                            new {Name = "Rajesh", Address = "Noakhali", Age = "25"},
                            new {Name="Ajay",Address="Noakhali",Age="25"}
                          
                          
                          };

            foreach (var v in p)
            {
                Console.WriteLine(v.Name);
            }
           
           


            Console.ReadKey();


            // var can be used inside only the method

        }
    }
}
