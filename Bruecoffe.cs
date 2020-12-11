using System;
using System.Collections.Generic;
using System.Text;

namespace Template_to_create_coffe_preparation
{
   public  class Bruecoffe : Coffetemplate
    {
        public override void boilwater()
        {
            Console.WriteLine("waterboiled");   
        }

        public override void addmilk()
        {
            Console.WriteLine("water added");
        }

        public override void addsugar()
        {
            Console.WriteLine("sugar added");
        }

        public override void addcoffepowder()
        {
            Console.WriteLine("coffepowder added");
        }

       
    }
}
