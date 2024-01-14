using System;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args){

            int i = 139;
            FunctionLibrary functionLibrary = new FunctionLibrary();

            Console.WriteLine("Hello World!");
            Console.WriteLine(functionLibrary.TestFunction());

            if (functionLibrary.TestFunction2(i)) {
                Console.WriteLine(i + " is smaller than 100");
            } else {
                Console.WriteLine(i + " is greater than 100");
            }

            Console.ReadKey();
        }
    }

    class FunctionLibrary {

        public string TestFunction() {
            return "This is a test";
        }
        public bool TestFunction2(int x) {
            return x < 100;
        }

    }
}
