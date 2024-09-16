namespace AutoKultura.Add
{
    partial class FormUpdatePartOfTheCar
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
            label2 = new Label();
            TbName = new TextBox();
            label1 = new Label();
            CmbServiceType = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            TbPrice = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(467, 149);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Изменить";
            btnAdd.Click += BtnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 29);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 13;
            label2.Text = "Тип работ";
            // 
            // TbName
            // 
            TbName.Location = new Point(159, 73);
            TbName.Margin = new Padding(5);
            TbName.Name = "TbName";
            TbName.Size = new Size(434, 33);
            TbName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 73);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 11;
            label1.Text = "Деталь";
            // 
            // CmbServiceType
            // 
            CmbServiceType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbServiceType.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbServiceType.FormattingEnabled = true;
            CmbServiceType.Location = new Point(159, 26);
            CmbServiceType.Name = "CmbServiceType";
            CmbServiceType.Size = new Size(434, 33);
            CmbServiceType.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(315, 119);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 25;
            label4.Text = "руб.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 119);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 24;
            label3.Text = "Цена";
            // 
            // TbPrice
            // 
            TbPrice.Location = new Point(159, 116);
            TbPrice.Margin = new Padding(5);
            TbPrice.Name = "TbPrice";
            TbPrice.Size = new Size(143, 33);
            TbPrice.TabIndex = 3;
            TbPrice.KeyPress += TbPrice_KeyPress;
            // 
            // FormUpdatePartOfTheCar
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(603, 198);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TbPrice);
            Controls.Add(CmbServiceType);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(TbName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(619, 237);
            MinimizeBox = false;
            MinimumSize = new Size(619, 237);
            Name = "FormUpdatePartOfTheCar";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение детали автомобиля на которой производятся работы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Label label2;
        private TextBox TbName;
        private Label label1;
        private ComboBox CmbServiceType;
        private Label label4;
        private Label label3;
        private TextBox TbPrice;
    }
}