using System;

namespace lab_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int x = 3, y = 3;
            Console.Write("Значення префіксного виразу: ");
            Console.WriteLine(++x);
            Console.Write("Значенння х після проведення операції: ");
            Console.WriteLine(x);
            Console.Write("Значення префіксного виразу: ");
            Console.WriteLine(y++);
            Console.Write("Значенння y після проведення операції: ");
            Console.WriteLine(y);
            Console.ReadKey();

            //------------------------------------------

            sbyte a = 3, b = -63, c = 126;
            bool d = true;
            Console.WriteLine(-a); // Результат -3
            Console.WriteLine(-c); // Результат -126
            Console.WriteLine(!d); // Результат false
            Console.WriteLine(~a); // Результат -4
            Console.WriteLine(~b); // Результат 62
            Console.WriteLine(~c); // Результат -127
            Console.ReadKey();

            //-----------------------------------------

            x = 11; y = 4;
            float z = 4;
            Console.WriteLine(z * y); // Результат 16
            Console.WriteLine(z * 1e308); // Рез. "бесконечность"
            Console.WriteLine(x / y); // Результат 2
            Console.WriteLine(x / z); // Результат 2,75
            Console.WriteLine(x % y); // Результат 3
            Console.WriteLine(1e-324 / 1e-324); // Результат NaN
            Console.ReadKey();

            //---------------------------------------

            int intgr = 10;
            float flt = 4.9f;
            long lng = 255;
            short shrt = 4;
            bool bl = true;
            string str = "word";
            char chaar = 's';
            double dbl = 1024;

            Console.Clear();
            Console.WriteLine($"const int = {intgr} ");
            Console.WriteLine($"const float = {flt} ");
            Console.WriteLine($"const long = {lng} ");
            Console.WriteLine($"const short = {shrt} ");
            Console.WriteLine($"const boolean = {bl} ");
            Console.WriteLine($"const string = {str} ");
            Console.WriteLine($"const char = {chaar} ");
            Console.WriteLine($"const double = {dbl} ");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Завдання до лаби");

            Console.WriteLine($"{flt} + {intgr} = {flt + intgr}");
            Console.WriteLine($"{flt} - {intgr} = {flt - intgr}");
            Console.WriteLine($"{flt} / {intgr} = {flt / intgr}");
            Console.WriteLine($"{flt} * {intgr} = {flt * intgr}");
            Console.WriteLine($"{flt} % {intgr} = {flt % intgr}");

            Console.WriteLine($"{flt} + {lng} = {flt + lng}");
            Console.WriteLine($"{flt} - {lng} = {flt - lng}");
            Console.WriteLine($"{flt} / {lng} = {flt / lng}");
            Console.WriteLine($"{flt} * {lng} = {flt * lng}");
            Console.WriteLine($"{flt} % {lng} = {flt % lng}");

            Console.WriteLine($"{flt} + {shrt} = {flt + shrt}");
            Console.WriteLine($"{flt} - {shrt} = {flt - shrt}");
            Console.WriteLine($"{flt} / {shrt} = {flt / shrt}");
            Console.WriteLine($"{flt} * {shrt} = {flt * shrt}");
            Console.WriteLine($"{flt} % {shrt} = {flt % shrt}");

            Console.WriteLine($"{flt} + {bl} = FAIL");
            Console.WriteLine($"{flt} - {bl} = FAIL");
            Console.WriteLine($"{flt} / {bl} = FAIL");
            Console.WriteLine($"{flt} * {bl} = FAIL");
            Console.WriteLine($"{flt} % {bl} = FAIL");

            Console.WriteLine($"{flt} + {str} = {flt + str}");
            Console.WriteLine($"{flt} - {str} = FAIL");
            Console.WriteLine($"{flt} / {str} = FAIL");
            Console.WriteLine($"{flt} * {str} = FAIL");
            Console.WriteLine($"{flt} % {str} = FAIL");

            Console.WriteLine($"{flt} + {chaar} = {flt + chaar}");
            Console.WriteLine($"{flt} - {chaar} = {flt - chaar}");
            Console.WriteLine($"{flt} / {chaar} = {flt / chaar}");
            Console.WriteLine($"{flt} * {chaar} = {flt * chaar}");
            Console.WriteLine($"{flt} % {chaar} = {flt % chaar}");

            Console.WriteLine($"{flt} + {dbl} = {flt + dbl}");
            Console.WriteLine($"{flt} - {dbl} = {flt - dbl}");
            Console.WriteLine($"{flt} / {dbl} = {flt / dbl}");
            Console.WriteLine($"{flt} * {dbl} = {flt * dbl}");
            Console.WriteLine($"{flt} % {dbl} = {flt % dbl}");

            Console.ReadKey();
            Console.WriteLine("---------------------------------");
            Console.Clear();

            Console.WriteLine($"{intgr} + {flt} = {intgr + flt}");
            Console.WriteLine($"{intgr} - {flt} = {intgr - flt}");
            Console.WriteLine($"{intgr} / {flt} = {intgr / flt}");
            Console.WriteLine($"{intgr} * {flt} = {intgr * flt}");
            Console.WriteLine($"{intgr} % {flt} = {intgr % flt}");

            Console.WriteLine($"{intgr} + {lng} = {intgr + lng}");
            Console.WriteLine($"{intgr} - {lng} = {intgr - lng}");
            Console.WriteLine($"{intgr} / {lng} = {intgr / lng}");
            Console.WriteLine($"{intgr} * {lng} = {intgr * lng}");
            Console.WriteLine($"{intgr} % {lng} = {intgr % lng}");

            Console.WriteLine($"{intgr} + {str} = {intgr + str}");
            Console.WriteLine($"{intgr} - {str} = FAIL");
            Console.WriteLine($"{intgr} / {str} = FAIL");
            Console.WriteLine($"{intgr} * {str} = FAIL");
            Console.WriteLine($"{intgr} % {str} = FAIL");

            Console.WriteLine($"{intgr} + {shrt} = {intgr + shrt}");
            Console.WriteLine($"{intgr} - {shrt} = {intgr - shrt}");
            Console.WriteLine($"{intgr} / {shrt} = {intgr / shrt}");
            Console.WriteLine($"{intgr} * {shrt} = {intgr * shrt}");
            Console.WriteLine($"{intgr} % {shrt} = {intgr % shrt}");

            Console.WriteLine($"{intgr} + {dbl} = {intgr + dbl}");
            Console.WriteLine($"{intgr} - {dbl} = {intgr - dbl}");
            Console.WriteLine($"{intgr} / {dbl} = {intgr / dbl}");
            Console.WriteLine($"{intgr} * {dbl} = {intgr * dbl}");
            Console.WriteLine($"{intgr} % {dbl} = {intgr % dbl}");

            Console.WriteLine($"{intgr} + {bl} = FAIL");
            Console.WriteLine($"{intgr} - {bl} = FAIL");
            Console.WriteLine($"{intgr} / {bl} = FAIL");
            Console.WriteLine($"{intgr} * {bl} = FAIL");
            Console.WriteLine($"{intgr} % {bl} = FAIL");

            Console.WriteLine($"{intgr} + {chaar} = {intgr + chaar}");
            Console.WriteLine($"{intgr} - {chaar} = {intgr - chaar}");
            Console.WriteLine($"{intgr} / {chaar} = {intgr / chaar}");
            Console.WriteLine($"{intgr} * {chaar} = {intgr * chaar}");
            Console.WriteLine($"{intgr} % {chaar} = {intgr % chaar}");

            Console.ReadKey();
            Console.WriteLine("---------------------------------");
            Console.Clear();

            Console.WriteLine($"{str} + {flt} = {str + flt}");
            Console.WriteLine($"{str} - {flt} = FAIL");
            Console.WriteLine($"{str} / {flt} = FAIL");
            Console.WriteLine($"{str} * {flt} = FAIL");
            Console.WriteLine($"{str} % {flt} = FAIL");

            Console.WriteLine($"{str} + {lng} = FAIL");
            Console.WriteLine($"{str} - {lng} = FAIL");
            Console.WriteLine($"{str} / {lng} = FAIL");
            Console.WriteLine($"{str} * {lng} = FAIL");
            Console.WriteLine($"{str} % {lng} = FAIL");

            Console.WriteLine($"{str} + {intgr} = {str + intgr}");
            Console.WriteLine($"{str} - {intgr} = FAIL");
            Console.WriteLine($"{str} / {intgr} = FAIL");
            Console.WriteLine($"{str} * {intgr} = FAIL");
            Console.WriteLine($"{str} % {intgr} = FAIL");

            Console.WriteLine($"{str} + {shrt} = {str + shrt}");
            Console.WriteLine($"{str} - {shrt} = FAIL");
            Console.WriteLine($"{str} / {shrt} = FAIL");
            Console.WriteLine($"{str} * {shrt} = FAIL");
            Console.WriteLine($"{str} % {shrt} = FAIL");

            Console.WriteLine($"{str} + {dbl} = {str + dbl}");
            Console.WriteLine($"{str} - {dbl} = FAIL");
            Console.WriteLine($"{str} / {dbl} = FAIL");
            Console.WriteLine($"{str} * {dbl} = FAIL");
            Console.WriteLine($"{str} % {dbl} = FAIL");

            Console.WriteLine($"{str} + {bl} = FAIL");
            Console.WriteLine($"{str} - {bl} = FAIL");
            Console.WriteLine($"{str} / {bl} = FAIL");
            Console.WriteLine($"{str} * {bl} = FAIL");
            Console.WriteLine($"{str} % {bl} = FAIL");

            Console.WriteLine($"{str} + {chaar} = {str + chaar}");
            Console.WriteLine($"{str} - {chaar} = FAIL");
            Console.WriteLine($"{str} / {chaar} = FAIL");
            Console.WriteLine($"{str} * {chaar} = FAIL");
            Console.WriteLine($"{str} % {chaar} = FAIL");

            Console.ReadKey();
            Console.WriteLine("---------------------------------");
            Console.Clear();

            Console.WriteLine($"{lng} + {intgr} = {lng + intgr}");
            Console.WriteLine($"{lng} - {intgr} = {lng - intgr}");
            Console.WriteLine($"{lng} / {intgr} = {lng / intgr}");
            Console.WriteLine($"{lng} * {intgr} = {lng * intgr}");
            Console.WriteLine($"{lng} % {intgr} = {lng % intgr}");

            Console.WriteLine($"{lng} + {flt} = {lng + flt}");
            Console.WriteLine($"{lng} - {flt} = {lng - flt}");
            Console.WriteLine($"{lng} / {flt} = {lng / flt}");
            Console.WriteLine($"{lng} * {flt} = {lng * flt}");
            Console.WriteLine($"{lng} % {flt} = {lng % flt}");

            Console.WriteLine($"{lng} + {shrt} = {lng + shrt}");
            Console.WriteLine($"{lng} - {shrt} = {lng - shrt}");
            Console.WriteLine($"{lng} / {shrt} = {lng / shrt}");
            Console.WriteLine($"{lng} * {shrt} = {lng * shrt}");
            Console.WriteLine($"{lng} % {shrt} = {lng % shrt}");

            Console.WriteLine($"{lng} + {bl} = FAIL");
            Console.WriteLine($"{lng} - {bl} = FAIL");
            Console.WriteLine($"{lng} / {bl} = FAIL");
            Console.WriteLine($"{lng} * {bl} = FAIL");
            Console.WriteLine($"{lng} % {bl} = FAIL");

            Console.WriteLine($"{lng} + {str} = {lng + str}");
            Console.WriteLine($"{lng} - {str} = FAIL");
            Console.WriteLine($"{lng} / {str} = FAIL");
            Console.WriteLine($"{lng} * {str} = FAIL");
            Console.WriteLine($"{lng} % {str} = FAIL");

            Console.WriteLine($"{lng} + {chaar} = {lng + chaar}");
            Console.WriteLine($"{lng} - {chaar} = {lng - chaar}");
            Console.WriteLine($"{lng} / {chaar} = {lng / chaar}");
            Console.WriteLine($"{lng} * {chaar} = {lng * chaar}");
            Console.WriteLine($"{lng} % {chaar} = {lng % chaar}");

            Console.WriteLine($"{lng} + {dbl} = {lng + dbl}");
            Console.WriteLine($"{lng} - {dbl} = {lng - dbl}");
            Console.WriteLine($"{lng} / {dbl} = {lng / dbl}");
            Console.WriteLine($"{lng} * {dbl} = {lng * dbl}");
            Console.WriteLine($"{lng} % {dbl} = {lng % dbl}");

            Console.ReadKey();
            Console.WriteLine("---------------------------------");
            Console.Clear();

            Console.WriteLine($"{shrt} + {intgr} = {shrt + intgr}");
            Console.WriteLine($"{shrt} - {intgr} = {shrt - intgr}");
            Console.WriteLine($"{shrt} / {intgr} = {shrt / intgr}");
            Console.WriteLine($"{shrt} * {intgr} = {shrt * intgr}");
            Console.WriteLine($"{shrt} % {intgr} = {shrt % intgr}");

            Console.WriteLine($"{shrt} + {lng} = {shrt + lng}");
            Console.WriteLine($"{shrt} - {lng} = {shrt - lng}");
            Console.WriteLine($"{shrt} / {lng} = {shrt / lng}");
            Console.WriteLine($"{shrt} * {lng} = {shrt * lng}");
            Console.WriteLine($"{shrt} % {lng} = {shrt % lng}");

            Console.WriteLine($"{shrt} + {flt} = {shrt + flt}");
            Console.WriteLine($"{shrt} - {flt} = {shrt - flt}");
            Console.WriteLine($"{shrt} / {flt} = {shrt / flt}");
            Console.WriteLine($"{shrt} * {flt} = {shrt * flt}");
            Console.WriteLine($"{shrt} % {flt} = {shrt % flt}");

            Console.WriteLine($"{shrt} + {bl} = FAIL");
            Console.WriteLine($"{shrt} - {bl} = FAIL");
            Console.WriteLine($"{shrt} / {bl} = FAIL");
            Console.WriteLine($"{shrt} * {bl} = FAIL");
            Console.WriteLine($"{shrt} % {bl} = FAIL");

            Console.WriteLine($"{shrt} + {str} = {shrt + str}");
            Console.WriteLine($"{shrt} - {str} = FAIL");
            Console.WriteLine($"{shrt} / {str} = FAIL");
            Console.WriteLine($"{shrt} * {str} = FAIL");
            Console.WriteLine($"{shrt} % {str} = FAIL");

            Console.WriteLine($"{shrt} + {chaar} = {shrt + chaar}");
            Console.WriteLine($"{shrt} - {chaar} = {shrt - chaar}");
            Console.WriteLine($"{shrt} / {chaar} = {shrt / chaar}");
            Console.WriteLine($"{shrt} * {chaar} = {shrt * chaar}");
            Console.WriteLine($"{shrt} % {chaar} = {shrt % chaar}");

            Console.WriteLine($"{shrt} + {dbl} = {shrt + dbl}");
            Console.WriteLine($"{shrt} - {dbl} = {shrt - dbl}");
            Console.WriteLine($"{shrt} / {dbl} = {shrt / dbl}");
            Console.WriteLine($"{shrt} * {dbl} = {shrt * dbl}");
            Console.WriteLine($"{shrt} % {dbl} = {shrt % dbl}");

            Console.ReadKey();
            Console.WriteLine("---------------------------------");
            Console.Clear();

            Console.WriteLine($"{bl} + {intgr} = FAIL");
            Console.WriteLine($"{bl} - {intgr} = FAIL");
            Console.WriteLine($"{bl} / {intgr} = FAIL");
            Console.WriteLine($"{bl} * {intgr} = FAIL");
            Console.WriteLine($"{bl} % {intgr} = FAIL");

            Console.WriteLine($"{bl} + {lng} = FAIL");
            Console.WriteLine($"{bl} - {lng} = FAIL");
            Console.WriteLine($"{bl} / {lng} = FAIL");
            Console.WriteLine($"{bl} * {lng} = FAIL");
            Console.WriteLine($"{bl} % {lng} = FAIL");

            Console.WriteLine($"{bl} + {shrt} = FAIL");
            Console.WriteLine($"{bl} - {shrt} = FAIL");
            Console.WriteLine($"{bl} / {shrt} = FAIL");
            Console.WriteLine($"{bl} * {shrt} = FAIL");
            Console.WriteLine($"{bl} % {shrt} = FAIL");

            Console.WriteLine($"{bl} + {flt} = FAIL");
            Console.WriteLine($"{bl} - {flt} = FAIL");
            Console.WriteLine($"{bl} / {flt} = FAIL");
            Console.WriteLine($"{bl} * {flt} = FAIL");
            Console.WriteLine($"{bl} % {flt} = FAIL");

            Console.WriteLine($"{bl} + {str} = {bl + str}");
            Console.WriteLine($"{bl} - {str} = FAIL");
            Console.WriteLine($"{bl} / {str} = FAIL");
            Console.WriteLine($"{bl} * {str} = FAIL");
            Console.WriteLine($"{bl} % {str} = FAIL");

            Console.WriteLine($"{bl} + {chaar} = FAIL");
            Console.WriteLine($"{bl} - {chaar} = FAIL");
            Console.WriteLine($"{bl} / {chaar} = FAIL");
            Console.WriteLine($"{bl} * {chaar} = FAIL");
            Console.WriteLine($"{bl} % {chaar} = FAIL");

            Console.WriteLine($"{bl} + {dbl} = FAIL");
            Console.WriteLine($"{bl} - {dbl} = FAIL");
            Console.WriteLine($"{bl} / {dbl} = FAIL");
            Console.WriteLine($"{bl} * {dbl} = FAIL");
            Console.WriteLine($"{bl} % {dbl} = FAIL");

            Console.ReadKey();
            Console.WriteLine("---------------------------------");
            Console.Clear();

            Console.WriteLine($"{chaar} + {intgr} = {chaar + intgr}");
            Console.WriteLine($"{chaar} - {intgr} = {chaar - intgr}");
            Console.WriteLine($"{chaar} / {intgr} = {chaar / intgr}");
            Console.WriteLine($"{chaar} * {intgr} = {chaar * intgr}");
            Console.WriteLine($"{chaar} % {intgr} = {chaar % intgr}");

            Console.WriteLine($"{chaar} + {lng} = {chaar + lng}");
            Console.WriteLine($"{chaar} - {lng} = {chaar - lng}");
            Console.WriteLine($"{chaar} / {lng} = {chaar / lng}");
            Console.WriteLine($"{chaar} * {lng} = {chaar * lng}");
            Console.WriteLine($"{chaar} % {lng} = {chaar % lng}");

            Console.WriteLine($"{chaar} + {shrt} = {chaar + shrt}");
            Console.WriteLine($"{chaar} - {shrt} = {chaar - shrt}");
            Console.WriteLine($"{chaar} / {shrt} = {chaar / shrt}");
            Console.WriteLine($"{chaar} * {shrt} = {chaar * shrt}");
            Console.WriteLine($"{chaar} % {shrt} = {chaar % shrt}");

            Console.WriteLine($"{chaar} + {bl} = FAIL");
            Console.WriteLine($"{chaar} - {bl} = FAIL");
            Console.WriteLine($"{chaar} / {bl} = FAIL");
            Console.WriteLine($"{chaar} * {bl} = FAIL");
            Console.WriteLine($"{chaar} % {bl} = FAIL");

            Console.WriteLine($"{chaar} + {str} = {chaar + str}");
            Console.WriteLine($"{chaar} - {str} = FAIL");
            Console.WriteLine($"{chaar} / {str} = FAIL");
            Console.WriteLine($"{chaar} * {str} = FAIL");
            Console.WriteLine($"{chaar} % {str} = FAIL");

            Console.WriteLine($"{chaar} + {flt} = {chaar + flt}");
            Console.WriteLine($"{chaar} - {flt} = {chaar - flt}");
            Console.WriteLine($"{chaar} / {flt} = {chaar / flt}");
            Console.WriteLine($"{chaar} * {flt} = {chaar * flt}");
            Console.WriteLine($"{chaar} % {flt} = {chaar % flt}");

            Console.WriteLine($"{chaar} + {dbl} = {chaar + dbl}");
            Console.WriteLine($"{chaar} - {dbl} = {chaar - dbl}");
            Console.WriteLine($"{chaar} / {dbl} = {chaar / dbl}");
            Console.WriteLine($"{chaar} * {dbl} = {chaar * dbl}");
            Console.WriteLine($"{chaar} % {dbl} = {chaar % dbl}");

            Console.ReadKey();
            Console.WriteLine("---------------------------------");
            Console.Clear();

            Console.WriteLine($"{dbl} + {intgr} = {dbl + intgr}");
            Console.WriteLine($"{dbl} - {intgr} = {dbl - intgr}");
            Console.WriteLine($"{dbl} / {intgr} = {dbl / intgr}");
            Console.WriteLine($"{dbl} * {intgr} = {dbl * intgr}");
            Console.WriteLine($"{dbl} % {intgr} = {dbl % intgr}");

            Console.WriteLine($"{dbl} + {lng} = {dbl + lng}");
            Console.WriteLine($"{dbl} - {lng} = {dbl - lng}");
            Console.WriteLine($"{dbl} / {lng} = {dbl / lng}");
            Console.WriteLine($"{dbl} * {lng} = {dbl * lng}");
            Console.WriteLine($"{dbl} % {lng} = {dbl % lng}");

            Console.WriteLine($"{dbl} + {shrt} = {dbl + shrt}");
            Console.WriteLine($"{dbl} - {shrt} = {dbl - shrt}");
            Console.WriteLine($"{dbl} / {shrt} = {dbl / shrt}");
            Console.WriteLine($"{dbl} * {shrt} = {dbl * shrt}");
            Console.WriteLine($"{dbl} % {shrt} = {dbl % shrt}");

            Console.WriteLine($"{dbl} + {bl} = FAIL");
            Console.WriteLine($"{dbl} - {bl} = FAIL");
            Console.WriteLine($"{dbl} / {bl} = FAIL");
            Console.WriteLine($"{dbl} * {bl} = FAIL");
            Console.WriteLine($"{dbl} % {bl} = FAIL");

            Console.WriteLine($"{dbl} + {str} = {dbl + str}");
            Console.WriteLine($"{dbl} - {str} = FAIL");
            Console.WriteLine($"{dbl} / {str} = FAIL");
            Console.WriteLine($"{dbl} * {str} = FAIL");
            Console.WriteLine($"{dbl} % {str} = FAIL");

            Console.WriteLine($"{dbl} + {chaar} = {dbl + chaar}");
            Console.WriteLine($"{dbl} - {chaar} = {dbl - chaar}");
            Console.WriteLine($"{dbl} / {chaar} = {dbl / chaar}");
            Console.WriteLine($"{dbl} * {chaar} = {dbl * chaar}");
            Console.WriteLine($"{dbl} % {chaar} = {dbl % chaar}");

            Console.WriteLine($"{dbl} + {flt} = {dbl + flt}");
            Console.WriteLine($"{dbl} - {flt} = {dbl - flt}");
            Console.WriteLine($"{dbl} / {flt} = {dbl / flt}");
            Console.WriteLine($"{dbl} * {flt} = {dbl * flt}");
            Console.WriteLine($"{dbl} % {flt} = {dbl % flt}");

            Console.ReadKey();
            Console.WriteLine("---------------------------------");
            Console.Clear();

        }
    }
}
