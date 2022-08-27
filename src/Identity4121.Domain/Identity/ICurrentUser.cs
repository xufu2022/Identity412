namespace Identity4121.Domain.Identity
{
    public interface ICurrentUser
    {
        bool IsAuthenticated { get; }

        Guid UserId { get; }
    }
}
