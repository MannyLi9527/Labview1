using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//各项检测最基础控件
namespace Labview
{
    public class TextCtrlViewModel : ViewModelBase
    {
        public string text_value_0
        {
            get => GetProperty(() => text_value_0);
            set => SetProperty(() => text_value_0, value);
        }
        
        public int text_value_1
        {
            get => GetProperty(() => text_value_1);
            set => SetProperty(() => text_value_1, value);
        }

        public int text_value_2
        {
            
            get => GetProperty(() => text_value_2);
            set => SetProperty(() => text_value_2, value);
        }

        public int text_value_3
        {

            get => GetProperty(() => text_value_3);
            set => SetProperty(() => text_value_3, value);
        }

        public int text_value_4
        {

            get => GetProperty(() => text_value_4);
            set => SetProperty(() => text_value_4, value);
        }

        public int text_value_5
        {

            get => GetProperty(() => text_value_5);
            set => SetProperty(() => text_value_5, value);
        }

        public int text_value_6
        {

            get => GetProperty(() => text_value_6);
            set => SetProperty(() => text_value_6, value);
        }


        public TextCtrlViewModel(string name)
        {
            text_value_0 = name;
            text_value_1 = 0;
            text_value_2 = 0;
            text_value_3 = 0;
            text_value_4 = 0;
            text_value_5 = 0;
            text_value_6 = 0;
        }

    }


   



    
}
