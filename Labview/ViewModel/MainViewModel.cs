using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using HandyControl.Controls;
using Labview.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labview
{
    public class MainViewModel:ViewModelBase
    {

        #region 判胶检测控件

       
        public TextCtrlViewModel textCtrl
        {
            get => GetProperty(() => textCtrl);
            set => SetProperty(() => textCtrl, value);
        }
        public TextCtrlViewModel textCtrl2
        {
            get => GetProperty(() => textCtrl2);
            set => SetProperty(() => textCtrl2, value);
        }
        public TextCtrlViewModel textCtrl3
        {
            get => GetProperty(() => textCtrl3);
            set => SetProperty(() => textCtrl3, value);
        }
        public TextCtrlViewModel textCtrl4
        {
            get => GetProperty(() => textCtrl4);
            set => SetProperty(() => textCtrl4, value);
        }
        #endregion
        
        #region 点胶检测控件
        public TextCtrlViewModel DJtextCtrl1
        {
            get => GetProperty(() => DJtextCtrl1);
            set => SetProperty(() => DJtextCtrl1, value);
        }

        public TextCtrlViewModel DJtextCtrl2
        {
            get => GetProperty(() => DJtextCtrl2);
            set => SetProperty(() => DJtextCtrl2, value);
        }

        public TextCtrlViewModel DJtextCtrl3
        {
            get => GetProperty(() => DJtextCtrl3);
            set => SetProperty(() => DJtextCtrl3, value);
        }

        public TextCtrlViewModel DJtextCtrl4
        {
            get => GetProperty(() => DJtextCtrl4);
            set => SetProperty(() => DJtextCtrl4, value);
        }

        #endregion

        #region 相机显示控件
        public DisplayViewModel CamCtrl
        {
            get => GetProperty(() => CamCtrl);
            set => SetProperty(() => CamCtrl, value);
        }

        public DisplayViewModel CamCtrl1
        {
            get => GetProperty(() => CamCtrl1);
            set => SetProperty(() => CamCtrl1, value);
        }

        public DisplayViewModel CamCtrl2
        {
            get => GetProperty(() => CamCtrl2);
            set => SetProperty(() => CamCtrl2, value);
        }

        public DisplayViewModel CamCtrl3
        {
            get => GetProperty(() => CamCtrl3);
            set => SetProperty(() => CamCtrl3, value);
        }

        public DisplayViewModel CamCtrl4
        {
            get => GetProperty(() => CamCtrl4);
            set => SetProperty(() => CamCtrl4, value);
        }


        #endregion

        #region 实例化
        public MainViewModel()
        {
            textCtrl = new TextCtrlViewModel("点胶内检测");
            textCtrl2 = new TextCtrlViewModel("点胶外检测");
            textCtrl3 = new TextCtrlViewModel("溢胶内检测");
            textCtrl4 = new TextCtrlViewModel("溢胶外检测");
            
            DJtextCtrl1 = new TextCtrlViewModel("挡光片检测");
            DJtextCtrl2 = new TextCtrlViewModel("隔圈检测");
            DJtextCtrl3 = new TextCtrlViewModel("漏组检测");
            DJtextCtrl4 = new TextCtrlViewModel("预留检测");

            CamCtrl = new DisplayViewModel("相机1");
            CamCtrl1 = new DisplayViewModel("相机2");
            CamCtrl2 = new DisplayViewModel("相机3");
            CamCtrl3 = new DisplayViewModel("相机4");
            CamCtrl4 = new DisplayViewModel("相机5");
        }
        #endregion

        #region SoftwareSet

        /// <summary>
        /// 最小化软件界面
        /// </summary>
        /// <param name="obj"></param>
        [AsyncCommand]
        public void MinCommand()
        {          
            windowState = WindowState.Minimized;          
        }
        
        public WindowState windowState
        {
            get => GetProperty(() => windowState);
            set => SetProperty(() => windowState, value);
        }

    

        /// <summary>
        /// 唤出Log界面
        /// </summary>
        /// <param name="obj"></param>
        [AsyncCommand]
        public void LogCommand(object obj)
        {
            var listView = new System.Windows.Controls.ListBox()
            {
                DisplayMemberPath = "Message",
                SelectedValuePath = "ID"
            };
            var scrollViewer = new ScrollViewer()
            {
                Height = 800,
                Content = listView
            };

            var window = new PopupWindow
            {
                Topmost = true,
                PopupElement = scrollViewer,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                AllowsTransparency = true,
                WindowStyle = WindowStyle.None,
                MinWidth = 0,
                MinHeight = 0,
                Title = "异常日志",
            };

            ObservableCollection<LogInfo> txt = new ObservableCollection<LogInfo>();
            using (StreamReader sr = new StreamReader("./Log/Log.txt", Encoding.UTF8))
            {
                int lineCount = 0;
                while (0 < sr.Peek())
                {
                    lineCount++;
                    string temp = sr.ReadLine();
                    txt.Insert(0, new LogInfo() { ID = lineCount, Message = temp });
                }
            }
            listView.ItemsSource = txt;
            window.Show();
        }

        









        /// <summary>
        /// 软件退出
        /// </summary>
        /// <param name="obj"></param>
        [AsyncCommand]
        public void ExitCommand(object obj)
        {           
            Application.Current.Shutdown(-1);
        }

        #endregion




        #region  绑定参数

        public struct LogInfo
        {
            public int ID { set; get; }
            public string Message { set; get; }
        }

       

        /// <summary>
        /// 通讯设置结构体
        /// </summary>
        public struct Interface
        {
            public bool IsUsing;
            public string IP;
            public string Port;
            //串口信息暂未添加
        }

        

        #endregion


    }
}
