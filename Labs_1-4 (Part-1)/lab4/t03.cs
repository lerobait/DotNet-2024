// using System;

// public class Complex
// {
//   public double Real { get; set; }
//   public double Imaginary { get; set; }

//   public Complex() : this(0, 0) { }

//   public Complex(double real, double imaginary)
//   {
//     Real = real;
//     Imaginary = imaginary;
//   }

//   public static Complex operator +(Complex c1, Complex c2)
//   {
//     return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
//   }

//   public static Complex operator -(Complex c1, Complex c2)
//   {
//     return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
//   }

//   public static Complex operator *(Complex c1, Complex c2)
//   {
//     return new Complex(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
//                        c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
//   }

//   public static Complex operator /(Complex c1, Complex c2)
//   {
//     double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
//     return new Complex((c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator,
//                        (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator);
//   }

//   public override string ToString()
//   {
//     return $"{Real} + {Imaginary}i";
//   }
// }

// public class Program
// {
//   public static Complex[] AddComplexVectors(Complex[] vector1, Complex[] vector2)
//   {
//     int length = Math.Min(vector1.Length, vector2.Length);
//     Complex[] result = new Complex[length];

//     for (int i = 0; i < length; i++)
//     {
//       result[i] = vector1[i] + vector2[i];
//     }

//     return result;
//   }

//   public static void Main(string[] args)
//   {
//     Random rand = new Random();

//     int size1 = 5;
//     int size2 = 5;

//     Complex[] vector1 = new Complex[size1];
//     Complex[] vector2 = new Complex[size2];

//     for (int i = 0; i < size1; i++)
//     {
//       vector1[i] = new Complex(rand.Next(-10, 10), rand.Next(-10, 10));
//     }

//     for (int i = 0; i < size2; i++)
//     {
//       vector2[i] = new Complex(rand.Next(-10, 10), rand.Next(-10, 10));
//     }

//     Complex[] result = AddComplexVectors(vector1, vector2);

//     Console.WriteLine("Vector 1:");
//     foreach (var c in vector1)
//     {
//       Console.WriteLine(c);
//     }

//     Console.WriteLine("\nVector 2:");
//     foreach (var c in vector2)
//     {
//       Console.WriteLine(c);
//     }

//     Console.WriteLine("\nResult Vector (Sum):");
//     foreach (var c in result)
//     {
//       Console.WriteLine(c);
//     }
//   }
// }
