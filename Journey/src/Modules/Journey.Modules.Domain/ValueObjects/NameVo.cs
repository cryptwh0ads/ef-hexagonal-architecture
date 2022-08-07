using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using Flunt.Validations;

namespace Journey.Modules.Domain.ValueObjects;

public class NameVo: Notifiable<Notification>
{
    public NameVo(string name)
    {
        Name = name;
        Validate();
    }
    public string Name { get; private set; }

    public override string ToString()
    {
        return $"{Name}";
    }

    public void Validate()
    {
        AddNotifications(new Contract<NameVo>()
            .Requires()
            .IsGreaterThan(Name, 3, "Name", "O nome deve conter pelo menos 3 caracteres")
            .IsLowerThan(Name, 20, "Name", "O nome deve conter no máximo 20 caracteres"));
    }
}