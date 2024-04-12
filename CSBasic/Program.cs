using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // c#에서 헬로월드를 찍어보자 
            Console.WriteLine("Hello World?!");

            // 오버플로우 연습
            //int a = 2147483647;
            int a = 2000000000; // 20억
            int b = 1000000000; // 10억
            Console.WriteLine(a+b);

            // 오버플로우 연습2
            Console.WriteLine((long)a + b); // b의 자료형인 int가 long과 더해져 암묵적으로 long타입으로 변환이 되어 오버플로우가 일어나지 않는다. 
            Console.WriteLine(a + (long)b);
            Console.WriteLine((long)a + (long)b);

            // 자료형 최소, 최대 값 출력하기
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
        }
    }
}
