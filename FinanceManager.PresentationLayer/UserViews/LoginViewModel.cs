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
            if (string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(UserName))
            {
                args.Cancel = true;
                return;
            }
            UserModel userModel = _userService.Login(UserName, Password);
            if (userModel != null)
            {
                Properties.Settings.Default["LastLoggedInUser"] = userModel.UserName;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                args.Cancel = true;
            }
        }

        public void Register()
        {
            if (_userService.GetUser(UserName) != null)
            {
                MessageBox.Show("Foglalt felhasználónév!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Password.Length < 8)
            {
                MessageBox.Show("Túl rövid jelszó!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _userService.SaveUser(new UserModel {UserName = UserName, Password = Password});
            MessageBox.Show("Sikeres regisztráció!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
