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

namespace Ooo
{
    /// <summary>
    /// Interaction logic for OknoClient.xaml
    /// </summary>
    public partial class OknoClient : Page
    {
        public OknoClient()
        {
            InitializeComponent();
            DataContext = new OknoClientViewModel();
        }
       public OknoClient(Client edit)
        {
            InitializeComponent();
            DataContext = new OknoClientViewModel(edit);
        }
    }
}
