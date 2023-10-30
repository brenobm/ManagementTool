namespace ManagementTool.Core.Services.Messaging;

public interface IEmailService
{
    Task SendEmailAsync(string email, string subject, string message);
}
