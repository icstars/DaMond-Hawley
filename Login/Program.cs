using System;
// Namespace for the Login System
namespace LoginDemo
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public void Submit()
        {
            try
            {
                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    throw new ArgumentException("Username or Password cannot be empty.");
                }
               
                if (Username == "admin" && Password == "password")
                {
                    Console.WriteLine("Admin login successful!");
                }
                else if (Username == "user" && Password == "1234")
                {
                    Console.WriteLine("User login successful!");
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
// Main Program
class Program
{
    static void Main(string[] args)
    {
        LoginDemo.Login login = new LoginDemo.Login();
       
        Console.WriteLine("Enter username:");
        login.Username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        login.Password = Console.ReadLine();
        login.Submit();
    }
}