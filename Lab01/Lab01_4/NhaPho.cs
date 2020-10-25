using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_4
{
    class NhaPho : DiaOcD
    {
        private int yearBuild;
        private int tang;

        public int YearBuild
        {
            get
            {
                return yearBuild;
            }
            set
            {
                yearBuild = value;
            }
        }

        public int Tang
        {
            get
            {
                return tang;
            }
            set
            {
                tang = value;
            }
        }
        
        public override void Input()
        {
            base.Input();
            System.Console.WriteLine("Nhap nam ");
            YearBuild = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Nhap tang ");
            Tang = int.Parse(System.Console.ReadLine());
        }
        public override void Show()
        {
            base.Show();
            System.Console.WriteLine("Nam: {0} | Tang: {1}", this.YearBuild, this.Tang);
        }
        public override int Type()
        {
            return 2;
        }
    }
}
