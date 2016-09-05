using System.ComponentModel;
using System.Windows.Forms;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.UserModels;

namespace FinanceManager.PresentationLayer.UserViews
{
    public class LoginViewModel : BaseModel
    {
        private readonly IUserService _userService;
        private string _userName;
        private string _password;

        public LoginViewModel(IUserService userService)
        {
            _userService = userService;
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                OnPropertyChanged(ref _userName, value);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                OnPropertyChanged(ref _password, value);
            }
        }

        public void Login(CancelEventArgs args)
        {
            UserModel userModel = _userService.Login(UserName, Password);
            if (userModel != null)
            {
                _userService.LoggedInUser = userModel;
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                args.Cancel = true;
            }
        }
    }
}
