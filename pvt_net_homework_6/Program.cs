﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvt_net_homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complexNumber1 = new ComplexNumber(1, 5);

            ComplexNumber complexNumber2 = new ComplexNumber(3, -3);
            Console.Out.WriteLine(complexNumber1.ToString());
            Console.Out.WriteLine(complexNumber2.ToString());
            Console.Out.WriteLine("<++++>");

             ComplexNumber sumOfNums =
                 complexNumber1 + complexNumber2;
             Console.Out.WriteLine("Сумма = {0}", sumOfNums.ToString());
             ComplexNumber difOfNums =
                 complexNumber1 - complexNumber2;
             Console.Out.WriteLine("Разность = {0}", difOfNums.ToString());
             ComplexNumber multOfNums =
                 complexNumber1 * complexNumber2;
             Console.Out.WriteLine("Произведение = {0}", multOfNums.ToString());
             ComplexNumber divOfNums =
                 complexNumber1 / complexNumber2;
             Console.Out.WriteLine("Деление = {0}", divOfNums.ToString());

            ComplexNumber complexNumber3 = new ComplexNumber(1, 5);

            bool statement1, statement2;
            statement1 = complexNumber1 == complexNumber2;
            statement2 = complexNumber1 != complexNumber2;


            Console.Out.WriteLine("{0} == {1} -> {2}", complexNumber1, complexNumber2 ,statement1);
            Console.Out.WriteLine("{0} != {1} -> {2}", complexNumber1, complexNumber2, statement2);

            statement1 = complexNumber1 == complexNumber3;
            statement2 = complexNumber1 != complexNumber3;


            Console.Out.WriteLine("{0} == {1} -> {2}", complexNumber1, complexNumber3, statement1);
            Console.Out.WriteLine("{0} != {1} -> {2}", complexNumber1, complexNumber3, statement2);

        }
    }
}


//    //ДЗ: преропределить метод toString  console.write(complexNum)
// проверять к. числа на равенство (equals)
//складывать вычитать и делить как обычные
// + - * / != == < > - перегрузить все это 
