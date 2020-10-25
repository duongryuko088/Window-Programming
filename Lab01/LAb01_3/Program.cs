using System;
using System.Collections.Generic;
using System.Linq;

namespace LAb01_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var listKhuDat = InputListKhuDat();
            outputListKhuDat(listKhuDat);
            //
            System.Console.WriteLine("\n=>The land area is gradually increasing: ");
            List<KhuDat> listAreaIncreasing = listKhuDat.OrderBy(p => p.Area).ToList();
            outputListKhuDat(listAreaIncreasing);
            //
            System.Console.WriteLine("\n=>Xuat ra khu dat co gia ban giao dong");
            List<KhuDat> listKhuDatTrongKhoang = listKhuDat.Where(p => p.Price <= Math.Pow(10, 9) || p.Area >= 60).ToList();
            if (listKhuDatTrongKhoang.Count == 0)
            {
                System.Console.WriteLine("Khong co khu dat thoa yeu cau");
            }
            else
            {
                outputListKhuDat(listKhuDatTrongKhoang);
            }
        }
        private static List<KhuDat> InputListKhuDat()
        {
            System.Console.WriteLine("Nhap tong so khu dat: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<KhuDat> listKhuDat = new List<KhuDat>();
            System.Console.WriteLine("\n ===Nhap danh sach Khu Dat cua Cong ty===");
            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine("\n - Nhap khu dat thu {0}", i + 1);
                KhuDat temp = new KhuDat();
                temp.Input();
                listKhuDat.Add(temp);
            }
            return listKhuDat;
        }
        private static void outputListKhuDat(List<KhuDat> list)
        {
            Console.WriteLine("\n ===Xuat Danh Sach Khu Dat cua Cong ty===");
            foreach (KhuDat kd in list)
            {
                kd.Show();
            }
        }
    }
}