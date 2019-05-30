using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the number of Students
            int studentCount = int.Parse(AskQuestion("How many students"));
            
            //Create the student array
            var studentInformation = new string[studentCount];
            
            //Loop through and grab the info for all students
            for (int i = 1; i < studentCount + 1; i++)
            {
                //get Array index
                var arrayIndex = i - 1;
                Console.WriteLine("Array index is {0}", arrayIndex.ToString());
                //Ask the Questions and gather the Answers.
                var name = AskQuestion("What the student name");
                var age = AskQuestion("What is the student age");
                var month = AskQuestion("What is the student birth month");
                var grade = AskQuestion("What is the student grade");
                studentInformation[arrayIndex] = StudentInfoFormation(name, age, month, grade);
                
            }

            int studentCounter = 0;
            //Display all students in array
            foreach (var i in studentInformation)
            {
                int studentNumber = studentCounter + 1;
                Console.WriteLine("-----\nSTUDENT ID: {0}\n-----", studentNumber.ToString());
                Console.WriteLine(i);
                studentCounter++;
            }
            
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

        static void DisplayStudent(string name, string age, string month, string grade)
        {
            string displayText = "Student Name: {0} \nStudent Age: {1} \nStudent Birth Month: {2} \n" +
                                 "Student Grade: {3}";
            Console.WriteLine(displayText, name, age, month, grade);
            
        }

        static string StudentInfoFormation(string name, string age, string month, string grade)
        {
            string displayLine = "Student Name: {0} \nStudent Age: {1} \nStudent Birth Month: {2} \n" +
                                 "Student Grade: {3}";
            string value = String.Format(displayLine, name, age, month, grade);
            return value;
        }
    }
}