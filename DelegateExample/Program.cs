using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please, input your surname: ");
            string surname = Console.ReadLine();

            Person person = new Person(name, surname);
            Console.WriteLine("Please, input your age: ");

            person.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(person.Name + "\n" + person.Surname + "\n");

            person.PreprocessProperties();

            Console.WriteLine(person.Name + "\n" + person.Surname + "\n");
            Console.ReadKey();
        }
    }
}
