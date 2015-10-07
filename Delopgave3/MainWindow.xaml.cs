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

namespace Delopgave3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btBack.Click     += new RoutedEventHandler(btBack_Click);
            btForward.Click  += new RoutedEventHandler(btForward_Click);
            btNew.Click      += new RoutedEventHandler(btNew_Click);
        }

        private void btNew_Click(object sender, RoutedEventArgs e)
        {
            Agents agents = (Agents)this.FindResource("agents");
            agents.Add(new Agent());
            lsbNames.SelectedIndex = lsbNames.Items.Count - 1;
            txbID.Focus();
        }

        private void btForward_Click(object sender, RoutedEventArgs e)
        {
            if (lsbNames.SelectedIndex < lsbNames.Items.Count - 1)
                lsbNames.SelectedIndex = ++lsbNames.SelectedIndex;
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            if (lsbNames.SelectedIndex > 0)
                lsbNames.SelectedIndex = --lsbNames.SelectedIndex;
        }
    }
}
