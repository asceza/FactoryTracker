
using FactoryTracker.Models;

namespace FactoryTracker.Repositories
{
    public class UserRepository
    {
        private readonly Dictionary<int, User> _users;

        private int _userId = 0;

        private int IncrementUserId()
        {
            return _userId++;
        }

        public void AddUser(User user)
        {
            _users.Add(IncrementUserId(), user);
        }

        public User GetUser(int userId)
        {
            KeyValuePair<int, User> foundItem = _users.FirstOrDefault(item => item.Key == userId);
            return foundItem.Value;
        }
    }
}
