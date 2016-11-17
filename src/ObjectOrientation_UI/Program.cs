using System;
using School;

namespace ConsoleApplication
{
    public class Program
    {

        private static CourseCollection courses = new CourseCollection();
        private static TeacherCollection teachers = new TeacherCollection();
        private static StudentCollection students = new StudentCollection();
        public static void Main(string[] args)
        {
            string input = "";
            do{
                Console.Clear();
                Console.WriteLine("t: Add Teacher");
                Console.WriteLine("s: Add Student");
                Console.WriteLine("p: Print List");
                Console.WriteLine("x: Exit");
                Console.Write("Please type your choice and press Enter: ");
                input = Console.ReadLine();
                switch(input.ToLower()){
                    case "t":
                        addTeacher();
                        break;
                    case "s":
                        addStudent();
                        break;
                    case "p":
                        printList();
                        break;
                    case "x":
                        System.Console.WriteLine("Bye.");
                        break;
                    default:
                        System.Console.WriteLine("Sorry, I don't understand, try again...");
                        break;
                }
                Console.Write("Press Enter.");
                Console.ReadLine();
            }while(input.ToLower()!="x");
        }

        private static void addTeacher()
        {
            System.Console.Write("Teacher Name: ");
            string teacherName = Console.ReadLine();
            System.Console.Write("Teacher Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            System.Console.Write("Course Name: ");
            string courseName = Console.ReadLine();
            teachers.Add(teacherName, salary, courses.Set(courseName));
            Console.WriteLine("Teacher Added.");
        }

        private static void addStudent()
        {
            System.Console.Write("Student Name: ");
            string studentName = Console.ReadLine();
            System.Console.Write("Student Number: ");
            string number =Console.ReadLine();
            System.Console.Write("Course Name: ");
            string courseName = Console.ReadLine();
            students.Add(studentName, number, courses.Set(courseName));
            Console.WriteLine("Student Added.");
        }

        private static void printList(){
            System.Console.WriteLine("******COURSES*****");
            for (int i = 0; i < courses.Count; i++)
            {
                System.Console.WriteLine(courses[i]);
            }
            System.Console.WriteLine("******TEACHERS*****");
            for (int i = 0; i < teachers.Count; i++)
            {
                System.Console.WriteLine(teachers[i]);
            }
            System.Console.WriteLine("******STUDENTS*****");
            for (int i = 0; i < students.Count; i++)
            {
                System.Console.WriteLine(students[i]);
            }
        }
    }
}
