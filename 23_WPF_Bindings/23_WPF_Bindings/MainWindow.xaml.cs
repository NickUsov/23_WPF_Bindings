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

namespace _23_WPF_Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee emp = new Employee { Sirname = "Anton", Age = 22, Rank = "manager" };
        public MainWindow()
        {
            InitializeComponent();
            DataContext = emp;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Фамилия {emp.Sirname} возраст {emp.Age} должность {emp.Rank}");
        }
    }
}
