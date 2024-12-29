using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Session3.Binding;

namespace OOP_Session3
{
    internal class Demo
    {
        public static void Print10NumbersFromSerise(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0;i<10;i++)
                {
                    Console.WriteLine($"{series.Current}");
                    series.GetNext();
                }
                series.Reset();
            }
        }
        public static void ProcessEmployee( Employee employee)
        {
            if (employee is not null)
            {
                employee.MyFun01(); // Static Binding  // Iam Employee
                employee.MyFun02(); // Dinamic Binding // 
            }
        }
        

        public static void Demo0()
        {
            #region Binding
            //// Binding Is A Behaviour 
            //// Reference From Parent = Object From Chiled
            //TypeA RefBase = new TypeB(1,2);
            //RefBase.A = 11;
            ////RefBase.B = 12; // Invalid
            //RefBase.fun01(); // Iam Base [Parent]
            //RefBase.fun02(); // Type B is : A = 11, B = 2
            ////--------------------------------
            //TypeA typeA;
            ////typeA = new TypeA(1);
            //typeA = new TypeB(1, 2);
            ////typeA = new TypeCode(1,2,3);
            //TypeB typeB1 = (TypeB) typeA; // Explicit Casting
            //Console.WriteLine(typeB1.A);
            //Console.WriteLine(typeB1.B);

            #endregion
            #region Binding Is Behavior
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee() 
            //{
            //    Id = 10,
            //    Name = "omar",
            //    Age = 22,
            //    Salary = 99999
            //};
            //PartTimeEmployee PartTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "omar",
            //    Age = 22,
            //    HourRate = 129
            //};
            //ProcessEmployee(fullTimeEmployee);
            //ProcessEmployee(PartTimeEmployee);

            #endregion
            #region Example 02 Binding
            //TypeA typeA = new TypeC(1,2,3);
            //typeA.A = 10;
            ////typeA.B = 10; // invalid
            ////typeA.C = 10; // invalid
            //typeA.fun01(); // Static Binding => Iam Base [Parent]
            //typeA.fun02();

            //TypeB typeB = new TypeC(2,3,4);
            //typeB.A = 10;
            //typeB.B = 10;
            ////typeB.C = 10; // invalid
            //typeB.fun01(); // Static Binding =>  I am Derived [Chiled]
            //typeB.fun02();

            //TypeC typeC = new TypeD(2, 3, 4, 5);
            //typeC.A = 10;
            //typeC.B = 10;
            //typeC.C = 10; 
            ////typeC.D = 10; // invalid
            //typeC.fun01(); // Static Binding =>  I am Derived [Chiled]
            //typeC.fun02();

            //TypeA typeA1 = new TypeE(2, 3, 4, 5, 6);
            //TypeB typeB1 = new TypeE(2, 3, 4, 5, 6);
            //TypeC typeC1 = new TypeE(2, 3, 4, 5, 6);
            ////-------------------
            //typeA1.fun02();
            //typeB1.fun02();
            //typeC1.fun02();
            //Console.WriteLine("After Break The Chain");
            //TypeD typeD1 = new TypeE(2, 3, 4, 5, 6);
            //typeD1.fun02();

            //typeA1.E = 10; // invalid
            //typeA1.fun01(); // Static Binding =>  I am Derived [Chiled]
            //typeA1.fun02();

            #endregion
            #region InterFace

            #region Example 01
            IMyType myType;
            //Declare For Reference Of Type "IMyType" Refering To Null
            // This Refernce "myType" Can Refer To An Object From Class Or Struct Implementation To The Interface
            // Clr Will Allocate 4 Bytes At Stack For The Refernce
            //myType =new IMyType(); // invalid u cannot Create Object From interface

            //MyType myType1 = new MyType();
            //myType1.Salary = 1000;
            //myType1.Myfun();
            ////myType1.Print();//Invalid
            //IMyType refrenceFromInterface = new MyType();
            //refrenceFromInterface.Salary = 66666;
            //refrenceFromInterface.Myfun();
            //refrenceFromInterface.Print();

            #endregion
            #region Example 02
            //SeriesByTwo series = new SeriesByTwo();

            //SeriesByThree series2 = new SeriesByThree();
            //Print10NumbersFromSerise(series2);
            #endregion

            #endregion
        }
    }
}
