using System;

namespace Sports
{
    //базовий клас
    class Sport
    {

        //вводимо змінні
        protected int people;
        double expenses;
        double protection;
        protected double cost;

        //функція вводу
        public virtual void input()
        {
            Console.Write("\n\nHow many people play the sport?: ");
            people = Convert.ToInt32(Console.ReadLine());
            Console.Write("How much equipment costs?: ");
            expenses = Convert.ToDouble(Console.ReadLine());
            Console.Write("How much protection costs?: ");
            protection = Convert.ToDouble(Console.ReadLine());
        }

        //функція розрахунку затрат
        public virtual void costs()
            {
                cost = people * (expenses + protection);
                Console.Write("\nEstimated cost is {0}", cost);
            }
    }
    class volleyball : Sport
    {
        double kneepads;
        double anklebraces;
        double asep;
        double ball;
        double hmballs;

        //функція вводу
        public override void input()
        {
            Console.Write("\n\nHow many people play the sport?: ");
            people = Convert.ToInt32(Console.ReadLine());
            Console.Write("How much anklebraces cost?: ");
            anklebraces = Convert.ToDouble(Console.ReadLine());
            Console.Write("How much arm sleeves and elbow pads cost?: ");
            asep = Convert.ToDouble(Console.ReadLine());
            Console.Write("How much kneepads cost?: ");
            kneepads = Convert.ToDouble(Console.ReadLine());
            Console.Write("How much a ball costs?: ");
            ball = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many balls do you need?: ");
            hmballs = Convert.ToDouble(Console.ReadLine());
        }

        //функція затрат за волейбол
        public override void costs()
        {
            cost = (people * (anklebraces + asep + kneepads)) + (ball * hmballs);
            Console.Write("\nEstimated cost is {0}", cost);
        }
    }

    class badminton: Sport
    {
        double kneebraces;
        double anklesleeves;
        double wristbands;
        double rackets;

        public override void input()
        {
        Console.Write("\n\nHow many people play the sport?: ");
        people = Convert.ToInt32(Console.ReadLine());
        Console.Write("How much kneebraces cost?: ");
        kneebraces = Convert.ToDouble(Console.ReadLine());
        Console.Write("How much anklesleeves cost?: ");
        anklesleeves = Convert.ToDouble(Console.ReadLine());
        Console.Write("How much wristbands cost?: ");
        wristbands = Convert.ToDouble(Console.ReadLine());
        Console.Write("How much a racket costs?: ");
        rackets = Convert.ToDouble(Console.ReadLine());
        }

        //функція затрат по бадмінтону
        public override void costs()
        {
            cost = people * (kneebraces + anklesleeves + wristbands + rackets);
            Console.Write("\nEstimated cost is {0}", cost);
        }

    }

    class Program
    {
        static void Main()
        {
            //даємо варіанти дій
            Console.Write("Cost of what do you want to count? 1 - Any sport, 2 - Volleyball, 3 - Badminton: "); 
            string choice = Console.ReadLine();

            //по кожному з варіанту дій викликаємо функції
            switch (choice)
            {
                case "1":
                {
                    Sport sportt = new Sport();
                    sportt.input();
                    sportt.costs();
                    break;
                }

                case "2":
                {
                    volleyball volley = new volleyball();
                    volley.input();
                    volley.costs();
                    break;
                }

                case "3":
                {
                    badminton badm = new badminton();
                    badm.input();
                    badm.costs();
                    break;
                }
            }
        }
    }
}
