using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Get Student's Name
            var strName = AskQuestion("What is your name");
            Console.WriteLine("Your name is {0}.", strName);
            
            //Get Student's Age
            var strAge = AskQuestion("What is your age");
            
            //Get Student's Birth Month
            var strMonth = AskQuestion("What is your birth month");

            var strGrade = AskQuestion("What is your grade");
            
            //Display the information
            DisplayStudent(strName.ToString(), strAge.ToString(), strMonth.ToString(), strGrade.ToString());

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
            string displayText = "--------\n STUDENT INFORMATION\n--------\nStudent Name: {0} \nStudent Age: {1} \nStudent Birth Month: {2} \n" +
                                 "Student Grade: {3}";
            Console.WriteLine(displayText, name, age, month, grade);
            
        }
    }
}