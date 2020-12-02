using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummyset.Pages.login;

namespace Yummyset.Pages.Delivery.Database
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllusers();
        public User GetUserById(int Id);
        public User AddUser(User newUser);
        public User Delete(int id);
        public User Update(User updateUser);
        public User FindByName(string name);
    }
}
