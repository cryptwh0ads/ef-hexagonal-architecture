using System;

namespace Journey.Modules.Domain;

internal interface IEntity
{
    Guid Id { get; }
}