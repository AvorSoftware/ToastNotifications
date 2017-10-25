using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Notifications notifications = new Notifications();
            notifications.Add("Outlook", "Nuovo messaggio ricevuto", null);
            notifications.Add("Applicazione", "Nuovo messaggio ricevutoNuovo messaggio ricevutoNuovo messaggio ricevutoNuovo messaggio ricevuto", null);
            notifications.Add("", "", null);
        }
    }
}
