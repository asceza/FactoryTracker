
using FactoryTracker.Models;

namespace FactoryTracker.Repositories
{
    public class UserRepository
    {
        private Dictionary<long, User> _users;

        private static long _userId = 0;

        private long IncrementUserId()
        {
            return _userId++;
        }

        public void AddUser(User user)
        {
            _users.Add(IncrementUserId(), user);
        }

        public User GetUser(long userId)
        {
            KeyValuePair<long, User> foundItem = _users.FirstOrDefault(item => item.Key == userId);
            return foundItem.Value;
        }
    }
}
