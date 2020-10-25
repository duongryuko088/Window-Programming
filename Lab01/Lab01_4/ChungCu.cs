using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_4
{
    class ChungCu : DiaOcD
    {
        private int tang;
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
            System.Console.WriteLine("Nhap tang: ");
            Tang = int.Parse(System.Console.ReadLine());
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Tang: {0}", this.Tang);
        }

        public override int Type()
        {
            return 3;
        }
    }
}
