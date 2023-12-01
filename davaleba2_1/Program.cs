using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sheiyvane ricxvi: ");

            int number = int.Parse(Console.ReadLine());

            if(number > 0) 
            {
                Console.WriteLine($"{number} dadebiti ricxvia");
            }else if(number < 0)
            {
                Console.WriteLine($"{number} uaryofiti ricxvia");
            }else if (number == 0) 
            {
                Console.WriteLine($"{number} nulis tolia");
            }
        }
    }
}
