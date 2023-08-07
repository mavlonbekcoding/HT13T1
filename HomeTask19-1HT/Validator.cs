namespace HomeTask19_1HT;

using System;

public class Validator
{
    public static bool IsValidName(in string name, out string formattedName)
    {
        formattedName = FormatName(name);

        if (name.Contains("@"))
        {
            return false; // Invalid nom
        }

        return true; // Valid nom
    }

    public static string FormatName(string name)
    {
        return name.ToUpper();
    }

    public static bool IsValidEmailAddress(in string emailAddress, out string formattedEmailAddress)
    {
        formattedEmailAddress = FormatEmailAddress(emailAddress);

        if (!IsValidEmail(formattedEmailAddress))
        {
            return false; // Invalid email manzil
        }

        return true; // Valid email manzil
    }


    public static string FormatEmailAddress(string emailAddress)
    {
        return emailAddress.ToLower();
    }

    public static bool IsValidAge(in int age)
    {
        if (age >= 0 && age <= 150)
        {
            return true; // Valid yosh
        }

        return false; // Invalid yosh
    }

    public static bool IsValidPhoneNumber(in string phoneNumber, out string formattedPhoneNumber)
    {
        formattedPhoneNumber = FormatPhoneNumber(phoneNumber);

        if (!IsValidPhone(phoneNumber))
        {
            return false; // Invalid telefon raqami
        }

        return true; // Valid telefon raqami
    }

    public static string FormatPhoneNumber(string phoneNumber)
    {
        return "+" + phoneNumber; // Masalan: +1234567890
    }

    public static bool IsValidPhone(string phone)
    {
        return phone.Length >= 10 && phone.All(char.IsDigit);
    }
}


