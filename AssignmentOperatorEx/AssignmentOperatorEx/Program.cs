using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOperatorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //logical operator
            Console.WriteLine("Enter marks of Cnadidate:");
            int marks = Convert.ToInt16(Console.ReadLine());
            if (marks >= 35 && marks <= 50)

                Console.WriteLine(" pass ");

            else if (marks >= 51 && marks <= 70)
                Console.WriteLine("pass with A grade");
            else if (marks >= 71 && marks <= 90)
                Console.WriteLine("You pass with first class grade");
            else if (marks >= 91 && marks <= 100)
                Console.WriteLine("You pass with first classwith distiction grade");

            else
                Console.WriteLine("you failed :( ");




        }
    }
}
