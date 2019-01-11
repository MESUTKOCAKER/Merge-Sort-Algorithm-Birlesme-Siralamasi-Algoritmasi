using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Short_Algoritm_MSTKCKR
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] dizi = new int[50];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(0, dizi.Length);
                Console.Write(dizi[i] + " ");
            }

            Console.WriteLine("\n\n");
            dizi = new Program().mergeShort(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.ReadKey();
        }

        public int[] mergeShort(int[] dizi)
        {

            if (dizi.Length == 1)
                return dizi;

            int orta = dizi.Length / 2;
            int[] sol = new int[orta];
            int[] sag = new int[dizi.Length - sol.Length];

            int x = 0;
            //Console.WriteLine("\n");
            for (int i = 0; i < orta; i++)
            {
                sol[x] = dizi[i];
                //Console.Write(sol[x] + " ");
                x++;
            }

            x = 0;
            //Console.WriteLine("");
            for (int i = orta; i < dizi.Length; i++)
            {
                sag[x] = dizi[i];
                //Console.Write(sag[x] + " ");
                x++;
            }

            sol = mergeShort(sol);
            sag = mergeShort(sag);
            return birlestir(sol, sag);
        }
        public int[] birlestir(int[] sol, int[] sag)
        {
            int a = 0;
            int b = 0;
            int kontrol;
            int[] yeniDizi = new int[sol.Length + sag.Length];

            //Console.Write("\nYeni Dizi : ");
            for (int i = 0; i <yeniDizi.Length; i++)
            {
                if (a < sol.Length)
                {
                    if (b < sag.Length)
                    {
                        if (sol[a] < sag[b])
                        {
                            yeniDizi[i] = sol[a];
                            a++;
                        }
                        else
                        {
                            yeniDizi[i] = sag[b];
                            b++;
                        }
                    }
                    else
                    {
                        yeniDizi[i] = sol[a];
                        a++;
                    }
                }//solda eleman kalmadıysa
                else if (b < sag.Length)
                {
                    yeniDizi[i] = sag[b];
                    b++;
                }
                else
                {
                    return yeniDizi;
                }

                //Console.Write(yeniDizi[i] + " ");
            }//for bitimi
            return yeniDizi;
        }














    }
}
/*
         public int[] mergesort(int[] m)
        {

            int x = 0;
            int y = 0;
            int middle = m.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[middle];
            int[] result = new int[(m.Length)];

            if (m.Length <= 1)
            {
                return m;
            }
            Console.WriteLine("\n");
            for (int i = 0; i < middle; i++)
            {
                left[x] = m[i];
                Console.Write(left[x] + " ");
                x++;
            }
            Console.WriteLine("");
            for (int i = middle; i < m.Length; i++)
            {
                right[y] = m[i];
                Console.Write(right[x] + " ");
                y++;
            }
            left = mergesort(left);
            right = mergesort(right);
            result = merge(left, right);
            return result;
        }

        public int[] merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];

            int x = 0;
            int y = 0;
            int k = 0;

            while (left.Length > x && right.Length > y)
            {
                if (left[x] <= right[y])
                {
                    result[k] = left[x];
                    x++;
                    k++;
                }
                else
                {
                    result[k] = right[y];
                    y++;
                    k++;
                }
            }
            if (left.Length > x)
            {
                while (x < left.Length)
                {
                    result[k] = left[x];
                    x++;
                    k++;
                }
            }

            if (right.Length > y)
            {
                while (y < right.Length)
                {
                    result[k] = right[y];
                    y++;
                    k++;
                }
            }
            return result;
        }
     */
