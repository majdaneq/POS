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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace PoS
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        private int empNo;
        public AddEmployee(int _empNo)
        {
            InitializeComponent();
            empNo = _empNo;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XDocument xDocument = XDocument.Load("Employees.xml");
            XElement newEmployee = new XElement("Employee",
                new XAttribute("id", empNo),
                new XElement("Name", NameBox.Text),
            new XElement("Surname", SurnameBox.Text),
            new XElement("PhoneNumber", Phone.Text));            
            xDocument.Element("Employees").Add(newEmployee);
            xDocument.Save("Employees.xml");
            this.Close();
        }
    }
}
