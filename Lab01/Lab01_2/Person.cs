using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_2
{
    abstract class Person
    {
        private string personID;
        private string fName;
        public string PersonID
        {
            get
            {
                return personID;
            }
            set
            {
                personID = value;
            }
        }
        public string FullName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public virtual void Input()
        {
            System.Console.WriteLine("Input ID: ");
            PersonID = System.Console.ReadLine();
            System.Console.WriteLine("Input full name : ");
            FullName = System.Console.ReadLine();
        }
        public virtual void Show()
        {
            System.Console.WriteLine("ID: {0} | Your full name: {1} ", this.PersonID, this.FullName);
        }
        public abstract int Type();
    }

}
