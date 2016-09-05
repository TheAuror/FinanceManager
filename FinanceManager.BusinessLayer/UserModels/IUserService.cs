namespace FinanceManager.BusinessLayer.UserModels
{
    public interface IUserService
    {
        UserModel LoggedInUser { get; set; }
        UserModel GetUser(int id);
        UserModel GetUser(string username);
        bool SaveUser(UserModel user);
        UserModel Login(string username, string password);
    }
}