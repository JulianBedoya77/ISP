using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class Human : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("The human is working.");
        }

        public void Eat()
        {
            Console.WriteLine("The human is eating.");
        }
    }
}
