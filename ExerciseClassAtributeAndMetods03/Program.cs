using System;
using System.Globalization;

namespace ExerciseClassAtributeAndMetods03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            

            Console.Write("Student name: ");
            s1.Name = (Console.ReadLine());
            Console.WriteLine("Type the three student notes: ");
            s1.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s1.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s1.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(s1);
            
            if (s1.Aproved())
            {
                Console.WriteLine("APROVED");
            }
            else
            {
                Console.WriteLine("REPROVED");
                Console.WriteLine(s1.Remaining().ToString("F2", CultureInfo.InvariantCulture) + " POINTS MISSING");
            }
            
        }
    }
}
