using System;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            //створюємо необхнідні змінні та два речення
            string sen1, sen2, combined, inserted, replaced, removed; 
            int comparedfull, comparedpartly, index;
            sen1 = "Hello! Today is wonderful day!";
            sen2 = "It is so sunny!";

            //виводимо речення на екран
            Console.WriteLine("Sentences: ");
            Console.WriteLine("Sentence 1: " + sen1);
            Console.WriteLine("Sentence 2: " + sen2);

            //Об'єднуємо два рядки
            Console.WriteLine("\n\nTwo sentences in one: ");
            combined = string.Concat(sen1, sen2);
            Console.Write(combined);

            //Вставлення рядків
            inserted = sen1.Insert(7, sen2);
            Console.WriteLine("\n\nInserted version: ");
            Console.Write(inserted);

            //Заміна рядків
            replaced = sen1.Replace("wonderful", "sunny");
            Console.WriteLine("\n\nReplaced verison: ");
            Console.Write(replaced);

            //Вилучення рядків
            removed = sen1.Remove(26, 4);
            Console.WriteLine("\n\nSentence 1 after deletion of the last word: ");
            Console.Write(removed);

            //Порівняння двох рядків
            comparedfull = sen1.CompareTo(sen2);
            Console.WriteLine("\n\nComparing two sentences... ");

            if (comparedfull == 0)
                Console.WriteLine("Two sentences are the same!");
            else if (comparedfull < 0)
                Console.WriteLine("Sentence 1 is comes before sentence 2");
            else
                Console.WriteLine("Sentence 2 is comes before sentence 1");
            
            
            //Порівняння символів із двох рядків, які знаходяться на певних місцях
            comparedpartly = string.Compare(sen1, 7, sen2, 3, 12);

            Console.WriteLine("\n\nComparing parts of two sentences... ");

            if (comparedpartly == 0)
                Console.WriteLine("Two sentences are the same!");
            else if (comparedpartly < 0)
                Console.WriteLine("Sentence 1 is shorter than sentence 2");
            else
                Console.WriteLine("Sentence 2 is shorter than sentence 1");

            //Визначення індексу першого входження заданого рядка в інший
            index = combined.IndexOf(sen2);
            Console.WriteLine("\n\nSearching for the first index of sentence 2 in sentence 1...");
            Console.WriteLine("Index of the first element from sentence 2 in sentence 1 = {0}", index);







        }
    }
}