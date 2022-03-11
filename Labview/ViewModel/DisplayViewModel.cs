using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace Labview
{
    public class DisplayViewModel:ViewModelBase
    {
        public string cam_value0
        {
            get => GetProperty(() => cam_value0);
            set => SetProperty(() => cam_value0, value);
        }

        public int cam_value1
        {
            get => GetProperty(() => cam_value1);
            set => SetProperty(() => cam_value1, value);
        }

        public DisplayViewModel(string name)
        {
            cam_value0 = name;
            cam_value1 = 0;
        }

    }
}
