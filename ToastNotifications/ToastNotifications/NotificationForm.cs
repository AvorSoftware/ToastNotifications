using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ToastNotifications
{
    internal partial class NotificationForm : Form
    {
        Notifications notification;
        Rectangle workingArea;
        Control _parent;

        public NotificationForm(Notifications notification, string notificationTitle, string notificationText, Image notificationIcon)
        {
            InitializeComponent();
            this.notification = notification;
            notification.notifications.Add(this);

            workingArea = Screen.GetWorkingArea(this);

            this.Location = new Point(workingArea.Right - (Size.Width + 10),
                                      workingArea.Bottom - (Size.Height + 10) * notification.notifications.Count());

            timerOpening.Start();

            AddMouseEventsToChildren(this);
            this.MouseEnter += Form_MouseEnter;
            this.MouseLeave += Form_MouseLeave;
            this.closeButton.Click += CloseButton_Click;

            this.timerClosing.Tick += TimerClosing_Tick;
            this.timerOpening.Tick += TimerOpening_Tick;

            this.notificationTitle.Text = notificationTitle;
            this.notificationText.Text = notificationText;
            this.notificationIcon.Image = notificationIcon;
            
        }

        private void TimerOpening_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - 10,
                                      this.Location.Y);

            if(Location.X <= (workingArea.Right - (Size.Width + 10)))
            {              
                timerOpening.Stop();
            }
        }

        private void TimerClosing_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 30, this.Location.Y);
            if (this.Location.X >= workingArea.Right)
            {
                foreach (NotificationForm toast in notification.notifications.Skip(notification.notifications.IndexOf(this) + 1))
                {
                    toast.Location = new Point(toast.Location.X, toast.Location.Y + (Size.Height + 10));
                }

                notification.notifications.Remove(this);

                timerClosing.Stop();

                this.Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.timerClosing.Start();
        }

        private void AddMouseEventsToChildren(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.MouseLeave += Form_MouseLeave;
                child.MouseEnter += Form_MouseEnter;
                AddMouseEventsToChildren(child);
            }
        }

        private void AddMouseEventsToParents(Control child)
        {
            if (child.Parent != null)
            {
                child.Parent.MouseEnter += Form_MouseLeave;
                child.Parent.MouseLeave += Form_MouseLeave;
                AddMouseEventsToParents(child.Parent);
            }
        }

        void Form_MouseEnter(object sender, EventArgs e)
        {
            if (_parent == null)
            {
                _parent = this.Parent;
                AddMouseEventsToParents(this);
            }
            closeButton.Visible = true;
        }

        void Form_MouseLeave(object sender, EventArgs e)
        {
            var pos = this.PointToClient(Cursor.Position);
            if (!this.ClientRectangle.Contains(pos))
            {
                closeButton.Visible = false;
            }
        }
    }
}
