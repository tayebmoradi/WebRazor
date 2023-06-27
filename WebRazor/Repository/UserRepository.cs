using WebRazor.Model;

namespace WebRazor.Repository
{
    public class UserRepository : IUser
    {
        public List<User> users()
        {
            var db = DataBase.Db.users.ToList();
            return db;
        }
    }
}
