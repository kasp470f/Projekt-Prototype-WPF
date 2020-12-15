using Prototype_WPF.UserData;
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

namespace Prototype_WPF.Views.Partials
{
    /// <summary>
    /// Interaction logic for LoginUser.xaml
    /// </summary>
    public partial class LoginUser : Page
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void LoginAccount_Click(object sender, RoutedEventArgs e)
        {
            string PredefinedPassword = "kode13";
            string EmailLogin = "propane@hotmail.com";
            if (Password.Text == PredefinedPassword && Email.Text == EmailLogin)
            {


                MessageBox.Show("Jango");
            }
            else
            {
                MessageBox.Show("Jimbo");
            }


        }
    }
}
