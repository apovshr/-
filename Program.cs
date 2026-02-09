using System;
using System.IO;

namespace Lab12
{
    class Program
    {
        public static void Main(string[] args)
        {
            //вводимо змінні
            double x, k, z, xmin, xmax, dx;

            //читаємо з файлу їх значення
            StreamReader sr = new StreamReader("/Users/nastyalytvynenko/Library/Mobile Documents/com~apple~CloudDocs/Downloads/Uni/Net Framework/лаб 12/lab 12/data.txt");
            xmin = Convert.ToDouble(sr.ReadLine());
            xmax = Convert.ToDouble(sr.ReadLine());
            dx = Convert.ToDouble(sr.ReadLine());
            k = Convert.ToDouble(sr.ReadLine());

            //виводимо дані
            Console.WriteLine("Вхідні дані: ");
            Console.WriteLine($"xmin: {xmin}");
            Console.WriteLine($"xamax: {xmax}");
            Console.WriteLine($"dx: {dx}");
            Console.WriteLine($"k: {k}\n\n");

            //створюємо новий файл для запису
            StreamWriter sw = new StreamWriter("/Users/nastyalytvynenko/Library/Mobile Documents/com~apple~CloudDocs/Downloads/Uni/Net Framework/лаб 12/lab 12/solutions.txt");

            //рахуємо для кожного х значення виразу, виводимо у консоль та вносимо у файл результати
            for (x = xmin; x <= xmax; x+=dx)
            {
                z = Math.Pow(1/Math.Tan(k * x), 1.0/3.0) + Math.Cos(k * x) / (Math.Log(Math.Sin(k * x)));
                Console.WriteLine($"x = {x:F4}      z = {z:F4}");
                sw.WriteLine($"x = {x:F4}       z = {z:F4}");
            }

            //закриваємо файл
            sw.Close();
        }
    }
}
