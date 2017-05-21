using FlowListViewSampleApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FlowListViewSampleApp.ViewModels
{
    public class SimpleSamplePageViewModel : BindableBase
    {

        public SimpleSamplePageViewModel()
        {
            GenerateSimpleItems();
        }

        private ObservableCollection<SimpleItem> _simpleItems = new ObservableCollection<SimpleItem>();
        public ObservableCollection<SimpleItem> SimpleItems
        {
            get { return _simpleItems; }
            set
            {
                SetProperty(ref _simpleItems, value);
            }
        }


        private void GenerateSimpleItems()
        {
            for (int i = 0; i < 100; i++)
            {
                var simpleItem = new SimpleItem();
                simpleItem.Id = i;
                _simpleItems.Add(simpleItem);
            }
        }
    }
}
