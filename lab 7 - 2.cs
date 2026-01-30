using System;

namespace task2
{
    //Клас організації
    class organisations
    {
        //вводимо змінні
        string name;
        int year;
        string city;
        int workers;
        string type;


        //функція вводу орагнізації
        public void input()
        {
            string s;
            Console.Write("\n\n\nВведіть ім'я: ");
            name = Console.ReadLine();
            Console.Write("Введіть рік заснування: ");
            s = Console.ReadLine();
            year = Convert.ToInt32(s);
            Console.Write("Введіть місто розсташування: ");
            city = Console.ReadLine();
            Console.Write("Введіть кількість робітників: ");
            s = Console.ReadLine();
            workers = Convert.ToInt32(s);
            Console.Write("Введіть тип (державний/приватний): ");
            type = Console.ReadLine();     
        }

        //функція виводу організацій
        public void output()
        {
            Console.WriteLine("\n\nІм'я: " + name);
            Console.WriteLine("Рік: " + year);
            Console.WriteLine("Місто: " + city);
            Console.WriteLine("Кількість робітників: " + workers);
            Console.WriteLine("Тип: " + type);
        }

    }

    //клас страхових компаній
    class insurance : organisations
    {
        string typeinsurance;
        int clients;
        double yearlymoney;


        //функція вводу даних страхових компаній
        public void input_insurance()
        {
            string s;
            input(); //вставляємо функції вводу з класу орагнізацій, щоб не повторювати питання
            Console.Write("Введіть тип страховки: ");
            typeinsurance = Console.ReadLine();
            Console.Write("Введіть кількість клієнтів: ");
            s = Console.ReadLine();
            clients = Convert.ToInt32(s);
            Console.Write("Введіть річний оборот: ");
            s = Console.ReadLine();
            yearlymoney = Convert.ToDouble(s);            

        }

        //функції виводу інформації по страховим компаніям
        public void output_insurance()
        {
            output();
            Console.WriteLine("Тип страховки: " + typeinsurance);
            Console.WriteLine("Кількість клієнтів: " + clients);
            Console.WriteLine("Річний оборот: " + yearlymoney);
        }

    }

    //клас суднобудівних компаній
    class shipbuilding : organisations
    {
        string shiptype;
        int count;
        int vodosmth;


        //функція вводу даних про судобудівні компанії
        public void input_shipbuilding()
        {
            input();
            Console.Write("Введіть тип судна: ");
            shiptype = Console.ReadLine();
            Console.Write("Введіть кількість суден: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть водотоннажність: ");
            vodosmth = Convert.ToInt32(Console.ReadLine());
        }

        //функція виведення даних про судобудівні компанії
        public void output_shipbuilding()
        {
            output(); //виклик функції виводу з класу організацій, щоб не повторювати питання
            Console.WriteLine("Тип судна: " + shiptype);
            Console.WriteLine("Кількість суден: " + count);
            Console.WriteLine("Водотоннажність: " + vodosmth);
        }

    }

    //клас заводів
    class factory: organisations
    {
        string typeproduction;
        int countz;

        public void input_factory()
        {
            input();
            Console.Write("Введіть тип продукції: ");
            typeproduction = Console.ReadLine();
            Console.Write("Введіть кількість виробничих цехів: ");
            countz = Convert.ToInt32(Console.ReadLine());
        }

        public void output_factory()
        {
            output();
            Console.WriteLine("Тип продукції: " + typeproduction);
            Console.WriteLine("Кількість виробничих цехів: " + countz);
        }
    }

    //основний клас
    class Program
    {

        //головна функція Main()
        public static void Main(string[] args)
        {
            string choice;
            Console.Write("Що ви хочете додати? 1 - Організацію, 2 - Страхову компанію, 3 - Суднобудівна компанія, 4 - Завод : ");
            choice = Console.ReadLine();


            //switch case для кожного варіанту
            switch (choice)
            {
                case "1":
                {
                    //питаємо розмір масиву
                    Console.Write("Введіть кількість організацій ви хочете додати: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    organisations[] organisation = new organisations[n];

                    //по кожному елементу заповнюємо інформацію та виводимо на екран
                    for(int i = 0; i < organisation.Length; i++)
                    {
                        organisation[i] = new organisations();
                        organisation[i].input();
                        Console.WriteLine("Організація {0}: ", i + 1);  
                        organisation[i].output();  
                    }  
                    break;   
                }

                case "2":
                {
                    //питаємо розмір масиву
                    Console.Write("Введіть кількість страхових компаній ви хочете додати: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    insurance[] ins = new insurance[n];

                    //по кожному елементу заповнюємо інформацію та виводимо на екран
                    for(int i = 0; i < ins.Length; i++)
                    {
                        ins[i] = new insurance();
                        ins[i].input_insurance();
                        Console.WriteLine("Організація {0}: ", i + 1);  
                        ins[i].output_insurance();  
                    }  
                    break;    
                }

                case "3":
                {
                    //питаємо розмір масиву
                    Console.Write("Введіть кількість суднобудівних компаній ви хочете додати: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    shipbuilding[] ship = new shipbuilding[n];

                    //по кожному елементу заповнюємо інформацію та виводимо на екран
                    for(int i = 0; i < ship.Length; i++)
                    {
                        ship[i] = new shipbuilding();
                        ship[i].input_shipbuilding();
                        Console.WriteLine("Суднобудівна компанія {0}: ", i + 1);
                        ship[i].output_shipbuilding();
                    }
                    break;
                }

                case "4":
                {
                    //питаємо розмір масиву
                    Console.Write("Введіть кількість заводів ви хочете додати: ");
                    int n = Convert.ToInt32(Console.ReadLine());    
                    factory[] fac = new factory[n];

                    //по кожному елементу заповнюємо інформацію та виводимо на екран
                    for(int i = 0; i < fac.Length; i++)
                    {
                        fac[i] = new factory();
                        fac[i].input_factory();
                        Console.WriteLine("Завод {0}: ", i + 1);
                        fac[i].output_factory();
                    }

                    break;
                }

                //якщо ніякий з варіантів не було обрано, виходимо з програми
                default:
                {
                    Console.WriteLine("Такої опції немає. Закриття програми...");
                    break;
                }
            }
        }
    }

}
