using HandyControl.Controls;
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
using HandyControl;
using Labview.UserControls.Userfunc;
using System.Runtime.InteropServices;

namespace Labview
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        MainViewModel MainVM = new MainViewModel();
        

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = MainVM;
            
        }
       
    }
        
    
}

