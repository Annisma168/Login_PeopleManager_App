using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login_PeopleManager_App
{
    /// <summary>
    /// Logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;

            //before we have created a new password in System enviroment variables on PC
            // password - Test123
            string envPw = Environment.GetEnvironmentVariable("LoginApp_Udemy_Lesson278");

            if (envPw != null)
            {
                if (passwordEntered == envPw)
                {
                    MessageBox.Show("Correct password!");
                    Window window = Window.GetWindow(this);
                    window.Content = new InvoiceView();
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
            }
            else 
            {
                MessageBox.Show("Enviroment variable is not found");
            }
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
