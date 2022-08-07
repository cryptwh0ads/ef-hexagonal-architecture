using Flunt.Notifications;
using Flunt.Validations;

namespace Journey.Modules.Domain.ValueObjects;

public class EmailVo: Notifiable<Notification>
{
    public EmailVo(string email)
    {
        Email = email;
        Validate();
    }
    
    public string Email { get; private set; }

    public void Validate()
    {
        AddNotifications(new Contract<EmailVo>()
            .Requires()
            .IsEmail(Email, "Email", "O e-mail é inválido"));
    }
}