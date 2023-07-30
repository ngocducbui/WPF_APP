using Project_Final.ViewModel;
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

namespace Project_Final.UserControlBar
{
    /// <summary>
    /// Interaction logic for ControllBarUC.xaml
    /// </summary>
    public partial class ControllBarUC : UserControl
    {
        public ControllerBarViewModel viewModelBar { get; set; }
        public ControllBarUC()
        {
            InitializeComponent();
            this.DataContext= viewModelBar= new ControllerBarViewModel();
        }
    }
}
