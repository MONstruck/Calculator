using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ToDo
    {

        //realizations of functions of mathematical operators
        public double Add(double a, double b) {

           
            return a+b;

        }
        public double Sub(double a, double b)
        {


            return a - b;

        }
        public double Divide(double a, double b)
        {


            return a / b;

        }
        public double Mult(double a, double b)
        {


            return a * b;

        }
        
        public  double Check(short i, double a,double b,ToDo toDo)
        {

            switch (i)
            {

                case 1:
                    return a = toDo.Add(a, b);

                   
                case 2:
                    return a = toDo.Sub(a, b);

                    
                case 3:
                    return a = toDo.Divide(a, b);

                    
                case 4:
                    return a = toDo.Mult(a, b);



            }
            return a;

        }
    }
}
