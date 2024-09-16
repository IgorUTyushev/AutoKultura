namespace AutoKultura.Update
{
    partial class FormUpdateBodyWork
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
            BtnUpdate = new Button();
            TbName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnUpdate
            // 
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(474, 57);
            BtnUpdate.Margin = new Padding(5);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(126, 42);
            BtnUpdate.TabIndex = 2;
            BtnUpdate.Text = "Изменить";
            BtnUpdate.Click += BtnAdd_Click;
            // 
            // TbName
            // 
            TbName.Location = new Point(162, 14);
            TbName.Margin = new Padding(5);
            TbName.Name = "TbName";
            TbName.Size = new Size(434, 33);
            TbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 19);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 11;
            label1.Text = "Тип кузова";
            // 
            // FormUpdateBodyWork
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(629, 111);
            Controls.Add(BtnUpdate);
            Controls.Add(TbName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(645, 150);
            MinimizeBox = false;
            MinimumSize = new Size(645, 150);
            Name = "FormUpdateBodyWork";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение типа кузова";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnUpdate;
        private TextBox TbName;
        private Label label1;
    }
}