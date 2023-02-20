// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(String[] args)
    {
        int option;
        Console.WriteLine("enter an option : ");
        Console.WriteLine("[0] SignUp!");
        Console.WriteLine("[1] SignIn");
        option = Convert.ToInt32(Console.ReadLine());

        if (option == 0)
        {
            Console.Write("ok");
        }
        else{
            Console.WriteLine("Enter username : ");
            string? username = Console.ReadLine();
            Console.WriteLine("Enter password : ");
            string? password = Console.ReadLine();
        }


    }


    
}
