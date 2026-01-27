using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //ПЕРШИЙ ПРИКЛАД


            //робимо масив з усіма змінними, а також масив під їх значення
            string[] variables = {"c", "x", "a"};
            double[] values = new double[variables.Length];

            //функція для заповнення усіх значень у масив значень
            for(int i = 0; i < values.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {variables[i]}: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out values[i]))
                        break;
                    Console.WriteLine("You did not enter a number, try again: ");
                }
            }

            //значення, які заповнили, присвоюємо змінним
            double c = values[0];
            double x = values[1];
            double a = values[2];

            //виводимо результат
            Console.WriteLine($"C = {c}, X = {x}, A = {a}");

            //рахуємо перший приклад: значення у. потім виводимо результат на екран
            if ( x <= 0)
            {
                Console.WriteLine("Log(x) is undefined for x <= 0");
                
            } 
            else
            {
                double y = Math.Pow(c * x - a, 1.0/3.0) + Math.Log(x) / (2 * Math.Sin(Math.PI/3 + x));    
                Console.WriteLine("\ny = " + y);
            }
            Console.WriteLine("\n________________________________\n\n");


            //ДРУГИЙ ПРИКЛАД


            //робимо масив з усіма змінними, а також масив під їх значення
            //(дала інші літери, щоб не було плутанини)
            string[] variables2 = {"b", "e"};
            double[] values2 = new double[variables2.Length];
            string[] xstuff = {"xmin", "xmax", "krok"};
            double[] valuesx = new double[3];

            //функція для заповнення усіх значень у масив значень
            for(int i = 0; i < variables2.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {variables2[i]}: ");
                    string input = Console.ReadLine();

                    if(double.TryParse(input, out values2[i]))
                        break;

                    Console.WriteLine("You didn't enter a number, try again: ");
                }
            } 

            //значення, які заповнили, присвоюємо змінним
            double b = values2[0];
            double e = values2[1];

            Console.WriteLine($"b = {b}, e = {e}\n");

            //просимо значення для макс та мін х + крок, також робимо перевірку
            for(int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {xstuff[i]}: ");
                    string input2 = Console.ReadLine();

                    if(double.TryParse(input2, out valuesx[i]))
                        break;

                    Console.WriteLine("You didn't enter a number, try again: ");
                }
            }

            //змінним даємо значення, які дізналися
            double xmin = valuesx[0];
            double xmax = valuesx[1];
            double krok = valuesx[2];

            Console.WriteLine($"xmin = {xmin}, xmax = {xmax}, krok = {krok}\n\n");

            //вирішуємо рівняння та збільшуємо х (тут d)
            for(double d = xmin; (krok > 0 && d <= xmax) || (krok < 0 && d >= xmax); d+= krok)
            {
                double v = Math.Pow((Math.Pow(b, 2)) * (Math.Pow(d, 2)) + 2, 1.0/3.0) + Math.Log((Math.Pow(d, 2)) + 1);
                Console.WriteLine("d = {0}, z = {1}", d, v);
            }

            Console.WriteLine("\n________________________________\n\n");


            //ТРЕТІЙ ПРИКЛАД


            //робимо масив з усіма змінними, а також масив під їх значення
            //(дала інші літери, щоб не було плутанини)
            string[] variables3 = {"j", "l"};
            double[] values3 = new double[variables3.Length];
            string[] xstuff1 = {"xmin", "xmax", "krok"};
            double[] valuesx1 = new double[3];

            //функція для заповнення усіх значень у масив значень
            for(int i = 0; i < variables3.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {variables3[i]}: ");
                    string input = Console.ReadLine();

                    if(double.TryParse(input, out values3[i]))
                        break;

                    Console.WriteLine("You didn't enter a number, try again: ");
                }
            } 

            //значення, які заповнили, присвоюємо змінним
            double j = values3[0];
            double l = values3[1];

            Console.WriteLine($"j = {j}, l = {l}\n");


            //просимо значення для макс та мін х + крок, також робимо перевірку
            for(int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {xstuff1[i]}: ");
                    string input2 = Console.ReadLine();

                    if(double.TryParse(input2, out valuesx1[i]))
                        break;

                    Console.WriteLine("You didn't enter a number, try again: ");
                }
            }

            //змінним даємо значення, які дізналися
            double xmin1 = valuesx1[0];
            double xmax1 = valuesx1[1];
            double krok1 = valuesx1[2];

            Console.WriteLine($"xmin = {xmin1}, xmax = {xmax1}, krok = {krok1}\n");


            //вирішуємо рівняння та збільшуємо х (тут р)
            for(double p = xmin1; (krok1 > 0 && p <= xmax1) || (krok1 < 0 && p >= xmax1); p+= krok1)
            {

                if (j * p <= 0)
                {
                    Console.WriteLine($"p = {p}: log undefined");
                    continue;
                }

                 double cosVal = Math.Cos(j * p);
                 double cubeRoot = Math.Sign(cosVal) * Math.Pow(Math.Abs(cosVal), 1.0 / 3.0);

                double z = cubeRoot + ((l * cosVal) / Math.Log(j * p));
                Console.WriteLine("p = {0}, z = {1}", p, z);
            }

            Console.WriteLine("\n________________________________\n\n");


            //ЧЕТВЕРТЕ ЗАВДАННЯ

            //ЛІНІЙНИЙ ПРОЦЕС

            //створюємо масиви для назв змінних і для значень
            string[] lin = {"m", "n"};
            double[] valuesmn = new double[2];

            //функція для запиту значень для змін
            for (int i = 0; i < 2; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {lin[i]}: ");

                    string inputmn = Console.ReadLine();
                    
                    if(double.TryParse(inputmn, out valuesmn[i]))
                        break;
                }
            }
            
            //значення, які заповнили, присвоюємо змінним
            double m = valuesmn[0];
            double n = valuesmn[1];

            Console.WriteLine($"m = {m}, n = {n}\n\n");

            //вирішуємо простий приклад
            double answer1 = Math.Pow(m, 2) + 2 * n;

            Console.WriteLine("Answer to linear example: " + answer1);

            Console.WriteLine("\n________________________________\n\n");



            //РОЗГАЛУЖЕНИЙ ПРОЦЕС

            //створюємо масиви для назв змінних і для значень
            string[] roz = {"s", "w"};
            double[] valuessw = new double[2];

            for (int i = 0; i < 2; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {roz[i]}: ");

                    string inputmn = Console.ReadLine();
                    
                    if(double.TryParse(inputmn, out valuessw[i]))
                        break;
                }
            }

            //значення, які заповнили, присвоюємо змінним
            double s = valuessw[0];
            double w = valuessw[1];

            //зміна для відповіді, поставила тут, щоб не створювати знову й знову локально
            double answer2 = 0;

            //функція для розгалудження
            if (s > w)
            {
                if (w + 5 > 0)
                {
                    answer2 = Math.Pow(s, 2) + 45 - Math.Log(w + 5);
                    //відповідь вивели у консоль
                    Console.WriteLine("Answer to branched example: " + answer2);
                }
                else
                {
                    Console.WriteLine("Log(w + 5) is undefined");
                }
            }
            else
            {
                answer2 = w - Math.Cos(s);

                //відповідь вивели у консоль
                Console.WriteLine("Answer to branched example: " + answer2);
            }


            Console.WriteLine("\n________________________________\n\n");


            //ЦИКЛІЧНИЙ ПРОЦЕС

            //робимо масив з усіма змінними, а також масив під їх значення
            //(дала інші літери, щоб не було плутанини)
            string[] variablesrt = {"r", "t"};
            double[] valuesrt = new double[2];
            string[] xstuffrt = {"xmin", "xmax", "krok"};
            double[] valuesxrt = new double[3];

            //функція для заповнення усіх значень у масив значень
            for(int i = 0; i < 2; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {variablesrt[i]}: ");
                    string input = Console.ReadLine();

                    if(double.TryParse(input, out valuesrt[i]))
                        break;

                    Console.WriteLine("You didn't enter a number, try again: ");
                }
            } 

            //значення, які заповнили, присвоюємо змінним
            double r = valuesrt[0];
            double t = valuesrt[1];

            Console.WriteLine($"r = {r}, t = {t}\n");

            //функція для заповнення значень х
            for(int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {xstuffrt[i]}: ");
                    string input2 = Console.ReadLine();

                    if(double.TryParse(input2, out valuesxrt[i]))
                        break;

                    Console.WriteLine("You didn't enter a number, try again: ");
                }
            }

            //присвоїли значення х змінним
            double xminrt = valuesxrt[0];
            double xmaxrt = valuesxrt[1];
            double krokrt = valuesxrt[2];

            Console.WriteLine($"xmin = {xminrt}, xmax = {xmaxrt}, krok = {krokrt}\n\n");

            //рахунок прикладу зі змінними значеннями х
            for(double u = xminrt; (krokrt > 0 && u <= xmaxrt) || (krokrt < 0 && u >= xmaxrt); u+= krokrt)
            {
                double q = r * u + 7;
                Console.WriteLine("u = {0}, q = {1}", u, q);
            }

            Console.WriteLine("\n________________________________\n\n");

        }
    }
}
