
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummyset.Pages.login;

namespace Yummyset.Pages.Delivery.Database
{
    public class SQLRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public SQLRepository(AppDbContext context)
        {
            _context = context;
        }

        public User AddUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public User Delete(int id)
        {
            var userToDelete = _context.Users.Find(id);
            if (userToDelete!=null)
            {
                _context.Users.Remove(userToDelete);
                _context.SaveChanges();
            }
            return userToDelete;
        }

        public User FindByName(string name)
        {
            User user=_context.Users.Where(x => x.Name.Contains(name)).FirstOrDefault(x=>x.Id==1);

            return user;
        }

        public IEnumerable<User> GetAllusers()
        {
            return _context.Users;
        }

        public User GetUserById(int Id)
        {
            return _context.Users.Find(Id);
        }

        public User Update(User updateUser)
        {
            var user = _context.Users.Attach(updateUser);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updateUser;
        }
        
    }
}
