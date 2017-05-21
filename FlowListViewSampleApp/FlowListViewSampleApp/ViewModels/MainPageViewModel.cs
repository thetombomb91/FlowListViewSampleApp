using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowListViewSampleApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand NavToSimpleSampleCommand { get; set; }
        public DelegateCommand NavToMultiplePropertySampleCommand { get; set; }

        public INavigationService _navigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavToSimpleSampleCommand = new DelegateCommand(OnNavToSimpleSample);
            NavToMultiplePropertySampleCommand = new DelegateCommand(OnNavToMultiplePropertySample);
        }

        private async void OnNavToMultiplePropertySample()
        {
            await _navigationService.NavigateAsync(Constants.MULTIPLE_PROPERTY_SAMPLE_PAGE_NAME);
        }

        private async void OnNavToSimpleSample()
        {
            await _navigationService.NavigateAsync(Constants.SIMPLE_SAMPLE_PAGE_NAME);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
