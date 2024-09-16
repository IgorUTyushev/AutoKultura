
namespace AutoKultura.Update
{
    partial class FormUpdateCompany
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
            label1 = new Label();
            TbName = new TextBox();
            TbPhone = new TextBox();
            label2 = new Label();
            TbEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            RtbAdress = new RichTextBox();
            button1 = new Button();
            TbNumberOrderOnOutfit = new TextBox();
            label6 = new Label();
            TbPath = new RichTextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 23);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // TbName
            // 
            TbName.Location = new Point(117, 20);
            TbName.Name = "TbName";
            TbName.Size = new Size(494, 33);
            TbName.TabIndex = 1;
            // 
            // TbPhone
            // 
            TbPhone.Location = new Point(117, 61);
            TbPhone.Name = "TbPhone";
            TbPhone.Size = new Size(494, 33);
            TbPhone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 64);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Телефон";
            // 
            // TbEmail
            // 
            TbEmail.Location = new Point(117, 102);
            TbEmail.Name = "TbEmail";
            TbEmail.Size = new Size(494, 33);
            TbEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 105);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 140);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 7;
            label4.Text = "Адрес";
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(506, 297);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 38);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Изменить";
            btnAdd.Click += BtnUpdate_Click;
            // 
            // RtbAdress
            // 
            RtbAdress.Location = new Point(117, 145);
            RtbAdress.Name = "RtbAdress";
            RtbAdress.Size = new Size(494, 51);
            RtbAdress.TabIndex = 4;
            RtbAdress.Text = "";
            // 
            // button1
            // 
            button1.ForeColor = Color.White;
            button1.Location = new Point(372, 200);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 20;
            button1.Text = "Обзор";
            button1.Click += Button1_Click;
            // 
            // TbNumberOrderOnOutfit
            // 
            TbNumberOrderOnOutfit.Location = new Point(165, 297);
            TbNumberOrderOnOutfit.Name = "TbNumberOrderOnOutfit";
            TbNumberOrderOnOutfit.Size = new Size(83, 33);
            TbNumberOrderOnOutfit.TabIndex = 6;
            TbNumberOrderOnOutfit.KeyPress += TbNumberOrderOnOutfit_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(7, 300);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 18;
            label6.Text = "№ заказ наряда";
            // 
            // TbPath
            // 
            TbPath.Location = new Point(117, 234);
            TbPath.Name = "TbPath";
            TbPath.Size = new Size(494, 51);
            TbPath.TabIndex = 5;
            TbPath.Text = "";
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 200);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(597, 33);
            label5.TabIndex = 16;
            label5.Text = "Путь к папе сохранения заказ нарядов:";
            // 
            // FormUpdateCompany
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(624, 349);
            Controls.Add(button1);
            Controls.Add(TbNumberOrderOnOutfit);
            Controls.Add(label6);
            Controls.Add(TbPath);
            Controls.Add(label5);
            Controls.Add(RtbAdress);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(TbEmail);
            Controls.Add(label3);
            Controls.Add(TbPhone);
            Controls.Add(label2);
            Controls.Add(TbName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(640, 388);
            MinimizeBox = false;
            MinimumSize = new Size(640, 388);
            Name = "FormUpdateCompany";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение информации о компании";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TbName;
        private TextBox TbPhone;
        private Label label2;
        private TextBox TbEmail;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private RichTextBox RtbAdress;
        private Button button1;
        private TextBox TbNumberOrderOnOutfit;
        private Label label6;
        private RichTextBox TbPath;
        private Label label5;
    }
}