using System;
using System.Windows.Input;
using Prism.Navigation;
using Udf.Base;
using Udf.Views;
using Xamarin.Forms;

namespace Udf.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public RegisterViewModel(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
        }


        public ICommand BackCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _navigationService.NavigateAsync(nameof(FirstPage));
                });
            }
        }
    }
}
