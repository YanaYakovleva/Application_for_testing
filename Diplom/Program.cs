using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    class Program
    {
        static void Main(string[] args)
        {
            Result.ResultOfTest = 0;
            var test1 = new Test("First");
            Console.WriteLine("Enter your name and surname.");
            var student1 = new User(Console.ReadLine(), Console.ReadLine());
            InputAndOutput.ShowTest(test1);
            Console.WriteLine("Результат теста\n" + Result.ResultOfTest);

        }
    }
}
