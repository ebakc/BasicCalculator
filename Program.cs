using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        public static int choice;
        static void Main(string[] args)
        {
            Console.Title = "Dil Seçimi/Language Selection - TR/ENG";
            int dilSecimi = 0;
            bool dilSecimiDogruMu=false;
            while (!dilSecimiDogruMu)
            {
                Console.Clear();
                Console.Write("Lütfen bir dil seçiniz. / Please select a language.\n1. Türkçe\n2. English\n\nSeçiminiz / Your Choice: ");
                try
                {
                    dilSecimi = Convert.ToInt16(Console.ReadLine());
                    if (dilSecimi >= 1 && dilSecimi <= 2)
                    {
                        dilSecimiDogruMu = true;
                        switch (dilSecimi)
                        {
                            case 1:
                                {
                                    bool devamEt = true;
                                    while (devamEt)
                                    {
                                        menuTR();
                                        islemlerTR();
                                        Console.Write("Başka bir hesaplama yapmak istiyor musun? (E/H): ");
                                        string cevap = Console.ReadLine().ToUpper();
                                        if (cevap != "E") devamEt = false;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    bool devamEt = true;
                                    while (devamEt)
                                    {
                                        menuENG();
                                        islemlerENG();
                                        Console.Write("Do you want to perform another calculation? (Y/N): ");
                                        string cevap = Console.ReadLine().ToUpper();
                                        if (cevap != "Y") devamEt = false;

                                    }
                                    break;
                                }
                        }
                    }
                    else
                    {
                        dilSecimiDogruMu = false;
                        Console.WriteLine("(TR)  Geçersiz sayı. Lütfen 1 ila 2 arasında bir sayı giriniz.");
                        Console.WriteLine("(ENG) Invalid selection. Please select a number in the range 1 to 2.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.WriteLine("(TR)  Geçersiz giriş. Lütfen bir sayı giriniz.");
                    Console.WriteLine("(ENG) Invalid input. Please enter a number.");
                    Console.ReadKey();
                }
            }
                
                
        }
        static void menuENG()  //Hangi işlemi yaptıracağımızı seçtiriyoruz.
        {
            Console.Title = "Calculator - ebakc";
            bool secimDogruMu = false;
            while (!secimDogruMu)
            {
                Console.Clear();
                Console.Write("Basic Calculator - github.com/ebakc\n\nPlease select the operator you would like to use.\n1. Add(+)\n2. Subtract(-)\n3. Multiply(x)\n4. Divide(/)\n\nYour Choice: ");
                try
                {
                    choice = Convert.ToInt16(Console.ReadLine());
                    if (choice >= 1 && choice <= 4)
                    {
                        secimDogruMu = true;
                        switch (choice)
                        {
                            case 1: Console.Write("You selected Add(+)"); break;
                            case 2: Console.Write("You selected Subtract(-)"); break;
                            case 3: Console.Write("You selected Multiply(x)"); break;
                            case 4: Console.Write("You selected Divide(/)"); break;
                        }
                    }
                    else
                    {
                        secimDogruMu = false;
                        Console.WriteLine("Invalid selection. Please select a number in the range 1 to 4.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void islemlerENG()  //Hangi iki sayı için işlem yaptırtacağımızı seçtiriyoruz.
        {
            double x = 0, y = 0, result = 0;
            bool secimDogruMuX=false, secimDogruMuY=false;
            while (!secimDogruMuX)
            {
                Console.Clear();
                Console.Write("Select the first number: ");
                try
                {
                    secimDogruMuX = true;
                    x = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    secimDogruMuX = false;
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ReadKey();
                }
            }
            while (!secimDogruMuY)
            {
                Console.Write("Select the second number: ");
                try
                {
                    secimDogruMuY=true;
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    secimDogruMuY = false;
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ReadKey();
                }
            }
            switch (choice)
            {
                case 1: result = x + y; break;
                case 2: result = x - y; break;
                case 3: result = x * y; break;
                case 4:
                    if (y != 0) result = x / y;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"First Number: {x} & Second Number: {y}");
                        Console.WriteLine("Cannot divide by zero."); return;
                    }
                    break;
            }
            Console.Clear();
            Console.WriteLine($"First Number: {x} & Second Number: {y}\nResult: {result}");
        }

        //--------------------TÜRKÇE DİL---------------------------------
        static void menuTR()  //Hangi işlemi yaptıracağımızı seçtiriyoruz.
        {
            Console.Title = "Hesap Makinesi - ebakc";
            bool secimDogruMu = false;
            while (!secimDogruMu)
            {
                Console.Clear();
                Console.Write("Temel Hesap Makinesi - github.com/ebakc\n\nKullanmak istediğiniz operatörü seçiniz.\n1. Toplama(+)\n2. Çıkarma(-)\n3. Çarpma(x)\n4. Bölme(/)\n\nSeçiminiz: ");
                try
                {
                    choice = Convert.ToInt16(Console.ReadLine());
                    if (choice >= 1 && choice <= 4)
                    {
                        secimDogruMu = true;
                        switch (choice)
                        {
                            case 1: Console.Write("Toplama(+) seçtiniz."); break;
                            case 2: Console.Write("Çıkarma(-) seçtiniz."); break;
                            case 3: Console.Write("Çarpma(x) seçtiniz."); break;
                            case 4: Console.Write("Bölme(/) seçtiniz."); break;
                        }
                    }
                    else
                    {
                        secimDogruMu = false;
                        Console.WriteLine("Geçersiz sayı. Lütfen 1 ila 4 arasında bir sayı giriniz.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void islemlerTR()  //Hangi iki sayı için işlem yaptırtacağımızı seçtiriyoruz.
        {
            double x = 0, y = 0, result = 0;
            bool secimDogruMuX = false, secimDogruMuY = false;
            while (!secimDogruMuX)
            {
                Console.Clear();
                Console.Write("İlk sayıyı giriniz: ");
                try
                {
                    secimDogruMuX = true;
                    x = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    secimDogruMuX = false;
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                    Console.ReadKey();
                }
            }
            while (!secimDogruMuY)
            {
                Console.Write("İkinci sayıyı giriniz: ");
                try
                {
                    secimDogruMuY = true;
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    secimDogruMuY = false;
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                    Console.ReadKey();
                }
            }
            switch (choice)
            {
                case 1: result = x + y; break;
                case 2: result = x - y; break;
                case 3: result = x * y; break;
                case 4:
                    if (y != 0) result = x / y;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"İlk sayı: {x} & İkinci sayı: {y}");
                        Console.WriteLine("Sıfıra bölme işlemi yapılamaz."); return;
                    }
                    break;
            }
            Console.Clear();
            Console.WriteLine($"İlk Sayı: {x} & İkinci Sayı: {y}\nSonuç: {result}");
        }
    }
}
