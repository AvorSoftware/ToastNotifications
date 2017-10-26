using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ToastNotifications;

namespace ToastNotifications
{
    public struct NotificationInfos
    {
        public string title;
        public string text;
        public Image image;

        public string action;
    }

    public class Notifications
    {

        public event Action<object, string> OnNotificationClick;
        public event Action<object, string> OnNotificationClose;

        internal List<NotificationForm> notifications = new List<NotificationForm>();
        internal Color backColor;
        internal Color titleColor;
        internal Color textColor;
        internal int timeToLive;

        public Notifications()
        {
            backColor = Color.FromArgb(28, 28, 28);
            titleColor = Color.FromKnownColor(KnownColor.Snow); 
             textColor = Color.FromKnownColor(KnownColor.DimGray);
            timeToLive = 7000;
        }

        public Notifications(Color? backColor, Color? titleColor, Color? textColor, int? timeToLive)
        {
            if (backColor == null)
                backColor = Color.FromArgb(28, 28, 28);
            if (titleColor == null)
                titleColor = Color.FromKnownColor(KnownColor.Snow);
            if (textColor == null)
                textColor = Color.FromKnownColor(KnownColor.DimGray);
            if (timeToLive == null)
                timeToLive = 7000;

            this.backColor = (Color)backColor;
            this.titleColor = (Color)titleColor;
            this.textColor = (Color)textColor;
            this.timeToLive = (int)timeToLive * 1000;        
        }
        
        public void Add(string notificationTitle, string notificationText)
        {
            NotificationForm notiform = new NotificationForm(this, notificationTitle, notificationText, null);
            notiform.Show();
        }

        private void Notiform_OnNotificationClose(object sender, string actionString)
        {
            NotificationForm notification = (NotificationForm)sender;
            OnNotificationClose?.Invoke(this, actionString);
        }

        public void Add(string notificationTitle, string notificationText, Image notificationImage = null, NotificationType notificationType = NotificationType.Default, string actionString = null, string okButtonString = null, string cancelButtonString = null)
        {
            NotificationForm notiform = new NotificationForm(this, notificationTitle, notificationText, notificationImage, notificationType, actionString, okButtonString, cancelButtonString);

            switch (notificationType)
            {
                case NotificationType.Default:
                    notiform.Show();
                    notiform.OnNotificationClick += Notiform_OnNotificationClick;
                    notiform.OnNotificationClose += Notiform_OnNotificationClose;
                    break;
                case NotificationType.OkCancel:
                    notiform.Show();
                    notiform.OnNotificationClick += Notiform_OnNotificationClick;
                    notiform.OnNotificationClose += Notiform_OnNotificationClose;
                    break;
                case NotificationType.OkDeny:
                    notiform.Show();
                    notiform.OnNotificationClick += Notiform_OnNotificationClick;
                    notiform.OnNotificationClose += Notiform_OnNotificationClose;
                    break;
            }
        }

        private void Notiform_OnNotificationClick(object sender, string actionString)
        {
            NotificationForm notification = (NotificationForm)sender;
            OnNotificationClick?.Invoke(this, actionString);
        }
    }
}
