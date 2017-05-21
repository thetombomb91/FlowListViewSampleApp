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
        public DelegateCommand CreateNewListItemButtonCommand { get; set; }

        public BindingToMultiplePropertyModelPageViewModel()
        {
            CreateNewListItemButtonCommand = new DelegateCommand(OnCreateNewListItemButton);

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

        private void OnCreateNewListItemButton()
        {
            var random = new Random(DateTime.Now.Millisecond);

            var multiplePropertyItem = new MultiplePropertyItem();
            multiplePropertyItem.BackgroundColor = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
            multiplePropertyItem.Id = MultiplePropertyItems[MultiplePropertyItems.Count - 1].Id + 1;
            MultiplePropertyItems.Add(multiplePropertyItem);
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
