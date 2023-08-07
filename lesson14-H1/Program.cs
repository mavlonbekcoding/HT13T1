using System;
using System.Collections.Generic;

public class NotificationMessages
{
    private Dictionary<string, string> _messages;

    public NotificationMessages()
    {
        _messages = new Dictionary<string, string>
        {
            {"SuccRegistration", "You successfully registered"},
            {"AskPassword", "Enter your password"},
            {"Blocked", "Your account has been blocked"}
        };
    }

    protected KeyValuePai r<string, string>? FindMessage(string message)
    {
        if (_messages.TryGetValue(message, out var content))
            return new KeyValuePair<string, string>(message, content);
        else
            return null;
    }

    public string SearchMessage(string message)
    {
        var foundMessage = FindMessage(message);
        if (foundMessage.HasValue)
            return $"{foundMessage.Value.Key} - {foundMessage.Value.Value}";
        else
            return $"Message '{message}' not found.";
    }
}

public class Program
{
    public static void Main()
    {
        // Create an object of the NotificationMessages class
        var notificationService = new NotificationMessages();

        // Test cases
        string messageName1 = "SuccRegistration";
        string messageName2 = "AskPassword";
        string messageName3 = "NotFoundMessage";

        string message1 = notificationService.SearchMessage(messageName1);
        string message2 = notificationService.SearchMessage(messageName2);
        string message3 = notificationService.SearchMessage(messageName3);

        // Display messages
        Console.WriteLine(message1);
        Console.WriteLine(message2);
        Console.WriteLine(message3);
    }
}
