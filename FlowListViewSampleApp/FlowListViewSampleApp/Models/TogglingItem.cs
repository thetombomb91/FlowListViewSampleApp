using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowListViewSampleApp.Models
{
    public class TogglingItem : BindableBase
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }
        
        private int _width = new int();
        public int Width
        {
            get { return _width; }
            set
            {
                SetProperty(ref _width, value);
            }
        }

    }


}
