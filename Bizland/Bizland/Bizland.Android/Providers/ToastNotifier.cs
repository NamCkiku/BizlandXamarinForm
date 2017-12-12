using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Bizland.Droid.Providers;
using Bizland.Core.Helpers;
using System.Threading.Tasks;

[assembly: Dependency(typeof(ToastNotifier))]
namespace Bizland.Droid.Providers
{
    public class ToastNotifier : IToastNotifier
    {
        public Task<bool> Notify(ToastNotificationType type, string title, string description, double duration, object context = null)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            Toast.MakeText(Forms.Context, description, ToastLength.Long).Show();
            return taskCompletionSource.Task;
        }

        public void HideAll()
        {
        }
    }
}