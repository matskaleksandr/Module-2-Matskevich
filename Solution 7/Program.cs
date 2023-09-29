using System;
using System.Linq;

namespace Solution_7
{
    //структура представляющая информацию о студенте
    struct Student
    {
        public string Name;//фамилия студента
        public string GroupNumber;//номер группы студента
        public int[] Grades;//Оценки студента
        //метод для вычисления средней оценки студента
        public double GetAverageGrade()
        {
            return Grades.Average();
        }
        //метод для проверки наличия отличных оценок (4 или 5)
        public bool HasExcellentGrades()
        {
            return Grades.All(grade => grade == 4 || grade == 5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];//создание массива студентов
            Random random = new Random();
            //заполнение массива студентами с произвольными данными
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Введите фамилию учащегося:");
                students[i].Name = Console.ReadLine();
                students[i].GroupNumber = "Группа " + (i % 3 + 1);
                students[i].Grades = new int[] { random.Next(0, 6), random.Next(0, 6), random.Next(0, 6), random.Next(0, 6), random.Next(0, 6) };//произвольные оценки
                if (random.Next(2) == 1)
                {
                    students[i].Grades = new int[] { 4, 5, 4, 5, 4 };//Установка отличных оценок для некоторых студентов
                }
            }
            //сортировка студентов по возрастанию среднего балла
            Array.Sort(students, (s1, s2) => s1.GetAverageGrade().CompareTo(s2.GetAverageGrade()));
            //вывод фамилий и номеров групп студентов с оценками 4 или 5
            Console.WriteLine("Учащиеся с отличными оценками (4 или 5):");
            foreach (var student in students)
            {
                if (student.HasExcellentGrades())
                {
                    Console.WriteLine($"Фамилия: {student.Name}, Группа: {student.GroupNumber}");
                }
            }
        }
    }
}
