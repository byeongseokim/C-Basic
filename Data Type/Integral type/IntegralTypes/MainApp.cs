using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args) {
            sbyte a = -10;
            //sbyte a = -500000000000; // 'long' 형식을 'sbyte' 형식으로 변환할 수 없습니다. 명시적 변환이 있습니다. 캐스트가 있는지 확
                                       //인하세요.
            byte b = 40;

            Console.WriteLine("a={0}, b={1}", a, b);

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine("a={0}, b={1}", c, d);

            int e = -10000000; // 0 7개
            uint f = 300000000; // 0 8개

            Console.WriteLine("e={0}, f={1}", e, f);

            long g = -500000000; // 0 11개
            ulong h = 2000000000000000000; // 0 18개

            Console.WriteLine("g={0}, h={1}", g, h);
        }
    }
}
