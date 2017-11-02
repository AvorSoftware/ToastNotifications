using System;
using System.Collections.Generic;
using System.Drawing;

namespace ToastNotifications
{
    public class Notifications
    {
        #region Public Events
        public event Action<object, string> OnNotificationClick;
        public event Action<object, string> OnNotificationClose;
        #endregion

        #region Public Fields
        public int timeToLive;
        #endregion

        #region Internal Fields
        internal List<NotificationForm> notifications = new List<NotificationForm>();
        internal Color backColor;
        internal Color titleColor;
        internal Color textColor;
        #endregion

        #region Constructors
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
        #endregion

        #region Methods
        internal void Show(string notificationTitle, string notificationText)
        {
            NotificationForm notiform = new NotificationForm(this, notificationTitle, notificationText, null);
            notiform.Show();
        }
        
        public void Show(string notificationTitle, string notificationText, Image notificationImage = null, NotificationType notificationType = NotificationType.Default, string actionString = null, string okButtonString = null, string cancelButtonString = null)
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
        #endregion

        #region Event Handlers
        private void Notiform_OnNotificationClick(object sender, string actionString)
        {
            NotificationForm notification = (NotificationForm)sender;
            OnNotificationClick?.Invoke(this, actionString);
        }
        
        private void Notiform_OnNotificationClose(object sender, string actionString)
        {
            NotificationForm notification = (NotificationForm)sender;
            OnNotificationClose?.Invoke(this, actionString);
        }
        #endregion
    }
}
