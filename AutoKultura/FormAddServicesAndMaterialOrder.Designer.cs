namespace AutoKultura
{
    partial class FormAddServicesAndMaterialOrder
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            TTSuccessAdd = new ToolTip(components);
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label4 = new Label();
            TbPrice = new TextBox();
            label3 = new Label();
            cmbPartOfTheCar = new ComboBox();
            dgvRenderServices = new DataGridView();
            contextMenuRenderService = new ContextMenuStrip(components);
            btnDeleteRenderServices = new ToolStripMenuItem();
            BtnAddRenderService = new Button();
            CmbServiceType = new ComboBox();
            label6 = new Label();
            scMaterialAndSpecialist = new SplitContainer();
            panel2 = new Panel();
            LblMeasureUnit = new Label();
            dgvUsedUpMaterial = new DataGridView();
            contextMenuMaterial = new ContextMenuStrip(components);
            BtnDeleteMaterial = new ToolStripMenuItem();
            label1 = new Label();
            label5 = new Label();
            CmbMaterials = new ComboBox();
            TbCount = new TextBox();
            btnAddUsedUpMaterial = new Button();
            panel3 = new Panel();
            dgvSpecialist = new DataGridView();
            contextMenuSpecialist = new ContextMenuStrip(components);
            btnDeleteSpecialist = new ToolStripMenuItem();
            label2 = new Label();
            CmbSpecialist = new ComboBox();
            BtnAddSpecialist = new Button();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRenderServices).BeginInit();
            contextMenuRenderService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMaterialAndSpecialist).BeginInit();
            scMaterialAndSpecialist.Panel1.SuspendLayout();
            scMaterialAndSpecialist.Panel2.SuspendLayout();
            scMaterialAndSpecialist.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsedUpMaterial).BeginInit();
            contextMenuMaterial.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialist).BeginInit();
            contextMenuSpecialist.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TTSuccessAdd
            // 
            TTSuccessAdd.AutoPopDelay = 3000;
            TTSuccessAdd.InitialDelay = 0;
            TTSuccessAdd.ReshowDelay = 3000;
            TTSuccessAdd.ShowAlways = true;
            TTSuccessAdd.ToolTipIcon = ToolTipIcon.Info;
            TTSuccessAdd.ToolTipTitle = "Успешно";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BackColor = Color.FromArgb(52, 52, 52);
            splitContainer1.Location = new Point(0, 36);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(scMaterialAndSpecialist);
            splitContainer1.Size = new Size(1533, 795);
            splitContainer1.SplitterDistance = 405;
            splitContainer1.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TbPrice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbPartOfTheCar);
            panel1.Controls.Add(dgvRenderServices);
            panel1.Controls.Add(BtnAddRenderService);
            panel1.Controls.Add(CmbServiceType);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1533, 405);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(1340, 93);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 41;
            label4.Text = "руб.";
            // 
            // TbPrice
            // 
            TbPrice.Location = new Point(1184, 90);
            TbPrice.Margin = new Padding(5);
            TbPrice.Name = "TbPrice";
            TbPrice.Size = new Size(143, 33);
            TbPrice.TabIndex = 40;
            TbPrice.KeyPress += TbPrice_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.ForeColor = Color.White;
            label3.Location = new Point(869, 92);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(313, 25);
            label3.TabIndex = 39;
            label3.Text = "Стоимость выполненных работ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbPartOfTheCar
            // 
            cmbPartOfTheCar.Anchor = AnchorStyles.Top;
            cmbPartOfTheCar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPartOfTheCar.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPartOfTheCar.FormattingEnabled = true;
            cmbPartOfTheCar.Location = new Point(12, 89);
            cmbPartOfTheCar.Name = "cmbPartOfTheCar";
            cmbPartOfTheCar.Size = new Size(835, 33);
            cmbPartOfTheCar.TabIndex = 38;
            cmbPartOfTheCar.SelectedIndexChanged += CmbPartOfTheCar_SelectedIndexChanged;
            // 
            // dgvRenderServices
            // 
            dgvRenderServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRenderServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRenderServices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRenderServices.BackgroundColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRenderServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRenderServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRenderServices.ContextMenuStrip = contextMenuRenderService;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(150, 150, 150);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRenderServices.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRenderServices.EnableHeadersVisualStyles = false;
            dgvRenderServices.Location = new Point(12, 130);
            dgvRenderServices.MultiSelect = false;
            dgvRenderServices.Name = "dgvRenderServices";
            dgvRenderServices.ReadOnly = true;
            dgvRenderServices.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(29, 32, 37);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(150, 150, 150);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvRenderServices.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvRenderServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRenderServices.Size = new Size(1507, 263);
            dgvRenderServices.TabIndex = 37;
            dgvRenderServices.SelectionChanged += DgvRenderServices_SelectionChanged;
            // 
            // contextMenuRenderService
            // 
            contextMenuRenderService.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contextMenuRenderService.Items.AddRange(new ToolStripItem[] { btnDeleteRenderServices });
            contextMenuRenderService.Name = "contextMenuDelete";
            contextMenuRenderService.Size = new Size(212, 34);
            // 
            // btnDeleteRenderServices
            // 
            btnDeleteRenderServices.Name = "btnDeleteRenderServices";
            btnDeleteRenderServices.Size = new Size(211, 30);
            btnDeleteRenderServices.Text = "Удалить     DEL";
            btnDeleteRenderServices.Click += УдалитьDELToolStripMenuItem_Click;
            // 
            // BtnAddRenderService
            // 
            BtnAddRenderService.Anchor = AnchorStyles.Top;
            BtnAddRenderService.FlatAppearance.BorderColor = Color.White;
            BtnAddRenderService.FlatAppearance.BorderSize = 2;
            BtnAddRenderService.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            BtnAddRenderService.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 150, 150);
            BtnAddRenderService.FlatAppearance.MouseOverBackColor = SystemColors.WindowFrame;
            BtnAddRenderService.FlatStyle = FlatStyle.Flat;
            BtnAddRenderService.Font = new Font("Segoe UI", 12F);
            BtnAddRenderService.ForeColor = Color.White;
            BtnAddRenderService.Location = new Point(1400, 89);
            BtnAddRenderService.Margin = new Padding(5);
            BtnAddRenderService.Name = "BtnAddRenderService";
            BtnAddRenderService.Size = new Size(119, 34);
            BtnAddRenderService.TabIndex = 32;
            BtnAddRenderService.Text = "Добавить";
            BtnAddRenderService.Click += BtnAddRenderService_Click;
            // 
            // CmbServiceType
            // 
            CmbServiceType.Anchor = AnchorStyles.Top;
            CmbServiceType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbServiceType.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbServiceType.FormattingEnabled = true;
            CmbServiceType.Location = new Point(12, 41);
            CmbServiceType.Name = "CmbServiceType";
            CmbServiceType.Size = new Size(1375, 33);
            CmbServiceType.TabIndex = 31;
            CmbServiceType.SelectedIndexChanged += CmbRenderService_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 0);
            label6.Margin = new Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(1517, 38);
            label6.TabIndex = 26;
            label6.Text = "Выполненные работы";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scMaterialAndSpecialist
            // 
            scMaterialAndSpecialist.Dock = DockStyle.Fill;
            scMaterialAndSpecialist.Enabled = false;
            scMaterialAndSpecialist.Location = new Point(0, 0);
            scMaterialAndSpecialist.Name = "scMaterialAndSpecialist";
            // 
            // scMaterialAndSpecialist.Panel1
            // 
            scMaterialAndSpecialist.Panel1.Controls.Add(panel2);
            // 
            // scMaterialAndSpecialist.Panel2
            // 
            scMaterialAndSpecialist.Panel2.Controls.Add(panel3);
            scMaterialAndSpecialist.Size = new Size(1533, 386);
            scMaterialAndSpecialist.SplitterDistance = 765;
            scMaterialAndSpecialist.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(LblMeasureUnit);
            panel2.Controls.Add(dgvUsedUpMaterial);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CmbMaterials);
            panel2.Controls.Add(TbCount);
            panel2.Controls.Add(btnAddUsedUpMaterial);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 386);
            panel2.TabIndex = 0;
            // 
            // LblMeasureUnit
            // 
            LblMeasureUnit.AutoSize = true;
            LblMeasureUnit.ForeColor = Color.White;
            LblMeasureUnit.Location = new Point(282, 88);
            LblMeasureUnit.Margin = new Padding(8, 0, 8, 0);
            LblMeasureUnit.Name = "LblMeasureUnit";
            LblMeasureUnit.Size = new Size(0, 25);
            LblMeasureUnit.TabIndex = 37;
            // 
            // dgvUsedUpMaterial
            // 
            dgvUsedUpMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsedUpMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsedUpMaterial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsedUpMaterial.BackgroundColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsedUpMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsedUpMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsedUpMaterial.ContextMenuStrip = contextMenuMaterial;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvUsedUpMaterial.DefaultCellStyle = dataGridViewCellStyle5;
            dgvUsedUpMaterial.EnableHeadersVisualStyles = false;
            dgvUsedUpMaterial.Location = new Point(12, 129);
            dgvUsedUpMaterial.MultiSelect = false;
            dgvUsedUpMaterial.Name = "dgvUsedUpMaterial";
            dgvUsedUpMaterial.ReadOnly = true;
            dgvUsedUpMaterial.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(29, 32, 37);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(29, 32, 37);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvUsedUpMaterial.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvUsedUpMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsedUpMaterial.Size = new Size(747, 254);
            dgvUsedUpMaterial.TabIndex = 36;
            // 
            // contextMenuMaterial
            // 
            contextMenuMaterial.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contextMenuMaterial.Items.AddRange(new ToolStripItem[] { BtnDeleteMaterial });
            contextMenuMaterial.Name = "contextMenuDelete";
            contextMenuMaterial.Size = new Size(212, 34);
            // 
            // BtnDeleteMaterial
            // 
            BtnDeleteMaterial.Name = "BtnDeleteMaterial";
            BtnDeleteMaterial.Size = new Size(211, 30);
            BtnDeleteMaterial.Text = "Удалить     DEL";
            BtnDeleteMaterial.Click += BtnDeleteMaterial_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 6);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(751, 27);
            label1.TabIndex = 35;
            label1.Text = "Израсходованные материалы";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 88);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 34;
            label5.Text = "Количество";
            // 
            // CmbMaterials
            // 
            CmbMaterials.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbMaterials.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMaterials.FormattingEnabled = true;
            CmbMaterials.Location = new Point(12, 43);
            CmbMaterials.Name = "CmbMaterials";
            CmbMaterials.Size = new Size(747, 33);
            CmbMaterials.TabIndex = 29;
            CmbMaterials.SelectedIndexChanged += CmbMaterials_SelectedIndexChanged;
            // 
            // TbCount
            // 
            TbCount.Location = new Point(126, 85);
            TbCount.Margin = new Padding(5);
            TbCount.Name = "TbCount";
            TbCount.Size = new Size(143, 33);
            TbCount.TabIndex = 33;
            TbCount.KeyPress += TbCount_KeyPress;
            // 
            // btnAddUsedUpMaterial
            // 
            btnAddUsedUpMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUsedUpMaterial.FlatAppearance.BorderColor = Color.White;
            btnAddUsedUpMaterial.FlatAppearance.BorderSize = 2;
            btnAddUsedUpMaterial.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            btnAddUsedUpMaterial.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 150, 150);
            btnAddUsedUpMaterial.FlatAppearance.MouseOverBackColor = SystemColors.WindowFrame;
            btnAddUsedUpMaterial.FlatStyle = FlatStyle.Flat;
            btnAddUsedUpMaterial.Font = new Font("Segoe UI", 12F);
            btnAddUsedUpMaterial.ForeColor = Color.White;
            btnAddUsedUpMaterial.Location = new Point(640, 85);
            btnAddUsedUpMaterial.Margin = new Padding(5);
            btnAddUsedUpMaterial.Name = "btnAddUsedUpMaterial";
            btnAddUsedUpMaterial.Size = new Size(119, 33);
            btnAddUsedUpMaterial.TabIndex = 28;
            btnAddUsedUpMaterial.Text = "Добавить";
            btnAddUsedUpMaterial.Click += BtnAddUsedUpMaterial_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvSpecialist);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(CmbSpecialist);
            panel3.Controls.Add(BtnAddSpecialist);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 386);
            panel3.TabIndex = 1;
            // 
            // dgvSpecialist
            // 
            dgvSpecialist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSpecialist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSpecialist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSpecialist.BackgroundColor = Color.FromArgb(52, 52, 52);
            dgvSpecialist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSpecialist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpecialist.ContextMenuStrip = contextMenuSpecialist;
            dgvSpecialist.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSpecialist.EnableHeadersVisualStyles = false;
            dgvSpecialist.Location = new Point(6, 129);
            dgvSpecialist.MultiSelect = false;
            dgvSpecialist.Name = "dgvSpecialist";
            dgvSpecialist.ReadOnly = true;
            dgvSpecialist.RowHeadersVisible = false;
            dgvSpecialist.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvSpecialist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpecialist.Size = new Size(746, 254);
            dgvSpecialist.TabIndex = 42;
            // 
            // contextMenuSpecialist
            // 
            contextMenuSpecialist.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contextMenuSpecialist.Items.AddRange(new ToolStripItem[] { btnDeleteSpecialist });
            contextMenuSpecialist.Name = "contextMenuDelete";
            contextMenuSpecialist.Size = new Size(212, 34);
            // 
            // btnDeleteSpecialist
            // 
            btnDeleteSpecialist.Name = "btnDeleteSpecialist";
            btnDeleteSpecialist.Size = new Size(211, 30);
            btnDeleteSpecialist.Text = "Удалить     DEL";
            btnDeleteSpecialist.Click += ToolStripMenuItem2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 9);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(746, 27);
            label2.TabIndex = 41;
            label2.Text = "Мастера выполнявшие работы";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmbSpecialist
            // 
            CmbSpecialist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbSpecialist.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbSpecialist.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbSpecialist.FormattingEnabled = true;
            CmbSpecialist.Location = new Point(10, 43);
            CmbSpecialist.Name = "CmbSpecialist";
            CmbSpecialist.Size = new Size(742, 33);
            CmbSpecialist.TabIndex = 38;
            // 
            // BtnAddSpecialist
            // 
            BtnAddSpecialist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAddSpecialist.FlatAppearance.BorderColor = Color.White;
            BtnAddSpecialist.FlatAppearance.BorderSize = 2;
            BtnAddSpecialist.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            BtnAddSpecialist.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 150, 150);
            BtnAddSpecialist.FlatAppearance.MouseOverBackColor = SystemColors.WindowFrame;
            BtnAddSpecialist.FlatStyle = FlatStyle.Flat;
            BtnAddSpecialist.Font = new Font("Segoe UI", 12F);
            BtnAddSpecialist.ForeColor = Color.White;
            BtnAddSpecialist.Location = new Point(629, 85);
            BtnAddSpecialist.Margin = new Padding(5);
            BtnAddSpecialist.Name = "BtnAddSpecialist";
            BtnAddSpecialist.Size = new Size(123, 33);
            BtnAddSpecialist.TabIndex = 37;
            BtnAddSpecialist.Text = "Добавить";
            BtnAddSpecialist.Click += BtnAddSpecialist_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(52, 52, 52);
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1533, 33);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem });
            менюToolStripMenuItem.ForeColor = Color.White;
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(142, 29);
            менюToolStripMenuItem.Text = "Справочники";
            менюToolStripMenuItem.Click += СправочникиToolStripMenuItem_Click;
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(202, 30);
            справочникиToolStripMenuItem.Text = "Справочники";
            справочникиToolStripMenuItem.Click += СправочникиToolStripMenuItem_Click;
            // 
            // FormAddServicesAndMaterialOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1533, 831);
            Controls.Add(menuStrip1);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddServicesAndMaterialOrder";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление выполненых работ";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRenderServices).EndInit();
            contextMenuRenderService.ResumeLayout(false);
            scMaterialAndSpecialist.Panel1.ResumeLayout(false);
            scMaterialAndSpecialist.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMaterialAndSpecialist).EndInit();
            scMaterialAndSpecialist.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsedUpMaterial).EndInit();
            contextMenuMaterial.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSpecialist).EndInit();
            contextMenuSpecialist.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip TTSuccessAdd;
        private SplitContainer splitContainer1;
        private SplitContainer scMaterialAndSpecialist;
        private Panel panel1;
        private Button BtnAddRenderService;
        private ComboBox CmbServiceType;
        private Label label6;
        private Panel panel2;
        private Label label5;
        private ComboBox CmbMaterials;
        private TextBox TbCount;
        private Button btnAddUsedUpMaterial;
        private Panel panel3;
        private DataGridView dgvUsedUpMaterial;
        private Label label1;
        private DataGridView dgvSpecialist;
        private Label label2;
        private ComboBox CmbSpecialist;
        private Button BtnAddSpecialist;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private Label LblMeasureUnit;
        private DataGridView dgvRenderServices;
        private ContextMenuStrip contextMenuRenderService;
        private ToolStripMenuItem btnDeleteRenderServices;
        private ContextMenuStrip contextMenuMaterial;
        private ToolStripMenuItem BtnDeleteMaterial;
        private ContextMenuStrip contextMenuSpecialist;
        private ToolStripMenuItem btnDeleteSpecialist;
        private ComboBox cmbPartOfTheCar;
        private Label label3;
        private Label label4;
        private TextBox TbPrice;
    }
}