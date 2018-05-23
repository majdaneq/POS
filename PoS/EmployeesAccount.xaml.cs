using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Resources;
using System.Reflection;

namespace PoS
{
    /// <summary>
    /// Interaction logic for EmployeesAccount.xaml
    /// </summary>
    public partial class EmployeesAccount : Page
    {
        XmlDocument xmlDocument;
        XElement xElement;
        public EmployeesAccount()
        {
            InitializeComponent();
            xElement = XElement.Load(@"XMLFile.xml");
        }

      
        //wspólne dane - nazwa pliku bazy
        const string FILE_NAME = "przyklad.xml";  //sciezka do bazy

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<XElement> childlist = from el in xElement.Elements() select el;

            foreach (XElement text in childlist) asd.Content = text;          

        }
    }
}
