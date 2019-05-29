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

            //foreach loop
            foreach (var i in studentGrades)
            {
                Console.WriteLine("The Student grade is {0}", i.ToString());
            }
            
        }
    }
}