using Library.Core;

namespace Library.Service
{
    public interface IUserService
    {
        void AddUser(User user);
        User? GetUser(int userId);
        IEnumerable<User> GetAllUsers();
        int GetNextUserId();
        // Tutaj możesz dodać inne metody, które uznasz za potrzebne
    }
}