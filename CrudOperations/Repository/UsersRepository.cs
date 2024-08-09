using CrudOperations.Models;

using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Repository
{
    public interface UsersRepository
    {
        DbSet<User> GetAllUsers();

        public int AddUser(User user);

        public User GetUserById (int id);
    }
}
