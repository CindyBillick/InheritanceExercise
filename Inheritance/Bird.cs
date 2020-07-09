using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird:Animal
    {
        public string FeatherColor { get; set; } 
        public string BeakType { get; set; }
        

         public void Fly(bool canFly)
        {
            if (canFly==true)

            {
                Console.WriteLine("I'm Flying High!!");
            }
            else
            {
                Console.WriteLine("I can't fly:(");
            }
    }
       


