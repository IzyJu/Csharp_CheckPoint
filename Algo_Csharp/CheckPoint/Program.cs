using System;
using System.Data;
using System.Globalization;

namespace CheckPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 10, 2, 12, 8, 0 };
            Console.WriteLine("Somme du tableau = " + SommeTableau(tab));
            Console.WriteLine("Moyenne du tableau = " + MoyenneTableau(tab));
            Console.Write("Tableau trié : ");
            Sort(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + ", ");
            }
        }

        static int SommeTableau(int[] monTableau)
        {
            int result = 0;
            for (int i = 0; i < monTableau.Length; i++)
            {
                result = result + monTableau[i];
            }
            return result;
        }

        static double MoyenneTableau(int[] monTableau)
        {
            double result;
            result = Convert.ToDouble(SommeTableau(monTableau)) / monTableau.Length;
            return result;
        }

        static int[] Sort(int[] monTableau)
        {
            for (int i = monTableau.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (monTableau[j - 1] > monTableau[j])
                    {
                        int temp = monTableau[j - 1];
                        monTableau[j - 1] = monTableau[j];
                        monTableau[j] = temp;
                    }
                }
            }
            return monTableau;
        }
    }
}
