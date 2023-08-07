public class Program
{
    static void Main()
    {
        // Get email address and username from the user
        Console.Write("Enter your email address: ");
        string emailAddress = Console.ReadLine();

        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        // Initialize the EmailService with credentials
        var emailService = new EmailService("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");

        // Send the email after registration
        emailService.SendEmail(emailAddress, username);

        Console.WriteLine("Registration email sent successfully.");
    }
}
