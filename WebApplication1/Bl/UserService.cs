using WebApplication1.Dal;
using WebApplication1.Models;

namespace WebApplication1.Bl
{
    public class UserService : IUserService
    {
        //private readonly IUserDAL _userDAL;
        //public UserService(IUserDAL userDAL)
        //{
        //    this._userDAL = userDAL ?? throw new ArgumentNullException(nameof(userDAL));
        //}
        public User AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            // return await _userDAL.GetUsersAsync();
            throw new NotImplementedException();

        }


        public async Task<string> GetUsers()
        {

            {
                string baseUrl = "https://jsonplaceholder.typicode.com/users";

                try
                {

                    using (HttpClient client = new HttpClient())
                    {

                        using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                        {

                            using (HttpContent content = res.Content)
                            {

                                var data = await content.ReadAsStringAsync();

                                if (data != null)
                                {

                                    Console.WriteLine("data------------{0}", data);
                                    return data;
                                }
                                else
                                {
                                    Console.WriteLine("NO Data----------");
                                    return "bhui";
                                }
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception Hit------------");
                    Console.WriteLine(exception);
                    return null;
                }
            }
        }



        public string UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
