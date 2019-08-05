using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            
            ///Exercise Method that compares if the lenght of 2 strings
            ClassA comparison = new ClassA();
            Console.WriteLine("Exercise Method that compares if the lenght of 2 strings ");
            Console.WriteLine("Type the first word");
            a = Console.ReadLine();
            Console.WriteLine("Type the second word");
            b = Console.ReadLine();
            comparison.WordsComparison(a, b);
            Console.ReadLine();
            
            ///Exercise Method that compares if the size of 2 List
            ClassA ListComparison = new ClassA();
            Console.WriteLine("Exercise Method that compares if the size of 2 List are equals");
            ListComparison.ListComparison();
            Console.ReadLine();
            
            ///Class (B) that inherits from Parent (A) class.
            ClassB PrintWords = new ClassB();
            Console.WriteLine("Exercise Method that compares the lenght of 2 strings and print them");
            PrintWords.WordsComparison(a, b);
            PrintWords.InheritMethod(a, b);
            Console.ReadLine();

            ///Print interfaces
            Console.WriteLine("Exercise Print Interface");
            InterClass InterPrint = new InterClass();
            InterPrint.PrintHello();
            Console.ReadLine();

            ///Interfaces Implementation
            Console.WriteLine("Exercise Interface Implementation");
            ClassB InterImple = new ClassB();
            InterImple.PrintHello();
            Console.ReadLine();

            ///Interfaces Implementation
            Console.WriteLine("Order List Desc Asc");
            ClassB sortby = new ClassB();
            sortby.ListOrderBy();
            Console.ReadLine();
        }
    }
}
