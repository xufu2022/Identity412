﻿namespace Identity4121.Domain.Repositories
{
    public interface IConcurrencyHandler<TEntity>
    {
        void SetRowVersion(TEntity entity, byte[] version);

        bool IsDbUpdateConcurrencyException(Exception ex);
    }
}
