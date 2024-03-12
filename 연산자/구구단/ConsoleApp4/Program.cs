using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("구구단을 출력할 숫자를 입력하세요:");
            int input = int.Parse(Console.ReadLine());

            // 입력 받은 숫자에 해당하는 구구단 출력
            if (input >= 2 && input <= 9) // 입력받은 input이 2이상 그리고 9이하인지 확인
            {
                Console.WriteLine(input + "단"); // 입력받은 숫자  + 단 출력

                for (int j = 1; j <= 9; j++) // 1에서 9 까지 곱해짐 (input  * 1 , input * 2 ... input * 9)
                {                            
                    Console.WriteLine(input + " × " + j + " = " + (input * j)); // WriteLine을 써서 자동으로 줄바꿈
                }                    // input X j = input * j 값 출력
            }
            else // 입력받은 input이 2이상 그리고 9 이하의 조건이 아니라면
            {
                Console.WriteLine("2부터 9까지의 숫자만 입력하세요."); // 출력
            }
        }
    }
}
