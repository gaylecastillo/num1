namespace num1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rightusername = "Admin";
            string rightpassword = "Admin1234!";
            int i = 0;
            while (i < 3)
            {
                Console.Write("Username: ");
                string username;
                username = Console.ReadLine();

                Console.Write("Password: ");
                string password;
                password = Console.ReadLine();

                if (rightusername == username && rightpassword == password)
                {
                    Console.WriteLine("Login Successful.");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Credentials.");
                    i++;


                    Console.WriteLine($"{3 - i} attempt(s) left");
                }
            }
            if (i == 3)
            {

                Console.WriteLine("Maximum attempt exceeded.");
            }
        }
    }
}
