using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber a = new(0);
            }
            catch (RomanNumberException exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                RomanNumber a = new(10);
                RomanNumber b = new(20);
                 a -= b; 
            }
            catch (RomanNumberException exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                RomanNumber x = new(5);
                RomanNumber y = new(20);
                RomanNumber c = new(3);
                RomanNumber z = new(2);
                RomanNumber res;
                RomanNumber[] mas = { x, y, c, z };
                res = x + y;
                Console.WriteLine($"{x} + {y} = {res}");
                res = c / z;
                Console.WriteLine($"{c} / {z} = {res}");
                res = y - x; 
                Console.WriteLine($"{y} - {x} = {res}");
                res = c * z; 
                Console.WriteLine($"{c} * {z} = {res}");
                Console.WriteLine("Массив:");
                foreach (RomanNumber num in mas)
                {
                    Console.WriteLine(num);
                }
                Array.Sort(mas);

                Console.WriteLine("Отсортированный массив:");
                foreach (RomanNumber num in mas)
                {
                    Console.WriteLine(num);
                }
            }
            catch (RomanNumberException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}