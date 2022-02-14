using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInClass
{
    class Islem
    {
        public int topla(int say1,int say2)
        {
            int sonuc = say1 + say2;
            Console.WriteLine("Sonuç : " + sonuc);
            return sonuc;
        }

        public int küp(int x)
        {
            int result = x * x * x;

            Console.WriteLine("Sonu. : " + result);

            return result;
        }
    }
}
