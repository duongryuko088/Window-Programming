//DuongThanhNhu_1811061967
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab01
{
    class Program
    {
        public static List<Student> InputStudentList()
        {
            List<Student> listST = new List<Student>();
            Console.Write("Input total of Students N =");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ---INPUT STUDENT LIST---");
            for(int i = 0; i<N; i++)
            {
                Console.WriteLine("\n Student {0}", i + 1);
                Student temp = new Student();
                temp.Input();
                listST.Add(temp);
            }
            return listST;
        }
        private static void OutputListStudent(List<Student> listSt)
        {
            Console.WriteLine("\n ---Output student list---");
            foreach(Student sv in listSt)
            {
                sv.Show();
            }
        }
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode; //để sử dụng tiếng việt
            //Console.InputEncoding = Encoding.Unicode; //Nhập tổng số sv N, Convert kiểu dữ liệu sang biến N kiểu int

            List<Student> listSt = InputStudentList();
            OutputListStudent(listSt);

            Console.Write("Input total of Students N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            Student[] arrStudents = new Student[N];
            Console.WriteLine("\n ---Input student list---");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n Student {0}", i + 1);
                arrStudents[i] = new Student();
                arrStudents[i].Input();
            }

            Console.WriteLine("\n ---Student list---");
            foreach (Student st in arrStudents)
            {
                st.Show();
            }
            Console.ReadKey();//Dừng màn hình kt kết quả

            //1.1
            //C1: sd cú pháp truy vấn
            //List<Student> listStIT = (from s in listSt
            //                          where s.Department == "CNTT"
            //                          select s).ToList();
            //C2: sd cú pháp phương thức
            List<Student> listStIT = listSt.Where(p => p.Department == "CNTT").ToList();

            if (listStIT.Count() == 0)
                Console.WriteLine("No student study in CNTT");
            else
                OutputListStudent(listStIT);
            //1.2
            Console.WriteLine("Student'average point is greater than or equal to 5: ");
            List<Student> result = listSt.Where(p => p.AvgScore >= 5).ToList();
            if (result.Count() == 0)
                Console.WriteLine("No student has >= 5");
            else
                OutputListStudent(result);
            //1.3
            Console.WriteLine("Sort by increasing point: ");
            List<Student> SortIncreasing = listSt.OrderBy(p => p.AvgScore).ToList();
            OutputListStudent(SortIncreasing);

            //1.4
            Console.WriteLine("List of GPA is greater than or equal to 5 and department in CNTT: \n");
            List<Student> ListStCNTT5 = listSt.OrderBy(p => p.AvgScore >= 5 && p.Department == "CNTT").ToList();
            if (ListStCNTT5.Count() == 0)
                Console.WriteLine("No Student in CNTT has point >= 5\n");
            else
                OutputListStudent(ListStCNTT5);

            //1.5
            Console.WriteLine("List the highest average point of IT students: \n");
            var maxPoint = listSt.Max(p => p.AvgScore);
            var listMaxPoint = listSt.Where(p => p.Department == "CNTT" && p.AvgScore == maxPoint).ToList();
            OutputListStudent(listMaxPoint);
        }

        
    }
}
