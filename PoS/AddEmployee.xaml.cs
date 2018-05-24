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
using System.Xml;
using System.Xml.Linq;

namespace PoS
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        private int empNo;
        private XElement employersXML;      
        public AddEmployee(int _empNo,string toDo)
        {
            InitializeComponent();
            empNo = _empNo;
        }

        public AddEmployee(int _empNo,XElement xmlelem)
        {
            InitializeComponent();
            empNo = _empNo;
            employersXML = xmlelem;
            NameBox.Text = GetName();
          //  SurnameBox.Text =
          //  Phone.Text =
        }

        string GetName()
        {
            string elx="";
            IEnumerable<XElement> name =
            from el in employersXML.Elements("Employee")
            where (string)el.Attribute("id") == empNo.ToString()
            select el.Elements("Name").First();
            foreach (XElement el in name) elx = (string)el;


            return elx;
            //IEnumerable<string> textSegs2 =
            // from seg in employersXML.Descendants("Name")
            // select (string)seg;

            //string str2 = textSegs2.Aggregate(new StringBuilder(),
            //    (sb, i) => sb.Append(i),
            //    sp => sp.ToString()
            //);
            //return str2;
        }
        // enum state


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
