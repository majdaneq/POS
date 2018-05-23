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

namespace PoS
{
    /// <summary>
    /// Interaction logic for ProgramWindow.xaml
    /// </summary>
    public partial class ProgramWindow : Window
    {
        public ProgramWindow()
        {
            InitializeComponent();

        }

        private void EmployeesAccountButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramFrame.Content = new EmployeesAccount();
            SetBgButtons(1);
        }

        private void CustomerAccountButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramFrame.Content = new CustomerAccount();
            SetBgButtons(2);
        }

        private void ManageProductButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramFrame.Content = new ManageProduct();
            SetBgButtons(3);
        }          

        private void PrintInvoiceButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramFrame.Content = new PrintInvoice();
            SetBgButtons(4);
        }

        private void DailyDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramFrame.Content = new DailyDetails();
            SetBgButtons(5);
        }

        private void LedgersButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramFrame.Content = new Ledgers();
            SetBgButtons(6);
        }

        private void InventoryItemsButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramFrame.Content = new InventoryItems();
            SetBgButtons(7);
        }

        void SetBgButtons(int choice)                                               //ustawianie koloru pozostałych buttonów na defaultowy, gdy 1 opcja wybrana
        {
            switch (choice)
            {
                case 1:
                    InventoryItemsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    LedgersButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    DailyDetailsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    PrintInvoiceButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    ManageProductButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    CustomerAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    EmployeesAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    break;
                case 2:
                    InventoryItemsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    LedgersButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    DailyDetailsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    PrintInvoiceButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    ManageProductButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    CustomerAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    EmployeesAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    break;
                case 3:
                    InventoryItemsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    LedgersButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    DailyDetailsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    PrintInvoiceButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    ManageProductButton.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    CustomerAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    EmployeesAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    break;
                case 4:
                    InventoryItemsButton.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    LedgersButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    DailyDetailsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    PrintInvoiceButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    ManageProductButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    CustomerAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    EmployeesAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    break;
                case 5:
                    InventoryItemsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    LedgersButton.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    DailyDetailsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    PrintInvoiceButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    ManageProductButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    CustomerAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    EmployeesAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    break;
                case 6:
                    InventoryItemsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    LedgersButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    DailyDetailsButton.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    PrintInvoiceButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    ManageProductButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    CustomerAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    EmployeesAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    break;
                case 7:
                    InventoryItemsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    LedgersButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    DailyDetailsButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    PrintInvoiceButton.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    ManageProductButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    CustomerAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    EmployeesAccountButton.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));
                    break;
            }
        }

        private void ProgramFrame_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
        }

        
    }
}
