using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_inj2
{
    class Person
    {
        public string name; // имя
        public int age;     // возраст

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.GetInfo();      // Имя: Возраст: 0

            tom.name = "Tom";
            tom.age = 34;
            tom.GetInfo();  // Имя: Tom Возраст: 34
            Console.ReadKey();
        }
    }
}