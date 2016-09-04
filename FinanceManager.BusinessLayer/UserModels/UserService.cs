using System.Linq;
using System.Linq.Expressions;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.DataLayer;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.BusinessLayer.UserModels
{
    public class UserService : BaseService, IUserService
    {
        public UserService(ISampleContext context) : base(context)
        {
        }

        public UserModel GetUser(int id)
        {
            if (Context.Users.Any(e => e.Id == id))
            {
                UserModel model = new UserModel();
                UserEntity entity = Context.Users.FirstOrDefault(e => e.Id == id);
                model.Id = entity?.Id;
                model.UserName = entity?.UserName;
                model.Password = entity?.Password;
                return model;
            }
            else
            {
                return null;
            }
        }

        public UserModel GetUser(string username)
        {
            if (Context.Users.Any(e => e.UserName == username))
            {
                UserModel model = new UserModel();
                UserEntity entity = Context.Users.FirstOrDefault(e => e.UserName == username);
                model.Id = entity?.Id;
                model.UserName = entity?.UserName;
                model.Password = entity?.Password;
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}