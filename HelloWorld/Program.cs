using System;
using System.Collections.Generic;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create student from class
//            var student = new Student();
//            student.Name = "Jim";
//            Console.WriteLine(student.Name);

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
            

            //Get the number of Students
//            int studentCount = int.Parse(AskQuestion("How many students"));

            //Create the student array
//            var studentInformation = new string[studentCount];
//            var studentInformation = new List<string>();
//            var studentCount = 0;
//            var more = true;


            //Loop through and grab the info for all students
//            while (more == true)
//            {
//                //get the student number
//                var number = studentCount + 1;
//                //Ask the Questions and gather the Answers.
//                var name = AskQuestion("What the student name");
//                var age = AskQuestion("What is the student age");
//                var month = AskQuestion("What is the student birth month");
//                var grade = AskQuestion("What is the student grade");
//                studentInformation.Add(StudentInfoFormation(number, name, age, month, grade));
//                
//                Console.WriteLine("Add More Students? Type y for yes or n for no.");
//                var addMore = Console.ReadLine().ToUpper();
//                if (addMore != "Y")
//                {
//                    more = false;
//                }
//                studentCount++;
//            }
//
//            foreach (var i in studentInformation)
//            {
//                Console.WriteLine(i);
//            }
//            

//            for (int i = 1; i < studentCount + 1; i++)
//            {
//                //get Array index
//                var arrayIndex = i - 1;
//                Console.WriteLine("Array index is {0}", arrayIndex.ToString());
//                //Ask the Questions and gather the Answers.
//                var name = AskQuestion("What the student name");
//                var age = AskQuestion("What is the student age");
//                var month = AskQuestion("What is the student birth month");
//                var grade = AskQuestion("What is the student grade");
//                studentInformation[arrayIndex] = StudentInfoFormation(name, age, month, grade);
//                
//            }

//            int studentCounter = 0;
//            //Display all students in array
//            foreach (var i in studentInformation)
//            {
//                int studentNumber = studentCounter + 1;
//                Console.WriteLine("-----\nSTUDENT ID: {0}\n-----", studentNumber.ToString());
//                Console.WriteLine(i);
//                studentCounter++;
//            }

//            //Get Student's Name
//            var strName = AskQuestion("What is your name");
//            Console.WriteLine("Your name is {0}.", strName);
//            
//            //Get Student's Age
//            var strAge = AskQuestion("What is your age");
//            
//            //Get Student's Birth Month
//            var strMonth = AskQuestion("What is your birth month");
//
//            var strGrade = AskQuestion("What is your grade");
//            
//            //Display the information
//            DisplayStudent(strName.ToString(), strAge.ToString(), strMonth.ToString(), strGrade.ToString());

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

//        static void DisplayStudent(int number, string name, string age, string month, string grade)
//        {
//            string displayText = "Student Name: {0} \nStudent Age: {1} \nStudent Birth Month: {2} \n" +
//                                 "Student Grade: {3}";
//            Console.WriteLine(displayText, name, age, month, grade);
//            
//        }

        static string StudentInfoFormation(int number, string name, string age, string month, string grade)
        {
            string displayLine = "-----\nSTUDENT ID: {0}\n-----\n"+
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
        public int Phone;
        public int Number;

    }
}