using FlowListViewSampleApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FlowListViewSampleApp.ViewModels
{
    public class TogglingPageViewModel : BindableBase
    {
        public TogglingPageViewModel()
        {
            GenerateTogglingItems();
        }

        private void GenerateTogglingItems()
        {
            var random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 25; i++)
            {
                var togglingItem = new TogglingItem();
                togglingItem.Id = i;
                togglingItem.Width = random.Next(1, 10);
                TogglingItems.Add(togglingItem);
            }
        }

        private ObservableCollection<TogglingItem> _togglingItem = new ObservableCollection<TogglingItem>();
        public ObservableCollection<TogglingItem> TogglingItems
        {
            get { return _togglingItem; }
            set
            {
                SetProperty(ref _togglingItem, value);
            }
        }
    }
}
