using System;

namespace Lab11
{
    //клас лайнер
    class liner
    {
        string mark;
        int passengers;
        double speed;
        double price;


        //функція вводу
        public void input()
        {
            Console.Write("Введіть марку лайнера: ");
            mark = Console.ReadLine();
            Console.Write("Введіть кількість пасажирів: ");
            passengers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть швидкість: ");
            speed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть ціну: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
        }

        //функція виводу
        public void output(string name)
        {
            Console.WriteLine("Лайнер {0}", name);
            Console.WriteLine("Марка: " + mark);
            Console.WriteLine("Пасажири: " + passengers);
            Console.WriteLine("Швидкість: " + speed);
            Console.WriteLine("Ціна: " + price);
        }

        //перевантаження оператору ==
        public static bool operator ==(liner a, liner b)
        {
            if (a.mark == b.mark && a.passengers == b.passengers && a.speed == b.speed && a.price == b.price)
                return true;
            else
                return false;
        }

        //перевантаження оператору != (пари для ==)
        public static bool operator !=(liner a, liner b)
        {
             if (a.mark != b.mark || a.passengers != b.passengers || a.speed != b.speed || a.price != b.price)
                return true;
            else
                return false;
        }

        //перевантаження оператору >
        public static bool operator >(liner a, liner b)
        {
            if (a.passengers > b.passengers)
                return true;
            else
                return false;
        }

        //перевантаження оператору < (пари для >)
        public static bool operator <(liner a, liner b)
        {
            if (a.passengers < b.passengers)
                return true;
            else 
                return false;
        }

        //перевантаження оператору +
        public static liner operator +(liner a, liner b)
        {
            liner c = new liner();
            c.mark = "не визначено";
            c.passengers = a.passengers + b.passengers;
            c.speed = 0.0;
            c.price = 0.0;
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            liner[] liners = new liner[3]; // зробимо три лайнера

            for (int i = 0; i < liners.Length; i++)
            {
                liners[i] = new liner();
                liners[i].input();

                // порівняння попереднього і поточного
                if (i > 0) 
                {
                    if (liners[i] == liners[i-1])
                        Console.WriteLine("Лайнер {0} має ті ж характеристики, що і попередній\n", i+1);
                    else
                        Console.WriteLine("Лайнер {0} відрізняється від попереднього по характеристикам\n", i+1);

                    if (liners[i] > liners[i-1])
                        Console.WriteLine("\nЛайнер {0} має більше пасажирів ніж лайнер {1}\n\n", i+1, i);
                    else if (liners[i] < liners[i-1])
                        Console.WriteLine("\nЛайнер {0} має менше пасажирів ніж лайнер {1}\n\n", i+1, i);
                    else
                        Console.WriteLine("Лайнер {0} та лайнер {1} мають однакову кількість пасажирів\n\n", i+1, i);
                }
            }

            //новий лайнер з сумою пасажирів
            liner passsum = liners[1] + liners[0];
            passsum.output("з сумою пасажирів першого та другого: "); //виводимо дані про лайнер на екран

            //порівняння кількості пасажирів на обох лайнерах

        }
    }
}
