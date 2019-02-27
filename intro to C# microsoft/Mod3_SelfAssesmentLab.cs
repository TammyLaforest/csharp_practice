using System;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetCourseInformation();
            GetProgramInformation();

        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();

            try
            {
                throw new NotImplementedException();
                //Console.WriteLine("Enter the student's birthday: ");
                //string birthday = Console.ReadLine();

            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }

            //PrintStudentDetails(firstName, lastName, birthday);
            PrintStudentDetails(firstName, lastName);

        }

        static void PrintStudentDetails(string first, string last, string birthday = "aug")
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName);
         
        }

        static void PrintTeacherDetails(string first, string last)
        {
            Console.WriteLine("The teacher's name is: {0} {1}", first, last);
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter Course Name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter number of credits: ");
            string credits = Console.ReadLine();
            PrintCourseDetails(courseName, credits);

        }

        static void PrintCourseDetails(string name, string credits)
        {
            Console.WriteLine("The course {0} is worth {1} credits", name, credits);
        }

        static void GetProgramInformation()
        {
            Console.WriteLine("Enter Program Name: ");
            string program = Console.ReadLine();
            Console.WriteLine("Enter total number of credits required: ");
            string credits = Console.ReadLine();
            PrintProgramDetails(program, credits);

        }

        static void PrintProgramDetails(string program, string credits)
        {
            Console.WriteLine("The program {0} requires a total of {1} credits", program, credits);
        }

    }
}