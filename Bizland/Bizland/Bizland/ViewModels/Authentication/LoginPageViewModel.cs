using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Bizland.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Đăng Nhập";
        }
        public Command ClickMe
        {
            get
            {
                return new Command(() =>
               {
                   Title = "Oke";

               });
            }
        }
    }
}
