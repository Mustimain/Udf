using System;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace Udf.Base
{
    public class BaseViewModel : BindableBase, IInitialize, INavigationAware, IDestructible, IPageLifecycleAware
    {
        protected INavigationService navigationService { get; set; }

       
        public BaseViewModel(INavigationService service)
        {
            navigationService = service;
        }

        public void Destroy()
        {

        }

        public void Initialize(INavigationParameters parameters)
        {

        }

        public void OnAppearing()
        {

        }

        public void OnDisappearing()
        {

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}