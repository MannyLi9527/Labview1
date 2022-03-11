using Labview.Upwindow;
using Labview.UserControls;
using Labview.UserControls.Userfunc;
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


namespace Labview.UserControls
{
    /// <summary>
    /// Display.xaml 的交互逻辑
    /// </summary>
    public partial class Display : UserControl
    {


        public MainViewModel PJMVM = new MainViewModel();
        public MainViewModel DJMVM = new MainViewModel();
        public MainViewModel MVM2 = new MainViewModel();
        public MainViewModel MVM3 = new MainViewModel();
        public Display()
        {
            InitializeComponent();
        }
        
        #region 只允许输入数字
        //isDigit是否是数字
        public static bool isNumberic(string _string)
        {
            if (string.IsNullOrEmpty(_string))
                return false;
            foreach (char c in _string)
            {
                if (!char.IsDigit(c))
                    //if(c<'0' c="">'9')//最好的方法,在下面测试数据中再加一个0，然后这种方法效率会搞10毫秒左右
                    return false;
            }
            return true;
        }

        private void intervalBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void intervalBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!isNumberic(e.Text))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void intervalBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!isNumberic(text))
                { e.CancelCommand(); }
            }
            else { e.CancelCommand(); }
        }
        #endregion

        #region 功能参数设置弹窗

        //捕捉圆弹窗
        private void Btn_catchcircle_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.WindowStyle = WindowStyle.ToolWindow;
            CatchCircle catchCircle = new CatchCircle();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = catchCircle.Height + 50;
            window.Width = catchCircle.Width + 50;
            window.Content = catchCircle;            
            window.ShowDialog();
           
        }

        //角度，标识点检测弹窗
        private void Btn_angledete_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.WindowStyle = WindowStyle.ToolWindow;
            Angledete angledete = new Angledete();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = angledete.Height + 50;
            window.Width = angledete.Width + 50;
            window.Content = angledete;
            window.ShowDialog();           
        }

        //模板匹配弹窗
        private void Btn_platedete_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.WindowStyle = WindowStyle.ToolWindow;
            TemplateMatch templateMatch = new TemplateMatch();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = templateMatch.Height+50;
            window.Width = templateMatch.Width+50;
            window.Content = templateMatch;
            window.ShowDialog();
            
        }


       

        private void Btn_PJspec1_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.WindowStyle = WindowStyle.ToolWindow;
            Specification1 specification = new Specification1();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = specification.Height + 50;
            window.Width = specification.Width + 50;
            window.Content = specification;
            specification.DataContext = PJMVM;
            
            window.ShowDialog();

        }

        private void Btn_DJspec_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.WindowStyle = WindowStyle.ToolWindow;
            Ringinter ringinter = new Ringinter();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Height = ringinter.Height + 50;
            window.Width = ringinter.Width + 50;
            window.Content = ringinter;
            ringinter.DataContext = DJMVM;
            window.ShowDialog();
           
        }
        private void Btn_ComToCam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ComToPLC_Click(object sender, RoutedEventArgs e)
        {

        }


        #endregion

    }
}
