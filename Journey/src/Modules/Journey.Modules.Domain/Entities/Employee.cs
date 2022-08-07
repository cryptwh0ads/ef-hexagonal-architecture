using System;
using Flunt.Notifications;
using Journey.Modules.Domain.ValueObjects;

namespace Journey.Modules.Domain.Entities;

public class Employee : Notifiable<Notification>, IEntity
{
    public Guid Id { get; private set; }

    public Employee(NameVo name, EmailVo email, string phone)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Phone = phone;

        Validate();
    }
    
    public NameVo Name { get; private set; }
    public EmailVo Email { get; private set; }
    public string Phone { get; private set; }

    public override string ToString()
    {
        return Name.ToString();
    }

    public void Validate()
    {
        AddNotifications(
            new Flunt.Validations.Contract<Employee>()
                .IsTrue(Name.IsValid, "Name", "Nome inválido")
                .IsTrue(Email.IsValid, "Email", "E-mail inválido"));
    }
    
}