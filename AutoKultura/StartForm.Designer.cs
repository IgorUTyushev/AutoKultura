namespace AutoKultura
{
    partial class FormBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvOrders = new DataGridView();
            cmsDgvOrders = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            scBase = new SplitContainer();
            skSerchOrder = new SplitContainer();
            gbFilter = new GroupBox();
            panel1 = new Panel();
            dtpFiltrOn = new DateTimePicker();
            dtpFiltrWith = new DateTimePicker();
            TbRegisterNumberFiltr = new MaskedTextBox();
            label2 = new Label();
            CmbStatusFiltr = new ComboBox();
            label43 = new Label();
            CmbCustomerFiltr = new ComboBox();
            label5 = new Label();
            CmbModelCarFiltr = new ComboBox();
            CmbBrandCarFiltr = new ComboBox();
            BtnClearFiltr = new Button();
            label4 = new Label();
            BtnSerch = new Button();
            label1 = new Label();
            label3 = new Label();
            lbl35 = new Label();
            tcDetailsOrder = new TabControl();
            tpOrder = new TabPage();
            btnCreateOrderAnOutfit = new Button();
            dtpDateOrderInfo = new DateTimePicker();
            label19 = new Label();
            DtpDeliveryOfTheOrder = new DateTimePicker();
            BtnChangeOrder = new Button();
            label29 = new Label();
            TbPriceOrderInfo = new TextBox();
            label30 = new Label();
            CmbPymentMethodInfo = new ComboBox();
            label16 = new Label();
            groupBox3 = new GroupBox();
            BtnAddServiceType = new Button();
            label27 = new Label();
            dgvSpecialist = new DataGridView();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            dgvCompletedWorks = new DataGridView();
            label14 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            dgvUsedUpMaterial = new DataGridView();
            label15 = new Label();
            groupBox2 = new GroupBox();
            TbRegisterNumberInfo = new MaskedTextBox();
            btnChangeVechicle = new Button();
            label13 = new Label();
            CmbModelCarInfo = new ComboBox();
            CmbBrandCarInfo = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            TbCustomerPhoneInfo = new MaskedTextBox();
            BtnChangeCustomerOrderInfo = new Button();
            TbCustomerNameInfo = new TextBox();
            TbCustomerAdditionalInfo = new RichTextBox();
            TbCustomerEmailInfo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tpCar = new TabPage();
            CmbPymentMethodAdd = new ComboBox();
            label18 = new Label();
            BtnClearFormAdd = new Button();
            button4 = new Button();
            label17 = new Label();
            dtpDateOrder = new DateTimePicker();
            groupBox7 = new GroupBox();
            TbRegisterNumber = new MaskedTextBox();
            label20 = new Label();
            cmbModelCarAdd = new ComboBox();
            CmbBrandCarAdd = new ComboBox();
            label21 = new Label();
            label22 = new Label();
            groupBox8 = new GroupBox();
            TbPhoneCustomer = new MaskedTextBox();
            TbAdditionalInformationCustomer = new RichTextBox();
            TbEmailCustomer = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            CmbNameCustomer = new ComboBox();
            label26 = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            настройкиПодключенияКСерверуToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatusInfo = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            cmsDgvOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scBase).BeginInit();
            scBase.Panel1.SuspendLayout();
            scBase.Panel2.SuspendLayout();
            scBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)skSerchOrder).BeginInit();
            skSerchOrder.Panel1.SuspendLayout();
            skSerchOrder.Panel2.SuspendLayout();
            skSerchOrder.SuspendLayout();
            gbFilter.SuspendLayout();
            panel1.SuspendLayout();
            tcDetailsOrder.SuspendLayout();
            tpOrder.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompletedWorks).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsedUpMaterial).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tpCar.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.ContextMenuStrip = cmsDgvOrders;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 0);
            dgvOrders.Margin = new Padding(4);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(720, 783);
            dgvOrders.TabIndex = 0;
            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;
            // 
            // cmsDgvOrders
            // 
            cmsDgvOrders.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            cmsDgvOrders.Name = "cmsDgvOrders";
            cmsDgvOrders.Size = new Size(136, 30);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(135, 26);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += УдалитьToolStripMenuItem_Click;
            // 
            // scBase
            // 
            scBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scBase.FixedPanel = FixedPanel.Panel1;
            scBase.Location = new Point(0, 33);
            scBase.Name = "scBase";
            // 
            // scBase.Panel1
            // 
            scBase.Panel1.Controls.Add(skSerchOrder);
            // 
            // scBase.Panel2
            // 
            scBase.Panel2.Controls.Add(tcDetailsOrder);
            scBase.Size = new Size(1305, 1003);
            scBase.SplitterDistance = 720;
            scBase.TabIndex = 1;
            // 
            // skSerchOrder
            // 
            skSerchOrder.Dock = DockStyle.Fill;
            skSerchOrder.FixedPanel = FixedPanel.Panel1;
            skSerchOrder.IsSplitterFixed = true;
            skSerchOrder.Location = new Point(0, 0);
            skSerchOrder.Name = "skSerchOrder";
            skSerchOrder.Orientation = Orientation.Horizontal;
            // 
            // skSerchOrder.Panel1
            // 
            skSerchOrder.Panel1.Controls.Add(gbFilter);
            // 
            // skSerchOrder.Panel2
            // 
            skSerchOrder.Panel2.Controls.Add(dgvOrders);
            skSerchOrder.Size = new Size(720, 1003);
            skSerchOrder.SplitterDistance = 216;
            skSerchOrder.TabIndex = 1;
            // 
            // gbFilter
            // 
            gbFilter.BackgroundImageLayout = ImageLayout.Center;
            gbFilter.Controls.Add(panel1);
            gbFilter.Dock = DockStyle.Fill;
            gbFilter.Location = new Point(0, 0);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(720, 216);
            gbFilter.TabIndex = 0;
            gbFilter.TabStop = false;
            gbFilter.Text = "Фильтр поиска";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpFiltrOn);
            panel1.Controls.Add(dtpFiltrWith);
            panel1.Controls.Add(TbRegisterNumberFiltr);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CmbStatusFiltr);
            panel1.Controls.Add(label43);
            panel1.Controls.Add(CmbCustomerFiltr);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CmbModelCarFiltr);
            panel1.Controls.Add(CmbBrandCarFiltr);
            panel1.Controls.Add(BtnClearFiltr);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BtnSerch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl35);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 188);
            panel1.TabIndex = 0;
            // 
            // dtpFiltrOn
            // 
            dtpFiltrOn.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpFiltrOn.Format = DateTimePickerFormat.Custom;
            dtpFiltrOn.Location = new Point(287, 11);
            dtpFiltrOn.Name = "dtpFiltrOn";
            dtpFiltrOn.Size = new Size(152, 29);
            dtpFiltrOn.TabIndex = 45;
            dtpFiltrOn.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // dtpFiltrWith
            // 
            dtpFiltrWith.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpFiltrWith.Format = DateTimePickerFormat.Custom;
            dtpFiltrWith.Location = new Point(80, 10);
            dtpFiltrWith.Name = "dtpFiltrWith";
            dtpFiltrWith.Size = new Size(155, 29);
            dtpFiltrWith.TabIndex = 44;
            dtpFiltrWith.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // TbRegisterNumberFiltr
            // 
            TbRegisterNumberFiltr.InsertKeyMode = InsertKeyMode.Overwrite;
            TbRegisterNumberFiltr.Location = new Point(522, 11);
            TbRegisterNumberFiltr.Mask = "L 000 LL 00";
            TbRegisterNumberFiltr.Name = "TbRegisterNumberFiltr";
            TbRegisterNumberFiltr.Size = new Size(95, 29);
            TbRegisterNumberFiltr.TabIndex = 39;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Location = new Point(442, 11);
            label2.Name = "label2";
            label2.Size = new Size(74, 29);
            label2.TabIndex = 38;
            label2.Text = "Гос. №";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CmbStatusFiltr
            // 
            CmbStatusFiltr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbStatusFiltr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbStatusFiltr.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbStatusFiltr.FormattingEnabled = true;
            CmbStatusFiltr.Items.AddRange(new object[] { "Выполненые", "Не выполненые" });
            CmbStatusFiltr.Location = new Point(80, 151);
            CmbStatusFiltr.Name = "CmbStatusFiltr";
            CmbStatusFiltr.Size = new Size(492, 29);
            CmbStatusFiltr.TabIndex = 17;
            // 
            // label43
            // 
            label43.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label43.Location = new Point(3, 151);
            label43.Name = "label43";
            label43.Size = new Size(74, 29);
            label43.TabIndex = 16;
            label43.Text = "Статус";
            label43.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CmbCustomerFiltr
            // 
            CmbCustomerFiltr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbCustomerFiltr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbCustomerFiltr.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbCustomerFiltr.FormattingEnabled = true;
            CmbCustomerFiltr.Location = new Point(80, 116);
            CmbCustomerFiltr.Name = "CmbCustomerFiltr";
            CmbCustomerFiltr.Size = new Size(492, 29);
            CmbCustomerFiltr.TabIndex = 13;
            // 
            // label5
            // 
            label5.Location = new Point(3, 116);
            label5.Name = "label5";
            label5.Size = new Size(74, 29);
            label5.TabIndex = 12;
            label5.Text = "Клиент";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CmbModelCarFiltr
            // 
            CmbModelCarFiltr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbModelCarFiltr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbModelCarFiltr.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbModelCarFiltr.FormattingEnabled = true;
            CmbModelCarFiltr.Location = new Point(80, 81);
            CmbModelCarFiltr.Name = "CmbModelCarFiltr";
            CmbModelCarFiltr.Size = new Size(492, 29);
            CmbModelCarFiltr.TabIndex = 10;
            // 
            // CmbBrandCarFiltr
            // 
            CmbBrandCarFiltr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbBrandCarFiltr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbBrandCarFiltr.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbBrandCarFiltr.FormattingEnabled = true;
            CmbBrandCarFiltr.Location = new Point(80, 46);
            CmbBrandCarFiltr.Name = "CmbBrandCarFiltr";
            CmbBrandCarFiltr.Size = new Size(492, 29);
            CmbBrandCarFiltr.TabIndex = 11;
            CmbBrandCarFiltr.SelectedIndexChanged += CmbBrandCarFiltr_SelectedIndexChanged;
            // 
            // BtnClearFiltr
            // 
            BtnClearFiltr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClearFiltr.Location = new Point(578, 46);
            BtnClearFiltr.Name = "BtnClearFiltr";
            BtnClearFiltr.Size = new Size(128, 64);
            BtnClearFiltr.TabIndex = 1;
            BtnClearFiltr.Text = "Очистить";
            BtnClearFiltr.UseVisualStyleBackColor = true;
            BtnClearFiltr.Click += BtnClearFiltr_Click;
            // 
            // label4
            // 
            label4.Location = new Point(3, 46);
            label4.Name = "label4";
            label4.Size = new Size(74, 29);
            label4.TabIndex = 7;
            label4.Text = "Марка";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnSerch
            // 
            BtnSerch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSerch.Location = new Point(578, 116);
            BtnSerch.Name = "BtnSerch";
            BtnSerch.Size = new Size(128, 64);
            BtnSerch.TabIndex = 0;
            BtnSerch.Text = "Поиск";
            BtnSerch.UseVisualStyleBackColor = true;
            BtnSerch.Click += BtnSerch_Click;
            // 
            // label1
            // 
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(62, 29);
            label1.TabIndex = 4;
            label1.Text = "Дата с";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(3, 81);
            label3.Name = "label3";
            label3.Size = new Size(74, 29);
            label3.TabIndex = 9;
            label3.Text = "Модель";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl35
            // 
            lbl35.Anchor = AnchorStyles.Top;
            lbl35.Location = new Point(230, 8);
            lbl35.Name = "lbl35";
            lbl35.Size = new Size(62, 35);
            lbl35.TabIndex = 5;
            lbl35.Text = "по";
            lbl35.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcDetailsOrder
            // 
            tcDetailsOrder.Controls.Add(tpOrder);
            tcDetailsOrder.Controls.Add(tpCar);
            tcDetailsOrder.Dock = DockStyle.Fill;
            tcDetailsOrder.Location = new Point(0, 0);
            tcDetailsOrder.Name = "tcDetailsOrder";
            tcDetailsOrder.SelectedIndex = 0;
            tcDetailsOrder.Size = new Size(581, 1003);
            tcDetailsOrder.TabIndex = 0;
            // 
            // tpOrder
            // 
            tpOrder.Controls.Add(btnCreateOrderAnOutfit);
            tpOrder.Controls.Add(dtpDateOrderInfo);
            tpOrder.Controls.Add(label19);
            tpOrder.Controls.Add(DtpDeliveryOfTheOrder);
            tpOrder.Controls.Add(BtnChangeOrder);
            tpOrder.Controls.Add(label29);
            tpOrder.Controls.Add(TbPriceOrderInfo);
            tpOrder.Controls.Add(label30);
            tpOrder.Controls.Add(CmbPymentMethodInfo);
            tpOrder.Controls.Add(label16);
            tpOrder.Controls.Add(groupBox3);
            tpOrder.Controls.Add(groupBox2);
            tpOrder.Controls.Add(groupBox1);
            tpOrder.Controls.Add(label6);
            tpOrder.Location = new Point(4, 30);
            tpOrder.Name = "tpOrder";
            tpOrder.Padding = new Padding(3);
            tpOrder.Size = new Size(573, 969);
            tpOrder.TabIndex = 0;
            tpOrder.Text = "Информация о заказе";
            tpOrder.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrderAnOutfit
            // 
            btnCreateOrderAnOutfit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateOrderAnOutfit.Location = new Point(365, 784);
            btnCreateOrderAnOutfit.Name = "btnCreateOrderAnOutfit";
            btnCreateOrderAnOutfit.Size = new Size(96, 75);
            btnCreateOrderAnOutfit.TabIndex = 43;
            btnCreateOrderAnOutfit.Text = "Заказ наряд";
            btnCreateOrderAnOutfit.UseVisualStyleBackColor = true;
            btnCreateOrderAnOutfit.Click += BtnCreateOrderAnOutfit_Click;
            // 
            // dtpDateOrderInfo
            // 
            dtpDateOrderInfo.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDateOrderInfo.Format = DateTimePickerFormat.Custom;
            dtpDateOrderInfo.Location = new Point(141, 819);
            dtpDateOrderInfo.Name = "dtpDateOrderInfo";
            dtpDateOrderInfo.Size = new Size(171, 29);
            dtpDateOrderInfo.TabIndex = 42;
            // 
            // label19
            // 
            label19.Location = new Point(15, 856);
            label19.Name = "label19";
            label19.Size = new Size(121, 29);
            label19.TabIndex = 39;
            label19.Text = "Дата сдачи";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DtpDeliveryOfTheOrder
            // 
            DtpDeliveryOfTheOrder.CustomFormat = "dd.MM.yyyy HH:mm";
            DtpDeliveryOfTheOrder.Format = DateTimePickerFormat.Custom;
            DtpDeliveryOfTheOrder.Location = new Point(141, 854);
            DtpDeliveryOfTheOrder.MaxDate = new DateTime(2100, 1, 1, 0, 0, 0, 0);
            DtpDeliveryOfTheOrder.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DtpDeliveryOfTheOrder.Name = "DtpDeliveryOfTheOrder";
            DtpDeliveryOfTheOrder.Size = new Size(171, 29);
            DtpDeliveryOfTheOrder.TabIndex = 38;
            // 
            // BtnChangeOrder
            // 
            BtnChangeOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnChangeOrder.Location = new Point(467, 784);
            BtnChangeOrder.Name = "BtnChangeOrder";
            BtnChangeOrder.Size = new Size(96, 75);
            BtnChangeOrder.TabIndex = 37;
            BtnChangeOrder.Text = "Сохранить";
            BtnChangeOrder.UseVisualStyleBackColor = true;
            BtnChangeOrder.Click += BtnChangeOrder_Click;
            // 
            // label29
            // 
            label29.Location = new Point(318, 784);
            label29.Name = "label29";
            label29.Size = new Size(131, 29);
            label29.TabIndex = 36;
            label29.Text = "руб.";
            label29.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TbPriceOrderInfo
            // 
            TbPriceOrderInfo.Location = new Point(141, 784);
            TbPriceOrderInfo.Name = "TbPriceOrderInfo";
            TbPriceOrderInfo.PlaceholderText = "Сумма";
            TbPriceOrderInfo.Size = new Size(171, 29);
            TbPriceOrderInfo.TabIndex = 34;
            TbPriceOrderInfo.KeyPress += TbPriceOrderInfo_KeyPress;
            // 
            // label30
            // 
            label30.Location = new Point(14, 784);
            label30.Name = "label30";
            label30.Size = new Size(131, 29);
            label30.TabIndex = 35;
            label30.Text = "Сумма к оплате";
            label30.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CmbPymentMethodInfo
            // 
            CmbPymentMethodInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbPymentMethodInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbPymentMethodInfo.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPymentMethodInfo.FormattingEnabled = true;
            CmbPymentMethodInfo.Location = new Point(141, 749);
            CmbPymentMethodInfo.Name = "CmbPymentMethodInfo";
            CmbPymentMethodInfo.Size = new Size(423, 29);
            CmbPymentMethodInfo.TabIndex = 24;
            // 
            // label16
            // 
            label16.Location = new Point(14, 749);
            label16.Name = "label16";
            label16.Size = new Size(121, 29);
            label16.TabIndex = 23;
            label16.Text = "Способ оплаты";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(BtnAddServiceType);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(dgvSpecialist);
            groupBox3.Controls.Add(splitContainer1);
            groupBox3.Location = new Point(6, 318);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(564, 416);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выполненные работы";
            // 
            // BtnAddServiceType
            // 
            BtnAddServiceType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAddServiceType.Location = new Point(462, 376);
            BtnAddServiceType.Name = "BtnAddServiceType";
            BtnAddServiceType.Size = new Size(99, 34);
            BtnAddServiceType.TabIndex = 1;
            BtnAddServiceType.Text = "Изменить";
            BtnAddServiceType.UseVisualStyleBackColor = true;
            BtnAddServiceType.Click += BtnAddServiceType_Click;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label27.Location = new Point(9, 226);
            label27.Name = "label27";
            label27.Size = new Size(552, 29);
            label27.TabIndex = 23;
            label27.Text = "Мастера выполнявшие работы";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSpecialist
            // 
            dgvSpecialist.AllowUserToAddRows = false;
            dgvSpecialist.AllowUserToDeleteRows = false;
            dgvSpecialist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSpecialist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpecialist.Location = new Point(6, 258);
            dgvSpecialist.Name = "dgvSpecialist";
            dgvSpecialist.ReadOnly = true;
            dgvSpecialist.Size = new Size(552, 112);
            dgvSpecialist.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(3, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(558, 198);
            splitContainer1.SplitterDistance = 287;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel1.Size = new Size(287, 198);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCompletedWorks);
            panel2.Controls.Add(label14);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 192);
            panel2.TabIndex = 0;
            // 
            // dgvCompletedWorks
            // 
            dgvCompletedWorks.AllowUserToAddRows = false;
            dgvCompletedWorks.AllowUserToDeleteRows = false;
            dgvCompletedWorks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompletedWorks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCompletedWorks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompletedWorks.Location = new Point(0, 38);
            dgvCompletedWorks.Name = "dgvCompletedWorks";
            dgvCompletedWorks.ReadOnly = true;
            dgvCompletedWorks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompletedWorks.Size = new Size(281, 151);
            dgvCompletedWorks.TabIndex = 0;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.Location = new Point(3, 6);
            label14.Name = "label14";
            label14.Size = new Size(274, 29);
            label14.TabIndex = 19;
            label14.Text = "Работы";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(267, 198);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvUsedUpMaterial);
            panel3.Controls.Add(label15);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 192);
            panel3.TabIndex = 0;
            // 
            // dgvUsedUpMaterial
            // 
            dgvUsedUpMaterial.AllowUserToAddRows = false;
            dgvUsedUpMaterial.AllowUserToDeleteRows = false;
            dgvUsedUpMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsedUpMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsedUpMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsedUpMaterial.Location = new Point(0, 38);
            dgvUsedUpMaterial.Name = "dgvUsedUpMaterial";
            dgvUsedUpMaterial.ReadOnly = true;
            dgvUsedUpMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsedUpMaterial.Size = new Size(261, 151);
            dgvUsedUpMaterial.TabIndex = 21;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.Location = new Point(3, 6);
            label15.Name = "label15";
            label15.Size = new Size(255, 29);
            label15.TabIndex = 20;
            label15.Text = "Материалы";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(TbRegisterNumberInfo);
            groupBox2.Controls.Add(btnChangeVechicle);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(CmbModelCarInfo);
            groupBox2.Controls.Add(CmbBrandCarInfo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(6, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(564, 138);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Автомобиль";
            // 
            // TbRegisterNumberInfo
            // 
            TbRegisterNumberInfo.Location = new Point(84, 98);
            TbRegisterNumberInfo.Mask = "L 000 LL 00";
            TbRegisterNumberInfo.Name = "TbRegisterNumberInfo";
            TbRegisterNumberInfo.Size = new Size(120, 29);
            TbRegisterNumberInfo.TabIndex = 35;
            TbRegisterNumberInfo.Text = "А000АА00";
            // 
            // btnChangeVechicle
            // 
            btnChangeVechicle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChangeVechicle.Location = new Point(458, 95);
            btnChangeVechicle.Name = "btnChangeVechicle";
            btnChangeVechicle.Size = new Size(99, 34);
            btnChangeVechicle.TabIndex = 20;
            btnChangeVechicle.Text = "Изменить";
            btnChangeVechicle.UseVisualStyleBackColor = true;
            btnChangeVechicle.Click += BtnChangeVechicle_Click;
            // 
            // label13
            // 
            label13.Location = new Point(6, 98);
            label13.Name = "label13";
            label13.Size = new Size(74, 29);
            label13.TabIndex = 18;
            label13.Text = "Гос. №";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CmbModelCarInfo
            // 
            CmbModelCarInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbModelCarInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbModelCarInfo.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbModelCarInfo.FormattingEnabled = true;
            CmbModelCarInfo.Location = new Point(84, 60);
            CmbModelCarInfo.Name = "CmbModelCarInfo";
            CmbModelCarInfo.Size = new Size(474, 29);
            CmbModelCarInfo.TabIndex = 14;
            // 
            // CmbBrandCarInfo
            // 
            CmbBrandCarInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbBrandCarInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbBrandCarInfo.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbBrandCarInfo.FormattingEnabled = true;
            CmbBrandCarInfo.Location = new Point(84, 25);
            CmbBrandCarInfo.Name = "CmbBrandCarInfo";
            CmbBrandCarInfo.Size = new Size(474, 29);
            CmbBrandCarInfo.TabIndex = 15;
            CmbBrandCarInfo.SelectedIndexChanged += CmbBrandCarInfo_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Location = new Point(7, 25);
            label11.Name = "label11";
            label11.Size = new Size(74, 29);
            label11.TabIndex = 12;
            label11.Text = "Марка";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Location = new Point(7, 60);
            label12.Name = "label12";
            label12.Size = new Size(74, 29);
            label12.TabIndex = 13;
            label12.Text = "Модель";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(TbCustomerPhoneInfo);
            groupBox1.Controls.Add(BtnChangeCustomerOrderInfo);
            groupBox1.Controls.Add(TbCustomerNameInfo);
            groupBox1.Controls.Add(TbCustomerAdditionalInfo);
            groupBox1.Controls.Add(TbCustomerEmailInfo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Клиент";
            // 
            // TbCustomerPhoneInfo
            // 
            TbCustomerPhoneInfo.Location = new Point(87, 66);
            TbCustomerPhoneInfo.Mask = "+7 (999) 000-00-00";
            TbCustomerPhoneInfo.Name = "TbCustomerPhoneInfo";
            TbCustomerPhoneInfo.Size = new Size(168, 29);
            TbCustomerPhoneInfo.TabIndex = 22;
            // 
            // BtnChangeCustomerOrderInfo
            // 
            BtnChangeCustomerOrderInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChangeCustomerOrderInfo.Location = new Point(458, 128);
            BtnChangeCustomerOrderInfo.Name = "BtnChangeCustomerOrderInfo";
            BtnChangeCustomerOrderInfo.Size = new Size(99, 34);
            BtnChangeCustomerOrderInfo.TabIndex = 21;
            BtnChangeCustomerOrderInfo.Text = "Изменить";
            BtnChangeCustomerOrderInfo.UseVisualStyleBackColor = true;
            BtnChangeCustomerOrderInfo.Click += BtnChangeCustomerOrderInfo_Click;
            // 
            // TbCustomerNameInfo
            // 
            TbCustomerNameInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbCustomerNameInfo.Location = new Point(87, 29);
            TbCustomerNameInfo.Name = "TbCustomerNameInfo";
            TbCustomerNameInfo.PlaceholderText = "Фамилия Имя Отчество";
            TbCustomerNameInfo.Size = new Size(470, 29);
            TbCustomerNameInfo.TabIndex = 20;
            // 
            // TbCustomerAdditionalInfo
            // 
            TbCustomerAdditionalInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TbCustomerAdditionalInfo.Location = new Point(151, 105);
            TbCustomerAdditionalInfo.Name = "TbCustomerAdditionalInfo";
            TbCustomerAdditionalInfo.Size = new Size(292, 51);
            TbCustomerAdditionalInfo.TabIndex = 19;
            TbCustomerAdditionalInfo.Text = "";
            // 
            // TbCustomerEmailInfo
            // 
            TbCustomerEmailInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbCustomerEmailInfo.Location = new Point(325, 64);
            TbCustomerEmailInfo.Name = "TbCustomerEmailInfo";
            TbCustomerEmailInfo.PlaceholderText = "Email";
            TbCustomerEmailInfo.Size = new Size(233, 29);
            TbCustomerEmailInfo.TabIndex = 18;
            // 
            // label10
            // 
            label10.Location = new Point(6, 98);
            label10.Name = "label10";
            label10.Size = new Size(132, 46);
            label10.TabIndex = 16;
            label10.Text = "Дополнительная информация";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(273, 64);
            label9.Name = "label9";
            label9.Size = new Size(74, 29);
            label9.TabIndex = 15;
            label9.Text = "Email";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(7, 64);
            label8.Name = "label8";
            label8.Size = new Size(74, 29);
            label8.TabIndex = 14;
            label8.Text = "Телефон";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(7, 28);
            label7.Name = "label7";
            label7.Size = new Size(74, 29);
            label7.TabIndex = 12;
            label7.Text = "ФИО";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(15, 819);
            label6.Name = "label6";
            label6.Size = new Size(135, 29);
            label6.TabIndex = 41;
            label6.Text = "Дата посещения";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tpCar
            // 
            tpCar.Controls.Add(CmbPymentMethodAdd);
            tpCar.Controls.Add(label18);
            tpCar.Controls.Add(BtnClearFormAdd);
            tpCar.Controls.Add(button4);
            tpCar.Controls.Add(label17);
            tpCar.Controls.Add(dtpDateOrder);
            tpCar.Controls.Add(groupBox7);
            tpCar.Controls.Add(groupBox8);
            tpCar.Location = new Point(4, 24);
            tpCar.Name = "tpCar";
            tpCar.Padding = new Padding(3);
            tpCar.Size = new Size(573, 975);
            tpCar.TabIndex = 1;
            tpCar.Text = "Добавить";
            tpCar.UseVisualStyleBackColor = true;
            // 
            // CmbPymentMethodAdd
            // 
            CmbPymentMethodAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbPymentMethodAdd.AutoCompleteMode = AutoCompleteMode.Suggest;
            CmbPymentMethodAdd.FormattingEnabled = true;
            CmbPymentMethodAdd.Location = new Point(488, 322);
            CmbPymentMethodAdd.Name = "CmbPymentMethodAdd";
            CmbPymentMethodAdd.Size = new Size(73, 29);
            CmbPymentMethodAdd.TabIndex = 33;
            // 
            // label18
            // 
            label18.Location = new Point(329, 322);
            label18.Name = "label18";
            label18.Size = new Size(121, 29);
            label18.TabIndex = 32;
            label18.Text = "Способ оплаты";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnClearFormAdd
            // 
            BtnClearFormAdd.Location = new Point(3, 363);
            BtnClearFormAdd.Name = "BtnClearFormAdd";
            BtnClearFormAdd.Size = new Size(128, 64);
            BtnClearFormAdd.TabIndex = 30;
            BtnClearFormAdd.Text = "Очистить";
            BtnClearFormAdd.UseVisualStyleBackColor = true;
            BtnClearFormAdd.Click += BtnClearFormAdd_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(439, 363);
            button4.Name = "button4";
            button4.Size = new Size(128, 64);
            button4.TabIndex = 29;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BtnAddOrder_Click;
            // 
            // label17
            // 
            label17.Location = new Point(6, 322);
            label17.Name = "label17";
            label17.Size = new Size(145, 29);
            label17.TabIndex = 20;
            label17.Text = "Дата посещения";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDateOrder
            // 
            dtpDateOrder.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDateOrder.Format = DateTimePickerFormat.Custom;
            dtpDateOrder.Location = new Point(157, 322);
            dtpDateOrder.Name = "dtpDateOrder";
            dtpDateOrder.Size = new Size(159, 29);
            dtpDateOrder.TabIndex = 28;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox7.BackColor = SystemColors.ActiveCaption;
            groupBox7.Controls.Add(TbRegisterNumber);
            groupBox7.Controls.Add(label20);
            groupBox7.Controls.Add(cmbModelCarAdd);
            groupBox7.Controls.Add(CmbBrandCarAdd);
            groupBox7.Controls.Add(label21);
            groupBox7.Controls.Add(label22);
            groupBox7.Location = new Point(6, 171);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(561, 138);
            groupBox7.TabIndex = 26;
            groupBox7.TabStop = false;
            groupBox7.Text = "Автомобиль";
            // 
            // TbRegisterNumber
            // 
            TbRegisterNumber.Location = new Point(84, 99);
            TbRegisterNumber.Mask = "L 000 LL 00";
            TbRegisterNumber.Name = "TbRegisterNumber";
            TbRegisterNumber.Size = new Size(120, 29);
            TbRegisterNumber.TabIndex = 34;
            TbRegisterNumber.Text = "А000АА00";
            TbRegisterNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TbRegisterNumber.Enter += TbRegisterNumber_Enter;
            // 
            // label20
            // 
            label20.Location = new Point(6, 98);
            label20.Name = "label20";
            label20.Size = new Size(74, 29);
            label20.TabIndex = 18;
            label20.Text = "Гос. №";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbModelCarAdd
            // 
            cmbModelCarAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbModelCarAdd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbModelCarAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbModelCarAdd.FormattingEnabled = true;
            cmbModelCarAdd.Location = new Point(84, 60);
            cmbModelCarAdd.Name = "cmbModelCarAdd";
            cmbModelCarAdd.Size = new Size(471, 29);
            cmbModelCarAdd.TabIndex = 14;
            // 
            // CmbBrandCarAdd
            // 
            CmbBrandCarAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbBrandCarAdd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbBrandCarAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbBrandCarAdd.FormattingEnabled = true;
            CmbBrandCarAdd.Location = new Point(84, 25);
            CmbBrandCarAdd.Name = "CmbBrandCarAdd";
            CmbBrandCarAdd.Size = new Size(471, 29);
            CmbBrandCarAdd.TabIndex = 15;
            CmbBrandCarAdd.SelectedIndexChanged += CmbBrandCars_SelectedIndexChanged;
            // 
            // label21
            // 
            label21.Location = new Point(7, 25);
            label21.Name = "label21";
            label21.Size = new Size(74, 29);
            label21.TabIndex = 12;
            label21.Text = "Марка";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.Location = new Point(7, 60);
            label22.Name = "label22";
            label22.Size = new Size(74, 29);
            label22.TabIndex = 13;
            label22.Text = "Модель";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox8.BackColor = Color.LightGray;
            groupBox8.Controls.Add(TbPhoneCustomer);
            groupBox8.Controls.Add(TbAdditionalInformationCustomer);
            groupBox8.Controls.Add(TbEmailCustomer);
            groupBox8.Controls.Add(label23);
            groupBox8.Controls.Add(label24);
            groupBox8.Controls.Add(label25);
            groupBox8.Controls.Add(CmbNameCustomer);
            groupBox8.Controls.Add(label26);
            groupBox8.Location = new Point(6, 6);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(561, 159);
            groupBox8.TabIndex = 25;
            groupBox8.TabStop = false;
            groupBox8.Text = "Клиент";
            // 
            // TbPhoneCustomer
            // 
            TbPhoneCustomer.Location = new Point(87, 66);
            TbPhoneCustomer.Mask = "+7 (999) 000-00-00";
            TbPhoneCustomer.Name = "TbPhoneCustomer";
            TbPhoneCustomer.Size = new Size(167, 29);
            TbPhoneCustomer.TabIndex = 20;
            // 
            // TbAdditionalInformationCustomer
            // 
            TbAdditionalInformationCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TbAdditionalInformationCustomer.Location = new Point(151, 105);
            TbAdditionalInformationCustomer.Name = "TbAdditionalInformationCustomer";
            TbAdditionalInformationCustomer.Size = new Size(404, 48);
            TbAdditionalInformationCustomer.TabIndex = 19;
            TbAdditionalInformationCustomer.Text = "";
            // 
            // TbEmailCustomer
            // 
            TbEmailCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbEmailCustomer.Location = new Point(316, 64);
            TbEmailCustomer.Name = "TbEmailCustomer";
            TbEmailCustomer.PlaceholderText = "Email";
            TbEmailCustomer.Size = new Size(239, 29);
            TbEmailCustomer.TabIndex = 18;
            // 
            // label23
            // 
            label23.Location = new Point(6, 98);
            label23.Name = "label23";
            label23.Size = new Size(132, 46);
            label23.TabIndex = 16;
            label23.Text = "Дополнительная информация";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.Location = new Point(260, 64);
            label24.Name = "label24";
            label24.Size = new Size(74, 29);
            label24.TabIndex = 15;
            label24.Text = "Email";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.Location = new Point(7, 64);
            label25.Name = "label25";
            label25.Size = new Size(74, 29);
            label25.TabIndex = 14;
            label25.Text = "Телефон";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CmbNameCustomer
            // 
            CmbNameCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbNameCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbNameCustomer.FormattingEnabled = true;
            CmbNameCustomer.Location = new Point(87, 29);
            CmbNameCustomer.Name = "CmbNameCustomer";
            CmbNameCustomer.Size = new Size(468, 29);
            CmbNameCustomer.TabIndex = 13;
            // 
            // label26
            // 
            label26.Location = new Point(7, 28);
            label26.Name = "label26";
            label26.Size = new Size(74, 29);
            label26.TabIndex = 12;
            label26.Text = "ФИО";
            label26.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1305, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, настройкиПодключенияКСерверуToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(77, 29);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(390, 30);
            справочникиToolStripMenuItem.Text = "Справочники";
            справочникиToolStripMenuItem.Click += СправочникиToolStripMenuItem_Click;
            // 
            // настройкиПодключенияКСерверуToolStripMenuItem
            // 
            настройкиПодключенияКСерверуToolStripMenuItem.Name = "настройкиПодключенияКСерверуToolStripMenuItem";
            настройкиПодключенияКСерверуToolStripMenuItem.Size = new Size(390, 30);
            настройкиПодключенияКСерверуToolStripMenuItem.Text = "Настройки подключения к серверу";
            настройкиПодключенияКСерверуToolStripMenuItem.Click += НастройкиПодключенияКСерверуToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusInfo, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 1031);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1305, 30);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusInfo
            // 
            lblStatusInfo.Name = "lblStatusInfo";
            lblStatusInfo.Size = new Size(0, 25);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(52, 25);
            toolStripStatusLabel2.Text = "        ";
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 1061);
            Controls.Add(statusStrip1);
            Controls.Add(scBase);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автокультура 59";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            cmsDgvOrders.ResumeLayout(false);
            scBase.Panel1.ResumeLayout(false);
            scBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scBase).EndInit();
            scBase.ResumeLayout(false);
            skSerchOrder.Panel1.ResumeLayout(false);
            skSerchOrder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)skSerchOrder).EndInit();
            skSerchOrder.ResumeLayout(false);
            gbFilter.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcDetailsOrder.ResumeLayout(false);
            tpOrder.ResumeLayout(false);
            tpOrder.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSpecialist).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompletedWorks).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsedUpMaterial).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tpCar.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private SplitContainer scBase;
        private TabControl tcDetailsOrder;
        private TabPage tpOrder;
        private TabPage tpCar;
        private SplitContainer skSerchOrder;
        private GroupBox gbFilter;
        private Label lbl35;
        private Label label1;
        private Label label4;
        private ComboBox CmbBrandCarFiltr;
        private Label label3;
        private ComboBox CmbModelCarFiltr;
        private Panel panel1;
        private Button BtnClearFiltr;
        private Button BtnSerch;
        private ComboBox CmbCustomerFiltr;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private RichTextBox TbCustomerAdditionalInfo;
        private TextBox TbCustomerEmailInfo;
        private Label label10;
        private Label label9;
        private StatusStrip statusStrip1;
        private GroupBox groupBox2;
        private ToolStripStatusLabel lblStatusInfo;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label label13;
        private ComboBox CmbModelCarInfo;
        private ComboBox CmbBrandCarInfo;
        private Label label11;
        private Label label12;
        private DataGridView dgvCompletedWorks;
        private GroupBox groupBox3;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label14;
        private DataGridView dgvUsedUpMaterial;
        private Label label15;
        private DataGridView dgvSpecialist;
        private ComboBox CmbPymentMethodInfo;
        private Label label16;
        private GroupBox groupBox7;
        private Label label20;
        private ComboBox cmbModelCarAdd;
        private ComboBox CmbBrandCarAdd;
        private Label label21;
        private Label label22;
        private GroupBox groupBox8;
        private RichTextBox TbAdditionalInformationCustomer;
        private TextBox TbEmailCustomer;
        private Label label23;
        private Label label24;
        private Label label25;
        private ComboBox CmbNameCustomer;
        private Label label26;
        private ComboBox CmbStatusFiltr;
        private Label label43;
        private Label label29;
        private TextBox TbPriceOrderInfo;
        private Label label30;
        private DateTimePicker dtpDateOrder;
        private DateTimePicker dtpFiltrWith;
        private Label label17;
        private Button BtnClearFormAdd;
        private Button button4;
        private ComboBox CmbPymentMethodAdd;
        private Label label18;
        private Button BtnAddServiceType;
        private Button BtnChangeOrder;
        private Panel panel2;
        private Panel panel3;
        private Label label19;
        private DateTimePicker DtpDeliveryOfTheOrder;
        private Label label27;
        private TextBox TbCustomerNameInfo;
        private Button btnChangeVechicle;
        private Button BtnChangeCustomerOrderInfo;
        private DateTimePicker dtpDateOrderInfo;
        private Label label6;
        private Button btnCreateOrderAnOutfit;
        private ToolStripMenuItem настройкиПодключенияКСерверуToolStripMenuItem;
        private MaskedTextBox TbPhoneCustomer;
        private MaskedTextBox TbCustomerPhoneInfo;
        private MaskedTextBox TbRegisterNumber;
        private MaskedTextBox TbRegisterNumberInfo;
        private MaskedTextBox TbRegisterNumberFiltr;
        private Label label2;
        private ContextMenuStrip cmsDgvOrders;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private DateTimePicker dtpFiltrOn;
    }
}
