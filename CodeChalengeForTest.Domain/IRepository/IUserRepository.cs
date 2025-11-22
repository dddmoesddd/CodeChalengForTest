namespace CodeChalengeForTest.Domain.IRepository
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User> GetByIdAsync(Guid id);
        Task<User> GetByUsernameAsync(string username);
        Task<User> GetByUserNameAndPasswordAsync(string username, string password);
    }
}
