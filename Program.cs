using System;

namespace vehicles
{

    //Базовий клас
    class transport
    {
        protected double pribut;

        //віртуальна функція для рахунку чистого прибутку
        public virtual void pributok()
        {
            pribut = 0;  
        }

        public double getpribut()
        {
            return pribut;
        }
    }

    class cargo: transport
    {

        //змінні
        public double weight;
        public double priceperton;
        public double expenses;

        //віртуальна функція для рахунку чистого прибутку
        public override void pributok()
        {
            pribut = weight * priceperton - expenses;
        }

        
        //функція для заповнення даних
         public void input()
        {
            Console.Write("Введіть вагу (тонни): ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть ціну за тонну: ");
            priceperton = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть затрати: ");
            expenses = Convert.ToDouble(Console.ReadLine());
        }
    }

    class passenger: transport
    {

        //змінні
        public int passengers;
        public double tickets;
        public double expenses;

        //віртуальна функція для рахунку чистого прибутку
        public override void pributok()
        {
            pribut = passengers * tickets - expenses;
        }

        //функція для заповнення даних
         public void input()
        {
            Console.Write("Введіть кількість посажирів: ");
            passengers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кількість квитків: ");
            tickets = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть затрати: ");
            expenses = Convert.ToDouble(Console.ReadLine()); 
        }
    }

    class Program
    {
        static void Main()
        {
            //даємо обрати дію
            Console.Write("Якого виду транспорту ви хочете порахувати чистий прибуток: 1 - Вантажний, 2 - Пасажирський: ");
            string choice = Console.ReadLine();

            //switch case для усіх варіантів дій
            switch (choice)
            {
                //опція вантажівок
                case "1":
                {
                    //питаємо розмір масиву
                    Console.Write("Введіть кільксіть вантажівок: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    cargo[] carg = new cargo[n]; 

                    //проходимося по кожному елементу
                    for(int i = 0; i < carg.Length; i++)
                    {
                        carg[i] = new cargo(); //створення елементу
                        Console.WriteLine("\n\nВантажівка {0}: ", i + 1);
                        carg[i].input(); //заповнення
                        carg[i].pributok(); // рахунок прибутку
                        Console.WriteLine("Чистий прибуток для вантажівки {0}: {1}", i + 1, carg[i].getpribut()); //вивід на екран
                    }
                    break;
                }

                //опція пасажирського транспорту, повторюємо дії
                case "2":
                {
                    Console.Write("Введіть кільксіть пасажирського транспорту: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    passenger[] pass = new passenger[n];

                    for(int i = 0; i < pass.Length; i++)
                    {
                       pass[i] = new passenger();
                       Console.WriteLine("\n\nПасажирський транспорт {0}: ", i + 1);
                       pass[i].input();
                       pass[i].pributok();
                       Console.WriteLine("Чистий прибуток для пасажирського транспорту {0}: {1}", i + 1, pass[i].getpribut()); 
                    }
                    break;
                }

                //варіант, якщо не обрали з запропонованих опцій - вихід з програми
                default:
                {
                    Console.WriteLine("Такої опції немає, вихід з програми...");
                    break;
                }
            }
        }
    }
}

