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

namespace UIApplication
{
    /// <summary>
    /// Interaction logic for WcfMathClient.xaml
    /// </summary>
    public partial class WcfMathClient : Window
    {
        public WcfMathClient()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender , RoutedEventArgs e)
        {
            var proxy = new MathComponentClient();
        }
    }
}
