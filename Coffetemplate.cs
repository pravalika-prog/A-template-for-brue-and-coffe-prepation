using System;

namespace Template_to_create_coffe_preparation
{
  public abstract   class Coffetemplate
    {
     public  void preparecoffee()
        {
            boilwater();
            addmilk();
            addsugar();
            addcoffepowder();
            Console.WriteLine(this.GetType().Name + "ready");
        }
      public abstract void boilwater();
       public abstract void addmilk();
        public abstract void addsugar();
        public abstract void addcoffepowder();

    }
    
    }

