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

namespace Delopgave2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Agents _newAgent = new Agents();
        public MainWindow()
        {
            InitializeComponent();
            _newAgent.Add(new Agent("007", "James Bond","", "Martinis", "Korea"));
            _newAgent.Add(new Agent("001", "Alex Bond", "", "Coding", "China"));
            DataContext = _newAgent;
        }
    }
}
