using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1, input2 ,division ;
           
            Console.WriteLine("Birinci sayiyi girin:");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi girin:");
            input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bölmek istediğiniz sayiyi girin:");
            division = Convert.ToInt32(Console.ReadLine());

            int max,min;
           
            if(input2>=input1)
            {
                max = input2;
                min = input1;
            }
            else 
            {
                max = input1;
                min = input2;
            }

            int sum = 0;

            for(int i=min; i<=max; i++)
            {
     
                if(i%division==0)
                {
                    sum =sum+i; 
                }
            }


            Console.Write("Sonuç:");
            Console.WriteLine(sum.ToString());
            Console.ReadLine();
            }
        
        }

    }

