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
    /// Interaction logic for UserSignup.xaml
    /// </summary>
    public partial class UserSignup : Page
    {
        public UserSignup()
        {
            InitializeComponent();
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            if (Password.Text == RepeatPassword.Text)
            {
                user.FirstName = FirstName.Text;
                user.MiddleName = MiddleName.Text;
                user.LastName = LastName.Text;
                user.Gender = Gender.Text;
                user.Birthday = Birthday.Text;
                user.City = City.Text;
                user.Phone = Phone.Text;
                user.Password = Password.Text;
                user.Email = Email.Text;

                MessageBox.Show(user.FirstName);
            }
            else
            {
                MessageBox.Show("Jimbo");
            }


        }
    }
}
