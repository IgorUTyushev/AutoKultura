namespace AnalysisOfTheFaceComparisonAlgorithm
{
    partial class SettingsConnect
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
            btnSave = new Button();
            label1 = new Label();
            txbServer = new TextBox();
            txbInitialCatalog = new TextBox();
            label2 = new Label();
            txbUserID = new TextBox();
            label3 = new Label();
            txbPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(250, 152);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(167, 22);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить настройки";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Экземпляр";
            // 
            // txbServer
            // 
            txbServer.Location = new Point(106, 26);
            txbServer.Name = "txbServer";
            txbServer.PlaceholderText = "Экземпляр";
            txbServer.Size = new Size(311, 23);
            txbServer.TabIndex = 0;
            txbServer.TextAlign = HorizontalAlignment.Center;
            // 
            // txbInitialCatalog
            // 
            txbInitialCatalog.Location = new Point(106, 55);
            txbInitialCatalog.Name = "txbInitialCatalog";
            txbInitialCatalog.PlaceholderText = "База Данных";
            txbInitialCatalog.Size = new Size(311, 23);
            txbInitialCatalog.TabIndex = 1;
            txbInitialCatalog.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 58);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "База Данных";
            // 
            // txbUserID
            // 
            txbUserID.Location = new Point(106, 84);
            txbUserID.Name = "txbUserID";
            txbUserID.PlaceholderText = "Пользователь";
            txbUserID.Size = new Size(311, 23);
            txbUserID.TabIndex = 2;
            txbUserID.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 87);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Пользователь";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(106, 113);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '●';
            txbPassword.PlaceholderText = "Пароль";
            txbPassword.Size = new Size(311, 23);
            txbPassword.TabIndex = 3;
            txbPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 116);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Пароль";
            // 
            // SettingsConnect
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 186);
            Controls.Add(txbPassword);
            Controls.Add(label4);
            Controls.Add(txbUserID);
            Controls.Add(label3);
            Controls.Add(txbInitialCatalog);
            Controls.Add(label2);
            Controls.Add(txbServer);
            Controls.Add(label1);
            Controls.Add(btnSave);
            MaximumSize = new Size(445, 225);
            MinimumSize = new Size(445, 225);
            Name = "SettingsConnect";
            Text = "Настройки подключения";
            FormClosing += SettingsConnect_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox txbServer;
        private TextBox txbInitialCatalog;
        private Label label2;
        private TextBox txbUserID;
        private Label label3;
        private TextBox txbPassword;
        private Label label4;
    }
}