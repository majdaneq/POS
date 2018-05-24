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
        XElement xElement;

        public EmployeesAccount()
        {
            InitializeComponent();
            xElement = XElement.Load("Employees.xml");
            LoadElements();
        }

        public int empNo;
        private void LoadElements()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("Employees.xml");
            DataView dataView = new DataView(dataSet.Tables[0]);        
            dataView.Table.Columns.Remove("id");
            empNo = dataView.Table.Rows.Count;
            NameGrid.ItemsSource = dataView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<XElement> childlist = from el in xElement.Elements() select el;

            foreach (XElement text in childlist) asd.Content = text;          // wszystkie elementy

            IEnumerable<string> textSegs =
            from seg in xElement.Descendants("Name")
                select (string)seg;

            string str = textSegs.Aggregate(new StringBuilder(),
                (sb, i) => sb.Append(i),
                sp => sp.ToString()
            ); 

            asd.Content = str;//wszystkie z zadanego węzła


            string grandChild3 = (string)
            (from el in xElement.Descendants("Name")
             select el).First();

            asd.Content = grandChild3; //pierwszy element węzla


            IEnumerable<string> textSegs2 =
             from seg in xElement.Descendants("Name")
             select (string)seg;

            string str2 = textSegs.Aggregate(new StringBuilder(),
                (sb, i) => sb.Append(i),
                sp => sp.ToString()
            );  //wszystkie elementy o konkretnej wartosci

            asd.Content = str2;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            XElement root = new XElement("Root",
                new XElement("Child1", "Value1"),
                new XElement("Child2", "Value2"),
                new XElement("Child3", "Value3"),
                new XElement("Child4", "Value4")
            );

            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (XElement el in root.Elements())
                dict.Add(el.Name.LocalName, el.Value);
            foreach (string str in dict.Keys) bbb.Content = str;//tworzenie nowego xml
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var programWindow = new AddEmployee(empNo);
            programWindow.Show();
            empNo++;            
            LoadElements();
        }        
    }
}
