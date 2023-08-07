using System.Security.Cryptography.X509Certificates;

var service = new EmailTemplateService();
//service.Add();

public class EmailTemplateService
{
    

    public void Add(string subject, string content)
    {

    }

    public string GetRegistrationTemplate(string name)
    {

    }

    public string GetAccountBlockedTemplate(string name)
    {

    }
}

public class EmailTemplate
{
    public string Subject { get; set; }
    public string Content { get; set; }

    public EmailTemplate()
    {
        

    }
}


public static class MessageConstants
{

}