using System;

namespace pr_5
{
    class Student
    {
        private string lastName; 
        // Фамилия студента
        private string firstName; 
        // Имя студента
        private int academicYear;
        // Курс студента
        private int studentAge;
        // Возраст студента

        public string LastName
        {
            get { return (lastName != "") ? lastName : "Пусто"; }
            // Возвращает фамилию студента, если она задана; иначе "пусто"
            set { lastName = value.ToUpper(); }
            // Преобразует фамилию в верхний регистр и сохраняет
        }

        public string FirstName
        {
            get { return (firstName != "") ? firstName : "Пусто"; }
            // Возвращает имя студента, если оно задано; иначе "пусто"
            set { firstName = value.ToUpper(); }
            // Преобразует имя в верхний регистр и сохраняет
        }

        public int AcademicYear
        {
            get => academicYear;
            // Возвращает курс студента
            set { academicYear = (value < 1 || value > 4) ? 0 : value; }
            // Проверяет, находится ли курс в допустимом диапазоне (1-4); иначе задает значение 0
        }

        public int StudentAge
        {
            get => studentAge;
            // Возвращает возраст студента
            set { studentAge = (value < 15 || value > 35) ? 0 : value; }
            // Проверяет, находится ли возраст в допустимом диапазоне (15-35); иначе задает значение 0
        }

        public Student()
        {

        }

        public Student(string lastName, string firstName, int academicYear, int studentAge)
        {
            this.LastName = lastName;
            // Задает фамилию студента
            this.FirstName = firstName;
            // Задает имя студента
            this.AcademicYear = academicYear;
            // Задает курс студента
            this.StudentAge = studentAge;
            // Задает возраст студента
        }

        public void ShowInfo()
        {
            Console.WriteLine("Студент {0} {1} курса {2} года рождения {3}",
                LastName, FirstName, AcademicYear, StudentAge);
            // Выводит информацию о студенте - фамилию, имя, курс и возраст
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.LastName = "Русов";
            // Задает фамилию студента
            student1.FirstName = "Владимир";
            // Задает имя студента
            student1.AcademicYear = 2;
            // Задает курс студента
            student1.StudentAge = 16;
            // Задает возраст студента
            student1.ShowInfo();
            // Выводит информацию о студенте (фамилия, имя, курс, возраст)
        }
    }
}
