﻿using DemoOOP04.First_Project;
using DemoOOP04.Mapping;
using DemoOOP04.Operator_Overloading;
using DemoOOP04.Partial;
using DemoOOP04.second_project;
using DemoOOP04.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04
{
    internal class Program
    {
        static void Main()
        {
            #region V01
            //Console.WriteLine("V01");
            //Shape shape = new Shape(); not valid

            //Rectangle rectangle = new Rectangle();

            //Console.WriteLine(rectangle.perimeter);

            //Console.WriteLine(rectangle.GetArea());

            //rectangle.print(); 
            #endregion

            #region V03
            //Console.WriteLine("V03"); 

            //int X = 3 + 4;

            //string Y = "hello" + "world";

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };

            //Complex C02 = new Complex() { Real = 3, Imag = 7 };

            //Console.WriteLine(C01); 
            //Console.WriteLine(C02) ;

            //Complex C03 = C01 - null;
            //Console.WriteLine(C03) ; 
            #endregion

            #region V05
            //Console.WriteLine("V05");

            //int X = 12;
            //X++; 

            //Console.WriteLine(X);

            //C01++; 
            //Console.WriteLine(C01);

            //Complex C03 = C01--;
            //Console.WriteLine(C03);

            #endregion

            #region V06
            //Console.WriteLine("V06");

            //if (C01 >= C02)
            //{

            //    Console.WriteLine("C01 IS GREATER THAN C02");
            //}
            //else
            //{
            //    Console.WriteLine("C01 IS NOT GREATER THAN C02");
            //} 
            #endregion

            #region V07

            //Console.WriteLine("V07");

            //double X = 12;

            //int Y = (int)X; 

            //Complex C01 = new Complex() { Real = 3 , Imag = 4};

            //string S = (string)C01;

            //Console.WriteLine(S);

            //int X = (int)C01;   

            //int X  =(int) new Complex() { Real = 3, Imag = 4 };    

            //User user = new User();

            //UserDto userdto = new UserDto()
            //{
            //    Email  = user.Email,
            //    Name = user.Name,
            //    PhoneNumber = user.PhoneNumber
            //};


            #endregion        } 

            #region V08
            //Console.WriteLine("V08");   

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();
            //Utilities U03 = new Utilities();

            //Console.WriteLine(U01.CmToInch(254));
            //Console.WriteLine(U02.CmToInch(254));
            //Console.WriteLine(U03.CmToInch(254));

            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));

            //Console.WriteLine(U01.PI);
            //Console.WriteLine(U02.PI);
            //Console.WriteLine(U03.PI);

            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);

            //Utilities U01 = new Utilities(); 
            #endregion

            #region V09
            //Console.WriteLine("V09"); 
            #endregion

            #region V10
            //Console.WriteLine("V10");

            //Employee employee = new Employee();
            //employee.

            #endregion


            //Assignemet
            #region first project
            //First Project 


            //Duration D1 = new Duration(1, 10, 15);
            //D1.Print();

            //D1 = new Duration(3600);
            //D1.Print();

            //Duration D2 = new Duration(7800);
            //D2.Print();

            //Duration D3 = new Duration(666);
            //D3.Print();

            //D3 = D1 + D2;
            //D3.Print();

            //D3 = D1 + 7800;
            //D3.Print();

            //D3 = 666 + D3;
            //D3.Print();

            //D3 = ++D1;
            //D3.Print();

            //D3 = --D2;
            //D3.Print();

            //Duration D4 = D1 - D2;
            //D4.Print();

            //Console.WriteLine($"D1 > D2: {D1 > D2}"); 
            #endregion

            //second project 
            #region second project
            //Console.WriteLine("Add: " + Maths.Add(12, 4));
            //Console.WriteLine("Subtract: " + Maths.Subtract(12, 4));
            //Console.WriteLine("Multiply: " + Maths.Multiply(12, 4));
            //Console.WriteLine("Divide: " + Maths.Divide(12, 4)); 
            #endregion


        }
    }
}
