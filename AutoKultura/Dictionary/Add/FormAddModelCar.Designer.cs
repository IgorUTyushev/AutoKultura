namespace AutoKultura.Add
{
    partial class FormAddModelCar
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
            CmbBrandCar = new ComboBox();
            CmbBodyWork = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(482, 136);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.Click += BtnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 55);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 13;
            label2.Text = "Марка";
            // 
            // TbName
            // 
            TbName.Location = new Point(174, 12);
            TbName.Margin = new Padding(5);
            TbName.Name = "TbName";
            TbName.Size = new Size(434, 33);
            TbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 17);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 11;
            label1.Text = "Модель";
            // 
            // CmbBrandCar
            // 
            CmbBrandCar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbBrandCar.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbBrandCar.FormattingEnabled = true;
            CmbBrandCar.Location = new Point(174, 52);
            CmbBrandCar.Name = "CmbBrandCar";
            CmbBrandCar.Size = new Size(434, 33);
            CmbBrandCar.TabIndex = 2;
            // 
            // CmbBodyWork
            // 
            CmbBodyWork.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbBodyWork.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbBodyWork.FormattingEnabled = true;
            CmbBodyWork.Location = new Point(174, 91);
            CmbBodyWork.Name = "CmbBodyWork";
            CmbBodyWork.Size = new Size(434, 33);
            CmbBodyWork.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 94);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 23;
            label5.Text = "Тип кузова";
            // 
            // FormAddModelCar
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(629, 186);
            Controls.Add(CmbBodyWork);
            Controls.Add(label5);
            Controls.Add(CmbBrandCar);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(TbName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(645, 255);
            MinimizeBox = false;
            MinimumSize = new Size(645, 225);
            Name = "FormAddModelCar";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление модели машины";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Label label2;
        private TextBox TbName;
        private Label label1;
        private ComboBox CmbBrandCar;
        private ComboBox CmbBodyWork;
        private Label label5;
    }
}