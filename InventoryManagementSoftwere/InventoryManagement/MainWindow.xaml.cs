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

namespace InventoryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String RegistProductNumber;

        private String RegistProductName;

        public MainWindow()
        {
            InitializeComponent();
        }

        // 登録ボタン
        private void Registration(object sender, RoutedEventArgs e)
        {
           this.RegistProductNumber = NumberInputBox.Text.ToString();

           this.RegistProductName = NameInputBox.Text.ToString();

           Preview();

        }

        // 表示
        private void Preview()
        {
            TestPreview.Text = this.RegistProductNumber;
        }
    }
}
