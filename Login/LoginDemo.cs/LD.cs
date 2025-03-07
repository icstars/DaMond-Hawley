
namespace LoginDemo
{
    public class LD    {
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