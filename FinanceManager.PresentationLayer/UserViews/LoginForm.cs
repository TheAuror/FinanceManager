using System;
using System.Windows.Forms;
using FinanceManager.BusinessLayer.UserModels;

namespace FinanceManager.PresentationLayer.UserViews
{
    public partial class LoginForm : Form
    {
        private readonly LoginViewModel _loginViewModel;
        public LoginForm(LoginViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;
            InitializeComponent();
            loginBindingSource.DataSource = _loginViewModel;
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                _loginViewModel.Login(e);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
