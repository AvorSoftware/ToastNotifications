namespace ToastNotifications
{
    partial class NotificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notificationIcon = new System.Windows.Forms.PictureBox();
            this.notificationTitle = new System.Windows.Forms.Label();
            this.notificationText = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.timerClosing = new System.Windows.Forms.Timer(this.components);
            this.timerOpening = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.notificationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationIcon
            // 
            this.notificationIcon.Location = new System.Drawing.Point(12, 12);
            this.notificationIcon.Name = "notificationIcon";
            this.notificationIcon.Size = new System.Drawing.Size(64, 64);
            this.notificationIcon.TabIndex = 0;
            this.notificationIcon.TabStop = false;
            // 
            // notificationTitle
            // 
            this.notificationTitle.AutoSize = true;
            this.notificationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTitle.ForeColor = System.Drawing.Color.Snow;
            this.notificationTitle.Location = new System.Drawing.Point(82, 12);
            this.notificationTitle.Name = "notificationTitle";
            this.notificationTitle.Size = new System.Drawing.Size(0, 20);
            this.notificationTitle.TabIndex = 1;
            // 
            // notificationText
            // 
            this.notificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationText.ForeColor = System.Drawing.Color.DimGray;
            this.notificationText.Location = new System.Drawing.Point(82, 41);
            this.notificationText.Name = "notificationText";
            this.notificationText.Size = new System.Drawing.Size(306, 85);
            this.notificationText.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Silver;
            this.closeButton.Location = new System.Drawing.Point(362, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "✖";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            // 
            // timerClosing
            // 
            this.timerClosing.Interval = 10;
            // 
            // timerOpening
            // 
            this.timerOpening.Interval = 10;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(400, 135);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.notificationText);
            this.Controls.Add(this.notificationTitle);
            this.Controls.Add(this.notificationIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotificationForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.notificationIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox notificationIcon;
        private System.Windows.Forms.Label notificationTitle;
        private System.Windows.Forms.Label notificationText;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer timerClosing;
        private System.Windows.Forms.Timer timerOpening;
    }
}