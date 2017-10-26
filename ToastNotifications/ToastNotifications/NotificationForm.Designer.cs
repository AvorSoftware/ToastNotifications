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
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.denyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notificationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationIcon
            // 
            this.notificationIcon.Location = new System.Drawing.Point(12, 12);
            this.notificationIcon.Name = "notificationIcon";
            this.notificationIcon.Size = new System.Drawing.Size(64, 64);
            this.notificationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.notificationIcon.TabIndex = 0;
            this.notificationIcon.TabStop = false;
            // 
            // notificationTitle
            // 
            this.notificationTitle.AutoSize = true;
            this.notificationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTitle.ForeColor = System.Drawing.Color.Snow;
            this.notificationTitle.Location = new System.Drawing.Point(82, 12);
            this.notificationTitle.Name = "notificationTitle";
            this.notificationTitle.Size = new System.Drawing.Size(16, 18);
            this.notificationTitle.TabIndex = 1;
            this.notificationTitle.Text = "_";
            // 
            // notificationText
            // 
            this.notificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationText.ForeColor = System.Drawing.Color.DimGray;
            this.notificationText.Location = new System.Drawing.Point(82, 37);
            this.notificationText.Name = "notificationText";
            this.notificationText.Size = new System.Drawing.Size(306, 57);
            this.notificationText.TabIndex = 2;
            this.notificationText.Text = "Nuovo messaggio ricevutoNuovo messaggio ricevutoNuovo messaggio ricevutoNuovo mes" +
    "saggio ricevuto";
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Silver;
            this.closeButton.Location = new System.Drawing.Point(370, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            // 
            // timerClosing
            // 
            this.timerClosing.Interval = 1;
            // 
            // timerOpening
            // 
            this.timerOpening.Interval = 1;
            // 
            // timerShow
            // 
            this.timerShow.Enabled = true;
            this.timerShow.Interval = 7000;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.okButton.Location = new System.Drawing.Point(86, 101);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(120, 32);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cancelButton.Location = new System.Drawing.Point(233, 101);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 32);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // denyButton
            // 
            this.denyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.denyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.denyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.denyButton.Location = new System.Drawing.Point(233, 101);
            this.denyButton.Name = "denyButton";
            this.denyButton.Size = new System.Drawing.Size(120, 32);
            this.denyButton.TabIndex = 6;
            this.denyButton.Text = "Deny";
            this.denyButton.UseVisualStyleBackColor = false;
            this.denyButton.Visible = false;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(400, 140);
            this.Controls.Add(this.denyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
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
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button denyButton;
    }
}