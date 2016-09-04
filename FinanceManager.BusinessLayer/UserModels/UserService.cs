using FinanceManager.BusinessLayer.Common;
using FinanceManager.DataLayer;

namespace FinanceManager.BusinessLayer.UserModels
{
    public class UserService : BaseService, IUserService
    {
        public UserService(ISampleContext context) : base(context)
        {
        }

        public UserModel GetUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public UserModel GetUser(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}