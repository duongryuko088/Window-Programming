//DuongThanhNhu_1811061967
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Lab01
{
    class Student
    {
        //1. Tao thuộc tính
        private string studentID;
        private string fullname;
        private float avgScore;
        private string department;

        //2. Tạo các thuộc tính

        public string Fullname 
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }

        public float AvgScore 
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

        public string StudentID 
        {
            get
            { 
                return studentID; 
            }
            set
            { 
                studentID = value; 
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        //3. Tạo constructor mặc định không tham số
        public Student()
        {  
            
        }
        //4. Tạo constructor có tham số
        public Student(string id, string name, float score, string dept)
        {
            StudentID = id;
            Fullname = name;
            AvgScore = score;
            Department = dept;
        }

        //5. Viết các phương thức nhập, xuất sinh viên
        public void Input()
        {
            Console.Write("Input MSSV: ");
            StudentID = Console.ReadLine();

            Console.Write("Input Full name of student: ");
            Fullname = Console.ReadLine();

            Console.Write("Input score: ");
            AvgScore = float.Parse(Console.ReadLine());

            Console.Write("Input department: ");
            Department = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0} Full name:{1} Department:{2} Score:{3}", this.StudentID, this.Fullname, this.Department, this.AvgScore);
        }

    }
}
