using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    //вказівник на метод
    delegate double F1 (double a);

    class Program
    {
        // функція вводу масивів
        public void input(double[] x, string name)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("Enter {0}[{1}] = ", name, i);
                x[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }

        // функція для рахунку значень змінних для прикладу
        public void suma(double []x, F1 f1,F1 f2, out double A, out double B, out double C, bool yes)
        {
            A = C = 0;
            B = 1;
            double s = 0;
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < x.Length; i++)
            {
                s += x[i]; // сума
                B *= x[i]; // добуток
                sum1 += x[i] * f1(x[i]); 
                sum2 += x[i] * f2(x[i]);
                
            }

            if (yes)
            {
                A = s * sum1;
                C = s * sum2;
            }

            else
            {
                A = sum1;
                C = sum2;
            }
        }

        // основна функція 
        static void Main(string[] args)
        {
            Program ob = new Program();

            // задаємо розміри масивів
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());  

            // створюємо 2 масиви
            double[] arr1 = new double[n];
            double[] arr2 = new double[m];

            // вводимо значення у масиви
            ob.input(arr1, "Array N");
            ob.input(arr2, "Array L");

            // вводимо усі змінні
            double A, B, C, D, E, F, den, result;

            // рахуємо значення змінних
            ob.suma(arr1, Math.Tan, Math.Sin, out A, out B, out C, true);
            ob.suma(arr2, Math.Cos, Math.Abs, out D, out E, out F, false);

            // рахуємо знаменник
            den = D + E * Math.Sin(F);

            // перевірка на обмеження та вивід результатів
            if (den != 0)
            {
                result = (A * Math.Cos(B) + C) / den;
                Console.WriteLine("Result = " + result);  
            }
            else
            {
                Console.WriteLine("Error! Division on zero");
            }
           
        }
    }
}
