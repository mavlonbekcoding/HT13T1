using System;
using System.Collections.Generic;

class ChatMessage
{
    public int Id { get; }
    public DateTime SentTime { get; }
    public DateTime EditedTime { get; }
    public string Content { get; }

    public ChatMessage(string content)
    {
        Id = GetNextId();
        SentTime = DateTime.Now;
        Content = content;
    }

    public ChatMessage(ChatMessage chatMessage)
    {
        Id = chatMessage.Id;
        SentTime = chatMessage.SentTime;
        EditedTime = DateTime.Now;
        Content = chatMessage.Content;
    }

    private static int currentId = 1;

    private static int GetNextId()
    {
        return currentId++;
    }
}

class ChatService
{
    public List<ChatMessage> Messages { get; }

    public ChatService()
    {
        Messages = new List<ChatMessage>();
    }

    public int Add(string content)
    {
        if (MessageValidator.IsValidMessage(content))
        {
            ChatMessage message = new ChatMessage(content);
            Messages.Add(message);
            return message.Id;
        }
        else
        {
            throw new ArgumentException("Invalid message content");
        }
    }

\
    public void Display()
    {
        foreach (ChatMessage message in Messages)
        {
            Console.WriteLine($"{message.Content} - {message.EditedTime.ToString("dd.MM.yyyy HH:mm")}");
        }
    }
}

static class MessageValidator
{
    public static bool IsValidMessage(string content)
    {
        // Bu metodda siz xabarni tekshirish uchun kerakli shartlarni yozishingiz kerak
        // Misol uchun, content uzunligi, simvollar, yoki boshqa validatsiya shartlari
        // Agar xabar to'g'ri bo'lsa true qaytarilsin, aks holda false qaytarilsin.
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ChatService chatService = new ChatService();

        int messageId1 = chatService.Add("Hi everybody");
        int messageId2 = chatService.Add("Let's get started");
        int messageId3 = chatService.Add("We'll start the meeting in 10 minutes");

        chatService.Update(messageId3, "Sorry guys, we are having technical issues, let's wait for another 10 minutes");
        chatService.Update(messageId3, "I'm really sorry meeting is cancelled");

        chatService.Display();
    }
}
