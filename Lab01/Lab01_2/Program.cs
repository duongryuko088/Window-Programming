using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var listPerson = inputListPerson();
            outputListPerson(listPerson);
            listSinhVienCNTT(listPerson);
            listSinhVienCNTTScore(listPerson);
            listTeacherDistrict9(listPerson);
            if (findGVID(listPerson) == 0)
            {
                System.Console.WriteLine("Wrong! Can not found");
            }
            else
            {
                listPerson[findGVID(listPerson)].Show();
            }
            listStudentCNTTMax(listPerson);
        }

        private static List<Person> inputListPerson()
        {
            System.Console.WriteLine("Input total of students and teachers : ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Person> listPerson = new List<Person>();
            System.Console.WriteLine("\n ===List Students and Teachers===");
            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine("\n - 1.Student 2. Teacher \nNo {0}", i + 1);
                int choice = Convert.ToInt32(Console.ReadLine());
                Person person;
                switch (choice)
                {
                    case 1:
                        person = new Student();
                        person.Input();
                        listPerson.Add(person);
                        break;
                    case 2:
                        person = new Teacher();
                        person.Input();
                        listPerson.Add(person);
                        break;
                    default:
                        System.Console.WriteLine("Wrong!");
                        break;
                }
            }
            return listPerson;
        }
        private static void outputListPerson(List<Person> listPerson)
        {
            System.Console.WriteLine("\nList the orders:");
            foreach (Person person in listPerson)
            {
                person.Show();
            }
        }
        private static void listSinhVienCNTT(List<Person> listPerson)
        {
            System.Console.WriteLine("\nList students in IT");
            foreach (Person person in listPerson)
            {
                if (person.Type() == 1 && ((Student)person).Department == "IT")
                {
                    person.Show();
                }
                else
                {
                    System.Console.WriteLine("Empty List");
                }
            }
        }
        private static void listSinhVienCNTTScore(List<Person> listPerson)
        {
            System.Console.WriteLine("\nList students in IT have average score less than 5:");
            foreach (Person person in listPerson)
            {
                if (person.Type() == 1 && ((Student)person).Department == "IT" && ((Student)person).AverageScore < 5)
                {
                    person.Show();
                }
                else
                {
                    System.Console.WriteLine("Not found");
                }
            }
        }
        private static void listTeacherDistrict9(List<Person> listPerson)
        {
            System.Console.WriteLine("\nList teach in District 9: ");
            foreach (Person person in listPerson)
            {
                if (person.Type() == 2 && ((Teacher)person).Address == "District 9")
                {
                    person.Show();
                }
                else
                {
                    System.Console.WriteLine("Not found!");
                }
            }
        }
        private static int findGVID(List<Person> listPerson)
        {
            for (int i = 0; i < listPerson.Count; i++)
            {
                if (listPerson[i].Type() == 2 && listPerson[i].PersonID == "CHN060286")
                {
                    return i;
                }
            }
            return 0;
        }
        private static void listStudentCNTTMax(List<Person> listPerson)
        {
            System.Console.WriteLine("\n=>List the highest score of IT Student");
            float maxScore = float.MinValue;
            foreach (Person person in listPerson)
            {
                if (person.Type() == 1 && ((Student)person).AverageScore > maxScore)
                {
                    maxScore = ((Student)person).AverageScore;
                }
            }
            foreach (Person person1 in listPerson)
            {
                if (person1.Type() == 1 && ((Student)person1).AverageScore == maxScore)
                {
                    person1.Show();
                }
            }
        }
    }
}

