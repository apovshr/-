using System;

class Country
{
    //робимо усі потрібні змінні + булеан для показу правильних варіантів
    string name;
    int amountofppl;
    double size;
    string continent;
    bool option = false;

    //функція заповнення даними про країни
    public void input(int n)
    {
        string s;
        Console.Write("\n\nEnter a name of the country {0}: ", n + 1);
        name = Console.ReadLine();

        Console.Write("Enter amount of people in the country {0}: ", n + 1);
        s = Console.ReadLine();
        amountofppl = Convert.ToInt32(s);

        Console.Write("Enter the size of the country {0}: ", n + 1);
        s = Console.ReadLine();
        size = Convert.ToDouble(s);

        Console.Write("Enter a continatent where the country {0} is: ", n + 1);
        continent = Console.ReadLine();
    }

    //функція аналізу даних по країнам
    public void analysis(double desirablesize, string desirablecontinent)
    {
        if(size >= desirablesize && continent == desirablecontinent)
           option = true; 
    }

    //функція виведення результатів на екран
    public void output(int n)
    {
        if (option)
        {
            Console.WriteLine("\n\n\nCountry {0} has all objections needed!", n + 1);
            Console.WriteLine("Name: {0}, \nAmount of people: {1}, \nSize: {2}, \nContinent: {3}", name, amountofppl, size, continent);
        }
    }

} 

class Program
{
    static void Main()
    {
        //створюємо змінні для розміру масиву, а також для критеріїв пошуку
        int n; 
        string conv, desirablecontinent;
        double desirablesize;

        //просимо розмір масиву й створюємо його
        Console.Write("How many countries do you want to add? ");
        conv = Console.ReadLine();
        n = Convert.ToInt32(conv);
        Country[] countries = new Country[n]; 

        //заповнюємо масив
        for(int i = 0; i < countries.Length; i++)
        {
            countries[i] = new Country();
            countries[i].input(i);
        }
        
        //просимо критерії
        Console.Write("\n\n\nEnter a size: ");
        conv = Console.ReadLine();
        desirablesize = Convert.ToDouble(conv);

        Console.Write("Enter a continent: ");
        desirablecontinent = Console.ReadLine();

        //порівнюємо з кожною країною
        for (int i = 0; i < countries.Length; i++)
        {
          countries[i].analysis(desirablesize, desirablecontinent);
          countries[i].output(i); 
        } 

    }
}
