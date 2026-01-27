using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ПЕРШИЙ ПРИКЛАД

            //питаємо х, конвертуємо з тексту до числа + виводимо на екран
            Console.Write("Equation 1\n\nEnter x = ");
            string conv = Console.ReadLine();
            double x = Convert.ToDouble(conv);

            Console.Write($"x = {x}");

            //даємо опції, зчитуємо, також змінну z робимо глобальною змінною
            Console.Write("\n\nChoose an action (1/first/FIRST/First, 2/Second/second/SECOND, 3/THIRD/Third//third): ");
            string option = Console.ReadLine();
            double z = 0;

            //порівнюємо опції та виводимо результати
            switch(option)
            {
                case "1":
                case "first":
                case "First":
                case "FIRST": 
                    z = Math.Pow(Math.Sin(x), 2);
                    Console.WriteLine($"z = {z}");
                    break;

                case "2":
                case "Second":
                case "second":
                case "SECOND":
                    if (x > 0) //перевірка на обмеження
                    {
                        z = Math.Pow(Math.Log(x), 2);
                        Console.WriteLine($"z = {z}");
                    }
                    else
                    {
                        Console.WriteLine("Logarithm is undefined");
                    }
                    break;  

                case "3":
                case "Third":
                case "third":
                case "THIRD":
                    if (Math.Cos(Math.Pow(x, 3)) != 0) //перевірка на обмеження
                    {
                        z = 1 / Math.Cos(Math.Pow(x, 3));
                        Console.WriteLine($"z = {z}");
                    }
                    else
                    {
                        Console.WriteLine("Error! Dividing on zero");
                    }
                    break; 

                default:
                    Console.WriteLine("You chose nonexistent option");
                    return;

            }


            //ДРУГИЙ ПРИКЛАД

            //питаємо х та робимо з тексту число + виводимо на екран
            Console.Write("\n\n\nEquation 2\n\nEnter x = ");
            string conv2 = Console.ReadLine();
            double x2 = Convert.ToDouble(conv2);

            Console.Write($"x = {x2}");

            //даємо опції для вибору + робимо z2 глобальною змінною
            Console.Write("\n\nChoose an action (a/A, B/b, C/c): ");
            string option2 = Console.ReadLine();
            double z2 = 0;

            //в залежності від обраної опції рахуємо різні приклади та виводимо результати
            switch(option2)
            {
                case "A":
                case "a":
                    z2 = Math.Sqrt(Math.Tan(x2));;
                    Console.WriteLine($"z = {z2}");
                    break;

                case "B":
                case "b":
                    if (Math.Tan(x2) != 0) //перевірка на обмеження
                    {
                        z2 = 1 / Math.Tan(x2);
                        Console.WriteLine($"z = {z2}");
                    }
                    else
                    {
                        Console.WriteLine("Error! Division on zero");
                    }
                    break;  

                case "C":
                case "c":
                    z2 = Math.Log(Math.Tan(x2));
                    Console.WriteLine($"z = {z2}");
                    break; 

                default:
                    Console.WriteLine("You chose nonexistent option");
                    return;
            }


            //ТРЕТІЙ ПРИКЛАД

            //просимо значення х та перетворюємо на число + виводимо у консоль
            Console.Write("\n\n\nEquation 3\n\nEnter x = ");
            string conv3 = Console.ReadLine();
            double x3 = Convert.ToDouble(conv3);

            Console.Write($"x = {x3}");

            //даємо опції для вибору + робимо z3 глобальною змінною
            Console.Write("\n\nChoose an action (A/100, 200/B, 250/C): ");
            string option3 = Console.ReadLine();
            double z3 = 0;

            //в залежності від обраної опції рахуємо різні приклади та виводимо результати
            switch(option3)
            {
                case "A":
                case "100":
                    if(Math.Sin(x3) > 0) //перевірка на обмеження
                    {
                        z3 = Math.Sqrt(Math.Sin(x3));
                        Console.Write($"z = {z3}"); 
                    }
                    else
                    {
                        Console.Write("Error! Sin is negative");
                    }
                    break;

                case "B":
                case "200":
                    if (Math.Cos(x3) != 0) //перевірка на обмеження
                    {
                        z3 = 1 / Math.Cos(x3);
                        Console.WriteLine($"z = {z3}");
                    }
                    else
                    {
                        Console.WriteLine("Error! Division on zero");
                    }
                    break;  

                case "C":
                case "250":
                    z3 = Math.Log(Math.Abs(Math.Tan(x3)));
                    Console.WriteLine($"z = {z3}");
                    break; 

                default:
                    Console.WriteLine("You chose nonexistent option");
                    return;

            }


            //ЧЕТВЕРТИЙ ПРИКЛАД

            ///просимо значення х та а, перетворюємо в числа + виводимо у консоль
            Console.Write("\n\n\nEquation 4\nEnter x = ");
            string conv4 = Console.ReadLine();
            double x4 = Convert.ToDouble(conv4);
            Console.Write("Enter a = ");
            string conva4 = Console.ReadLine();
            double a4 = Convert.ToDouble(conva4);
            Console.Write($"x = {x4}, a = {a4}");

            //даємо опції дій + робимо z4 глобальною змінною
            Console.Write("\n\nChoose an action (1/alfa, 2/beta, 3/gamma): ");
            string option4 = Console.ReadLine();
            double z4 = 0;

            //в залежності від обраної опції рахуємо різні приклади та виводимо результати
            switch (option4)
            {
                case "1":
                case "alfa":
                    if (Math.Sin(x4) + a4 > 0) //перевірка на обмеження
                    {
                        z4 = Math.Sqrt(a4 + Math.Sin(x4));
                        Console.Write($"z = {z4}");
                    }
                    else
                    {
                        Console.Write("Error! Square Root of negative number!");
                    }
                    break;

                case "2":
                case "beta":
                    if (Math.Sin(a4 * x4) > 0) //перевірка на обмеження
                    {
                        z4 = Math.Sqrt(Math.Sin(a4 * x4));
                        Console.Write($"z = {z4}");
                    }
                    else
                    {
                        Console.Write("Error! Square Root of negative number!");
                    }
                    break;

                case "3":
                case "gamma":
                    if (a4 - x4 > 0) //перевірка на обмеження
                    {
                        z4 = Math.Log(a4 - x4);
                        Console.Write($"z = {z4}");
                        break;
                    }
                    else
                    {
                        Console.Write("Error! Logarithm undefined");
                    }
                    break;
            }

        }
    }
}
