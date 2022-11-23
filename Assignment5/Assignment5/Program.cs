// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
Console.WriteLine("* calculator v0.1 * ");
/*Console.Write("\t\n how can i help you ? please enter your number?:");
int  num1  = Convert.ToInt32(Console.ReadLine());
Console.Write("\t\nplease enter your second number!:");
int num2 = Convert.ToInt32(Console.ReadLine());
normally use codes are when there are only int,but what if we have doubles?
Console.WriteLine(num1 + num2);
lets try to doubles 
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("\t\nplease enter your second number!:");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(num1 + num2);
all of these codes are time consuming and make our work hard so lets do it a smart way by using
switch and loops*/
do
{
    double num1 = 0;
    double num2 = 0;
    double answer = 0;
    Console.Write("Enter a number 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter a second number 2 : ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nOperations:");
    Console.WriteLine("\t 1. Addition ");
    Console.WriteLine("\t 2. Subtraction ");
    Console.WriteLine("\t 3. Division ");
    Console.WriteLine("\t 4. Multiplication ");
    Console.WriteLine("\t 5  Modulus ");
    Console.Write("\nWhat operation do you want to perform? (1-5): ");
   //switch to help specify different cases
    switch (Console.ReadLine())
    {


        case "1":
            answer = num1 + num2;
            Console.WriteLine($"\nResult: {answer}");
            break;
        case "2":
            answer = num1 - num2;
            Console.WriteLine($"\nResult:    {answer}");
            break;
        case "3":
            answer = num1 / num2;
            Console.WriteLine($"\nResult:    {answer}");
            break;
        case "4":
            answer = num1 * num2;
            Console.WriteLine($"\nResult:   {answer}");
            break;
        case "5":
            answer = num1 % num2;
            Console.WriteLine($"\nResult:   {answer}");
            break;
        default:
            Console.WriteLine("please choose an correct option");
            break;
    }
      Console.Write("\nDo you want to perform another calculation ? (Y/N) : ");
}     while (Console.ReadLine().ToUpper() == "Y");
      Console.WriteLine(" * Exiting * ");
//do while loops helps to restart the programme if user want to do more calculation
 

 