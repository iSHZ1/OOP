using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class RationalNumber
    {
        public int _firstNumber;
        public int _secondNumber;
        public string _length;
        private double _num;

        public RationalNumber()
        {

        }
        public RationalNumber(double num)
        {
            _num = num;

            string[] tokens = num.ToString("G", CultureInfo.InvariantCulture).Split(".");
            int length = tokens.Length > 1 ? tokens[1].Length : 0;

            for (int i = 0; i < num.ToString().ToCharArray().Length; i++)
                _length += "-";

            _firstNumber = (int)(num * Math.Pow(10, length));
            _secondNumber = (int)Math.Pow(10, length);
            
        }

        public void PrintInfo()
        {
            CheckDrob();
            Console.WriteLine(_firstNumber);
            Console.WriteLine(_length);
            Console.WriteLine(_secondNumber);
        }

        public void CheckDrob()
        {
            if (_length == null)
            {
                for (int i = 0; i < _firstNumber.ToString().ToCharArray().Length; i++)
                    _length += "-";
            }
        }

        public void Reduction()
        {
            for (int i = _secondNumber; i > 2; --i)
            {
                if (_secondNumber % i == 0 && _firstNumber % i == 0)
                {
                    _firstNumber = _firstNumber / i;
                    _secondNumber = _secondNumber / i;
                }
            }
        }

        public override string ToString()
        {
            return _firstNumber.ToString() + _length.ToString() + _secondNumber.ToString();
        }

        public static bool operator >(RationalNumber v1, RationalNumber v2)
        {
            if (v1._firstNumber * v2._secondNumber > v2._firstNumber * v1._secondNumber)
                return true;
            else
                return false;
            
        }

        public static bool operator >=(RationalNumber v1, RationalNumber v2)
        {
            if (v1._firstNumber * v2._secondNumber >= v2._firstNumber * v1._secondNumber)
                return true;
            else
                return false;

        }
        public static bool operator <=(RationalNumber v1, RationalNumber v2)
        {
            if (v1._firstNumber * v2._secondNumber <= v2._firstNumber * v1._secondNumber)
                return true;
            else
                return false;

        }

        public static bool operator <(RationalNumber v1, RationalNumber v2)
        {
            if (v1._firstNumber * v2._secondNumber < v2._firstNumber * v1._secondNumber)
                return true;
            else
                return false;

        }

        public static bool operator ==(RationalNumber v1, RationalNumber v2)
        {
            if (v1._firstNumber * v2._secondNumber == v2._firstNumber * v1._secondNumber)
                return true;
            else
                return false;

        }

        public static bool operator !=(RationalNumber v1, RationalNumber v2)
        {
            if (v1._firstNumber * v2._secondNumber != v2._firstNumber * v1._secondNumber)
                return true;
            else
                return false;

        }

        public static RationalNumber operator +(RationalNumber v1, RationalNumber v2)
        {
            RationalNumber m = new RationalNumber();
            m._firstNumber = v1._firstNumber * v2._secondNumber + v2._firstNumber * v1._secondNumber;
            m._secondNumber = v1._secondNumber * v2._secondNumber;
            return m;
        }

        public static RationalNumber operator -(RationalNumber v1, RationalNumber v2)
        {
            RationalNumber m = new RationalNumber();
            m._firstNumber = v1._firstNumber * v2._secondNumber - v2._firstNumber * v1._secondNumber;
            m._secondNumber = v1._secondNumber * v2._secondNumber;
            return m;
        }

        public bool Equals(RationalNumber v2)
        {
            if (_firstNumber * v2._secondNumber == v2._firstNumber * _secondNumber)
                return true;
            else
                return false;
        }

        public static RationalNumber operator --(RationalNumber v1)
        {
            v1._firstNumber = v1._firstNumber - v1._secondNumber;
            return v1;
        }

        public static RationalNumber operator ++(RationalNumber v1)
        {
            v1._firstNumber = v1._firstNumber + v1._secondNumber;
            return v1;
        }

        public static RationalNumber operator *(RationalNumber v1, RationalNumber v2)
        {
            RationalNumber m = new RationalNumber();
            m._firstNumber = v1._firstNumber * v2._firstNumber;
            m._secondNumber = v1._secondNumber * v2._secondNumber;
            return m;
        }

        public static RationalNumber operator /(RationalNumber v1, RationalNumber v2)
        {
            RationalNumber m = new RationalNumber();
            m._firstNumber = v1._firstNumber * v2._secondNumber;
            m._secondNumber = v1._secondNumber * v2._firstNumber;
            return m;
        }

    }
}

/*
Создать класс рациональных чисел. +
В классе два поля – числитель и знаменатель. +
Предусмотреть конструктор. +
Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, –, ++, --. +
Переопределить метод ToString() для вывода дроби. +
Определить операторы преобразования типов между типом дробь,float, int. Не понял вообще, но принцип в методичке понял
Определить операторы *, /. +
*/