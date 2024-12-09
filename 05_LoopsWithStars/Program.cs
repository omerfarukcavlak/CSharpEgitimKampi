using System;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Üçgen

            //for(int i = 5; i >= 1; i--)
            // {
            //     for (int j = 1; j <= i; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }

            #endregion

            #region Dik ve Ters Dik üçgen beraber

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            //üst kısım
            //int satirSayisi = 5;
            //for (int i = 1; i <= satirSayisi; i++)
            //{
            //    for (int j = satirSayisi - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j <= 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            ////alt kısım

            //for (int i = satirSayisi - 1; i >= 1; i--)
            //{
            //    for (int j = satirSayisi - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j <= 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region Baklava Deseni


            //Console.Write("Satır sayısını girin: ");
            //int satirSayisi = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= satirSayisi / 2; i++)
            //{
            //    for (int j = i; j <= satirSayisi / 2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 2 * (i + 1) - 1; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            //for (int i = satirSayisi / 2 - 1; i >= 0; i--)
            //{
            //    for (int j = i; j <= satirSayisi / 2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 2 * (i + 1) - 1; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int satirSayisi = 5;
            //for (int i = 1; i <= satirSayisi; i++)
            //{
            //    //boşluklar
            //    for (int j = satirSayisi - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int satirSayisi = 5;
            //for (int i = satirSayisi; i >= 1; i--)
            //{
            //    //boşluklar
            //    for (int j = satirSayisi - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}
