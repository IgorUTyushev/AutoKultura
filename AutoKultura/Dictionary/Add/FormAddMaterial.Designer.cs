namespace AutoKultura.Add
{
    partial class FormAddMaterial
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
            CmbMeasureUnits = new ComboBox();
            TbPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TbCount = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(485, 131);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 42);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить";
            btnAdd.Click += BtnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 58);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 13;
            label2.Text = "Ед. Измерения";
            // 
            // TbName
            // 
            TbName.Location = new Point(177, 10);
            TbName.Margin = new Padding(5);
            TbName.Name = "TbName";
            TbName.Size = new Size(434, 33);
            TbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 15);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 11;
            label1.Text = "Материал";
            // 
            // CmbMeasureUnits
            // 
            CmbMeasureUnits.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbMeasureUnits.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeasureUnits.FormattingEnabled = true;
            CmbMeasureUnits.Location = new Point(177, 55);
            CmbMeasureUnits.Name = "CmbMeasureUnits";
            CmbMeasureUnits.Size = new Size(434, 33);
            CmbMeasureUnits.TabIndex = 2;
            // 
            // TbPrice
            // 
            TbPrice.Location = new Point(177, 140);
            TbPrice.Margin = new Padding(5);
            TbPrice.Name = "TbPrice";
            TbPrice.Size = new Size(143, 33);
            TbPrice.TabIndex = 4;
            TbPrice.KeyPress += TbPrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 143);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 21;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(333, 143);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 22;
            label4.Text = "руб.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 100);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 24;
            label5.Text = "Количество";
            // 
            // TbCount
            // 
            TbCount.Location = new Point(177, 97);
            TbCount.Margin = new Padding(5);
            TbCount.Name = "TbCount";
            TbCount.Size = new Size(143, 33);
            TbCount.TabIndex = 3;
            TbCount.KeyPress += TbCount_KeyPress;
            // 
            // FormAddMaterial
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(629, 180);
            Controls.Add(label5);
            Controls.Add(TbCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TbPrice);
            Controls.Add(CmbMeasureUnits);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(TbName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(645, 219);
            MinimizeBox = false;
            MinimumSize = new Size(645, 219);
            Name = "FormAddMaterial";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление материала";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Label label2;
        private TextBox TbName;
        private Label label1;
        private ComboBox CmbMeasureUnits;
        private TextBox TbPrice;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TbCount;
    }
}