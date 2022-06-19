using System;
// function name parameter with no return type
namespace FuntionUnderstanding_2
{
    class functionUnderstanding_2
    {
        int i, fact=1, n;
        void fun( int s)
        {
            for (i = 1; i <= s; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("the value of given factorial" +" "+n+ " is" +" "+ fact);
        }
        static void Main(string[] args)
        {
            functionUnderstanding_2 obj = new functionUnderstanding_2();
            Console.WriteLine("Please enter the no for factorial :");
            obj.n = Convert.ToInt32(Console.ReadLine());
            obj.fun(obj.n);

          
        }
    }
}
