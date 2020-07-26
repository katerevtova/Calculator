using System;
namespace Calculator
{
    public class Calculations

    {

        public int firstnumber;
        public int secondnumber;
       


        public Calculations(int firstnumber, int secondnumber)
        {
            this.firstnumber = firstnumber;
            this.secondnumber = secondnumber;

        }

        public int Plus(int firstnumber, int secondnumber)
        {
            return firstnumber + secondnumber;
           
        }

        public int Minus(int firstnumber, int secondnumber)
        {
            return firstnumber - secondnumber;

        }

        public int Umnozhit(int firstnumber, int secondnumber)
        {
            return firstnumber * secondnumber;

        }

        public int Delit(int firstnumber, int secondnumber)
        {
            return firstnumber / secondnumber;

        }

        
    }
}
