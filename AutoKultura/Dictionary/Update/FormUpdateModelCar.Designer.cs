namespace AutoKultura.Update
{
    partial class FormUpdateModelCar
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
            btnAdd.Location = new Point(474, 138);
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
            label2.Location = new Point(17, 57);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 13;
            label2.Text = "Марка";
            // 
            // TbName
            // 
            TbName.Location = new Point(166, 14);
            TbName.Margin = new Padding(5);
            TbName.Name = "TbName";
            TbName.Size = new Size(434, 33);
            TbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 19);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 11;
            label1.Text = "Модель";
            // 
            // CmbBrandCar
            // 
            CmbBrandCar.FormattingEnabled = true;
            CmbBrandCar.Location = new Point(166, 54);
            CmbBrandCar.Name = "CmbBrandCar";
            CmbBrandCar.Size = new Size(434, 33);
            CmbBrandCar.TabIndex = 2;
            // 
            // CmbBodyWork
            // 
            CmbBodyWork.FormattingEnabled = true;
            CmbBodyWork.Location = new Point(166, 96);
            CmbBodyWork.Name = "CmbBodyWork";
            CmbBodyWork.Size = new Size(434, 33);
            CmbBodyWork.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 99);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 23;
            label5.Text = "Тип кузова";
            // 
            // FormUpdateModelCar
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(609, 190);
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
            MaximumSize = new Size(625, 229);
            MinimizeBox = false;
            MinimumSize = new Size(625, 229);
            Name = "FormUpdateModelCar";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение модели машины";
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