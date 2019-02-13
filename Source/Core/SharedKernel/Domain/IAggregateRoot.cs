using System;

namespace Core.SharedKernel.Domain
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}