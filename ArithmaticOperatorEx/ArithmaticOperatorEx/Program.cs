using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticOperatorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Principle Amount:");
            int principleAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate Of Intrest:");
            int rateOfIntrest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter time: ");
            int time = Convert.ToInt32(Console.ReadLine());

            int simpleIntrest = ((principleAmount * rateOfIntrest * time) / 100);
            Console.WriteLine("simple intrest is : " + simpleIntrest);



            string firstName = "Anjali";
            string lastName = " Jadhav";
            Console.WriteLine(firstName + lastName);
           
            



        }
    }
}
