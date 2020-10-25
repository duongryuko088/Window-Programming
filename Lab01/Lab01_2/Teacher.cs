using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_2
{
    class Teacher : Person
    {
        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public override void Input()
        {
            base.Input();
            System.Console.WriteLine("Input address: ");
            Address = System.Console.ReadLine();
        }
        public override void Show()
        {
            base.Show();
            System.Console.WriteLine("Address: {0}", this.Address);
        }
        public override int Type()
        {
            return 2;
        }
    }

}
