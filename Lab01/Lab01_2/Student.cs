using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_2
{
   class Student : Person
{
    private float avgScore;
    private string dept;
    public float AverageScore
    {
        get
        {
            return avgScore;
        }
        set
        {
            avgScore = value;
        }
    }
    //
    public string Department
    {
        get
        {
            return dept;
        }
        set
        {
            dept = value;
        }
    }
    public override void Input()
    {
        base.Input();
        System.Console.WriteLine("Input average score: ");
        AverageScore = float.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Input department: ");
        Department = System.Console.ReadLine();
    }
    public override void Show()
    {
        base.Show();
        System.Console.WriteLine("Department: {0} | Average score: {1}",this.Department,this.AverageScore);
    }
    public override int Type()
    {
        return 1;
    }
}

}
