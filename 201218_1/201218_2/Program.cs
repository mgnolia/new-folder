using System;

namespace _201218_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제풀이 시작");
            Console.WriteLine("1번 문제");
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    //sum = i;
                    sum += i;
            }
            Console.WriteLine($"1부터 100까지의 수 중 3의 배수의 합은" + $"{sum}이다.");

            Console.WriteLine("2번 문제");
            int inputSecond = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inputSecond / 60}분 {inputSecond % 60}초");

            Console.WriteLine("3번문제");
            Console.WriteLine("몇 층 까지 쌓을 것 인가");
            int floor = int.Parse(Console.ReadLine());
            for (int i = 0; i < floor; i++) // 전체 츶을 출력
            {
                for (int j = floor; j > i; j--) //각 층을 출력(공백)
                {
                    Console.Write(' ');
                }
                //별을 찍는 부분 //각 층을 출력(별)

                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine("4번 문제");

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i * j}");
                }
            }
            Console.WriteLine("5번 문제");

            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("fall");
                    break;

            }
            Console.WriteLine("6번 문제");

            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            if (input1 > 0 && input2 > 0)
                Console.WriteLine("1");
            else if (input1 > 0 && input2 > 0)
                Console.WriteLine("2");
            else if (input1 < 0 && input2 > 0)
                Console.WriteLine("3");
            else if (input1 < 0 && input2 < 0)
                Console.WriteLine("4");
            else
                Console.WriteLine("0");


        }

        Console.WriteLine("7번 문제");

        string start = "1";
        for (int i = 0; i<length; i++)
			{

			}
            //8 번 문제
            Console.WriteLine("8번 문제);



}
