using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kutu = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] kullanilanDegerler = new string[9];
            string oyuncuAdi = "";
            bool oyunDurumu = false;

            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("1.Oyuncu(X) - 2.Oyuncu(O) \n");

            Console.WriteLine(" {0} | {1} | {2}", kutu[0], kutu[1], kutu[2]);
            Console.WriteLine("------------");
            Console.WriteLine(" {0} | {1} | {2}", kutu[3], kutu[4], kutu[5]);
            Console.WriteLine("------------");
            Console.WriteLine(" {0} | {1} | {2}", kutu[6], kutu[7], kutu[8] + "\n");

            Console.Write("ilk oyuncunun adini giriniz : ");
            string ilkOyunucuAdi = Console.ReadLine();
            Console.Write("ikinci oyuncunun adini giriniz : ");
            string ikinciOyuncuAdi = Console.ReadLine();

            int i = 1;
            bool sonucDurumu = true;
            while (i < 10 && sonucDurumu)
            {
                Console.Clear(); //Tablolar temizlenmesi icin kullanılır.
                Console.WriteLine("\nTic Tac Toe");
                Console.WriteLine("{0} (X) - {1} (O) \n", ilkOyunucuAdi, ikinciOyuncuAdi);

                Console.WriteLine(" {0} | {1} | {2}", kutu[0], kutu[1], kutu[2]);
                Console.WriteLine("------------");
                Console.WriteLine(" {0} | {1} | {2}", kutu[3], kutu[4], kutu[5]);
                Console.WriteLine("------------");
                Console.WriteLine(" {0} | {1} | {2}", kutu[6], kutu[7], kutu[8] + "\n");

                oyuncuAdi = ilkOyunucuAdi; //OyuncuAdi bulundu
                if (i % 2 == 0)
                    oyuncuAdi = ikinciOyuncuAdi;

                int deger = 0;
                bool dahaOnceKullanilmisMi = true;
                do
                {
                    bool degerKontrol = true;
                    do
                    {
                        Console.Write("{0} oyuncu değer giriniz (1-9): ", oyuncuAdi);
                        deger = Convert.ToInt32(Console.ReadLine());
                        if (deger > 0 && deger < 10)
                            degerKontrol = false;
                    } while (degerKontrol); //Sifirdan kücük yada Ondan büyük ise tekrar girisin!

                    int kontrol = Array.IndexOf(kullanilanDegerler, deger.ToString()); //daha once kullanilmis mi?
                    if (kontrol < 0)
                    {
                        kullanilanDegerler[i - 1] = deger.ToString();
                        dahaOnceKullanilmisMi = false;
                    }
                } while (dahaOnceKullanilmisMi);//Daha Once deger girilmis ise!

                string harf = "";
                if (oyuncuAdi == ilkOyunucuAdi)
                {
                    kutu[deger - 1] = "X";
                    harf = "X";
                }
                else
                {
                    kutu[deger - 1] = "O";
                    harf = "O";
                }


                switch (deger)
                {
                    case 1:
                        if (kutu[1] == harf && kutu[2] == harf)
                            oyunDurumu = true;
                        if (kutu[3] == harf && kutu[6] == harf)
                            oyunDurumu = true;
                        if (kutu[4] == harf && kutu[8] == harf)
                            oyunDurumu = true;
                        break;
                    case 2:
                        if (kutu[0] == harf && kutu[2] == harf)
                            oyunDurumu = true;
                        if (kutu[4] == harf && kutu[7] == harf)
                            oyunDurumu = true;
                        break;
                    case 3:
                        if (kutu[0] == harf && kutu[1] == harf)
                            oyunDurumu = true;
                        if (kutu[4] == harf && kutu[6] == harf)
                            oyunDurumu = true;
                        if (kutu[5] == harf && kutu[8] == harf)
                            oyunDurumu = true;
                        break;
                    case 4:
                        if (kutu[0] == harf && kutu[6] == harf)
                            oyunDurumu = true;
                        if (kutu[4] == harf && kutu[5] == harf)
                            oyunDurumu = true;
                        break;
                    case 5:
                        if (kutu[7] == harf && kutu[1] == harf)
                            oyunDurumu = true;
                        if (kutu[3] == harf && kutu[5] == harf)
                            oyunDurumu = true;
                        if (kutu[0] == harf && kutu[8] == harf)
                            oyunDurumu = true;
                        if (kutu[2] == harf && kutu[6] == harf)
                            oyunDurumu = true;
                        break;
                    case 6:
                        if (kutu[2] == harf && kutu[8] == harf)
                            oyunDurumu = true;
                        if (kutu[3] == harf && kutu[4] == harf)
                            oyunDurumu = true;
                        break;
                    case 7:
                        if (kutu[0] == harf && kutu[3] == harf)
                            oyunDurumu = true;
                        if (kutu[2] == harf && kutu[4] == harf)
                            oyunDurumu = true;
                        if (kutu[7] == harf && kutu[8] == harf)
                            oyunDurumu = true;
                        break;
                    case 8:
                        if (kutu[1] == harf && kutu[4] == harf)
                            oyunDurumu = true;
                        if (kutu[6] == harf && kutu[8] == harf)
                            oyunDurumu = true;
                        break;
                    case 9:
                        if (kutu[0] == harf && kutu[4] == harf)
                            oyunDurumu = true;
                        if (kutu[2] == harf && kutu[5] == harf)
                            oyunDurumu = true;
                        if (kutu[6] == harf && kutu[7] == harf)
                            oyunDurumu = true;
                        break;
                    default: break;
                }

                if (oyunDurumu == true)
                    sonucDurumu = false;

                i += 1;
            }

            Console.Clear(); //Tablolar temizlenmesi icin kullanılır.
            Console.WriteLine("\nTic Tac Toe");
            Console.WriteLine("{0} - {1} \n", ilkOyunucuAdi, ikinciOyuncuAdi);

            Console.WriteLine(" {0} | {1} | {2}", kutu[0], kutu[1], kutu[2]);
            Console.WriteLine("------------");
            Console.WriteLine(" {0} | {1} | {2}", kutu[3], kutu[4], kutu[5]);
            Console.WriteLine("------------");
            Console.WriteLine(" {0} | {1} | {2}", kutu[6], kutu[7], kutu[8] + "\n");

            if (oyunDurumu == true)
                Console.WriteLine("Oyunu Kazanan {0}", oyuncuAdi);
            else
                Console.WriteLine("Oyun Berabere Bitmiştir.");


            Console.ReadKey();
        }
    }
}
