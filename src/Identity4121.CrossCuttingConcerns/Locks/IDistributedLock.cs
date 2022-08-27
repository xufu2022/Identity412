﻿namespace Identity4121.CrossCuttingConcerns.Locks
{
    public interface IDistributedLock : IDisposable
    {
        IDistributedLockScope Acquire(string lockName);

        IDistributedLockScope TryAcquire(string lockName);
    }
}
