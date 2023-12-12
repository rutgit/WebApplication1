//using WebApplication1.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.ChangeTracking;

//namespace WebApplication1.Dal
//{
//    public class UserDAL : IUserDAL
//    {
//        private readonly PractikumContext _practikumContext;
//        public UserDAL(PractikumContext practikumContext)
//        {
//            this._practikumContext = practikumContext ?? throw new ArgumentNullException(nameof(practikumContext));
//        }


       




//        public User AddUserAsync(User user)
//        {
//            throw new NotImplementedException();
//        }

//        public void DeleteUserAsync(User user)
//        {
//            throw new NotImplementedException();
//        }

//        public User GetUserByIdAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<List<User>> GetUsersAsync()
//        {
//            try
//            {
//                return await _practikumContext.Users.ToListAsync();
//            }catch(Exception ex)
//            {
//                throw new Exception("can't get users" + ex);
//            }
//        }

//        public string UpdateUserAsync(User user)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
