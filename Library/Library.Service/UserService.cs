using Library.Core;
using Library.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Library.Service
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User? GetUser(int userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public int GetNextUserId()
        {
            return _users.Count == 0 ? 1 : _users.Max(u => u.Id) + 1;
        }
    }
}