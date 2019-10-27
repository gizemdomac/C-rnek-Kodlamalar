using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizideki eleman sayisini girin:");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[boyut];

            for (int i = 0; i <Math.Pow(2,boyut); i++)
            {
                Console.Write(i + ".elemanı giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            string s = "";
            int max = 0;
            int ara_deger;

            for (int i = 0; i < boyut; i++)
            {
                int b = i;
               
                s = "(";
                ara_deger = 0;
                int sum = 0;
                for (int j = 0; j < boyut; j++)
                {
                    
                    if ((b & 1) == 1)
                    {
                        if (j - ara_deger > 1)
                        {
                            s += dizi[j].ToString() + ",";
                            sum = sum + dizi[j];
                            ara_deger = j;
                        }
                    
                    }
                    b = b >> 1;
                }
                
                s += "),  ";
                Console.Write(s+"=>");
                Console.WriteLine(sum.ToString());

                if(max<sum)
                {
                    max = sum;
                }
            }
            Console.Write("En büyük toplam:");
            Console.WriteLine(max.ToString());



            Console.ReadLine();

        }
    }
}
