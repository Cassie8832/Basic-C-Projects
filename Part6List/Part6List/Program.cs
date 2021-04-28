using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6List
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of 10 students, instantiated from class employee
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, firstName = "Cassie", lastName = "Chamberlain" },
                new Student { Id = 2, firstName = "Cassie", lastName = "Peets" },
                new Student { Id = 3, firstName = "Arya", lastName = "Meadows" },
                new Student { Id = 4, firstName = "Aiden", lastName = "Maximus" },
                new Student { Id = 5, firstName = "Josh", lastName = "Trescot" },
                new Student { Id = 6, firstName = "Sarah", lastName = "Padgent" },
                new Student { Id = 7, firstName = "Leo", lastName = "Ellis" },
                new Student { Id = 8, firstName = "Bruce", lastName = "Earl" },
                new Student { Id = 9, firstName = "Rebecca", lastName = "Smith" },
                new Student { Id = 10, firstName = "Carmen", lastName = "Knowles" }
            };
            //foreach loop adding to new list if first name is cassie
            foreach  (Student student in students)
            {
                if (student.firstName == "Cassie")
                {
                    List<string> listSameName = new List<string>();
                    listSameName.Add(student.firstName + student.lastName);
                    Console.WriteLine($"{student.firstName} {student.lastName}");
                }
            }
            //lambda to the above foreach loop
            List<Student> listCassie = students.Where(x => x.firstName == "Cassie").ToList();
            //printing to the console the names of students named cassie
            Console.WriteLine($"{listCassie.Count} students have the same first name!");
            Console.WriteLine($"{listCassie[0].SayName()} and {listCassie[1].SayName()}!");

            //lambda for new list if Id is greater than 5
            List<Student> listId = students.Where(x => x.Id > 5).ToList();
            //foreach loop to print list names to console from lambda expression new list
            Console.WriteLine("These students have an ID greater than 5:");
            foreach (Student student in listId)
            {
                //prints each student name and ID
                Console.WriteLine($"{student.SayName()} ID:{student.Id}");
            }
            Console.ReadLine();
        }
    }
}
