using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            Random rnd = new Random();
            int counter = 0;

            Console.WriteLine("/n*** IT Students ***/n");

            do
            {               
                students.Add(new ITStudent());

                students[counter].Grade1 = rnd.Next(1, 101);
                students[counter].Grade2 = rnd.Next(1, 101);
                students[counter].Grade3 = rnd.Next(1, 101);

                Console.WriteLine($"Student[{counter}] grades: {students[counter].Grade1} - {students[counter].Grade2} - {students[counter].Grade3}");
                Console.WriteLine($"Student[{counter}] average: {students[counter].Grades()}\n");
                Console.ReadLine();
                counter++;
            } while (counter < 5);

            Console.WriteLine("/n*** Business Students ***/n");

            do
            {
                students.Add(new BussinessStudent());

                students[counter].Grade1 = rnd.Next(1, 101);
                students[counter].Grade2 = rnd.Next(1, 101);
                students[counter].Grade3 = rnd.Next(1, 101);

                Console.WriteLine($"Student[{counter}] grades: {students[counter].Grade1} - {students[counter].Grade2} - {students[counter].Grade3}");
                Console.WriteLine($"Student[{counter}] biggest grade: {students[counter].Grades()}");
                Console.ReadLine();
                counter++;
            } while (counter < 10);
        }
    }
}
