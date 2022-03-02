using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labview
{
    public class TextCtrlViewModel:ViewModelBase
    {
        public int text_value_1
        {
            get => GetProperty(() => text_value_1);
            set => SetProperty(() => text_value_1, value);
        }

        public TextCtrlViewModel()
        {
            text_value_1 = 100;
        }

    }
}
