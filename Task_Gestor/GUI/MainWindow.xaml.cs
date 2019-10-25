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
using Business;

namespace GUI
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

        private void Taskbt_Click(object sender, RoutedEventArgs e)
        {
            string nome = tasktb.Text;
            DateTime time = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            CreateTask task = new CreateTask();
            task.CriaTask(nome, time);
            this.Hide();
            TaskWindow taskwindow = new TaskWindow();
            taskwindow.ShowDialog();
        }

        private void Tasktb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
