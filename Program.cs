using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Method_Implementation
{
    public interface IMyInterface
    {
        void Calculate();

        void Display();
    }

    //Way 1 : Using NotSupportedException() OR NotImplementedException()
    public abstract class MyClass1 : IMyInterface
    {
        public void Calculate()
        {
            Console.WriteLine("This is Calculate Method");
        }

        public  void Display()
        {
            throw new NotSupportedException();
            throw new NotImplementedException();
        }

    }

    // Way 2  : Using Abstract Class
    public abstract class MyClass2 : IMyInterface
    {
        public void Calculate()
        {
            Console.WriteLine("This is Calculate Method");
        }

        public abstract void Display();
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
