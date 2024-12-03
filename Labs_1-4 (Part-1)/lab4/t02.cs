// using System;
// using System.Collections.Generic;
// using System.Linq;

// public abstract class Person
// {
//   protected string surname;
//   protected string name;
//   protected string patronymic;
//   protected DateTime birthDate;
//   protected string address;
//   protected string phone;

//   protected Person(string surname, string name, string patronymic, DateTime birthDate, string address, string phone)
//   {
//     this.surname = surname;
//     this.name = name;
//     this.patronymic = patronymic;
//     this.birthDate = birthDate;
//     this.address = address;
//     this.phone = phone;
//   }

//   public string Surname => surname;
//   public string Name => name;
//   public string Patronymic => patronymic;
//   public DateTime BirthDate => birthDate;
//   public string Address => address;
//   public string Phone => phone;

//   public abstract void Show();

//   public bool BornAfter(int year)
//   {
//     return birthDate.Year > year;
//   }
// }

// public class Administrator : Person
// {
//   private string position;
//   private int experience;

//   public Administrator(string surname, string name, string patronymic, DateTime birthDate,
//                        string address, string phone, string position, int experience)
//       : base(surname, name, patronymic, birthDate, address, phone)
//   {
//     this.position = position;
//     this.experience = experience;
//   }

//   public string Position => position;
//   public int Experience => experience;

//   public override void Show()
//   {
//     Console.WriteLine($"Адміністратор: {surname} {name} {patronymic}, Дата народження: {birthDate.ToShortDateString()}, " +
//                       $"Адреса: {address}, Телефон: {phone}, Посада: {position}, Досвід: {experience} років");
//   }

//   public void UpdatePosition(string newPosition)
//   {
//     position = newPosition;
//   }
// }

// public class Staff : Person
// {
//   private string department;
//   private decimal salary;

//   public Staff(string surname, string name, string patronymic, DateTime birthDate,
//                string address, string phone, string department, decimal salary)
//       : base(surname, name, patronymic, birthDate, address, phone)
//   {
//     this.department = department;
//     this.salary = salary;
//   }

//   public string Department => department;
//   public decimal Salary => salary;

//   public override void Show()
//   {
//     Console.WriteLine($"Персонал: {surname} {name} {patronymic}, Дата народження: {birthDate.ToShortDateString()}, " +
//                       $"Адреса: {address}, Телефон: {phone}, Відділ: {department}, Зарплата: {salary} грн");
//   }

//   public void UpdateSalary(decimal newSalary)
//   {
//     salary = newSalary;
//   }
// }

// public class AcademicStaff : Staff
// {
//   private string academicDegree;
//   private int publicationsCount;

//   public AcademicStaff(string surname, string name, string patronymic, DateTime birthDate,
//                        string address, string phone, string department, decimal salary,
//                        string academicDegree, int publicationsCount)
//       : base(surname, name, patronymic, birthDate, address, phone, department, salary)
//   {
//     this.academicDegree = academicDegree;
//     this.publicationsCount = publicationsCount;
//   }

//   public string AcademicDegree => academicDegree;
//   public int PublicationsCount => publicationsCount;

//   public override void Show()
//   {
//     base.Show();
//     Console.WriteLine($"Академічний ступінь: {academicDegree}, Кількість публікацій: {publicationsCount}");
//   }

//   public void AddPublication()
//   {
//     publicationsCount++;
//   }

//   public void UpdateAcademicDegree(string newDegree)
//   {
//     academicDegree = newDegree;
//   }
// }

// public class AdministrativeStaff : Staff
// {
//   private string position;
//   private int yearsInPosition;

//   public AdministrativeStaff(string surname, string name, string patronymic, DateTime birthDate,
//                              string address, string phone, string department, decimal salary,
//                              string position, int yearsInPosition)
//       : base(surname, name, patronymic, birthDate, address, phone, department, salary)
//   {
//     this.position = position;
//     this.yearsInPosition = yearsInPosition;
//   }

//   public string Position => position;
//   public int YearsInPosition => yearsInPosition;

//   public override void Show()
//   {
//     base.Show();
//     Console.WriteLine($"Посада: {position}, Роки на посаді: {yearsInPosition}");
//   }

//   public void Promote(string newPosition)
//   {
//     position = newPosition;
//     yearsInPosition = 0;
//   }

//   public void IncreaseYearsInPosition()
//   {
//     yearsInPosition++;
//   }
// }

// public class Student : Person
// {
//   private string faculty;
//   private int course;

//   public Student(string surname, string name, string patronymic, DateTime birthDate,
//                  string address, string phone, string faculty, int course)
//       : base(surname, name, patronymic, birthDate, address, phone)
//   {
//     this.faculty = faculty;
//     this.course = course;
//   }

//   public string Faculty => faculty;
//   public int Course => course;

//   public override void Show()
//   {
//     Console.WriteLine($"Студент: {surname} {name} {patronymic}, Дата народження: {birthDate.ToShortDateString()}, " +
//                       $"Адреса: {address}, Телефон: {phone}, Факультет: {faculty}, Курс: {course}");
//   }

//   public void UpdateAddress(string newAddress)
//   {
//     address = newAddress;
//   }
// }

// public class Teacher : Person
// {
//   private string subject;
//   private int experience;

//   public Teacher(string surname, string name, string patronymic, DateTime birthDate,
//                  string address, string phone, string subject, int experience)
//       : base(surname, name, patronymic, birthDate, address, phone)
//   {
//     this.subject = subject;
//     this.experience = experience;
//   }

//   public string Subject => subject;
//   public int Experience => experience;

//   public override void Show()
//   {
//     Console.WriteLine($"Викладач: {surname} {name} {patronymic}, Дата народження: {birthDate.ToShortDateString()}, " +
//                       $"Адреса: {address}, Телефон: {phone}, Предмет: {subject}, Досвід: {experience} років");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     List<Person> people = new List<Person>
//         {
//             new Student("Іваненко", "Іван", "Іванович", new DateTime(2001, 5, 12),
//                         "Київ, вул. Центральна, 1", "0501234567", "Факультет комп'ютерних наук", 2),
//             new Student("Петренко", "Петро", "Петрович", new DateTime(2003, 3, 15),
//                         "Львів, вул. Головна, 10", "0677654321", "Факультет економіки", 1),
//             new AcademicStaff("Сидоренко", "Олександр", "Олександрович", new DateTime(1985, 1, 20),
//                         "Одеса, вул. Морська, 5", "0634567890", "Програмування", 10000m,
//                         "Кандидат наук", 5),
//             new AcademicStaff("Коваленко", "Анна", "Антонівна", new DateTime(1990, 6, 25),
//                         "Харків, вул. Квіткова, 2", "0938765432", "Математика", 8000m,
//                         "Доктор наук", 10),
//             new AdministrativeStaff("Петров", "Сергій", "Володимирович", new DateTime(1975, 2, 14),
//                               "Київ, вул. Академічна, 3", "0987654321", "Деканат", 15000m,
//                               "Декан", 10),
//             new AdministrativeStaff("Іванова", "Ольга", "Олександрівна", new DateTime(1988, 8, 19),
//                        "Запоріжжя, вул. Садова, 15", "0679876543", "Канцелярія", 12000m,
//                        "Секретар", 5)
//         };

//     Console.WriteLine("Усі особи:");
//     foreach (var person in people)
//     {
//       person.Show();
//       Console.WriteLine();
//     }

//     Console.WriteLine("Додаткові операції для академічного персоналу:");
//     var academicStaff = people.OfType<AcademicStaff>();
//     foreach (var staff in academicStaff)
//     {
//       staff.AddPublication();
//       staff.Show();
//       Console.WriteLine();
//     }

//     Console.WriteLine("Особи, які народилися після 2000 року:");
//     foreach (var person in people.Where(p => p.BornAfter(2000)))
//     {
//       person.Show();
//       Console.WriteLine();
//     }
//   }
// }
