using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labview
{
    public class MainViewModel:ViewModelBase
    {
        public TextCtrlViewModel textCtrl
        {
            get => GetProperty(() => textCtrl);
            set => SetProperty(() => textCtrl, value);
        }

        public MainViewModel()
        {
            textCtrl = new TextCtrlViewModel();
        }
    }
}
