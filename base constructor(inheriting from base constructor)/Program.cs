using System;

namespace base_constructor_inheriting_from_base_constructor_
{


    //    class first
    //    {
    //        int a, b;

    //        public first(int para1 , int para2)

    //        {
    //            a = para1;
    //            b = para2;

    //        }
    //    }

    //    class second
    //    {
    //        int c ,b,a ;

    //        public second(int para1, int para2, int para3) : base()

    //        {
    //           this.c = para3;



    //        }

    //       public void print()
    //        {
    //            Console.WriteLine(a,b,c);
    //        }
    //    }

    class Class1
    {
        public int a, b;
        
        public Class1(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(" base class parameterized constructor");
        }
    }
    class Class2 : Class1
    {
        public int c;
        public Class2(int a, int b, int c) : base(a, b)
        {
            this.c = c;
            Console.WriteLine("Inside derived class parametrized constructor" + a.ToString()+b.ToString()+c.ToString());
        }

        public void print() => Console.WriteLine(a.ToString() + b.ToString() + c.ToString()); 
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class2 sec = new Class2(1,2,3);
            sec.print();
            // Console.WriteLine(sec.a.ToString()+sec.b.ToString() + sec.c.ToString());

        }
    }
}
