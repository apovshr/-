using System;

namespace Classes
{
    class ship
    {
        string name;
        string purpose;
        double vodosmth;
        double power;
        string fuel;

        public void input_ship()
        {
            string s;
            Console.Write("\n\nВведіть ім'я: ");
            name = Console.ReadLine();
            Console.Write("Введіть призначення: ");
            purpose = Console.ReadLine();
            Console.Write("Введіть водотоннажність: ");
            s = Console.ReadLine();
            vodosmth = Convert.ToDouble(s);
            Console.Write("Введіть потужність двигуна: ");
            s = Console.ReadLine();
            power = Convert.ToDouble(s);
            Console.Write("Введіть тип палива: ");
            fuel = Console.ReadLine();
        }

        public void output_ship()
        {
            Console.WriteLine("Ім'я: " + name);
            Console.WriteLine("Призначення: " + purpose);
            Console.WriteLine("Вдотоннажність: " + vodosmth);
            Console.WriteLine("Потужність двигуна: " + power);
            Console.WriteLine("Введіть тип палива: " + fuel);
        }

    }
    class aircrafts: ship
    {
        string typeaircraft;
        int howmanyaircrafts;

        public void input_aircraft()
        {
            input_ship();
            Console.Write("Введіть тип літака: ");
            typeaircraft = Console.ReadLine();
            Console.Write("Введіть кількість літаків: ");
            howmanyaircrafts = Convert.ToInt32(Console.ReadLine());
        }

        public void output_aircraft()
        {
            output_ship();
            Console.WriteLine("Вид літака: " + typeaircraft);
            Console.WriteLine("Кількість літаків: " + howmanyaircrafts);
        }
    }
    class rockets: ship
    {
        string typerocket;
        int howmanyrockets;

        public void input_rockets()
        {
            input_ship();
            Console.Write("Введіть тип ракетоносця: ");
            typerocket = Console.ReadLine();
            Console.Write("Введіть кількість ракетоносців: ");
            howmanyrockets = Convert.ToInt32(Console.ReadLine());
        }

        public void output_rocket()
        {
            output_ship();
            Console.WriteLine("Вид ракетоносця: " + typerocket);
            Console.WriteLine("Кількість ракетоносців: " + howmanyrockets);
        }
    }

    class Program
    {
       public static void Main(string[] args)
        {
            Console.Write("Що ви хочете додати? 1. Корабель 2. Літак 3. Ракетоносець (оберіть 1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Як багато кораблів ви хочете додати? ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    ship[] shipp = new ship[n];

                    for (int i = 0; i < shipp.Length; i++)
                    {
                        shipp[i] = new ship();
                        shipp[i].input_ship();
                        Console.WriteLine("\n\nКорабель {0}: ", i + 1);
                        shipp[i].output_ship();
                    }
                    break;

                case "2":
                    Console.Write("Як багато літаків ви хочете додати? ");
                    n = Convert.ToInt32(Console.ReadLine());
                    aircrafts[] aircraft = new aircrafts[n];

                    for (int i = 0; i < aircraft.Length; i++)
                    {
                        aircraft[i] = new aircrafts();
                        aircraft[i].input_aircraft();
                        Console.WriteLine("\n\nЛітак {0}: ", i + 1);
                        aircraft[i].output_aircraft();
                    }
                    break;

                case "3":
                    Console.Write("Як багато ракетоносців ви хочете додати? ");
                    n = Convert.ToInt32(Console.ReadLine());
                    rockets[] rocket = new rockets[n];

                    for (int i = 0; i < rocket.Length; i++)
                    {
                        rocket[i] = new rockets();
                        rocket[i].input_rockets();
                        Console.WriteLine("\n\nРакетоносець {0}: ", i + 1);
                        rocket[i].output_rocket();
                    }
                    break;
                default:
                    Console.WriteLine("Такої опції не було. Вихід з програми...");
                    break;
                

            }
        }     
    }


}
