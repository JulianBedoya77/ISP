using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("The robot is working.");
        }
    }
}
