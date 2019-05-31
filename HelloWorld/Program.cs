using System;
using System.Collections.Generic;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            // Create a list of type student
            var students = new List<Student>();
            var adding = true;
            var studentCount = 0;
            while (adding)
            {
                //Create the new Student Object
                var newStudent = new Student();
                //get the student number
                var number = studentCount + 1;
                // Ask the Questions and Gather Answers here
                var name = AskQuestion("What the student name");
                newStudent.Name = name;
                var birthday = AskQuestion("What is the student date of birth");
                newStudent.Birthday = birthday;
                var address = AskQuestion("What is the student address");
                newStudent.Address = address;
                var grade = AskQuestion("What is the student grade");
                newStudent.Grade = Convert.ToInt32(grade);
                var num = AskQuestion("What is the student number");
                newStudent.Number = Convert.ToInt32(num);
                var phone = AskQuestion("What is the student phone number");
                newStudent.Phone = phone;
                //Insert the student into the student list
                students.Add(newStudent);

                

                Console.WriteLine("Add More Students? y for yes and n for no");
                var addMore = Console.ReadLine().ToUpper();
                if (addMore != "Y")
                {
                    adding = false;
                }
            }

            Console.WriteLine("done");


            
        }

        static string AskQuestion(string question)
        {
            var value = "";
            while (value == "")
            {
                Console.WriteLine(question);
                value = Console.ReadLine();
                if (value == "")
                {
                    Console.WriteLine("You must enter a value...");
                }
            }

            return value;
        }


        static string StudentInfoFormation(int number, string name, string age, string month, string grade)
        {
            string displayLine = "-----\nSTUDENT ID: {0}\n-----\n" +
                                 "Student Name: {1} \nStudent Age: {2} \nStudent Birth Month: {3} \n" +
                                 "Student Grade: {4}";
            string value = String.Format(displayLine, number.ToString(), name, age, month, grade);
            return value;
        }
    }

    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public int Number;
        private string phone;

        public string Phone
        {
            set { phone = value;
                Console.WriteLine(phone);
            }
        }

        public void SetPhone(string number)
        {
            this.Phone = number;
        }
    }
}