using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace A001_BMI
{
    class program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            //배열에 숫자 저장
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            
            //배열에 저장된 10개의 정수를 출력
            for (int i = 0; i < 10; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();


            //foreach를 사용(a 배열에 있는 원소 각각 출력)
            foreach (var val in a)
                Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}