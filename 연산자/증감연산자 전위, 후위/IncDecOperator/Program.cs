using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncDecOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++); // a = a + 1
                                    // (a++ 순서처럼 a가 10이니 10 먼저 출력, 그 후에 1을 증가 시켜 값은 11이 출력되서 나옴)
                                    // 2씩 증가 하고 싶으면 a = a + 2 ...
            Console.WriteLine(++a); //  (++a 편하게 순서대로 생각하면 됨 1이 먼저 출력되고 10이 더해지는... 후위증가 연산자)

            Console.WriteLine(a--); // a = a - 1 (+ 와 반대 개념)
            Console.WriteLine(--a); // + 와 반대
        }
    }
}
