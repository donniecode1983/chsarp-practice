using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Arrays
            //School Tracker
            var studentGrades = new int[10] {80, 77, 45, 87, 53, 43, 67, 34, 23, 76};

            for (int i = 0; i < 10; i++)
            {
                var ctStudent = i + 1;
                Console.WriteLine("Student {0}'s Grade is {1}", ctStudent.ToString(), studentGrades[i].ToString());
            }
            
        }
    }
}