﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtv_metot
{
    class Program
    {
        public static double tutar { get; set; }
        

        public static double Secim1(int s1)
        {
            if (s1 == 1)
            {
               return tutar = 100;
            }
            else if(s1 == 2)
            {
                return tutar = 150;
            }
            else
            {
                return 0;
            }
        }

        public static double Secim2(int s2)
        {

            if (s2 == 1)
            {
                return tutar = tutar * 1.75 ;

            }
            else if (s2 == 2)
            {
                return tutar = tutar * 1.50 ;
            }
            else if (s2 == 3)
            {
                return tutar = tutar * 1.25 ;
            }
            else
            {
                Console.WriteLine("yanlış seçim yaptınız.");
                return tutar = 0;
            }

        }
        public static double Secim3(int s3)
        {
            if (s3 == 1)
            {
                return tutar = tutar * 2;

            }
            else if (s3 == 2)
            {
                return tutar = tutar * 3;
            }
            else if (s3 == 3)
            {
                return tutar = tutar* 4;

            }
            else if (s3 == 4)
            {
                return tutar = tutar * 5;
            }
            else
            {
                Console.WriteLine("yanlış seçim yaptınız!!");
                return tutar = 0;

            }

        }
        static void Main(string[] args)
        {

            double TopTutar = 0;
            int secim1, secim2, secim3;
            Console.WriteLine("araç türünü girin: ");
            Console.WriteLine("1- binek araç");
            Console.WriteLine("2- ticari araç");
            secim1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("araç yaşını girin lütfen: ");
            Console.WriteLine("1 numara: 1-3 yaş arası");
            Console.WriteLine("2 numara: 4-7 yaş arası");
            Console.WriteLine("3 numara: 7 yaş üstü");
            Console.WriteLine("lütfen 1-2-3 numaralardan birini seçerek işlem yapınız!");
            secim2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("motor hacmini numaralara göre seçiniz.");
            Console.WriteLine("(1) 0-1300cc arası motor hacmi");
            Console.WriteLine("(2) 1300-1600cc arası motor hacmi");
            Console.WriteLine("(3) 1600-2000cc arası motor hacmi");
            Console.WriteLine("(4) 2000cc ve yukarısı motor hacmi ");
            secim3 = Convert.ToInt32(Console.ReadLine());
            Secim1(secim1);
            Secim2(secim2);
            Secim3(secim3);
            TopTutar = Secim1(secim1) + Secim2(secim2) + Secim3(secim3);
            Console.WriteLine("toplam tutar:{0}",TopTutar);
            
            Console.ReadLine();
        }
    }
}
