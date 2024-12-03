// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Student
// {
//   private string surname;
//   private string name;
//   private string patronymic;
//   private DateTime birthDate;
//   private string address;
//   private string phone;
//   private string faculty;
//   private int course;

//   public Student(string surname, string name, string patronymic, DateTime birthDate,
//                  string address, string phone, string faculty, int course)
//   {
//     this.surname = surname;
//     this.name = name;
//     this.patronymic = patronymic;
//     this.birthDate = birthDate;
//     this.address = address;
//     this.phone = phone;
//     this.faculty = faculty;
//     this.course = course;
//   }

//   public string Surname => surname;
//   public string Name => name;
//   public string Patronymic => patronymic;
//   public DateTime BirthDate => birthDate;
//   public string Address => address;
//   public string Phone => phone;
//   public string Faculty => faculty;
//   public int Course => course;

//   public void Show()
//   {
//     Console.WriteLine($"Студент: {surname} {name} {patronymic}, Дата народження: {birthDate.ToShortDateString()}, " +
//                       $"Адреса: {address}, Телефон: {phone}, Факультет: {faculty}, Курс: {course}");
//   }

//   public bool BornAfter(int year)
//   {
//     return birthDate.Year > year;
//   }

//   public void UpdateAddress(string newAddress)
//   {
//     address = newAddress;
//   }
// }
// class Program
// {
//   static void Main(string[] args)
//   {
//     List<Student> students = new List<Student>
//         {
//             new Student("Іваненко", "Іван", "Іванович", new DateTime(2001, 5, 12),
//                         "Київ, вул. Центральна, 1", "0501234567", "Факультет комп'ютерних наук", 2),
//             new Student("Петренко", "Петро", "Петрович", new DateTime(2003, 3, 15),
//                         "Львів, вул. Головна, 10", "0677654321", "Факультет економіки", 1),
//             new Student("Сидоренко", "Сидір", "Сидорович", new DateTime(2000, 7, 20),
//                         "Одеса, вул. Морська, 5", "0634567890", "Факультет комп'ютерних наук", 3),
//             new Student("Коваленко", "Ольга", "Олександрівна", new DateTime(2002, 11, 25),
//                         "Харків, вул. Квіткова, 2", "0938765432", "Факультет математики", 2)
//         };

//     string facultyToSearch = "Факультет комп'ютерних наук";
//     Console.WriteLine($"Студенти факультету \"{facultyToSearch}\":");
//     foreach (var student in students.Where(s => s.Faculty == facultyToSearch))
//     {
//       student.Show();
//     }

//     Console.WriteLine("\nСписки студентів за факультетами та курсами:");
//     var groupedStudents = students.GroupBy(s => new { s.Faculty, s.Course });
//     foreach (var group in groupedStudents)
//     {
//       Console.WriteLine($"Факультет: {group.Key.Faculty}, Курс: {group.Key.Course}");
//       foreach (var student in group)
//       {
//         student.Show();
//       }
//     }

//     int year = 2001;
//     Console.WriteLine($"\nСтуденти, які народилися після {year} року:");
//     foreach (var student in students.Where(s => s.BornAfter(year)))
//     {
//       student.Show();
//     }

//     Console.WriteLine("\nДодавання нового студента:");
//     Student newStudent = new Student("Федоренко", "Федір", "Федорович", new DateTime(2004, 4, 4),
//                                       "Київ, вул. Новий, 3", "0951234567", "Факультет математики", 1);
//     students.Add(newStudent);
//     newStudent.Show();

//     Console.WriteLine("\nОновлення адреси студента:");
//     students[0].UpdateAddress("Київ, вул. Стара, 8");
//     students[0].Show();

//     Console.WriteLine("\nВидалення студента:");
//     students.Remove(newStudent);
//     foreach (var student in students)
//     {
//       student.Show();
//     }
//   }
// }
