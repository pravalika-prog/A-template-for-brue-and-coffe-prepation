using System;
using System.Collections.Generic;
using System.Text;

namespace Template_to_create_coffe_preparation
{
    class program
    { static void Main()
        {
            Console.WriteLine("brue coffe preparation");
            Coffetemplate c = new Bruecoffe();
            c.preparecoffee();
            Console.WriteLine();
            Console.WriteLine("Nescafe coffe preparation");
            Coffetemplate c1 = new Nescafe();
            c1.preparecoffee();
        }
    }
}
