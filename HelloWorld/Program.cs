using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
            var strName = Console.ReadLine();
            if (strName == "")
            {
                strName = TryAgain();
            }
            Console.WriteLine("How old are you?");
            var strAge = Console.ReadLine();
            if (strAge == "")
            {
                strAge = TryAgain();
            }
            Console.WriteLine("What is your birth month?");
            var strMonth = Console.ReadLine();
            if (strMonth == "")
            {
                strMonth = TryAgain();
            }
            
            Console.Write("Client Name: {0} \n" +
                          "Client Age: {1} \n" +
                          "Client Birth Month: {2} \n" 
                ,strName, strAge, strMonth);

            switch (strMonth)
            {
                case "March":
                    Console.WriteLine("You are an Aries");
                    break;
                case "April":
                    Console.WriteLine("You are a Taurus.");
                    break;
                default:
                    Console.WriteLine("We Dont know your sign.");
                    break;
            }

        }

        static string TryAgain(string value)
        {
            if (value == " ")
            {
                Console.WriteLine("You did not enter anything, Please try again.");
                value = Console.ReadLine();
            }

            return value;

        }
    }
}