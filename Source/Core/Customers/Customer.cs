using System;
using Core.SharedKernel.Domain;

namespace Core.Customers
{
    public class Customer : IAggregateRoot
    {
        public Guid Id { get; }
        public virtual string FirstName { get; protected set; }
        public virtual string LastName { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Password { get; protected set; }
    }
}