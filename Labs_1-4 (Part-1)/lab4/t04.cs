// using System;
// using System.Collections.Generic;

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

//   public void UpdateAddress(string newAddress)
//   {
//     address = newAddress;
//   }
// }

// public class Faculty
// {
//   private string name;
//   private List<Student> students;

//   public Faculty(string name)
//   {
//     this.name = name;
//     this.students = new List<Student>();
//   }

//   public string Name => name;

//   public void AddStudent(Student student)
//   {
//     students.Add(student);
//     Console.WriteLine($"Студента {student.Surname} {student.Name} додано до факультету {name}.");
//   }

//   public void RemoveStudent(Student student)
//   {
//     if (students.Remove(student))
//     {
//       Console.WriteLine($"Студента {student.Surname} {student.Name} видалено з факультету {name}.");
//     }
//     else
//     {
//       Console.WriteLine($"Студент {student.Surname} {student.Name} не знайдений на факультеті {name}.");
//     }
//   }

//   public void ShowFaculty()
//   {
//     Console.WriteLine($"Факультет: {name}");
//     foreach (var student in students)
//     {
//       student.Show();
//     }
//   }
// }

// public class University
// {
//   private string name;
//   private List<Faculty> faculties;

//   public University(string name)
//   {
//     this.name = name;
//     this.faculties = new List<Faculty>();
//   }

//   public void AddFaculty(Faculty faculty)
//   {
//     faculties.Add(faculty);
//     Console.WriteLine($"Факультет {faculty.Name} додано до університету {name}.");
//   }

//   public void ShowUniversity()
//   {
//     Console.WriteLine($"Університет: {name}");
//     foreach (var faculty in faculties)
//     {
//       faculty.ShowFaculty();
//     }
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     University university = new University("Національний університет");

//     Faculty csFaculty = new Faculty("Факультет комп'ютерних наук");
//     Faculty ecoFaculty = new Faculty("Факультет економіки");

//     university.AddFaculty(csFaculty);
//     university.AddFaculty(ecoFaculty);

//     Student student1 = new Student("Іваненко", "Іван", "Іванович", new DateTime(2001, 5, 12),
//                                    "Київ, вул. Центральна, 1", "0501234567", "Факультет комп'ютерних наук", 2);
//     Student student2 = new Student("Петренко", "Петро", "Петрович", new DateTime(2003, 3, 15),
//                                    "Львів, вул. Головна, 10", "0677654321", "Факультет економіки", 1);
//     Student student3 = new Student("Сидоренко", "Сидір", "Сидорович", new DateTime(2000, 7, 20),
//                                    "Одеса, вул. Морська, 5", "0634567890", "Факультет комп'ютерних наук", 3);

//     csFaculty.AddStudent(student1);
//     csFaculty.AddStudent(student3);
//     ecoFaculty.AddStudent(student2);

//     Console.WriteLine("\nСтуденти в університеті:");
//     university.ShowUniversity();

//     student1.UpdateAddress("Київ, вул. Стара, 8");

//     csFaculty.RemoveStudent(student3);

//     Console.WriteLine("\nСтуденти в університеті після видалення:");
//     university.ShowUniversity();
//   }
// }
