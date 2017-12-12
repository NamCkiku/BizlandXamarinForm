using Bizland.ViewModels;
using Bizland.Views;
using Autofac;
using Prism.Autofac;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Bizland
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();


            await NavigationService.NavigateAsync("/RootPage/BaseNavigationPage/Login");
        }

        protected override void RegisterTypes()
        {
            Builder.RegisterTypeForNavigation<NavigationPage>();
            Builder.RegisterTypeForNavigation<BaseNavigationPage, BaseNavigationPageViewModel>("BaseNavigationPage");
            Builder.RegisterTypeForNavigation<LoginPage>("Login");
            Builder.RegisterTypeForNavigation<RootPage, RootPageViewModel>("RootPage");
            Builder.RegisterTypeForNavigation<MenuPage, MenuPageViewModel>("MenuPage");
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
