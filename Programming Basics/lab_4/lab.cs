using System;

namespace lab_4
{
    public class lab
    {

        static void Main(string[] args)
        {
            float a =2f, b = 4f;
            lab Program = new lab();

            Console.WriteLine("Площа фігури за малюнком даного завдання");
            Console.WriteLine(Program.RectangSqr(a, b));
            Console.ReadKey();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введіть свої значення (сторони)");
                string A = Console.ReadLine(), B = Console.ReadLine();

                try
                {
                    Console.WriteLine(Program.RectangSqr( float.Parse(A), float.Parse(B) ));
                    break;
                }
                catch
                {
                    continue;
                }
            };
            Console.ReadKey();

            //----------------------------------------------------//

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введіть свої значення для коеффіцієнти кв. рівняння(A>0, B, C)");

                string A = Console.ReadLine(), B = Console.ReadLine(), C = Console.ReadLine();
                try
                {
                    bool Task2 = Program.SqrEquation( float.Parse(A), float.Parse(B), float.Parse(C) );

                    if (Task2 == true) 
                        break;
                } 
                catch
                {
                    continue;
                }
                
            }

        }
        float RectangSqr(float sideA, float sideB)
        {
            return sideA * sideB;
        }

        bool SqrEquation(double fA, double fB, double fC)
        {
            if (fA <= 0) 
                return false;

            double D = fB * fB - 4 * fA * fC, X1, X2;

            if (D <= 0) 
                return false;
            else
            {
                X1 = (-fB - Math.Sqrt(D)) / (2 * fA);

                X2 = (-fB + Math.Sqrt(D)) / (2 * fA);
                if (X1 > X2) 
                    Console.WriteLine(X1 + " " + X2);
                else
                    Console.WriteLine(X2 + " " + X1);
            }
            return true;
        }


    }
}
