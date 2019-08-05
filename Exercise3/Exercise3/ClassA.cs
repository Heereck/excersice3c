using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class ClassA
    {
        public void WordsComparison(string word1, string word2)
        {
            int a = word1.Length;
            int b = word2.Length;

            if (a == b)
            {
                Console.WriteLine("Words are the same lenght");
            }
            else
            {
                Console.WriteLine("Words are not the same lenght");
            }
        }

        public void ListComparison()
        {
            var numbers = new List<int>() { 1, 2, 3, 7 };
            var letters = new List<string>() { "b", "b", "a" };

            if (numbers.Count == letters.Count)
            {
                Console.WriteLine("List are the same size");
            }
            else
            {
                Console.WriteLine("List are NOT the same size");
            }
            Console.WriteLine("LIST 1 Number leght: " + numbers.Count);
            Console.WriteLine("LIST 2 Letters leght: " + letters.Count);
        }


    }

    public class ClassB : ClassA, Interface1
    {
        public void InheritMethod(string a, string b)
        {
            Console.WriteLine("Word 1: " + a);
            Console.WriteLine("Word 2: " + b);
        }

        public void PrintHello()
        {
            Console.WriteLine("Interface Class Implementation"); 
            //throw new NotImplementedException();
        }

        public void ListOrderBy()
        {
            
            var words = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };

            for (int i = 0; i < 2; i++)
            {
                if (i==0)
                {
                    Console.WriteLine("Order Lists by ASC & DESC");
                    words.Sort();
                }
                else
                {                    
                    words.Reverse();
                }  

                foreach (string value in words)
                {
                    Console.WriteLine(value);
                }

                Console.ReadLine();
            }

        }

        public void IntList()
        {

        }
    }


}



