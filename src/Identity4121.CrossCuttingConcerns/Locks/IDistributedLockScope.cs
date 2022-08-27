namespace Identity4121.CrossCuttingConcerns.Locks
{
    public interface IDistributedLockScope : IDisposable
    {
        bool StillHoldingLock();
    }
}
