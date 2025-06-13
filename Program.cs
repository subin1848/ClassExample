using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Program
    {
        class Parent
        {
            public Parent() { Console.WriteLine("부모 생성자"); }
            public Parent(string name) { Console.WriteLine("부모 생성자"); }

            public Parent(float param) { Console.WriteLine("Parent(double param)"); }
        }
        class Child : Parent
        {
            public Child() : base("child")
            {
                Console.WriteLine("Child()");
            }
            public Child(string name) : base(name)
            {
                Console.WriteLine("Child(name)");
            }
            public Child(float param) : base(param)
            {
                Console.WriteLine("Child(dobule param)");
            }
        }
        static void Main(string[] args)
        {
            Child childA = new Child("abc");
            Child childB = new Child(3L);
            // int < long < float < double 
            //  4     8      4      8
        }
    }
}
