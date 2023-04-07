using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLinearg
{
    struct MyStruct
    {

    }

    internal class Program
    {
        static List<Person> Ask_N_Times(int n)
        {
            //List<Person> ans = new List<Person>();
            var ans = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                ans.Add(CreatePerson());
            }
            return ans;
        }
        static Person CreatePerson()
        {
            string name;
            int age = 0;
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            do {
                try
                {
                    Console.WriteLine("Введите возраст");
                    age = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("Возраст введен не корректно!");
                }
            } while ((age <= 0) && (age > 120));
            var person = new Person(name);
            person.Age = age;
            return person;
        } 
        static void Main(string[] args)
        {
           // Person person = new Person("Bilbo Baggins");
            //person.MyProperty = 1;
            //Console.WriteLine(person.MyProperty);
           // person.Age = 5;
            //person.Print();
            
            /* string name;
             int age;
             Console.WriteLine("Введите имя");
             name = Console.ReadLine();
             Console.WriteLine("Введите возраст");
             age = int.Parse(Console.ReadLine());
             var person = new Person(name);
             person.Age = age;*/
           /* var _list = new List<Person>();
            var person = CreatePerson();
            _list.Add(person);
            _list[0].Print();*/
            var PersonList = Ask_N_Times(3);
            foreach (Person person in PersonList)
            {
                Console.WriteLine($"Имя {person.Name},$ возраст {person.Age}");
            }

        }
    }
}
