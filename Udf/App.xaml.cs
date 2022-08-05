using Prism.Ioc;
using Prism.Unity;
using Udf.ViewModels;
using Udf.Views;
using Xamarin.Forms;


namespace Udf
{
    public partial class App : PrismApplication
    {
        public App()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
         
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<FirstPage, FirstPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterViewModel>();


        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(nameof(FirstPage));
        }

    

        protected override void OnResume()
        {
            base.OnResume();
        }

    }
}
