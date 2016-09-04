namespace FinanceManager.BusinessLayer.UserModels
{
    public interface IUserService
    {
        UserModel GetUser(int id);
        UserModel GetUser(string username);
    }
}