using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Project_Final.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public ICommand LoadWindowCommand { get; set; }

        public bool isLoad =false;

        public MainViewModel()
        {

            LoadWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                isLoad = true;
 
                Login login = new Login();
                login.ShowDialog();
            });


        }
    }
}
