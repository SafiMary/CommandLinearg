using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLinearg
{
    internal class Person
    {
        private string name;
        /* private int age;*/
        public string Name { /*set;*/ get { return name; } }
        public int Age { set; get; }

       /* public int MyProperty
        {
            get { return myVar; }
            set
            {
                if (value % 2 == 0)
                {
                    myVar = value;
                }
                else
                {
                    myVar = 0;
                }
            }
        }*/

        public void Print()
        {
            Console.WriteLine($"Имя: {Name}\nвозраст: {Age}");//вывод имя и возраста в одном выводе
        } //Console.WriteLine("Имя{0} возраст{1}",Name,Age);
        public Person(string _name)
        {
            name = _name;
        }                                           

    }
}