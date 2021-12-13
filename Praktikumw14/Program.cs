using System;
using System.Collections.Generic;

namespace Praktikumw14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output : ");
            int pemindaiPrima = 0;
            int faktor = 0;
            for (int i = 0; i < input; i++)
            {
                if (input % (i + 1) == 0)
                {
                    faktor++;
                }
            }
            if (faktor == 2)
            {
                pemindaiPrima += 1;
            }
            if (pemindaiPrima == 1)
            {
                bilPrima(input);
            }
            else if (pemindaiPrima == 0)
            {
                bukanBilPrima(input);
            }
        }
        static void bilPrima(int input)
        {
            var dataPrima = new List<int>();
            int angkaPrima = 1;
            int faktor1 = 0;
            int pencetakSpasiSatuKali = 0;
            int spasi = 0;
            while (spasi < input)
            {
                for (int i = 0; i < angkaPrima; i++)
                {
                    if (angkaPrima % (i + 1) == 0)
                    {
                        faktor1++;
                    }
                }
                if (dataPrima.Count % input == 0 && pencetakSpasiSatuKali > 1)
                {
                    Console.WriteLine();
                    pencetakSpasiSatuKali = 0;
                    spasi++;
                }
                if (faktor1 == 2)
                {
                    dataPrima.Add(angkaPrima);
                    Console.Write(string.Format("{0,5}", angkaPrima));
                    pencetakSpasiSatuKali++;
                }
                faktor1 = 0;
                angkaPrima++;
            }
        }
        static void bukanBilPrima(int input)
        {
            var dataBukanPrima = new List<int>();
            int angkaPrima = 1;
            int faktor1 = 0;
            int pencetakSpasiSatuKali = 0;
            int spasi = 0;
            while (spasi < input)
            {
                for (int i = 0; i < angkaPrima; i++)
                {
                    if (angkaPrima % (i + 1) == 0)
                    {
                        faktor1++;
                    }
                }
                if (dataBukanPrima.Count % input == 0 && pencetakSpasiSatuKali > 1)
                {
                    Console.WriteLine();
                    pencetakSpasiSatuKali = 0;
                    spasi++;
                }
                if (faktor1 != 2)
                {
                    if (spasi < input)
                    {
                        dataBukanPrima.Add(angkaPrima);
                        Console.Write(string.Format("{0,5}", angkaPrima));
                        pencetakSpasiSatuKali++;
                    }
                }
                faktor1 = 0;
                angkaPrima++;
            }
        }
    }
}
