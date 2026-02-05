using System;

namespace Sports
{
    //абстрактний клас
    abstract class Sport
    {

        //вводимо змінні
        protected int people;
        double expenses;
        double protection;
        protected double cost;

        //абстрактна функція вводу
        public abstract void input();

        //абстрактна функція розрахунку затрат
        public abstract void costs();
    }
    class volleyball : Sport
    {
        double kneepads;
        double anklebraces;
        double asep;
        double ball;
        double hmballs;

        //перевизначена функція вводу
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

        //перевизначена функція затрат за волейбол
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

        //функція вводу по бадмінтону
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
            Console.Write("Cost of what do you want to count? 1 - Volleyball, 2 - Badminton: "); 
            string choice = Console.ReadLine();

            Sport sport;

            //по кожному з варіанту дій викликаємо потрібний клас
            if (choice == "1")
                sport = new volleyball();
            else if (choice == "2")
                sport = new badminton();
            else
            {
                Console.WriteLine("Такої опції не існує...");
                return;
            }
            // виклик функцій вводу та виводу
            sport.input();
            sport.costs();
        }
    }
}
