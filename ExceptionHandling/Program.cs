internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter first Number");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second NUmber");
        int num2=int.Parse(Console.ReadLine());
        try
        {
            int result = num1 / num2;
            Console.WriteLine("Division Result is:" + result);

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You can not divide a number by Zero");
  Console.WriteLine(ex.Message);
        }
        
        Console.WriteLine("Remaining Program-1");
        Console.WriteLine("Remaining Program-2");
        Console.WriteLine("Remaining Program-3");
        Console.WriteLine("Remaining Program-4");


    }
}