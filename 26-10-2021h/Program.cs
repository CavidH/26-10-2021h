using System;

namespace _26_10_2021h
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Verilmiş n ədədinin son rəqəmini onun əvvəlinə gətirərək yeni bir ədəd düzəldin (misalçün daxil edilen ədəd 475 olarsa, geriye 547 qaytarsin)

            int inputm = 475;
            int reqemsayi = 0;
            int mertebe = 1;
            int sonreqem = inputm % 10;
            int ilkreqem = 0;

            int inputcopy = inputm;

            while (inputcopy >= 1 || inputcopy <= -1)
            {
                inputcopy /= 10;
                reqemsayi++;
            }
            for (int i = 1; i < reqemsayi; i++)
            {
                mertebe *= 10;
            }
            ilkreqem = inputm / mertebe;
            Console.WriteLine(inputm - ilkreqem * mertebe - sonreqem + ilkreqem + sonreqem * mertebe);

            #endregion

            #region İki integer array-i arasında dəyəri en böyük olan elementi tapın. Məs: {3,1,7,2}  & {10,0,3,1} - output - 10
            int[] numberarr1 = { 3, 1, 7, 2 };
            int[] numberarr2 = { 10, 0, 3, 1 };

            int boyuk = numberarr1[1];
            int boyuk2 = numberarr2[1];
            for (int i = 0; i < numberarr1.Length; i++)
            {
                if (numberarr1[i] > boyuk)
                {
                    boyuk = numberarr1[i];
                }
            }
            for (int i = 0; i < numberarr2.Length; i++)
            {
                if (numberarr2[i] > boyuk)
                {
                    boyuk = numberarr2[i];
                }
            }
            if (boyuk > boyuk2)
            {
                Console.WriteLine(boyuk);
            }
            else
            {
                Console.WriteLine(boyuk2);
            }



            #endregion



            #region ededin sade bolenlerinin sayi


            int input = 7;
            int sadecount = 0;
            int eded = 3;
            if (input % 2 == 0)
            {
                sadecount++;
            }

            while (eded <= input)
            {
                if (input % eded == 0)
                {
                    if (sadedimi(eded))
                    {
                        sadecount++;
                    }
                }
                eded++;
            }
            Console.WriteLine(sadecount);
            #endregion

        }
        static bool sadedimi(int eded)
        {
            Boolean sadedimi = true;
            for (int i = 2; i * i <= eded; i++)
            {
                if (eded % i == 0)
                {
                    sadedimi = false;
                }
            }
            return sadedimi;
        }
    }
}