namespace AutoKultura.Add
{
    partial class FormAddSpecialist
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
            btnAdd = new Button();
            TbPhone = new TextBox();
            label2 = new Label();
            TbName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(474, 99);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.Click += BtnAdd_Click;
            // 
            // TbPhone
            // 
            TbPhone.Location = new Point(113, 56);
            TbPhone.Margin = new Padding(5);
            TbPhone.Name = "TbPhone";
            TbPhone.Size = new Size(487, 33);
            TbPhone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 61);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 13;
            label2.Text = "Телефон";
            // 
            // TbName
            // 
            TbName.Location = new Point(113, 13);
            TbName.Margin = new Padding(5);
            TbName.Name = "TbName";
            TbName.Size = new Size(487, 33);
            TbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 18);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 11;
            label1.Text = "ФИО";
            // 
            // FormAddSpecialist
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(608, 150);
            Controls.Add(btnAdd);
            Controls.Add(TbPhone);
            Controls.Add(label2);
            Controls.Add(TbName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(624, 189);
            MinimizeBox = false;
            MinimumSize = new Size(624, 189);
            Name = "FormAddSpecialist";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление мастера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private TextBox TbPhone;
        private Label label2;
        private TextBox TbName;
        private Label label1;
    }
}