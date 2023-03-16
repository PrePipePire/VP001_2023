using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace A012_for
{
    class program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            //1 ~ 100까지의 합
            for (int i = 1; i <= 100; i++)
                sum += i;

            Console.WriteLine("1 ~ 100까지의 합 : {0}", sum);

            //1 ~ 100의 홀수의 값의 합
            sum = 0;
            for (int i = 1; i <= 100; i++)
                if (i % 2 == 1)
                    sum += 1;

            //1 ~ 100의 역수의 값의 합
            double rsum = 0;
            for (int i = 1; i <= 100; i++)
                rsum += 1.0 /i;
            Console.WriteLine("1 ~ 100까지의 합 : {0}", rsum);

            //구구단
            Console.Write("구구단의 단을 입력 : ");
            int x = int.Parse(Console.ReadLine());  

            for (int i = 1; i <= 9; i++)
            {
                int gu = x * i;
                Console.WriteLine("{0} * {1} = {2}", x, i, gu);
            }

            // n의 m승 구하기
            int n, m;

            Console.Write("n 입력 : ");
            n = int.Parse(Console.ReadLine());

            Console.Write("m 입력 : ");
            m = int.Parse(Console.ReadLine());

            int exp = 1;
            for (int i =1; i <= m; i++)
                exp *= n;
            Console.WriteLine("{0}의 {1}승은 {2}", n, m, exp);

            //팩토리얼
            Console.Write("구하고자 하는 팩토리얼 수를 입력 : ");
            int fac = int.Parse(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= fac; i++)
                f *= i;
            Console.WriteLine("{0} 팩토리얼은 {1}", fac, f);
        }
    }
}