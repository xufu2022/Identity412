﻿namespace Identity4121.Domain.Events
{
    public interface IDomainEventHandler<T>
           where T : IDomainEvent
    {
        Task HandleAsync(T domainEvent, CancellationToken cancellationToken = default);
    }
}
