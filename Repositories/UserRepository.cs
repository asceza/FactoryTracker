
using FactoryTracker.Models;

namespace FactoryTracker.Repositories
{
    public class UserRepository
    {
        private readonly Dictionary<int, User> _users;


        public UserRepository()
        {
            _users = new Dictionary<int, User>();
        }


        private int IncrementUserId()
        {
            if (_users.Count == 0)
            {
                return 1;
            }
            else
            {
                return _users.MaxBy(k => k.Key).Key + 1;
                //return _users.Keys.Max() + 1;
            }
        }

        public void AddUser(User user)
        {
            int id = IncrementUserId();
            user.ID = id;
            _users.Add(id, user);
        }

        public User GetUser(int userId)
        {
            try
            {
                KeyValuePair<int, User> foundItem = _users.First(item => item.Key == userId);
                return foundItem.Value;
            }
            catch (Exception)
            {
                throw new Exception($"В словаре _users нет значения с ключом {userId}");
            }
        }
    }
}
