using System;
using System.IO;

namespace Lab12_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //відкриваємо файл для читання
            StreamReader sr = new StreamReader("/Users/nastyalytvynenko/Library/Mobile Documents/com~apple~CloudDocs/Downloads/Uni/Net Framework/лаб 12/lab 12/matrix.txt");
            
            //заповнюємо розміри матриць
            Console.Write("How many rows in matrix A?: ");
            int rowsa = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many columns in matrix A?: ");
            int columa = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many rows in matrix B?: ");
            int rowsb = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many columns in matrix B?: ");   
            int columsb = Convert.ToInt32(Console.ReadLine());

            //створюємо 2 матриці для множення і одну для результатів
            double[][] A = new double[rowsa][]; 
            double[][] B = new double[rowsb][];
            double[][] C = new double[rowsa][];

            //виводимо дані матриці А
            Console.WriteLine("Matrix A: ");

            for (int i = 0; i < rowsa; i++)
            {
                A[i] = new double[columa];
                string line = sr.ReadLine();
                string[] parts = line.Split(); 
                for (int j = 0; j < columa; j++)
                {
                    A[i][j] = double.Parse(parts[j]);  
                    Console.Write(A[i][j] + " ");
                }
                Console.WriteLine();
            }

            //Виводимо дані матриці В
            Console.WriteLine("\n\nMatrix B: ");
            for (int i = 0; i < rowsb; i++)
            {
                B[i] = new double[columsb];
                string line = sr.ReadLine();
                string[] parts = line.Split();  
                for (int j = 0; j < columsb; j++)
                {
                    B[i][j] = double.Parse(parts[j]);
                    Console.Write(B[i][j] + " ");
                }
                Console.WriteLine();
            }
            
            //закриваємо файл для читання
            sr.Close();

            Console.WriteLine("\n\nMatrix C: ");

            // Множення матриць
            for (int i = 0; i < rowsa; i++)
            {
                C[i] = new double[columsb];
                for (int j = 0; j < columsb; j++)
                {
                    C[i][j] = 0;
                    for (int k = 0; k < columa; k++)
                    {
                        C[i][j] += A[i][k] * B[k][j];
                        
                    }
                    Console.Write(C[i][j] + " "); 
                }
                Console.WriteLine();
            }
            
            
            // Запис результату у файл
            StreamWriter sw = new StreamWriter("/Users/nastyalytvynenko/Library/Mobile Documents/com~apple~CloudDocs/Downloads/Uni/Net Framework/лаб 12/lab 12/result.txt");
            for (int i = 0; i < rowsa; i++)
            {
                for (int j = 0; j < columsb; j++)
                    sw.Write(C[i][j] + " ");
                sw.WriteLine();
            }

            //закриваємо файл для запису
            sw.Close();
        } 
    }
}

