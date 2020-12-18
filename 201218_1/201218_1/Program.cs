using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201218_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //실행:ctrl+F5
            
            //cw 입력 tap키 2번 = system.out.println
            Console.WriteLine("hello 하고 한줄 줄바꿈");

            //cw 입력 tap키 2번 후 Line 지우기 = system.out.print
            Console.Write("hello 하고 줄 안바꿈");

            //변수 : java와 동일 

            int example = 100;
            //단 Sring 변수는 String 이랑 string 둘 다 동일하게 쓸 수 있음
            //c#에서는 보통 s를 소문자로 쓴다.
            string ex1 = "hello";
            String ex2 = "헬로";
            string 이런것도됨 = "신기함";
            Console.WriteLine(이런것도됨); // 근데 옛날 버전에선 안 돌아갈 수 있음.

            //문자열과 숫자 혼합하기
            string ex3 = example + "더하기" + example + "은" + (example + example) + "이다";
            string ex4 = $"{example} 더하기 {example}은 {example + example}이다";
            string ex5 = string.Format("{0} 더하기 {1}은 {2}이다", example, example, example+example);

            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);
            
            //조건문
            //java와 동일
            if (example > 50)
            {
                Console.WriteLine("example은 50이상);
            }
            if (example > 30)
            {
                Console.WriteLine("example은 30이상);

            }
            else
            {
                Console.WriteLine("example은 30미만");

            }

            if(example == 10)
            {
                Console.WriteLine("10);

            }
            else if(example == 20)
            {
                Console.WriteLine("20");

                          }
            if (example == 10)
            {
                Console.WriteLine("10");

            }
            else if (example == 20)
            {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine("10이랑 20은 아님");

            }
            switch (example)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("10이랑 20은 아니므니다");
                    break;
            }

            //반복문도java와 동일
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("같은말 10번 반복 하기);
            }
            int temp = 10;

            while (temp>0)
            {
                temp--;
            }
            do
            {
                temp++;
            } while (temp < 10);

            //값을 입력받은 경우
            //java
            /*
                Scanner s = new Scanner(System.in);
                String test = s.nextLine();
                int test2 = s.nextIne;
            */
            //c#
            // string test = Console.






            


            

        }
    }
}

