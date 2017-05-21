using FlowListViewSampleApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace FlowListViewSampleApp.ViewModels
{
    public class BindingToMultiplePropertyModelPageViewModel : BindableBase
    {
        public BindingToMultiplePropertyModelPageViewModel()
        {
            GenerateMultiplePropertyItems();
        }
        private ObservableCollection<MultiplePropertyItem> _multiplePropetyItems = new ObservableCollection<MultiplePropertyItem>();
        public ObservableCollection<MultiplePropertyItem> MultiplePropertyItems
        {
            get { return _multiplePropetyItems; }
            set
            {
                SetProperty(ref _multiplePropetyItems, value);
            }
        }

        private void GenerateMultiplePropertyItems()
        {
            var random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 25; i++)
            {
                var multiplerPropertyItem = new MultiplePropertyItem();
                multiplerPropertyItem.BackgroundColor = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
                multiplerPropertyItem.Id = i;
                MultiplePropertyItems.Add(multiplerPropertyItem);
            };
        }
    }
}
