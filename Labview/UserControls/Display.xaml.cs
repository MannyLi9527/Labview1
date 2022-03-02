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
        private void Btn_catchcircle_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            CatchCircle catchCircle = new CatchCircle();
            window.Content = catchCircle;
            
            //MessageBox.Show(catchCircle.ActualWidth.ToString()+"/"+catchCircle.ActualHeight.ToString());
            window.Show();
            window.Width = catchCircle.ActualWidth;
            window.Height = catchCircle.ActualHeight;
            //输入的参数数据需要传输

            //int a = 11;
        }

        private void Btn_angledete_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            Angledete angledete = new Angledete();
            window.Content = angledete;
            window.Show();
            window.Width = angledete.ActualWidth;
            window.Height = angledete.ActualHeight;
        }

        private void Btn_platedete_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            TemplateMatch templateMatch = new TemplateMatch();
            window.Content = templateMatch;
            window.Show();
            window.Width = templateMatch.ActualWidth;
            window.Height = templateMatch.ActualHeight;
        }

        private void Btn_somadete_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            Somadete somadete = new Somadete();
            window.Content = somadete;
            window.Show();
            window.Height = somadete.ActualHeight;
            window.Width = somadete.ActualWidth;

        }

        private void Btn_ringdete_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            Ringinter ringinter = new Ringinter();
            window.Content = ringinter;
            window.Show();
            window.Width = ringinter.ActualWidth;
            window.Height = ringinter.ActualHeight;
        }

        private void Btn_spec1_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            Specification1 specification1 = new Specification1();
            window.Content = specification1;
            window.Show();
            window.Width = specification1.ActualWidth;
            window.Height = specification1.ActualHeight;
        }
        #endregion
    }
}
