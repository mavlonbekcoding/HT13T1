using System.ComponentModel.DataAnnotations;

public class Program
{
    static void Main(string[] args)
    {
        Validator validator = new Validator();

        string inputName = "John";
        string formattedName;
        bool isValidName = Validator.IsValidName(inputName, out formattedName);

        Console.WriteLine($"IsValidName: {isValidName}, FormattedName: {formattedName}");

        string inputEmail = "John.Doe@example.com";
        string formattedEmail;
        bool isValidEmail = Validator.IsValidEmailAddress(inputEmail, out formattedEmail);

        Console.WriteLine($"IsValidEmailAddress: {isValidEmail}, FormattedEmailAddress: {formattedEmail}");

        int inputAge = 25;
        bool isValidAge = Validator.IsValidAge(inputAge);

        Console.WriteLine($"IsValidAge: {isValidAge}");

        string inputPhoneNumber = "1234567890";
        string formattedPhoneNumber;
        bool isValidPhoneNumber = Validator.IsValidPhoneNumber(inputPhoneNumber, out formattedPhoneNumber);

        Console.WriteLine($"IsValidPhoneNumber: {isValidPhoneNumber}, FormattedPhoneNumber: {formattedPhoneNumber}");
    }
}
