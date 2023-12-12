using WebApplication1.Models;

namespace WebApplication1.Bl
{
    public interface IUserService
    {
        public Task<List<User>> GetUsersAsync();
        public string UpdateUserAsync(User user);
        public void DeleteUserAsync(User user);
        public User GetUserByIdAsync(int id);
        public User AddUserAsync(User user);



        public Task<string> GetUsers();
    }
}