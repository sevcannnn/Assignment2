using System;
using System.Collections.Generic;

namespace Sevcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-ci sual
            /*
            
            Dictionary<int, string> telebeler = new Dictionary<int, string>();

            telebeler.Add(1, "Ali");
            telebeler.Add(2, "Aysel");
            telebeler.Add(3, "Murad");
            telebeler.Add(4, "Leyla");
            telebeler.Add(5, "Kamran");

            int secim = 0;

            while (secim != 4)
            {
                Console.WriteLine("\nTelebe Qeydiyyat Sistemi");
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebeni ID ile axtar");
                Console.WriteLine("3. Butun telebeleri goster");
                Console.WriteLine("4. Cixis");
                Console.Write("Seciminizi daxil edin: ");

                if (!int.TryParse(Console.ReadLine(), out secim))
                {
                    Console.WriteLine("Duzgun secim daxil edin!");
                    secim = 0;
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        Console.Write("Telebenin ID-sini daxil edin: ");

                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("ID duzgun daxil edilmeyib!");
                            break;
                        }

                        Console.Write("Telebenin adini daxil edin: ");
                        string ad = Console.ReadLine();

                        if (!telebeler.ContainsKey(id))
                        {
                            telebeler.Add(id, ad);
                            Console.WriteLine("Telebe elave edildi!");
                        }
                        else
                        {
                            Console.WriteLine("Bu ID artiq movcuddur!");
                        }
                        break;

                    case 2:
                        Console.Write("Telebenin ID-sini daxil edin: ");

                        if (!int.TryParse(Console.ReadLine(), out int axtarisId))
                        {
                            Console.WriteLine("ID duzgun daxil edilmeyib!");
                            break;
                        }

                        if (telebeler.TryGetValue(axtarisId, out string telebeAdi))
                        {
                            Console.WriteLine("Telebenin adi: " + telebeAdi);
                        }
                        else
                        {
                            Console.WriteLine("Telebe tapilmadi!");
                        }
                        break;

                    case 3:
                        foreach (var telebe in telebeler)
                        {
                            Console.WriteLine("ID: " + telebe.Key +
                                              " - Ad: " + telebe.Value);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Proqramdan cixilir!");
                        break;

                    default:
                        Console.WriteLine("Yanlis secim!");
                        break;
                }
            }
            */

            //2-ci sual
            /*
            Console.WriteLine("Hendesi Kalkulyator");
            Console.WriteLine("1. Daire");
            Console.WriteLine("2. Duzbucaqli");
            Console.WriteLine("3. Ucbucaq");
            Console.Write("Fiquru secin: ");

            if (!int.TryParse(Console.ReadLine(), out int secim))
            {
                Console.WriteLine("Duzgun secim daxil edin!");
                return;
            }

            switch (secim)
            {
                case 1:
                    Console.Write("Radiusu daxil edin: ");

                    if (!double.TryParse(Console.ReadLine(), out double radius)
                        || radius < 0)
                    {
                        Console.WriteLine("Radius duzgun deyil!");
                        break;
                    }

                    double daireSahesi = Math.PI * Math.Pow(radius, 2);

                    Console.WriteLine("Dairenin sahesi: " +
                        Math.Round(daireSahesi, 2));
                    break;

                case 2:
                    Console.Write("Eni daxil edin: ");

                    if (!double.TryParse(Console.ReadLine(), out double en)
                        || en < 0)
                    {
                        Console.WriteLine("En duzgun deyil!");
                        break;
                    }

                    Console.Write("Hundurluyu daxil edin: ");

                    if (!double.TryParse(Console.ReadLine(), out double hundurluk)
                        || hundurluk < 0)
                    {
                        Console.WriteLine("Hundurluk duzgun deyil!");
                        break;
                    }

                    double duzbucaqliSahesi = en * hundurluk;

                    Console.WriteLine("Duzbucaqlinin sahesi: " +
                        Math.Round(duzbucaqliSahesi, 2));
                    break;

                case 3:
                    Console.Write("Birinci terefi daxil edin: ");

                    if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0)
                    {
                        Console.WriteLine("Teref duzgun deyil!");
                        break;
                    }

                    Console.Write("Ikinci terefi daxil edin: ");

                    if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0)
                    {
                        Console.WriteLine("Teref duzgun deyil!");
                        break;
                    }

                    Console.Write("Ucuncu terefi daxil edin: ");

                    if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0)
                    {
                        Console.WriteLine("Teref duzgun deyil!");
                        break;
                    }

                    if (a + b <= c || a + c <= b || b + c <= a)
                    {
                        Console.WriteLine("Bu tereflerle ucbucaq yaratmaq olmaz!");
                        break;
                    }

                    double yarimPerimetr = (a + b + c) / 2;

                    double ucbucaqSahesi = Math.Sqrt(
                        yarimPerimetr *
                        (yarimPerimetr - a) *
                        (yarimPerimetr - b) *
                        (yarimPerimetr - c));

                    Console.WriteLine("Ucbucagin sahesi: " +
                        Math.Round(ucbucaqSahesi, 2));
                    break;

                default:
                    Console.WriteLine("Yanlis secim!");
                    break;
            }
            */

            //3-cu sual
            /*
            List<int> ededler = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + "-ci ededi daxil edin: ");

                if (!int.TryParse(Console.ReadLine(), out int eded))
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    i--;
                    continue;
                }

                ededler.Add(eded);
            }

            int enBoyuk = ededler[0];
            int enKicik = ededler[0];
            int cutSay = 0;
            int tekSay = 0;

            foreach (int eded in ededler)
            {
                enBoyuk = Math.Max(enBoyuk, eded);
                enKicik = Math.Min(enKicik, eded);

                if (eded % 2 == 0)
                {
                    cutSay++;
                }
                else
                {
                    tekSay++;
                }
            }

            Console.WriteLine("\nEn boyuk eded: " + enBoyuk);
            Console.WriteLine("En kicik eded: " + enKicik);
            Console.WriteLine("Cut ededlerin sayi: " + cutSay);
            Console.WriteLine("Tek ededlerin sayi: " + tekSay);
            */

            //4-cu sual
            /*
            Random tesadufi = new Random();

            int gizliEded = tesadufi.Next(0, 101);
            int texmin;

            do
            {
                Console.Write("0-100 arasinda eded texmin edin: ");

                if (!int.TryParse(Console.ReadLine(), out texmin))
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    continue;
                }

                if (texmin < 0 || texmin > 100)
                {
                    Console.WriteLine("Eded 0 ile 100 arasinda olmalidir!");
                }
                else if (texmin > gizliEded)
                {
                    Console.WriteLine("Daha kicik eded cehd edin!");
                }
                else if (texmin < gizliEded)
                {
                    Console.WriteLine("Daha boyuk eded cehd edin!");
                }
                else
                {
                    Console.WriteLine("Tebrikler! Ededi tapdiniz!");
                }

            } while (texmin != gizliEded);
            */

            Console.WriteLine("Proqrami bitirmek ucun duymeni basin...");
            Console.ReadKey();
        }
    }
}