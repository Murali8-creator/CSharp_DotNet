using CrudOperations.Models;
using CrudOperations.Models.DTO;
using CrudOperations.Service.command;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Repository
{
    public class UsersRepositoryImpl : UsersRepository
    {

        private readonly BrandContext _dbContext;

        public UsersRepositoryImpl(BrandContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddUser(User user)
        {
            

            _dbContext.Add(user);

            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }

            return 1;
        }

        

        public DbSet<User> GetAllUsers()
        {
            return _dbContext.Users;
        }

        public User GetUserById(int id)
        {
            User user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }
    }
}
