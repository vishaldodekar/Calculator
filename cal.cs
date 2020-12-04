using System;
class cal 
{
    public void Addition()
    {
        Console.WriteLine("\n------------------Addition-----------");
        System.Console.WriteLine("Enter First Number");
        int num1=Convert.ToInt32( Console.ReadLine());
        System.Console.WriteLine("Enter Second Number");
        int num2=Convert.ToInt32( Console.ReadLine());
        Console.WriteLine( "\n"+num1+" + " + num2 + " = " + (num1+num2));

    }
     public void Subtraction()
    {
        Console.WriteLine("\n------------------Subtraction-----------");
        System.Console.WriteLine("Enter First Number");
        int num1=Convert.ToInt32( Console.ReadLine());
        System.Console.WriteLine("Enter Second Number");
        int num2=Convert.ToInt32( Console.ReadLine());
        Console.WriteLine( "\n"+num1+" - " + num2 + " = " + (num1-num2));

    }
     public void Multiplication()
    {
        Console.WriteLine("\n------------------Multiplication-----------");
        System.Console.WriteLine("Enter First Number");
        int num1=Convert.ToInt32( Console.ReadLine());
        System.Console.WriteLine("Enter Second Number");
        int num2=Convert.ToInt32( Console.ReadLine());
        Console.WriteLine( "\n" +num1+" * " + num2 + " = " + (num1*num2));

    }
     public void Division()
    {
        Console.WriteLine("\n------------------Division-----------");
        System.Console.WriteLine("Enter First Number");
        int num1=Convert.ToInt32( Console.ReadLine());
        System.Console.WriteLine("Enter Second Number");
        int num2=Convert.ToInt32( Console.ReadLine());
        Console.WriteLine( "\n" +num1+" / " + num2 + " = " + (num1/num2));

    }
    public static void Main(string[] args)
    {
        cal cl=new cal();
        // // cl.Addition();
        // // cl.Subtraction();
        // // cl.Multiplication();
        // cl.Division();
        while(true){

        
        Console.WriteLine("---------------calculator----------");
        Console.WriteLine("\n Addition press + \n Subtraction press - \n Multiplication press * \n Division press /");
        string op=Console.ReadLine();
        switch(op)
        {
            case "+":
            {
                cl.Addition();
                break;
            }
            case "-":
            {
                cl.Subtraction();
                break;

            }
            case "*":
            {
                cl.Multiplication();
                break;
            }
            case "/":
            {
                cl.Division();
                break;
            }
            default:
            {
                Console.WriteLine("\n Please seleect correct operator");
                break;
            }
        }
            Console.WriteLine("Do you want to Break Yes (Y/y)  Or No(N/n)");
            string status=Console.ReadLine();
            if(status.Equals("Y") || status.Equals("y"))
            {
                break;
            }
        }
    }
}