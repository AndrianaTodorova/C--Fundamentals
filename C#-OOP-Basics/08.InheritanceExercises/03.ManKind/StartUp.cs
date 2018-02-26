using System;

namespace _03.ManKind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] infoStudent = Console.ReadLine().Split();
                string firstName = infoStudent[0];
                string lastName = infoStudent[1];
                string facultyNumber = infoStudent[2];
                Human student = new Student(firstName, lastName, facultyNumber);

                string[] infoWorker = Console.ReadLine().Split();
                string firstNameWorker = infoWorker[0];
                string lastNameWorker = infoWorker[1];
                double salary = double.Parse(infoWorker[2]);
                double hours = double.Parse(infoWorker[3]);
                Human worker = new Worker(firstNameWorker, lastNameWorker, salary, hours);

                Console.WriteLine(student.ToString());
                Console.WriteLine();
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
