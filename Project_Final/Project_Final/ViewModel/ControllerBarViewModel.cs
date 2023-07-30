using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Project_Final.ViewModel
{
    public class ControllerBarViewModel:BaseViewModel
    {
        #region commands
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MaxWindowCommand { get; set; }
        public ICommand MinWindowCommand { get; set; }
        public ICommand MouseWindowCommand { get; set; }

        #endregion

        public ControllerBarViewModel()
        {
            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {FrameworkElement window= getWindowParent(p);
                var win = window as Window;
                if (win != null)
                {
                    win.Close();
                }
                });
            MaxWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = getWindowParent(p);
                var win = window as Window;
                if (win != null)
                {
                    if(win.WindowState!=WindowState.Maximized)
                    {
                        win.WindowState = WindowState.Maximized;
                    }
                    else
                    {
                        win.WindowState = WindowState.Normal;

                    }
                }
            });
            MinWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = getWindowParent(p);
                var win = window as Window;
                if (win != null)
                {
                    if (win.WindowState != WindowState.Minimized)
                    {
                        win.WindowState = WindowState.Minimized;
                    }
                    else
                    {
                        win.WindowState = WindowState.Maximized;

                    }
                }
            });
            MouseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = getWindowParent(p);
                var win = window as Window;
                if (win != null)
                {
                    win.DragMove();
                }
            });
        }
        FrameworkElement getWindowParent(UserControl u)
        {
            FrameworkElement parent= u;
            while (parent.Parent!=null)
            {
                parent=parent.Parent as FrameworkElement;
                
            }
            return parent;
        }
    }
}
