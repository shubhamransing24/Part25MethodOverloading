using System;

namespace Part25MethodOverloading
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20);
            Add(10, 20, 30);
            Add(10, 10.5f);
            Add(10.5f, 10);
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition is={0}", a + b);
        }
        //method overloading on the basis of no of parameters
        public static void Add(int a,int b,int c)
        {
            Console.WriteLine("Addition is={0}", a + b + c);

        }
        //based on type of parameter
        public static void Add(int a,float b)
        {
            Console.WriteLine("Addition is={0}", a + b);
        }
        //based on kind of parameter
        public static void Add(int a,int b, out int sum)
        {
            Console.WriteLine("Addition is={0}");
            sum = a + b;

        }
        //based on order of the parameters
        public static void Add(float a, int b)
        {
            Console.WriteLine("Addition is={0}", a + b);
        }

    }

}
