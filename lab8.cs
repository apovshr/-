using System;

namespace KP
{
    //клас собак
    class Dogs
    {
        //змінні
        string breed;
        string sex;
        int age;
        string nickname;
        double price;
        public bool search = false;

        //функція вводу даних про собаку
        public void input()
        {
            Console.Write("Введіть породу собаки: ");
            breed = Console.ReadLine().ToLower();
            Console.Write("Введіть стать собаки: ");
            sex = Console.ReadLine().ToLower();
            Console.Write("Ввведть вік собаки: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кличку собаки: ");
            nickname = Console.ReadLine().ToLower();
            Console.Write("Введіть ціну собаки: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        //функція виводу даних про собак
        public void output()
        {
            Console.WriteLine("Порода: " + breed);
            Console.WriteLine("Стать: " + sex);
            Console.WriteLine("Вік: " + age);
            Console.WriteLine("Кличка: " + nickname);
            Console.WriteLine("Ціна: " + price);
        }

        //функція пошуку по заданим параметрам
        public bool searching(string dbreed, string dsex, int dage, double dprice)
        {
            if(breed == dbreed && sex == dsex && age <= dage && price <= dprice)
            {
                search = true;
            }
            else
            {
                search = false;
            }
            return search;
        }
    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Заповнення даних про собак");
        
            Console.Write("Скільки записів ви хочете додати?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Dogs[] dog = new Dogs[n];

            //функція для заповення кожної собаки
            for(int i = 0; i < dog.Length; i++)
            {
                dog[i] = new Dogs();
                Console.WriteLine("\n\nСобака {0}: ", i + 1);
                dog[i].input();
            }
                    
            //змінні для пошуку
            string dbreed, dsex;
            int dage;
            double dprice;

            //заповнюємо змінні для пошуку
            Console.WriteLine("\n\n\nЗаповніть дані для пошуку");
            Console.Write("Порода: ");
            dbreed = Console.ReadLine().ToLower();
            Console.Write("Стать: ");
            dsex = Console.ReadLine().ToLower();
            Console.Write("Максимальний вік: ");
            dage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Максимальна ціна: ");
            dprice = Convert.ToDouble(Console.ReadLine());

            //функція для виклику пошуку та виводу на екран результатів
            for(int i = 0; i < dog.Length; i++)
            {
                dog[i].searching(dbreed, dsex, dage, dprice);

                if (dog[i].search)
                {
                    Console.WriteLine("\n\nСобака {0} відповідає заданим параметрами!! Детальніше: ", i + 1);
                    dog[i].output();
                }
                else
                {
                    Console.WriteLine("\n\nСобака {0} не відповідає заданим параметрам", i + 1);
                }
            }
        }
    }
}
