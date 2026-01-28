using System;

namespace sorting
{
    class Program
    {

        //функція для заповнення масивів
        void fillarray(ref double[] array, int min, int max, Random rnd)
        {

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
                Console.Write(array[i] + " ");
            }

        }

        //функція для запиту мін/макс значень для різних параметрів
        void fillvar(ref int variable, string criteria, string criteria2)
        {
            string p; 
            Console.Write($"Enter {criteria2} {criteria}: ");
            p = Console.ReadLine();
            variable = Convert.ToInt32(p); 
        }

        //основна функція
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Program op = new Program();

            //створення необхідних змінних та запит на розмір масиву
            string s; 
            int n, minh = 0, mins = 0, maxh = 0, maxs = 0;
            string height = "height", weight = "weight", minimum = "minimum", maximum = "maximum"; 
            Console.Write("Enter how many people you want to sort: ");
            s = Console.ReadLine();
            n = Convert.ToInt32(s);

            //створення двох масивів: ріст та вага
            double[] heights = new double[n];
            double[] weights = new double[n];


            //заповнення мін\макс значень для росту та ваги
            op.fillvar(ref minh, height, minimum);
            op.fillvar(ref maxh, height, maximum);
            op.fillvar(ref mins, weight, minimum);
            op.fillvar(ref maxs, weight, maximum);

            //вивід зібранних даних на екран
            Console.WriteLine("\nAll values entered:");
            Console.WriteLine($"Height: min = {minh}, max = {maxh}");
            Console.WriteLine($"Weight: min = {mins}, max = {maxs}");
            Console.WriteLine("\nAll heights (cm): ");
            op.fillarray(ref heights, minh, maxh, rnd);
            Console.WriteLine("\nAll weights (kg): ");
            op.fillarray(ref weights, mins, maxs, rnd);

            //сортування по росту та вивід на екран
            Console.WriteLine("\n\nArray sorted by height: ");
            Array.Sort(heights, weights);
            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine($"Height: {heights[i]}, Weight: {weights[i]}");
            }

            //сортування по вазі та вивід на екран
            Console.WriteLine("\n\nArray sorted by weight: ");
            Array.Sort(weights, heights);
            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine($"Height: {heights[i]}, Weight: {weights[i]}");
            }


            //ДРУГЕ ЗАВДАННЯ

            //створення необхідних змінних та запит на розмір масивів
            string conv, price = "price";
            int l, minp = 0, maxp = 0;
            Console.Write("\n\n\nEnter how many products do you want to add to a shop: ");
            conv = Console.ReadLine();
            l = Convert.ToInt32(conv); 

            //створення двх масивів: назва продуктів та ціна
            string[] products = new string[l];
            double[] prices = new double[l];

            //функція для заповнення назв продуктів
            for(int i = 0; i < l; i++)
            {
                Console.Write($"Enter a name of the product [{i}]: ");
                products[i] = Console.ReadLine();
            }

            //вивід на екран назв продуктів
            Console.WriteLine("\nAll products: ");
            
            foreach (string a in products)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("\n");

            //виклик функції на мін/макс ціну
            op.fillvar(ref minp, price, minimum);
            op.fillvar(ref maxp, price, maximum);

            //вивід цін на екран
            Console.WriteLine("Prices: ");
            op.fillarray(ref prices, minp, maxp, rnd);

            //сортування продуктів та цін на назвою продуктів
            Console.WriteLine("\n\nArray sorted by name: ");
            Array.Sort(products, prices);
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product: {products[i]}, Price: {prices[i]}");
            }

            //сортування продуктів та цін за ціною
            Console.WriteLine("\n\nArray sorted by prices: ");
            Array.Sort(prices, products);
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product: {products[i]}, Price: {prices[i]}");
            }


            //ТРЕТЄ ЗАВДАННЯ

            //створення необхідних змінних та запит на розмір масиву
            string conv1, grade = "grade";
            int st, ming = 0, maxg = 0;
            Console.Write("\n\n\nEnter how many students do you want to add?: ");
            conv1 = Console.ReadLine();
            st = Convert.ToInt32(conv1);

            //створення двох масивів: ім'я учнів та оцінки
            string[] students = new string[st];
            double[] grades = new double[st];

            //заповнення масиву з іменами учнів
            for(int i = 0; i < st; i++)
            {
                Console.Write($"Enter a name of a student [{i}]: ");
                students[i] = Console.ReadLine();
            }

            //запит на мін/макс оцінки
            op.fillvar(ref ming, grade, minimum);
            op.fillvar(ref maxg, grade, maximum);

            //вивід усіх оцінок на екран
            Console.WriteLine("\nGrades: ");
            op.fillarray(ref grades, ming, maxg, rnd);

            //сортування по найкращим оцінкам
            Console.WriteLine("\n\nSorted grades from highest to lowest: ");
            Array.Sort(grades, students);
            Array.Reverse(grades);
            Array.Reverse(students);

            //вивід результатів
            for(int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Student: {students[i]}, Grade: {grades[i]}");
            }

        }
    }
}
