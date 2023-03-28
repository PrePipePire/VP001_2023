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
            Random r = new Random();

            //for (int i  = 0; i < 10; i++)
            //    Console.WriteLine(r.Next(1, 7));

            //10명의 성적을 저장하는 배열 score를 만들고 랜덤하게 점수을 생성하여 저장하시오.
            
            int[] score = new int[10];

            for (int i = 0; i < 10; i++)
            {
                score[i] = r.Next(101);
            }
            //배열의 내용을 출력
            foreach(var val in score)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            //10000사이의 수 10개를 배열에 저장하고 최대 최소 평균 구하기
            int[] num = new int[10];

            for (int i = 0; i < 10; i++) 
            {
                num[i] = r.Next(10001);
            }

            int max = num[0];
            int min = num[0];
            double sum = 0;

            foreach (var val in num)
            {
                if (max > val)
                    max = val;
                if (min < val)
                    min = val;
                sum += val;
            }
            Console.WriteLine("최대 : {0}, 최소 : {1}, 평균 : {2}", max, min, sum / 10.0);
        }
    }
}