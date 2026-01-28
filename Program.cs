using System;

namespace lab3
{
    class Program
    {

        //функція для заповнення масивів та виведення їх на екран
        void input (ref double[] array, string name1)
        {
            //заповнення масиву
            string read;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0}[{1}]: ", name1, i);
                read = Console.ReadLine();
                array[i] = Convert.ToDouble(read);
            }

            //виведення масиву на екран
            Console.WriteLine($"Array {name1}: ");
            for(int i = 0; i < array.Length; i++)
            {
               Console.Write(array[i] + " ");  
            }
        }

        //функція для аналізу масивів
        void analysis(ref double[]array, string name1, out double sum1, out double mid1)
        {
            double min1 = 0, max1 = 0;
            sum1 = 0;
            int count = 0;
            string t;

            //питаємо мінімальний та максимальний елементи для розрахунків суми й серед.знач.
            Console.Write($"\n\nEnter minimum element for sum and average in {name1} array: ");
            t = Console.ReadLine();
            min1 = Convert.ToDouble(t);

            Console.Write($"Enter maximum element for sum and average in {name1} array: ");
            t = Console.ReadLine();
            max1 = Convert.ToDouble(t);

            //функція для рахунку суми
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min1 && array[i] <= max1) // перевіряємо значення елемента
                {
                    sum1 += array[i];
                    count++;
                }
            }

            //перевірка, щоб не ділилося на 0, а такоє підрахунок серед.знач. + вивід на екран
            if (count > 0)
                mid1 = sum1 / count;
            else 
                mid1 = 0;

            Console.WriteLine("\nFor {0} array:\nsum = {1}\naverage = {2}\n\n\n", name1, sum1, mid1);
        }


        //основна функція
        static void Main(string[] args)
        {
            Program myclass = new Program();
            
            //змінні для розміру масивів
            int n, m, l;

            //назви масивів
            string name1 = "A";
            string name2 = "B";
            string name3 = "C";

            //змінні для сум та середніх значень
            double sum1, sum2, sum3;
            double mid1, mid2, mid3;

            string p;

            //просимо вести скільки елементів буде в масивах і викликаємо заповнення та підрахунок для усіх 3 масивів
            Console.Write("Enter an amount of elements for A array: ");
            p = Console.ReadLine();
            n = Convert.ToInt32(p);
            double[] A = new double[n];
            myclass.input(ref A, name1);
            myclass.analysis(ref A, name1, out sum1, out mid1);


            Console.Write("Enter an amount of elements for B array: ");
            p = Console.ReadLine();
            m = Convert.ToInt32(p);
            double[] B = new double[m];
            myclass.input(ref B, name2);
            myclass.analysis(ref B, name2, out sum2, out mid2);

            Console.Write("Enter an amount of elements for C array: ");
            p = Console.ReadLine();
            l = Convert.ToInt32(p);
            double[] C = new double[l];
            myclass.input(ref C, name3);
            myclass.analysis(ref C, name3, out sum3, out mid3);

        }


    }

}
