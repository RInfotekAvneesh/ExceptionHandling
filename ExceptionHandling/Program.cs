using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Exception-1 Divide BY Zero Exception

        //      Console.WriteLine("Enter first Number");
        //      int num1=int.Parse(Console.ReadLine());
        //      Console.WriteLine("Enter second NUmber");
        //      int num2=int.Parse(Console.ReadLine());
        //      try
        //      {
        //          int result = num1 / num2;
        //          Console.WriteLine("Division Result is:" + result);

        //      }
        //      catch (DivideByZeroException ex)
        //      {
        //          Console.WriteLine("You can not divide a number by Zero");
        //Console.WriteLine(ex.Message);
        //      }

        //      Console.WriteLine("Remaining Program-1");
        //      Console.WriteLine("Remaining Program-2");
        //      Console.WriteLine("Remaining Program-3");
        //      Console.WriteLine("Remaining Program-4");

        // Exception - 2 Index Out of Range Exception

        //int[] arr = new int[3];
        //try
        //{
        //    arr[0] = 5;
        //    arr[1] = 10;
        //    arr[2] = 20;
        //    arr[3] = 30;
        //    foreach (int i in arr)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}
        //catch (IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine("Array Range is exceeded------");
        //    Console.WriteLine(ex.Message);

        //}


        //  Exception-3 NULL Refrence Exception
        //try
        //{
        //    string name =null;
        //    Console.WriteLine(name.Length);

        //}
        //catch (NullReferenceException ex)
        //{
        //    Console.WriteLine("String is Null");
        //    Console.WriteLine(ex.Message);


        //}

        // Exception-4 Handle Format Exception
        //Console.WriteLine("Enter a Number");
        //string number = Console.ReadLine();

        //try
        //{

        //    int num = int.Parse(number);
        //    Console.WriteLine("Number is:" + num);

        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("String format is invalid--------");
        //    Console.WriteLine(ex.Message);

        //}
        //Console.WriteLine("Execute");

        //Try with Multiple Catch
        try
        {
            int a = 10;
            int b = 0;
            int c = a / b;

            string f = null;
            Console.WriteLine(f.Length);

            int[] arr=new int[3];
            arr[0] = 11;
            arr[1] = 12;
            arr[2] = 13;
            arr[3] = 14;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);

            
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);


        }
        Console.WriteLine();





    }
}