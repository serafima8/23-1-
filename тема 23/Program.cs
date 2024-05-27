
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_23
{
    class Program
    {
        enum Month
        {
            январь,
            февраль,
            март,
            апрель,
            май,
            июнь,
            июль,
            август,
            сентябрь,
            октябрь,
            ноябрь,
            декабрь
        }

        // 2 задание

        //enum Days
        //{
        //    Sat,
        //    Sun,
        //    Mon,
        //    Tue,
        //    Wed,
        //    Thu,
        //    Fri
        //}
        static void Main(string[] args)
        {
            Month i;
            for (i = Month.январь; i <= Month.декабрь; i++)
            {
                Console.WriteLine(i+ (int)i);
            }


            // 2 задание 

            //Days i;
            //for (i = Days.Sat; i <= Days.Fri; i++)
            //{
            //    Console.WriteLine(i + " имеет значение " + (int)i);
            //}

            Console.ReadKey();

        }
    }
}
