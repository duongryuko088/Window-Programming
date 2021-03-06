﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_4
{
    abstract class DiaOcD
    {
        private string diaDiem;
        private double giaBan;
        private double dienTich;
        public string DiaDiem
        {
            get
            {
                return diaDiem;
            }
            set
            {
                diaDiem = value;
            }
        }
        public double GiaBan
        {
            get
            {
                return giaBan;
            }
            set
            {
                giaBan = value;
            }
        }
        public double DienTich
        {
            get
            {
                return dienTich;
            }
            set
            {
                dienTich = value;
            }
        }
        public virtual void Input()
        {
            System.Console.WriteLine("Nhap dia diem: ");
            DiaDiem = System.Console.ReadLine();
            System.Console.WriteLine("Nhap gia ban: ");
            GiaBan = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Nhap dien tich ");
            DienTich = double.Parse(System.Console.ReadLine());
        }
        public virtual void Show()
        {
            System.Console.WriteLine("Dia diem: {0} | Gia ban: {1} | Dien tich: {2}", this.DiaDiem, this.GiaBan, this.DienTich);
        }
        public abstract int Type();
    }
}
