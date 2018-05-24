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

namespace PoS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int tryPassword = 3;
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { if (tryPassword == 0) this.Close();
            if (UserName.Text == "admin" && Password.Password == "admin")
            {
                MessageBox.Show("Login succesfull");                
                var programWindow = new ProgramWindow();
                programWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Remaining trials:" + tryPassword);
                tryPassword--;
            };
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) Button_Click(sender,e);
        }
    }
}
