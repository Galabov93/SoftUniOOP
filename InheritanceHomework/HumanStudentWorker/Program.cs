using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = null;
            List<Worker> listOfWorkers = null;

            try
            {
                listOfStudents = new List<Student>();
                listOfStudents.Add(new Student("Yordan", "Galabov", "123241"));
                listOfStudents.Add(new Student("Kosta", "Garbov", "21A2412"));
                listOfStudents.Add(new Student("Yon", "Labov", "93123241"));
                listOfStudents.Add(new Student("Adan", "Gabov", "6443241"));

                foreach (var item in listOfStudents.OrderBy(student => student.FacultyNumber))
                {
                    Console.WriteLine(item);
                }
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine();

            try
            {
                listOfWorkers = new List<Worker>();
                listOfWorkers.Add(new Worker("Gosho", "Etrov", 200, 50));
                listOfWorkers.Add(new Worker("Osho", "Trov", 250, 55));
                listOfWorkers.Add(new Worker("Goso", "Perov", 20, 10));
                listOfWorkers.Add(new Worker("Petar", "Pov", 200, 60));
                listOfWorkers.Add(new Worker("Zddravko", "Gang", 200, 50));
                foreach (var item in listOfWorkers.OrderByDescending(worker => worker.MoneyPerHour()))
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception)
            {

                throw;
            }

            List<Human> mergedList = new List<Human>();

            mergedList.AddRange(listOfStudents);
            mergedList.AddRange(listOfWorkers);

            Console.WriteLine("\n\nMerged list....");
            foreach (var item in mergedList.OrderBy(human => human.FirstName).ThenBy(hum => hum.LastName))
            {
                Console.WriteLine(item);
            }

        }
    }
}
