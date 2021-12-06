using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanarysInheritanceX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the Parent");
            Parent op = new Parent();
            op.DisplayParent();

            Console.WriteLine("I am the Child");
            Child oc = new Child();
            oc.DisplayParent();
            oc.DisplayChild();
            Console.ReadLine();
        }
        public class Parent
        {
            public void DisplayParent()
            {
                Console.WriteLine("Hey Mom");
            }
        }

        public class Child : Parent
        {
            public void DisplayChild()
            {
                Console.WriteLine("Hey Child");
            }
        }
    }
 }
