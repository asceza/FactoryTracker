
using FactoryTracker.Models;

namespace FactoryTracker.Repositories
{
    public class UserRepository
    {
        private readonly Dictionary<int, User> _users;


        public UserRepository()
        {
            _users = new Dictionary<int, User>() { { 0, new User() } }; 
        }


        private int IncrementUserId()
        {
            return _users.MaxBy(k => k.Key).Key + 1;
            //return _users.Keys.Max() + 1;

        }

        public void AddUser(User user)
        {
            // здесь масло масленное???
            int id = IncrementUserId();
            user.ID = id;
            _users.Add(id, user);
        }

        public User GetUser(int userId)
        {
            KeyValuePair<int, User> foundItem = _users.FirstOrDefault(item => item.Key == userId);
            return foundItem.Value;
        }
    }
}
