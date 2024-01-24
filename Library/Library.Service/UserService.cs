using Library.Core;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>();
            // Możesz tu dodać kilku użytkowników dla testów
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public int GetNextUserId()
        {
            return _users.Count == 0 ? 1 : _users.Max(user => user.Id) + 1;
        }

        // Inne metody
    }
}