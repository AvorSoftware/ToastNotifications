using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ToastNotifications
{
    internal partial class NotificationForm : Form
    {
        #region Internal Properties and Attributes
        internal string notificationTitleText
        {
            get
            {
                return notificationTitle.Text;
            }
            set
            {
                notificationTitle.Text = value;
            }
        }

        internal string notificationTextText
        {
            get
            {
                return notificationText.Text;
            }
            set
            {
                notificationText.Text = value;
            }
        }

        internal Image notificationIconImage
        {
            get
            {
                return notificationIcon.Image;
            }
            set
            {
                notificationIcon.Image = value;
            }
        }

        internal string actionString;
        internal NotificationType? notificationType = null;
        #endregion

        #region Private Fields
        private Notifications notification;
        private Rectangle workingArea;
        private Control _parent;

        private struct CursorPosition
        {
            public static double x;
            public static double y;
        }
        #endregion

        #region Public Events
        public event Action<object, string> OnNotificationClick;
        public event Action<object, string> OnNotificationClose;
        #endregion

        #region Constructors
        internal NotificationForm(Notifications notification, string notificationTitle, string notificationText, Image notificationIcon)
        {
            InitializeComponent();
            this.notification = notification;

            workingArea = Screen.GetWorkingArea(this);
            
                this.Location = new Point(workingArea.Right - (Size.Width + 10),
                            workingArea.Bottom - (Size.Height + 10));

            this.Opacity = 90;

            timerOpening.Start();

            AddMouseEventsToChildren(this);
            this.MouseEnter += Form_MouseEnter;
            this.MouseLeave += Form_MouseLeave;
            this.MouseDown += NotificationForm_MouseDown;
            this.MouseUp += NotificationForm_MouseUp;
            this.MouseClick += Form_Click;
            this.closeButton.Click += CloseButton_Click;
            this.denyButton.Click += DenyButton_Click;

            this.timerClosing.Tick += TimerClosing_Tick;
            this.timerOpening.Tick += TimerOpening_Tick;
            this.timerShow.Tick += TimerShow_Tick;

            this.notificationTitle.Text = notificationTitle;
            this.notificationText.Text = notificationText;
            this.notificationIcon.Image = notificationIcon;

            this.BackColor = notification.backColor;
            this.notificationTitle.ForeColor = notification.titleColor;
            this.notificationText.ForeColor = notification.textColor;
            this.closeButton.ForeColor = notification.textColor;
            this.closeButton.BackColor = notification.backColor;
            this.closeButton.FlatAppearance.BorderColor = notification.backColor;
            this.timerShow.Interval = notification.timeToLive == 0 ? this.timerShow.Interval = 7000 : this.timerShow.Interval = notification.timeToLive;


            notification.notifications.Add(this);
        }
        
        public NotificationForm(Notifications notification, string notificationTitle, string notificationText, Image notificationIcon, NotificationType notificationType, string notificationString = null, string okButtonString = null, string cancelButtonString = null) : this(notification, notificationTitle, notificationText, notificationIcon)
        {
            actionString = notificationString;
            this.notificationType = notificationType;

            switch (notificationType)
            {
                case NotificationType.Default:
                    this.Height = 100;
                    if (notification.notifications.Count() > 1)
                        this.Location = new Point(this.Location.X,
                                (notification.notifications[notification.notifications.Count() - 2].Location.Y - 10) - this.Size.Height);
                    break;
                case NotificationType.OkCancel:
                    this.Height = 140;
                    if (notification.notifications.Count() > 1)
                        this.Location = new Point(this.Location.X,
                                (notification.notifications[notification.notifications.Count() - 2].Location.Y - 10) - this.Size.Height);

                    this.timerShow.Stop();

                    this.cancelButton.Click += CloseButton_Click;
                    this.okButton.MouseClick += Form_Click;
                    this.okButton.Text = okButtonString == null ? "Ok" : okButtonString;
                    this.cancelButton.Text = okButtonString == null ? "Cancel" : cancelButtonString;
                    break;
                case NotificationType.OkDeny:
                    this.Height = 140;
                    if (notification.notifications.Count() > 1)
                        this.Location = new Point(this.Location.X,
                                (notification.notifications[notification.notifications.Count() - 2].Location.Y - 10) - this.Size.Height);

                    this.timerShow.Stop();

                    this.denyButton.Click += DenyButton_Click;
                    this.denyButton.Visible = true;
                    this.cancelButton.Visible = false;
                    this.okButton.MouseClick += Form_Click;
                    this.okButton.Text = okButtonString == null ? "Accept" : okButtonString;
                    this.denyButton.Text = cancelButtonString == null ? "Deny" : cancelButtonString;
                    break;
            }

            AddMouseEventsToChildren(this);
        }
        #endregion

        #region Timers
        private void TimerShow_Tick(object sender, EventArgs e)
        {
            this.CloseButton_Click(this, e);
        }
        
        private void TimerOpening_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - 10,
                                      this.Location.Y);

            if (this.Opacity <= 100)
                this.Opacity += 0.1;

            if (Location.X <= (workingArea.Right - (Size.Width + 10)))
            {
                timerOpening.Stop();
            }
        }

        private void TimerClosing_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 10, this.Location.Y);

            if (this.Opacity >= 0)
                this.Opacity -= 0.1;

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
        #endregion 

        #region Event Handlers
        private void Form_Click(object sender, MouseEventArgs e)
        {
            if (_parent == null)
            {
                _parent = this.Parent;
                AddMouseEventsToParents(this);
            }

            this.CloseButton_Click(this, e);
            OnNotificationClick.Invoke(this, actionString);
        }

        private void NotificationForm_MouseUp(object sender, MouseEventArgs e)
        {
            if ((Cursor.Position.X - CursorPosition.x) > 5)
            {
                this.CloseButton_Click(sender, e);
            }
        }

        private void NotificationForm_MouseDown(object sender, MouseEventArgs e)
        {
            CursorPosition.x = Cursor.Position.X;
            CursorPosition.y = Cursor.Position.Y;
        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            this.timerClosing.Start();
            OnNotificationClose.Invoke(this, actionString);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.timerClosing.Start();
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


        #endregion

        #region Helper
        private void AddMouseEventsToChildren(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.MouseLeave += Form_MouseLeave;
                child.MouseEnter += Form_MouseEnter;
                if (this.Height == 100 && this.notificationType != null)
                    child.MouseClick += Form_Click;
                AddMouseEventsToChildren(child);
            }
        }

        private void AddMouseEventsToParents(Control child)
        {
            if (child.Parent != null)
            {
                child.Parent.MouseEnter += Form_MouseLeave;
                child.Parent.MouseLeave += Form_MouseLeave;
                if (this.Height == 100
                     && this.notificationType != null)
                    child.MouseClick += Form_Click;
                AddMouseEventsToParents(child.Parent);
            }
        }
        #endregion
    }
}
