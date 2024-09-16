namespace AutoKultura
{
    partial class formMessage
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
            panel1 = new Panel();
            lblMessage = new Label();
            lblCaption = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(150, 150, 150);
            panel1.Controls.Add(lblMessage);
            panel1.Controls.Add(lblCaption);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 275);
            panel1.TabIndex = 0;
            panel1.MouseLeave += Panel1_MouseLeave;
            panel1.MouseMove += Panel1_MouseMove;
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMessage.Location = new Point(0, 25);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(652, 250);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "label3";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.MouseLeave += Panel1_MouseLeave;
            lblMessage.MouseMove += Panel1_MouseMove;
            // 
            // lblCaption
            // 
            lblCaption.Dock = DockStyle.Top;
            lblCaption.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCaption.ImageAlign = ContentAlignment.MiddleLeft;
            lblCaption.Location = new Point(0, 0);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(652, 25);
            lblCaption.TabIndex = 1;
            lblCaption.Text = "sdf";
            lblCaption.TextAlign = ContentAlignment.MiddleLeft;
            lblCaption.MouseLeave += Panel1_MouseLeave;
            lblCaption.MouseMove += Panel1_MouseMove;
            // 
            // formMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(652, 275);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "formMessage";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            BackColorChanged += FormMessage_BackColorChanged;
            MouseLeave += Panel1_MouseLeave;
            MouseMove += Panel1_MouseMove;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCaption;
        private Label lblMessage;
    }
}