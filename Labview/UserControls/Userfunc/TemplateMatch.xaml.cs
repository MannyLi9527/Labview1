using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Labview.UserControls.Userfunc
{
    /// <summary>
    /// TemplateMatch.xaml 的交互逻辑
    /// </summary>
    public partial class TemplateMatch : UserControl
    {
        public TemplateMatch()
        {
            InitializeComponent();
        }


        private void TemplatePath_Click(object sender, RoutedEventArgs e)
        {

            //声明两个局部变量

            Stream photo = null;

            int length;

            //1.1打开（文本框）

            OpenFileDialog ofdWenJian = new OpenFileDialog();

            //筛选文件类型

            ofdWenJian.Filter = "ALL Image Files|*.*";

            if ((bool)ofdWenJian.ShowDialog())

            {
                //选定的文件（选定的文件打开只读流）

                if ((photo = ofdWenJian.OpenFile()) != null)

                {
                    //获取文件长度（用字节表示的流长度）

                    length = (int)photo.Length;

                    //声明数组

                    byte[] bytes = new byte[length];

                    //读取文件（字节数组，从零开始的字节偏移量，读取的字节数）

                    photo.Read(bytes, 0, length);

                    

                    BitmapImage images = new BitmapImage(new Uri(ofdWenJian.FileName));

                    //绑定图片

                    Tempimage.Source = images;

                    txt_Load.Text = ofdWenJian.FileName;

                }

                else
                {
                    MessageBox.Show("对话框没有显示，没办法选择图片！");

                }

            }
        }

    }
}