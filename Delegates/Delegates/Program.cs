using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateDemo d = new DelegateDemo();

            d.StartDelegateTest();
        }
    }
    public class DelegateDemo
    {
        //public delegate double DoMathOperation(double num1, double num2);
        public delegate int DoMathOperation(int num1, int num2);

        public void StartDelegateTest()
        {
            int answer;

            DoMathOperation mathDelegate;
            mathDelegate = AddNumbers;
            answer = mathDelegate(10, 5);
            Debug.WriteLine("Add: " + answer);

            mathDelegate = SubNumbers;
            answer = mathDelegate(10, 5);
            Debug.WriteLine("Subtract: " + answer);

            Debug.WriteLine(answer);

            Console.ReadLine();
        }

        private int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        private int SubNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}


