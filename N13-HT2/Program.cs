using System;
using System.Collections.Generic;
using System.Text;


PasswordGenerate passwordGenerator = new PasswordGenerate();
string password1 = passwordGenerator.Generate(10, false, false);
Console.WriteLine("1. Password: " + password1);


SecurePasswordGenerator securePasswordGenerator = new SecurePasswordGenerator();
string password2 = securePasswordGenerator.Generate(12, true, true, true);
Console.WriteLine("2. Password: " + password2);


UniquePasswordGenerate uniquePasswordGenerator = new UniquePasswordGenerate();
string password3 = uniquePasswordGenerator.GenerateUniquePassword(8, true, true, false);
Console.WriteLine("3. Unique Password: " + password3);
public class PasswordGenerate
{
    public string Generate(int length, bool hasLetters, bool hasDigits = true)
    {
        string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        if (hasDigits)
            characters += "0123456789";

        StringBuilder password = new StringBuilder();
        Random random = new Random();

        while (password.Length < length)
        {
            int index = random.Next(0, characters.Length);
            password.Append(characters[index]);
        }

        return password.ToString();
    }
}

public class SecurePasswordGenerator : PasswordGenerate
{
    public string Generate(int length, bool hasLetters, bool hasDigits = true, bool hasSymbols = true)
    {
        string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        if (hasDigits)
            characters += "0123456789";
        if (hasSymbols)
            characters += "!@#$%^&*()_+-=[]{}|;:,.<>?";

        StringBuilder password = new StringBuilder();
        Random random = new Random();

        while (password.Length < length)
        {
            int index = random.Next(0, characters.Length);
            password.Append(characters[index]);
        }

        return password.ToString();
    }
}



public class UniquePasswordGenerate : SecurePasswordGenerator
{
    private HashSet<string> generatedPasswords = new HashSet<string>();

    public string GenerateUniquePassword(int length, bool hasLetters, bool hasDigits = true, bool hasSymbols = true)
    {
        string password;
        do
        {
            password = Generate(length, hasLetters, hasDigits, hasSymbols);
        }
        while (!generatedPasswords.Add(password));

        return password;
    }
}
