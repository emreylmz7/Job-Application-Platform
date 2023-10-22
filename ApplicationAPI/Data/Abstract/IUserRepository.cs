using ApplicationAPI.Entity;

namespace ApplicationAPI.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users {get;}
        void CreateUser(User user);
    }
}