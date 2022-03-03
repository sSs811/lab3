using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class RomanNumber : ICloneable, IComparable
    {
        private string rom;
        private ushort arab;
        private readonly ushort[] numer = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private readonly string[] symbol = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };


        public RomanNumber(ushort n)//Конструктор получает число n, которое должен представлять объект класса в римской записи
        {
            if (n <= 0)
                throw new RomanNumberException("Значение >0.");
            else
            {
                this.arab = n;
                this.rom = "";
            }
        }

        public static RomanNumber operator +(RomanNumber? n1, RomanNumber? n2)//Сложение римских чисел
        {
            return new RomanNumber((ushort)(n1.arab + n2.arab));
        }

        public static RomanNumber operator -(RomanNumber? n1, RomanNumber? n2)//Вычитание римских чисел
        {
            if (0 >= n1.arab - n2.arab)
                throw new RomanNumberException("Значение вычитания <= 0.");
            else
                return new RomanNumber((ushort)(n1.arab - n2.arab));
        }

        public static RomanNumber operator *(RomanNumber? n1, RomanNumber? n2)//Умножение римских чисел
        {
            return new RomanNumber((ushort)(n1.arab * n2.arab));
        }

        public static RomanNumber operator /(RomanNumber? n1, RomanNumber? n2)//Целочисленное деление римских чисел
        {
            if ((n1.arab / n2.arab) <= 0)
                throw new RomanNumberException("Значение деления <= 0.");
            else
                return new RomanNumber((ushort)(n1.arab / n2.arab));
        }

        public override string ToString() //Возвращает строковое представление римского числа
        {
            ushort temp = this.arab;
            this.rom = "";
            for (int i = 0; i < 13; i++)
            {
                while (temp >= numer[i])
                {
                    this.rom = this.rom + symbol[i];
                    temp -= numer[i];
                }
            }
            return this.rom;
        }

        public object Clone()
        {
            return new RomanNumber(this.arab);
        }

        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber number)
                return arab.CompareTo(number.arab);
            else
                throw new ArgumentException();
        }
    }
}