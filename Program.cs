using System;

namespace Lab_10_1
{

    //абстрактний клас літаків
    abstract class plane
    {
        protected string model;
        protected double maxspeed;
        protected double fuel;

        //абстрактні фукнції заповнення та виведення
        public abstract void input();
        public abstract void output();
    }

    //клас літаків винищувачів
    class fighter: plane
    {
        int hmpilots;
        double rad;

        //функція вводу
        public override void input()
        {
            Console.Write("Введіть модель літака: ");
            model = Console.ReadLine();
            Console.Write("Введіть максимальну швидкість: ");
            maxspeed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть витрати пального: ");
            fuel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть кількість пілотів: ");
            hmpilots = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть бойовий радіус дії: ");
            rad = Convert.ToDouble(Console.ReadLine());
        }

        //функція виводу
        public override void output()
        {
            Console.WriteLine("Модель: {0}", model);
            Console.WriteLine("Максимальна швидкість : {0}", maxspeed);
            Console.WriteLine("Витрати пального : {0}", fuel);
            Console.WriteLine("Кількість пілотів : {0}", hmpilots);
            Console.WriteLine("Бойовий радіус дії : {0}", rad);
        }
    }

    //клас пасажирських літаків
    class passenger: plane
    {
        int passengers;
        int workers;
        double time;

        //клас вводу
        public override void input()
        {
            Console.Write("\n\nВведіть модель літака: ");
            model = Console.ReadLine();
            Console.Write("Введіть максимальну швидкість: ");
            maxspeed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть витрати пального: ");
            fuel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть кількість пасажирів: ");
            passengers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кількість членів екіпажу: ");
            workers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть середню тривалість рейсу: ");
            time = Convert.ToDouble(Console.ReadLine());
        }

        //клас виводу
        public override void output()
        {
            Console.WriteLine("Модель: : {0}", model);
            Console.WriteLine("Максимальна швидкість : {0}", maxspeed);
            Console.WriteLine("Витрати пального : {0}", fuel);
            Console.WriteLine("Кількість пасажирів : {0}", passengers);
            Console.WriteLine("Кількість робітників : {0}", workers);
            Console.WriteLine("Середня тривалість рейсу : {0}\n\n", time);
        }
        
    }

    //клас програми
    class Program
    {
        static void Main()
        {
            //даємо опції, що саме заповнювати
            Console.Write("Інформацію про що хочете заповнити: 1 - Літак винищувач, 2 - Пасажирський літак: ");
            string choice = Console.ReadLine();

            //по-кожній опції свій варіант дії
            switch (choice)
            {
                case "1":
                {
                    //питаємо розмір масиву
                    Console.Write("Про скількох літаків винищувачів ви хочете ввести інформацію?: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    fighter[] f = new fighter[n];

                    //заповнюємо та виводу інформацію по кожному елементу з масива (літак винищувач)
                    for(int i = 0; i < f.Length; i++)
                    {
                        f[i] = new fighter();
                        f[i].input();
                        Console.WriteLine("\n\nЛітак {0}: ", i + 1);
                        f[i].output();
                        Console.WriteLine();
                    }
                    break;
                }


                //повторюємо усі дії з першої опції, тільки тепер з пасажирським літаком
                case "2":
                {
                    Console.Write("Про скількох пасажирських літаків ви хочете ввести інформацію?: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    passenger[] p = new passenger[n];

                    for(int i = 0; i < p.Length; i++)
                    {
                        p[i] = new passenger();
                        p[i].input();
                        Console.WriteLine("\n\nЛітак {0}: ", i + 1);
                        p[i].output();
                        Console.WriteLine();
                    }
                    break;
                }

                //якщо жодна з опцій не була обрана, повідомлення про помилку й вихід
                default:
                {
                    Console.WriteLine("Такої опції немає, вихід з програми...");
                    break;  
                }
            }
        }
    }
}
