using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegat_trans_func
{
    delegate double F1(double a);
    class Program
    {
        public void input(double[] x,  string q)
        {
            string s;
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Enter {0}[{1}]=", q, i);
                s = Console.ReadLine();
                x[i] = Convert.ToDouble(s);
            }
        }
        public void sum(double []x, F1 f1,F1 f2, out double A, out double B, out double W)
        {
            A = B = W = 0;
            for(int i=0;i<x.Length;i++)
            {
                W += x[i];
                if (x[i] <= 0)
                    A += x[i] * f1(x[i]);
                else
                    B += x[i] * f2(x[i]);
            }
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            int n, m;
            string s;
            Console.WriteLine("Enter n=");
            s = Console.ReadLine();
            n = Convert.ToInt32(s);
            Console.WriteLine("Enter m=");
            s = Console.ReadLine();
            m = Convert.ToInt32(s);
            double[] alfa = new double[n];
            double[] beta = new double[m];
            ob.input(alfa,  "alfa");
            ob.input(beta,"beta");
            double A , B , C , D , W , Q , denominator, gamma;
            ob.sum(alfa,Math.Sin,Math.Tan,out A,out B,out W);
            ob.sum(beta, Math.Cos, Math.Sin, out D, out C, out Q);
            denominator = Math.Sin(D) + Math.Sin(C);
            if (denominator != 0)
            {
                gamma = (A + B) / (denominator) + W * Q;
                Console.WriteLine("Gamma = {0}", gamma);
            }
            else
                Console.WriteLine("Division be zero");
        }
    }
}
