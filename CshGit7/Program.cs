using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshGit7
{
    public class Student
    {
        public int ID
        {
            get;
            set;
        }
        public string FIO
        {
            get;
            set;
        }
        public string Group
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }

        public Student(int id, string fio, string group, string date)
        {
            ID = id;
            FIO = fio;
            Group = group;
            Date = date;
        }

        public static List<Student> students = new List<Student> { new Student(1, "Бондаренко Алина Юрьевна", "ИСиП 19-11-1", "01.04.2001"),
        new Student(2, "Антуфьева Александра Юрьевна", "ИСиП 19-11-1", "11.01.2003")};

        public static void newstudent() // добавление студента
        {
            string fio = "";
            string group = "";
            string date = "";
            int id = 0;

            Console.Write("\nВведите ФИО студента:");
            fio = Console.ReadLine();

            Console.Write("\nВведите Группу студента: ");
            group = Console.ReadLine();

            Console.Write("\nВведите Дату рождения студента (дд.мм.гггг): ");
            date = Console.ReadLine();

            Console.WriteLine("\nВведите ID студента: ");
            id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count; i++)
            {
                while (id == students[i].ID)
                {
                    Console.WriteLine("Студент с данным ID уже существует, введите другое: ");
                    id = Convert.ToInt32(Console.ReadLine());
                }
            }

            students.Add(new Student(id, fio, group, date));

            for (int i = 0; i < students.Count(); i++)
            {
                Console.WriteLine("\nID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");
            }
        }

        public static void correctinfo() // изменение информации о студенте
        {
            Console.WriteLine("\nВведите ID студента: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count(); i++)
            {
                if (id == students[i].ID)
                {
                    Console.WriteLine("\nВыберите параметр, который хотите изменить:\n1) ФИО\n2) Дата рождения\n3) Группа\n");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n == 1)
                    {
                        Console.WriteLine("\nВведите новые ФИО: ");
                        string fio = Console.ReadLine();
                        students[i].FIO = fio;

                        Console.WriteLine("\nИзмененные данные: ");
                        Console.WriteLine("ID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");

                    }

                    if (n == 2)
                    {
                        Console.WriteLine("\nВведите новую Дату рождения (дд.мм.гггг): ");
                        string date = Console.ReadLine();
                        students[i].Date = date;

                        Console.WriteLine("\nИзмененные данные: ");
                        Console.WriteLine("ID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");
                    }

                    if (n == 3)
                    {
                        Console.WriteLine("\nВведите новую Группу: ");
                        string group = Console.ReadLine();
                        students[i].Group = group;

                        Console.WriteLine("\nИзмененные данные: ");
                        Console.WriteLine("ID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");
                    }
                }
            }
        }

        public static void deletestudent() // удаление студента
        {
            Console.WriteLine("\nВведите ID студента: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count(); i++)
            {
                if (id == students[i].ID)
                {
                    students.Remove(students[i]);
                    Console.WriteLine("\nДанные о студенте удалены.");
                    Console.WriteLine("\nID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");
                }
            }
        }

        public static void showlist() // вывести список студентов
        {
            for (int i = 0; i < students.Count(); i++)
            {
                Console.WriteLine("\nФИО: " + students[i].FIO + "\n");
            }
        }

        public static void showinfo() // вывести информацию о студенте
        {
            Console.WriteLine("\nВведите ID студента: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count(); i++)
            {
                if (id == students[i].ID)
                {
                    Console.WriteLine("\nID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");
                }
            }
        }

        public static void age() // вывести возраст студента
        {
            Console.WriteLine("\nВведите ID студента: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count(); i++)
            {
                if (id == students[i].ID)
                {
                    DateTime now = DateTime.Today;
                    DateTime bday = Convert.ToDateTime(students[i].Date);
                    int age = now.Year - bday.Year;
                    Console.WriteLine("\nВозраст студента: " + age + "\n");
                }
            }
        }

        public static void initials() // вывести фамилию и  инициалы
        {
            Console.WriteLine("\nВведите ID студента: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count(); i++)
            {
                if (id == students[i].ID)
                {
                    string[] init = students[i].FIO.Split(' ');
                    Console.WriteLine("\n" + init[0] + " " + init[1][0] + "." + init[2][0] + ".");
                }

            }

        }

        // вот этот метод не работает, но я совсем не понимаю почему 
        public static void sovershennolet() // вывод студентов старше/младше 18 лет
        {
            Console.WriteLine("Введите параметр: с - старше 18, м - младше 18");
            char p = Convert.ToChar( Console.ReadLine());

            for (int i = 0; i < students.Count(); i++)
            {
                DateTime now = DateTime.Today;
                DateTime bday = Convert.ToDateTime(students[i].Date);
                int age = now.Year - bday.Year;
                int month1 = now.Month;
                int month2 = bday.Month;
                int day1 = now.Day;
                int day2 = bday.Day;

                if ( p == 'c')
                {
                    if(age>=18 && month2<=month1 && day2<day1)
                    {
                        Console.WriteLine("\nID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");
                    }
                }

                if ( p == 'м')
                {
                    if(age<=18 && month2>=month1 && day2 > day1)
                    {
                        Console.WriteLine("\nID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");
                    }
                }
            }
        }

        public static void poisk() // поиск по фамилии
        {
            Console.WriteLine("\nВведите фамилию c заглавной буквы: ");
            string f = Console.ReadLine();

            for (int i = 0; i < students.Count(); i++)
            {
                string[] init = students[i].FIO.Split(' ');

                if (init[0] == f)
                {
                    Console.WriteLine("\nID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", Дата рождения: " + students[i].Date + ", Группа: " + students[i].Group + "\n");
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВыберите действие:\n\n1) Добавить студента \n2) Изменить информацию о студенте " +
                "\n3) Удалить студента \n4) Вывести список студентов \n5) Вывести информацию о студенте" +
                "\n6) Вывести возраст студента\n7) Фамилия и инициалы студента \n8) Вывести студентов старше/младше 18 лет" +
                "\n9) Поиск студента по фамилии\n");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Student.newstudent();
            }

            if (n == 2)
            {
                Student.correctinfo();
            }

            if (n == 3)
            {
                Student.deletestudent();
            }

            if (n == 4)
            {
                Student.showlist();
            }

            if (n == 5)
            {
                Student.showinfo();
            }

            if (n == 6)
            {
                Student.age();
            }

            if (n == 7)
            {
                Student.initials();
            }

            if (n == 8)
            {
                Student.sovershennolet();
            }

            if (n == 9)
            {
                Student.poisk();
            }
        }
    }
}
