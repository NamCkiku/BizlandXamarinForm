using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Bizland.iOS.Providers;
using Bizland.Core.Helpers;
using System.Threading.Tasks;
using MessageBar;

[assembly: Dependency(typeof(ToastNotifier))]
namespace Bizland.iOS.Providers
{
    public class ToastNotifier : IToastNotifier
    {
        public static void Init()
        {
            //_styleSheet = new MessageBarStyleSheet();
        }

        public Task<bool> Notify(ToastNotificationType type, string title, string description, double duration, object context = null)
        {
            MessageType msgType = MessageType.Info;

            switch (type)
            {
                case ToastNotificationType.Error:
                case ToastNotificationType.Warning:
                    msgType = MessageType.Error;
                    break;

                case ToastNotificationType.Success:
                    msgType = MessageType.Success;
                    break;
            }

            var taskCompletionSource = new TaskCompletionSource<bool>();
            MessageBarManager.SharedInstance.ShowMessage(title, description, msgType, duration, b => taskCompletionSource.TrySetResult(b));
            return taskCompletionSource.Task;
        }

        public void HideAll()
        {
            MessageBarManager.SharedInstance.HideAll();
        }
    }
}