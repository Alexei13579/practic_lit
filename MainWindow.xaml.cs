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

namespace Lebedev_pract_Litvin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }





        private void Button_click(object sender, RoutedEventArgs e)
        {
            var login = LogBox.Text;
            var pass = PasswrdBox.Password;
            var context = new AppDbContext();
            var user_exists = context.Users.FirstOrDefault(x => x.Login == login || x.Email == login && x.Password == pass);
            if (user_exists is null)
            {
                oshibka1.Text = ("Неправильный логин или пароль");
                return;
            }
            new Pustoewin().Show();
            Close();

        }

        private void Button_click_1(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
            Close();

        }

        private void EyeBtn_Click(object sender, RoutedEventArgs e)
        {
            if(TextBox.Visibility == Visibility.Collapsed) 
            {
                TextBox.Text = PasswrdBox.Password;
                TextBox.Visibility = Visibility.Visible;
                PasswrdBox.Visibility = Visibility.Collapsed;
            }
            else
            {
                PasswrdBox.Password = TextBox.Text;
                TextBox.Visibility= Visibility.Collapsed;
                PasswrdBox.Visibility= Visibility.Visible;
            }


        }

        
    }
}
