using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace TestApp
{
    public partial class Form1 : Form
    {
        Notifications notifications = new Notifications();
        public Form1()
        {
            InitializeComponent();
            
            notifications.OnNotificationClick += Notifications_OnNotificationClick;
            notifications.OnNotificationClose += Notifications_OnNotificationClose;
        }

        private void Notifications_OnNotificationClose(object sender, string e)
        {
            this.Focus();
        }

        private void Notifications_OnNotificationClick(object sender, string e)
        {
            this.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifications.Show("Test Notification", "This is a notification test for GitHub Friends\nSays \"Hello Friends!\"", this.Icon.ToBitmap());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifications.Show("Test2", "Nuovo messaggio ricevutoNuovo messaggio ricevutoNuovo messaggio ricevutoNuovo messaggio ricevuto", this.Icon.ToBitmap(), NotificationType.OkCancel, "Test2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            notifications.Show("Test3", "Nuovo messaggio ricevutoNuovo messaggio ricevutoNuovo messaggio ricevutoNuovo messaggio ricevuto", this.Icon.ToBitmap(), NotificationType.OkDeny, "Test3");

        }
    }
}
