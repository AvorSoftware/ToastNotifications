/*
 * 
 *  Developer: Domenico Zarcone
 *  Please visit https://github.com/AvorSoftware for documentation
 *  
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ToastNotifications;

namespace ToastNotifications
{
    public class Notifications
    {
        internal List<NotificationForm> notifications = new List<NotificationForm>();

        public void Add(string notificationTitle, string notificationText, Image notificationIcon)
        {
            NotificationForm notiform = new NotificationForm(this, notificationTitle, notificationText, notificationIcon);
            notiform.Show();
        }
    }
}
