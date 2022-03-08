using System;

namespace cok_boyutlu_diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÇOK BOYUTLU DİZİLER
            /*
            int[,] matris = new int[5, 5];
            matris[0, 0] = 10;
            matris[0, 4] = 20;
            matris[4, 0] = 30;
            matris[4, 4] = 40;
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write(matris[i,j]+" ");
                }
                Console.WriteLine();//içerdeki dngü tamamlanınca dışarı çıkar.
            }
            */
            //aşağıdaki çıktıyı veren matrisi döngü ile yazınız.
            /*
            2 0 0 0 2
            1 0 0 0 1
            2 0 0 0 2
            1 0 0 0 1
            2 0 0 0 2
            */
            /*  int[,] matris = new int[5, 5];
              for (int satir=0;satir<5;satir++)
              {
                  for(int sutun=0;sutun<5;sutun++)
                  {
                      if (satir % 2 == 0 && (sutun == 0 || sutun == 4))
                          matris[satir, sutun] = 2;
                      else if (satir % 2 == 1 && (sutun == 0 || sutun == 4))
                          matris[satir, sutun] = 1;                   
                      else
                          matris[satir, sutun] = 3; // aralarına 3 yazdırır.
                      matris[satir, 2] = 0;
                  }
              }
              //matris[2, 2] = 0;
              for (int i = 0; i < 5; i++)
              {
                  for (int j = 0; j < 5; j++)
                  {
                      Console.Write(matris[i, j] + " ");
                  }
                  Console.WriteLine();
              }
             */   /* 1 0 0 0 0
                   * 0 1 0 0 0
                   * 0 0 1 0 0
                   * 0 0 0 1 0
                   * 0 0 0 0 1*/

            /*  int[,] matris = new int[5, 5];
              for (int satir = 0; satir < 5; satir++)
              {
                  for (int sutun = 0; sutun < 5; sutun++)
                  {
                      if (satir==sutun)
                          matris[satir, sutun] = 1;

                  }
              }

              for (int i = 0; i < 5; i++)
              {
                  for (int j = 0; j < 5; j++)
                  {
                      Console.Write(matris[i, j] + " ");
                  }
                  Console.WriteLine();
              }
            */
            //çarpraz yapma
            /*
            int[,] matris = new int[5, 5];
            for (int satir = 0; satir < 5; satir++)
            {
                for (int sutun = 0; sutun < 5; sutun++)
                {
                    if (satir == sutun || satir + sutun == 4)
                        matris[satir, sutun] = 1;

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            */


            //2x3 tüm elemanları 5 olacak
            /*
                        int[,] matris = new int[2, 3];
                        for (int satir = 0; satir < 2; satir++)
                        {
                            for (int sutun = 0; sutun < 3; sutun++)
                            {

                                    matris[satir, sutun] = 5;
                                Console.Write(matris[satir,sutun]+" ");
                            }
                            Console.WriteLine("");
                        }
            */
            //2x4 lük dizi tanımla her eleman klavyeden alınacak.
            /*int[,] matris = new int[2, 4];
            int sutun;
            for (int satir = 0; satir < 2; satir++)
            {
                for (sutun = 0; sutun < 4; sutun++)
                {
                    Console.WriteLine("sayı : ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    matris[satir, sutun] = sayi;
                   
                }
                Console.WriteLine("\n");

            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();

            }

*/
            //2x4 matris, her satırın son değeri hariç kalvyeden alınacak. son kolon satırdaki sayıların toplamını yazsın.
            /* 1 2 3 6
             * 4 5 6 15
             */
            /*int[,] matris = new int[2, 4];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {//if kaldırılırsa for içindeki 4 değeri azaltılarask 3 olur.
                    //if (j != 3)
                   // {
                        Console.WriteLine("sayı: ");
                        matris[i, j] = int.Parse(Console.ReadLine());
                   // }
                }
            }
            int satirtop;
            for (int i = 0; i < 2; i++)
            {
                satirtop = 0;
                for (int j = 0; j < 4; j++)
                {
                    satirtop += matris[i, j];
                }
                matris[i, 3] = satirtop;
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            //tek blokta yapamak için 
            /*
            int[,] dizi2 = new int[2, 4];
            for (int i = 0; i < 2; i++)
            {
                int satirToplam = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (j < 3)
                    {
                        Console.WriteLine("Sayı=");
                        dizi2[i, j] = int.Parse(Console.ReadLine());
                        satirToplam += dizi2[i, j];
                    }
                    else
                        dizi2[i, 3] = satirToplam;

                }
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(dizi2[i, j] + " ");
                }
                Console.WriteLine();
            }


            */
            // 3 BOYUTLU DİZİLER

            int[,,] dizi3b = new int[2, 3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        dizi3b[i, j, k] = rnd.Next(1, 1001);
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        dizi3b[i, j, k] = rnd.Next(1, 1001);
                        Console.Write(dizi3b[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("****************************");
                Console.WriteLine("****************************");
            }














        }

    }
}
