﻿using AnalysisOfTheFaceComparisonAlgorithm;
using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using System.Configuration;
using AutoKultura.DataAccess.SqlServer.View;
using AutoKultura.DataAccess.SqlServer.Filter.Order;
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace AutoKultura
{
    public partial class StartFormDesign : Form
    {
        readonly ButtonGlow menuButton = new();
        readonly ButtonGlow filtrButton = new();
        readonly ButtonGlow InfoOrderButton = new();
        AutoKulturaDbContext? _dbContext;
        Guid _currentRenderServiceId;

        private Guid _currentOrderId;
        private List<ViewOrders> _listDataSource = [];
        public StartFormDesign()
        {
            InitializeComponent();
            menuButton.AddButton(btnSettingConnect, btnDictionary, btnNewCustomer, btnInfoOrder);
            filtrButton.AddButton(BtnSerch, btnClearFiltr);
            InfoOrderButton.AddButton(btnChangeVechicle, BtnAddServiceType, BtnChangeCustomerOrderInfo, BtnChangeOrder, btnCreateOrderAnOutfit, btnClearNewCustomer, btnAddNewCustomer);
            SettingsConnect settigsConnectForm = new();
            if (!SettingsConnect.CheckedConnectionSQLServer(ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString))
            {
                if (settigsConnectForm.ShowDialog() == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
            FillPanelOrderToday();
        }

        private Label LabelForTodayOrders
        {
            get
            {
                LinkLabel result = new()
                {
                    Dock = DockStyle.Top,
                    ForeColor = Color.White,
                    AutoSize = false,
                    BackColor = Color.FromArgb(29, 32, 37),
                    LinkColor = Color.FromArgb(150, 150, 150),
                    DisabledLinkColor = Color.FromArgb(150, 150, 150),
                    ActiveLinkColor = Color.White,
                    VisitedLinkColor = Color.White,
                    Height = 70,
                    Width = panelOrderToday.Width - 3,
                    BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                    Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204),
                    Padding = new Padding(5, 5, 5, 5),
                    TextAlign = ContentAlignment.MiddleLeft,
                    LinkBehavior = LinkBehavior.HoverUnderline                    
                };
                result.LinkClicked += LinkLabel_LinkClicked;

                return result;
            }
        }
        private void LinkLabel_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel? current = (LinkLabel?)sender;
            current.LinkVisited = true;
            if (current.Tag is ViewOrders orderSelect)
            {
                int selectedRowIndex = _listDataSource.IndexOf(orderSelect);
                dgvOrders.ClearSelection();
                dgvOrders.Rows[selectedRowIndex].Selected = true;
            }

            foreach (var item in current.Parent.Controls)
            {
                if (item is LinkLabel lbl && item != current)
                {
                    lbl.LinkVisited = false;
                }
            }
            btnInfoOrder.PerformClick();
        }
        private void FillPanelOrderToday()
        {
            panelOrderToday.Controls.Clear();
            panelOrderToday.Controls.Add(new Label()
            {
                Text = "Заказы на сегодня:",
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204),
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                AutoSize = false,
                Size = new Size(206,36)
            });
            var ordersToday = _listDataSource.Where(o => o.DateOrder > DateTime.Now.Date 
                                                    & o.DateOrder < DateTime.Now.Date.AddDays(1)
                                                    & o.DateOfDeliveryOfTheOrder == DateTime.MinValue);

            foreach (ViewOrders order in ordersToday)
            {
                Label lbl = LabelForTodayOrders;
                lbl.Tag = order;
                lbl.Text = $"{order.DateOrder.ToShortDateString()} {order.DateOrder.ToShortTimeString()}\n{order.NameCustomer}\n{order.NameBrandCar} {order.NameModelCar}";

                panelOrderToday.Controls.Add(lbl);
            }


        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FillingCmbBrandCar();
            await FillingCmbPymentMethod();
            await FillingCmbCustomer();

            BtnClearFiltr_Click(new(), new EventArgs());
            btnInfoOrder.PerformClick();
        }
        private async void FillingCmbBrandCar()
        {
            using AutoKulturaDbContext dbContext = new();

            BrandCarRepository brandCarRep = new(dbContext);
            var listBrandCarsInfo = await brandCarRep.Get();
            var listBrandCarsAdd = await brandCarRep.Get();
            var listBrandCarsFiltr = await brandCarRep.Get();

            CmbBrandCarAdd.DataSource = null;
            CmbBrandCarAdd.DataSource = listBrandCarsAdd;
            CmbBrandCarAdd.DisplayMember = "Name";
            CmbBrandCarAdd.ValueMember = "Id";

            CmbBrandCarInfo.DataSource = null;
            CmbBrandCarInfo.DataSource = listBrandCarsInfo;
            CmbBrandCarInfo.DisplayMember = "Name";
            CmbBrandCarInfo.ValueMember = "Id";

            CmbBrandCarFiltr.DataSource = null;
            CmbBrandCarFiltr.DataSource = listBrandCarsFiltr;
            CmbBrandCarFiltr.DisplayMember = "Name";
            CmbBrandCarFiltr.ValueMember = "Id";
        }
        private async Task FillingCmbCustomer()
        {
            using AutoKulturaDbContext dbContext = new();

            CustomerRepository CustomerRep = new(dbContext);
            var listCustomer = await CustomerRep.Get();

            CmbCustomerFiltr.DataSource = listCustomer;
            CmbCustomerFiltr.DisplayMember = "Name";
            CmbCustomerFiltr.ValueMember = "Id";
        }

        private async Task FillingCmbPymentMethod()
        {
            using AutoKulturaDbContext dbContext = new();

            PymentMethodRepository pymentMethodRepository = new(dbContext);
            var listPymentMethodInfo = await pymentMethodRepository.Get();
            var listPymentMethodAdd = await pymentMethodRepository.Get();
            if (listPymentMethodInfo.Count > 0)
            {
                CmbPymentMethodInfo.DataSource = null;
                CmbPymentMethodInfo.DataSource = listPymentMethodInfo;
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                PymentMethodEntity defaultMethod = listPymentMethodInfo.FirstOrDefault(itm => itm.MethodDefault == true);
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                CmbPymentMethodInfo.DisplayMember = "Name";
                CmbPymentMethodInfo.ValueMember = "Id";
                CmbPymentMethodInfo.SelectedItem = defaultMethod;

                CmbPymentMethodAdd.DataSource = null;
                CmbPymentMethodAdd.DataSource = listPymentMethodAdd;
                CmbPymentMethodAdd.DisplayMember = "Name";
                CmbPymentMethodAdd.ValueMember = "Id";
                CmbPymentMethodAdd.SelectedItem = defaultMethod;
            }
        }

        private async Task ReadDataOrders()
        {
            using AutoKulturaDbContext dbContext = new();

            OrdersRepository orders = new(dbContext);

            int selectedRowIndex = -1;
            if (_currentOrderId != Guid.Empty && dgvOrders.SelectedRows.Count > 0)
                selectedRowIndex = dgvOrders.Rows.IndexOf(dgvOrders.SelectedRows[0]);
            _listDataSource = await orders.GetViewOrders();
            dgvOrders.DataSource = _listDataSource;
            dgvOrders.Columns["Id"].Visible = false;

            if (selectedRowIndex != -1)
            {
                dgvOrders.ClearSelection();
                dgvOrders.Rows[selectedRowIndex].Selected = true;
            }

            if (_listDataSource.Count > 0)
                FillPanelOrderToday();
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimazeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnStreach_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private async void BtnClearFiltr_Click(object sender, EventArgs e)
        {
            CmbModelCarFiltr.Text = "";
            CmbBrandCarFiltr.Text = "";
            CmbCustomerFiltr.Text = "";
            CmbStatusFiltr.Text = "";
            TbRegisterNumberFiltr.Text = "";
            dtpFiltrWith.Checked = false;
            dtpFiltrOn.Checked = false;
            await ReadDataOrders();
        }

        private void BtnSerch_Click(object sender, EventArgs e)
        {
            List<Specification<ViewOrders>> findFieldFiltr = [];
            if (_listDataSource.Count < 1) return;

            if (CmbCustomerFiltr.Text != "")
            {
                CustomerSpecification customerSpec = new(CmbCustomerFiltr.Text);
                findFieldFiltr.Add(customerSpec);
            }
            if (CmbBrandCarFiltr.Text != "")
            {
                BrandCarSpecification brandCarSpec = new(CmbBrandCarFiltr.Text);
                findFieldFiltr.Add(brandCarSpec);
            }

            if (CmbModelCarFiltr.Text != "")
            {
                ModelCarSpecification modelCarSpec = new(CmbModelCarFiltr.Text);
                findFieldFiltr.Add(modelCarSpec);
            }

            if (CmbStatusFiltr.Text != "")
            {
                StatusOrderSpecification statusOrderSpec = new(CmbStatusFiltr.Text);
                findFieldFiltr.Add(statusOrderSpec);
            }

            if (TbRegisterNumberFiltr.Text != "         ")
            {
                RegisterNumberSpecification registerNumberSpec = new(TbRegisterNumberFiltr.Text);
                findFieldFiltr.Add(registerNumberSpec);
            }

            if (dtpFiltrOn.Checked)
            {
                DateOrderSpecification dateOnSpec = new(dtpFiltrOn.Value, -1);
                findFieldFiltr.Add(dateOnSpec);
            }

            if (dtpFiltrWith.Checked)
            {
                DateOrderSpecification dateWithSpec = new(dtpFiltrWith.Value, 1);
                findFieldFiltr.Add(dateWithSpec);
            }

            AndSpecification<ViewOrders> andSpecification = new([.. findFieldFiltr]);
            OrdersFilter orderFilter = new();
            var result = orderFilter.Filter(_listDataSource, andSpecification).ToList();
            dgvOrders.DataSource = result;
        }

        private async void DgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count < 1) return;

            _currentOrderId = (Guid)dgvOrders.SelectedRows[0].Cells["Id"].Value;

            using (_dbContext = new AutoKulturaDbContext())
            {
                CustomerRepository customer = new(_dbContext);
                CustomerEntity current = await customer.GetByOrderId(_currentOrderId);
                TbCustomerNameInfo.Text = current.Name;
                TbCustomerPhoneInfo.Text = current.Phone;
                TbCustomerEmailInfo.Text = current.Email;
                TbCustomerAdditionalInfo.Text = current.AdditionalInformation;
            }

            using (_dbContext = new AutoKulturaDbContext())
            {
                VechicleRepository VechicleRepository = new(_dbContext);
                ViewVechicleForOrder vichicle = await VechicleRepository.GetByOrderId(_currentOrderId);
                if (CmbBrandCarInfo.DataSource is List<BrandCarEntity> listbrand)
                {
                    CmbBrandCarInfo.SelectedIndex = listbrand.FindIndex(itm => itm.Id == vichicle.BrandCar?.Id);
                    if (CmbModelCarInfo.DataSource is List<ModelCarEntity> listmodel)
                        CmbModelCarInfo.SelectedIndex = listmodel.FindIndex(itm => itm.Id == vichicle.Model?.Id);
                }
                TbRegisterNumberInfo.Text = vichicle.RegisterNumber;
            }

            using (_dbContext = new AutoKulturaDbContext())
            {
                OrdersRepository orderRepository = new(_dbContext);
                OrderEntity order = await orderRepository.GetById(_currentOrderId);
                if (CmbPymentMethodInfo.DataSource is List<PymentMethodEntity> listPymentMethod)
                    if (order.PymentMethodId != Guid.Empty)
                        CmbPymentMethodInfo.SelectedIndex = listPymentMethod.FindIndex(itm => itm.Id == order.PymentMethodId);
                    else
                        CmbPymentMethodInfo.SelectedIndex = listPymentMethod.FindIndex(itm => itm.MethodDefault);


                TbPriceOrderInfo.Text = order.Price.ToString();

                dtpDateOrderInfo.Value = order.DateOrder;
                if (order.DateOfDeliveryOfTheOrder.Year > 1)
                    DtpDeliveryOfTheOrder.Value = order.DateOfDeliveryOfTheOrder;
                else
                    DtpDeliveryOfTheOrder.Value = dtpDateOrderInfo.Value;
            }

            using (AutoKulturaDbContext dbContext = new())
            {

                RenderServiceRepository renderService = new(dbContext);

                int selectedRowIndex = -1;
                if (dgvCompletedWorks.SelectedRows.Count > 0)
                    selectedRowIndex = dgvCompletedWorks.Rows.IndexOf(dgvCompletedWorks.SelectedRows[0]);

                var result = await renderService.GetByIdOrder(_currentOrderId);
                dgvCompletedWorks.DataSource = result;
                dgvCompletedWorks.Columns["Id"].Visible = false;
                dgvCompletedWorks.Columns["IdOrder"].Visible = false;

            }

            if (dgvCompletedWorks.SelectedRows.Count > 0)
            {
                _currentRenderServiceId = (Guid)dgvCompletedWorks.SelectedRows[0].Cells["Id"].Value;

                decimal priceWork = 0;

                using (AutoKulturaDbContext dbContext = new())
                {
                    UsedUpMaterialRepository usedUpMaterialRepository = new(dbContext);
                    List<ViewUsedUpMaterial> result = await usedUpMaterialRepository.GetByIdRenderServices(_currentRenderServiceId);

                    foreach (DataGridViewRow row in dgvCompletedWorks.Rows)
                    {
                        priceWork += Convert.ToDecimal(row.Cells["Price"].Value);

                        if (((Guid)row.Cells["Id"].Value) != _currentRenderServiceId)
                        {
                            using AutoKulturaDbContext dbContext2 = new();
                            UsedUpMaterialRepository fullmaterial = new(dbContext2);

                            List<ViewUsedUpMaterial> buf = await fullmaterial.GetByIdRenderServices((Guid)row.Cells["Id"].Value);
                            foreach (ViewUsedUpMaterial viewUsedMaterial in buf)
                            {
                                if (result.FirstOrDefault(itm => itm.IdUsedUpMaterial == viewUsedMaterial.IdUsedUpMaterial) == null)
                                {
                                    result.Add(viewUsedMaterial);
                                }
                            }
                        }
                    }
                    TbPriceOrderInfo.Text = priceWork.ToString();
                    dgvUsedUpMaterial.DataSource = result;
                    dgvUsedUpMaterial.Columns["IdUsedUpMaterial"].Visible = false;
                }



                using (AutoKulturaDbContext dbContext = new())
                {
                    LinqSpecialistForRenderServiceslRepository specialistExecutingWork = new(dbContext);


                    List<SpecialistEntity> result;
                    result = await specialistExecutingWork.GetSpecialistByIdRenderServices(_currentRenderServiceId);
                    foreach (DataGridViewRow row in dgvCompletedWorks.Rows)
                    {
                        if (((Guid)row.Cells["Id"].Value) != _currentRenderServiceId)
                        {
                            using AutoKulturaDbContext dbContext2 = new();
                            LinqSpecialistForRenderServiceslRepository specialist = new(dbContext2);

                            List<SpecialistEntity> buf = await specialistExecutingWork.GetSpecialistByIdRenderServices((Guid)row.Cells["Id"].Value);
                            foreach (SpecialistEntity spec in buf)
                            {
                                if (result.FirstOrDefault(itm => itm.Id == spec.Id) == null)
                                {
                                    result.Add(spec);
                                }
                            }
                        }
                    }

                    dgvSpecialist.DataSource = result;
                    dgvSpecialist.Columns["Id"].Visible = false;
                }
            }
            else
            {
                dgvSpecialist.DataSource = null;
                dgvUsedUpMaterial.DataSource = null;
            }


        }

        private void CmbBrandCarFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBrandCarFiltr.SelectedItem is BrandCarEntity brandCar)
                using (AutoKulturaDbContext dbContext = new())
                {
                    ModelCarRepository modelCarRepository = new(dbContext);
                    CmbModelCarFiltr.DataSource = null;
                    CmbModelCarFiltr.DataSource = modelCarRepository.GetByIdBrandCar(brandCar.Id);
                    CmbModelCarFiltr.DisplayMember = "Name";
                    CmbModelCarFiltr.ValueMember = "Id";
                    CmbModelCarFiltr.Text = "";
                }
        }

        private void CmbBrandCarInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBrandCarInfo.SelectedItem is BrandCarEntity brandCar)
                using (AutoKulturaDbContext dbContext = new())
                {
                    ModelCarRepository modelCarRepository = new(dbContext);
                    CmbModelCarInfo.DataSource = null;
                    CmbModelCarInfo.DataSource = modelCarRepository.GetByIdBrandCar(brandCar.Id);
                    CmbModelCarInfo.DisplayMember = "Name";
                    CmbModelCarInfo.ValueMember = "Id";
                }
        }

        private async void BtnChangeCustomerOrderInfo_Click(object sender, EventArgs e)
        {
            try
            {
                using (_dbContext = new AutoKulturaDbContext())
                {
                    CustomerRepository customerRepository = new(_dbContext);
                    CustomerEntity customer = await customerRepository.GetByOrderId(_currentOrderId);
                    int t = await customerRepository.Update(customer.Id, TbCustomerNameInfo.Text, TbCustomerPhoneInfo.Text, TbCustomerEmailInfo.Text, TbCustomerAdditionalInfo.Text);

                    if (t > 0)
                    {
                        new formMessage($"Клиент \"{customer.Name}\" изменен", "Изменение данных клиента", true).Show();
                        await ReadDataOrders();

                    }
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Изменение данных клиента", false).Show();
                }
            }
            catch (Exception ex) { new formMessage(ex.Message, "Изменение данных клиента").Show(); };
        }

        private void BtnSettingConnect_Click(object sender, EventArgs e)
        {
            SettingsConnect settigsConnectForm = new();
            settigsConnectForm.Show();
        }

        private async void BtnDictionary_Click(object sender, EventArgs e)
        {
            DictionaryForm df = new();
            df.ShowDialog();

            int selectedRowIndex = -1;
            if (_currentOrderId != Guid.Empty)
                selectedRowIndex = dgvOrders.Rows.IndexOf(dgvOrders.SelectedRows[0]);

            await ReadDataOrders();
            FillingCmbBrandCar();
            await FillingCmbPymentMethod();

            if (selectedRowIndex != -1)
                dgvOrders.Rows[selectedRowIndex].Selected = true;
        }

        private void BtnAddServiceType_Click(object sender, EventArgs e)
        {
            FormAddServicesAndMaterialOrder form = new(_currentOrderId);
            form.ShowDialog();
            DgvOrders_SelectionChanged(sender, e);
        }

        private static float MmToMeaningDocument(float value)
        {
            return value / 3.53f;
        }

        private async void BtnCreateOrderAnOutfit_Click(object sender, EventArgs e)
        {
            CompanyEntity company;
            using (AutoKulturaDbContext dbContext = new())
            {
                CompanyRepository cr = new(dbContext);

                var buf = await cr.Get();
                company = buf[0];

                await cr.Update(company.Id, company.Name, company.Phone, company.Email, company.Adress, company.NumberOrderOnOutfit + 1, company.PathToFilesOrderOnOutfit);
            }


            DocX documentOrderOnOutfit = DocX.Create(company.PathToFilesOrderOnOutfit + $"\\Заказ наряд для клиента {TbCustomerNameInfo.Text} машина {CmbBrandCarInfo.Text} {CmbModelCarInfo.Text}.docx");


            documentOrderOnOutfit.MarginTop = MmToMeaningDocument(125f);
            documentOrderOnOutfit.MarginLeft = MmToMeaningDocument(175f);
            documentOrderOnOutfit.MarginRight = MmToMeaningDocument(125f);
            documentOrderOnOutfit.MarginBottom = MmToMeaningDocument(125f);
            string pathToImagelabel = Application.StartupPath + $"\\ImageLabel.jpg";
            Xceed.Document.NET.Image imagelabel;
            if (File.Exists(pathToImagelabel))
                imagelabel = documentOrderOnOutfit.AddImage(pathToImagelabel);
            else
            {
                MessageBox.Show($"Не удалось найти изображение {pathToImagelabel}", "Ошибка");
                return;
            }
            Picture pic = imagelabel.CreatePicture();
            pic.Width = MmToMeaningDocument(1468f);
            pic.Height = MmToMeaningDocument(433f);
            Paragraph paragraphImage = documentOrderOnOutfit.InsertParagraph();
            paragraphImage.Alignment = Alignment.center;
            paragraphImage.AppendPicture(pic);


            documentOrderOnOutfit.InsertParagraph(company.Name).Font("Cambria").FontSize(16).Alignment = Alignment.right;

            string[] phonesCompany = company.Phone.Split('|');
            documentOrderOnOutfit.InsertParagraph($"{company.Adress}").Font("Cambria").FontSize(12).Alignment = Alignment.right;
            foreach (string phone in phonesCompany)
                documentOrderOnOutfit.InsertParagraph(phone).Font("Cambria").FontSize(12).Alignment = Alignment.right;

            Paragraph paragrapSite = documentOrderOnOutfit.InsertParagraph("www.avtokultura59.ru").Font("Cambria").FontSize(12);
            paragrapSite.Alignment = Alignment.center;
            paragrapSite.IndentationBefore = MmToMeaningDocument(800f);

            Paragraph paragrapEmail = documentOrderOnOutfit.InsertParagraph(company.Email).Font("Cambria").FontSize(12);
            paragrapEmail.Alignment = Alignment.center;
            paragrapEmail.IndentationBefore = MmToMeaningDocument(800f);

            documentOrderOnOutfit.InsertParagraph($"ЗАКАЗ НАРЯД №{company.NumberOrderOnOutfit}").Bold().FontSize(16);

            Paragraph paragrapCustomer = documentOrderOnOutfit.InsertParagraph("Заказчик ").Font("Cambria").FontSize(12);
            paragrapCustomer.Alignment = Alignment.left;
            paragrapCustomer.IndentationBefore = MmToMeaningDocument(600f);
            paragrapCustomer.Append(TbCustomerNameInfo.Text).UnderlineStyle(UnderlineStyle.singleLine).FontSize(14);

            Paragraph paragraphDataOrder = documentOrderOnOutfit.InsertParagraph($"Заказ принят ").Font("Cambria").FontSize(12);
            paragraphDataOrder.Append($"{dtpDateOrderInfo.Value.ToShortDateString()} в " +
                $"{dtpDateOrderInfo.Value:HH:mm}").Font("Cambria").UnderlineStyle(UnderlineStyle.singleLine).FontSize(12);
            paragraphDataOrder.Alignment = Alignment.left;
            paragraphDataOrder.IndentationBefore = MmToMeaningDocument(600f);

            Paragraph paragrapCar = documentOrderOnOutfit.InsertParagraph($"Автомобиль ").Font("Cambria").FontSize(12);
            paragrapCar.Append($"{CmbBrandCarInfo.Text} {CmbModelCarInfo.Text}").Font("Cambria").UnderlineStyle(UnderlineStyle.singleLine).FontSize(12);
            paragrapCar.Append($"  Гос. Номер: ").Font("Cambria").FontSize(12);
            paragrapCar.Append($"{TbRegisterNumberInfo.Text}").Font("Cambria").UnderlineStyle(UnderlineStyle.singleLine).FontSize(12);
            paragrapCar.Alignment = Alignment.left;
            paragrapCar.IndentationBefore = MmToMeaningDocument(600f);

            int rowCount = dgvCompletedWorks.Rows.Count;

            int deltaCountRow = 3;

            for (int i = 1; i < dgvCompletedWorks.Rows.Count; i++)
            {
                if (dgvCompletedWorks.Rows[i].Cells["NameServiceType"].Value.ToString() !=
                    dgvCompletedWorks.Rows[i - 1].Cells["NameServiceType"].Value.ToString())
                    deltaCountRow++;
            }

            Table tableRenderServices = documentOrderOnOutfit.AddTable(rowCount + deltaCountRow, 4);

            tableRenderServices.Alignment = Alignment.center;
            tableRenderServices.Design = TableDesign.TableGrid;

            tableRenderServices.Rows[0].Cells[0].Paragraphs[0].Append("№ п/п").FontSize(12).Bold();
            tableRenderServices.Rows[0].Cells[1].Paragraphs[0].Append("Услуги").FontSize(12).Bold();
            tableRenderServices.Rows[0].Cells[2].Paragraphs[0].Append("Материалы").FontSize(12).Bold();
            tableRenderServices.Rows[0].Cells[3].Paragraphs[0].Append("Сумма, руб.").FontSize(12).Bold();
            tableRenderServices.SetColumnWidth(0, 30);
            tableRenderServices.SetColumnWidth(1, 250);
            tableRenderServices.SetColumnWidth(2, 170);
            tableRenderServices.SetColumnWidth(3, 61);

            tableRenderServices.Rows[^1].MergeCells(0, 2);
            tableRenderServices.Rows[^1].Cells[0].Paragraphs[0].Append("Итого").FontSize(12).Bold();
            tableRenderServices.Rows[^1].Cells[1].Paragraphs[0].Append(TbPriceOrderInfo.Text).FontSize(12);




            using (AutoKulturaDbContext dbContext = new())
            {
#pragma warning disable IDE0305 // Упростите инициализацию коллекции
                List<RenderServiceEntity> renderServiceEntities = dbContext.RendersServices
                    .AsNoTracking()
                    .Where(rs => rs.OrderId == _currentOrderId)
                    .Include(rs => rs.PartOfTheCar)
                        .ThenInclude(pc => pc.ServiceType)
                    .Include(rs => rs.UsedUpMaterials)
                        .ThenInclude(m => m.Material)
                     .OrderBy(rs => rs.PartOfTheCar.ServiceType.Title)
                    .ToList();
#pragma warning restore IDE0305 // Упростите инициализацию коллекции
                int indexRowServiceType = 0;
                int countServiceType = 1;
                int indexStartMargeCels = 0;
                List<Guid> includeServiceTypeOrderAnOutfit = [];
                List<Guid> includeMaterialsOrderAnOutfit = [];

                string usedUpMaterialStr = "";
                foreach (RenderServiceEntity renderService in renderServiceEntities)
                {
                    if (!includeServiceTypeOrderAnOutfit.Contains(renderService.PartOfTheCar.ServiceType.Id))
                    {
                        indexRowServiceType++;
                        includeServiceTypeOrderAnOutfit.Add(renderService.PartOfTheCar.ServiceType.Id);
                        tableRenderServices.Rows[indexRowServiceType].Cells[0].Paragraphs[0].Font("Cambria").Append(countServiceType.ToString()).FontSize(12);
                        tableRenderServices.Rows[indexRowServiceType].Cells[1].Paragraphs[0].Font("Cambria").Append(renderService.PartOfTheCar.ServiceType.Title).FontSize(12);
                        if (usedUpMaterialStr != "")
                        {
                            usedUpMaterialStr = usedUpMaterialStr.Remove(usedUpMaterialStr.Length - 1);
                            tableRenderServices.Rows[indexStartMargeCels].Cells[2].Paragraphs[0].Font("Cambria").Append(usedUpMaterialStr).FontSize(12);
                        }

                        includeMaterialsOrderAnOutfit.Clear();
                        countServiceType++;

                        indexStartMargeCels = indexRowServiceType;
                        usedUpMaterialStr = "";
                    }

                    foreach (UsedUpMaterialEntity usedUpMaterials in renderService.UsedUpMaterials)
                    {
                        if (!includeMaterialsOrderAnOutfit.Contains(usedUpMaterials.Material.Id))
                        {
                            includeMaterialsOrderAnOutfit.Add(usedUpMaterials.Material.Id);
                            usedUpMaterialStr += usedUpMaterials.Material.Name + "\n";
                            //tableRenderServices.Rows[indexStartMargeCels].Cells[2].Paragraphs[0].Font("Cambria").Append(usedUpMaterials.Material.Name ).FontSize(12);
                        }
                    }



                    tableRenderServices.MergeCellsInColumn(0, indexStartMargeCels, indexRowServiceType + 1);
                    tableRenderServices.Rows[indexRowServiceType + 1].Cells[1].Paragraphs[0].Font("Cambria").Append(renderService.PartOfTheCar.Name).FontSize(12);
                    tableRenderServices.Rows[indexRowServiceType + 1].Cells[3].Paragraphs[0].Font("Cambria").Append(renderService.Price.ToString()).FontSize(12);

                    indexRowServiceType++;
                }

                if (usedUpMaterialStr != "")
                {
                    usedUpMaterialStr = usedUpMaterialStr.Remove(usedUpMaterialStr.Length - 1);
                    tableRenderServices.Rows[indexStartMargeCels].Cells[2].Paragraphs[0].Font("Cambria").Append(usedUpMaterialStr).FontSize(12);
                }
            }


            documentOrderOnOutfit.InsertParagraph().InsertTableAfterSelf(tableRenderServices);
            documentOrderOnOutfit.InsertParagraph();
            documentOrderOnOutfit.InsertParagraph();

            documentOrderOnOutfit.InsertParagraph($"Телефон заказчика {TbCustomerPhoneInfo.Text}").Font("Cambria").FontSize(12).Alignment = Alignment.both;
            Paragraph paragraphDeliveryOfTheOrder = documentOrderOnOutfit.InsertParagraph($"Ориентировочная дата сдачи заказа ").Font("Cambria").FontSize(12);
            paragraphDeliveryOfTheOrder.Append($"{DtpDeliveryOfTheOrder.Value.ToShortDateString()} "
                + $"{DtpDeliveryOfTheOrder.Value:HH:mm}").Font("Cambria").FontSize(12).UnderlineStyle(UnderlineStyle.singleLine).Alignment = Alignment.both;

            documentOrderOnOutfit.InsertParagraph($"Подпись мастера (ФИО) __________________________________________________________________").Font("Cambria").FontSize(12).Alignment = Alignment.both;
            documentOrderOnOutfit.InsertParagraph($"Настоящим я, {TbCustomerNameInfo.Text}, принимаю автомобиль и выполненные работы в полном объеме, претензий по качеству выполненных работ, состоянию и комплектации не имею ________________________").Font("Cambria").FontSize(12).Alignment = Alignment.both;

            try
            {
                documentOrderOnOutfit.Save();
            }
            catch (Exception) { MessageBox.Show("Невозможно создать заказ наряд так, как документ с таким же именем уже открыт", "Ошибка"); }
            var p = new Process();
            string filename = company.PathToFilesOrderOnOutfit + $"\\Заказ наряд для клиента {TbCustomerNameInfo.Text} машина {CmbBrandCarInfo.Text} {CmbModelCarInfo.Text}.docx";
            p.StartInfo = new ProcessStartInfo(filename)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void BtnInfoOrder_Click(object sender, EventArgs e)
        {
            scInfoAndNewOrder.Panel2Collapsed = true;
        }

        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            scInfoAndNewOrder.Panel1Collapsed = true;
        }

        private async void BtnChangeVechicle_Click(object sender, EventArgs e)
        {
            if (CmbModelCarInfo.SelectedItem is ModelCarEntity modelCar)
            {
                try
                {
                    using (_dbContext = new AutoKulturaDbContext())
                    {
                        VechicleRepository vechicleRepository = new(_dbContext);
                        ViewVechicleForOrder vechicle = await vechicleRepository.GetByOrderId(_currentOrderId);
                        int t = await vechicleRepository.Update(vechicle.IdVechicle, modelCar.Id, TbRegisterNumberInfo.Text);

                        if (t > 0)
                        {
                            new formMessage($"Автомобиль {vechicle?.BrandCar?.Name} {vechicle?.Model?.Name} клиента {TbCustomerNameInfo.Text} изменен", "Изменение данных автомобиля", true).Show();
                            await ReadDataOrders();

                        }
                        else
                            new formMessage($"Ошибка! Заполните все поля", "Изменение данных автомобиля", false).Show();
                    }
                }
                catch (Exception ex) { new formMessage(ex.Message, "Изменение данных автомобиля").Show(); };
            }
        }

        private async void BtnChangeOrder_Click(object sender, EventArgs e)
        {
            if (CmbPymentMethodInfo.SelectedItem is PymentMethodEntity pymentMethod)
                try
                {
                    using AutoKulturaDbContext dbContext = new();

                    VechicleRepository vechicleRepository = new(dbContext);
                    ViewVechicleForOrder vechicle = await vechicleRepository.GetByOrderId(_currentOrderId);


                    OrdersRepository orderRepository = new(dbContext);
                    DateTime dateDeliveryOfTheOrder = new();

                    if (dtpDateOrderInfo.Value != DtpDeliveryOfTheOrder.Value)
                        dateDeliveryOfTheOrder = DtpDeliveryOfTheOrder.Value;


                    int t = await orderRepository.Update(_currentOrderId, vechicle.IdVechicle, dtpDateOrderInfo.Value,
                        dateDeliveryOfTheOrder, Convert.ToDecimal(TbPriceOrderInfo.Text), pymentMethod.Id);
                    if (t > 0)
                    {
                        new formMessage($"Информация о заказе клиента {TbCustomerNameInfo.Text} на {dtpDateOrderInfo.Value.ToShortDateString()}" +
                            $" {dtpDateOrderInfo.Value.ToShortTimeString()} изменена", "Изменение деталей заказа", true).Show();
                        await ReadDataOrders();
                    }
                    else
                        new formMessage($"Ошибка при изменении деталей заказа клиента {TbCustomerNameInfo.Text}.\nПроверьте правильность заполнения полей ", "Изменение деталей заказа", false).Show();

                }
                catch (Exception ex) { new formMessage(ex.Message, "Изменение деталей заказа").Show(); }

            else
                new formMessage("Не выбран способ оплаты", "Изменение деталей заказа", false).Show();
        }

        private void CmbBrandCarAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBrandCarAdd.SelectedItem is BrandCarEntity brandCar)
                using (AutoKulturaDbContext dbContext = new())
                {
                    ModelCarRepository modelCarRepository = new(dbContext);
                    cmbModelCarAdd.DataSource = null;
                    cmbModelCarAdd.DataSource = modelCarRepository.GetByIdBrandCar(brandCar.Id);
                    cmbModelCarAdd.DisplayMember = "Name";
                    cmbModelCarAdd.ValueMember = "Id";
                }
        }

        private void BtnClearNewCustomer_Click(object sender, EventArgs e)
        {
            TbAdditionalInformationCustomer.Text = string.Empty;
            TbEmailCustomer.Text = string.Empty;
            TbPhoneCustomer.Text = string.Empty;
            CmbNameCustomer.Text = string.Empty;
            TbRegisterNumber.Text = string.Empty;
        }

        private async void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int statusAdd = 0;
                Guid customerId = Guid.NewGuid();
                Guid vechicleId = Guid.NewGuid();
                using (AutoKulturaDbContext dbContext = new())
                {
                    CustomerRepository customerRepository = new(dbContext);
                    statusAdd = await customerRepository.Add(customerId, CmbNameCustomer.Text, TbPhoneCustomer.Text, TbEmailCustomer.Text, TbAdditionalInformationCustomer.Text);
                }

                if (statusAdd > 0 && cmbModelCarAdd.SelectedItem is ModelCarEntity modelCar)
                    using (AutoKulturaDbContext dbContext = new())
                    {
                        VechicleRepository vechicleRepository = new(dbContext);

                        statusAdd = await vechicleRepository.Add(vechicleId, customerId, modelCar.Id, TbRegisterNumber.Text);
                    }
                if (statusAdd > 0 && CmbPymentMethodAdd.SelectedItem is PymentMethodEntity pymentMethod)
                    using (AutoKulturaDbContext dbContext = new())
                    {
                        OrdersRepository oederRepository = new(dbContext);

                        statusAdd = await oederRepository.Add(Guid.NewGuid(), dtpDateOrder.Value, vechicleId, pymentMethod.Id);
                    }

                await ReadDataOrders();
                new formMessage($"Заказ клиента {CmbNameCustomer.Text} на {dtpDateOrder.Value} добавлен", "Добавление нового заказа", true).Show();
            }
            catch (Exception ex) { new formMessage(ex.Message, "Добавление нового заказа").Show(); }
        }

        private void CmbBrandCarInfo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CmbBrandCarInfo.SelectedItem is BrandCarEntity brandCar)
                using (AutoKulturaDbContext dbContext = new())
                {
                    ModelCarRepository modelCarRepository = new(dbContext);
                    CmbModelCarInfo.DataSource = null;
                    CmbModelCarInfo.DataSource = modelCarRepository.GetByIdBrandCar(brandCar.Id);
                    CmbModelCarInfo.DisplayMember = "Name";
                    CmbModelCarInfo.ValueMember = "Id";
                }
        }

        private async void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вся информация о заказе клиента {TbCustomerNameInfo.Text} будет удалена.\nВы действительно хотите удалить?",
               "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (_dbContext = new AutoKulturaDbContext())
                {
                    OrdersRepository ordersRepository = new(_dbContext);
                    await ordersRepository.Delete((Guid)dgvOrders.SelectedRows[0].Cells["Id"].Value);
                }
                await ReadDataOrders();
            }
        }


    }

    public class ButtonGlow()
    {

        readonly Color activeBackgroundColor = Color.FromArgb(70, 70, 74);
        readonly Color activeForegroundColor = Color.White;

        readonly Color defaultBackgroundColor = Color.FromArgb(46, 46, 50);
        readonly Color defaultForegroundColor = Color.FromArgb(150, 150, 150);

        readonly private List<Button> groupButton = [];

        private static void SetButtonColors(Button button, Color BackColor, Color foreColor)
        {
            button.BackColor = BackColor;
            button.ForeColor = foreColor;           
        }

        private void GlowButton_Click(object sender, EventArgs e)
        {
            SetActive(sender);
        }

        public void AddButton(params Button[] button)
        {
            groupButton.AddRange(button);
            foreach (Button btn in groupButton)
#pragma warning disable CS8622 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует целевому объекту делегирования (возможно, из-за атрибутов допустимости значений NULL).
                btn.Click += GlowButton_Click;
#pragma warning restore CS8622 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует целевому объекту делегирования (возможно, из-за атрибутов допустимости значений NULL).
        }

        public void SetActive(object button)
        {
            Button activeButton = (Button)button;
            SetButtonColors(activeButton, activeBackgroundColor, activeForegroundColor);
            if (activeButton.Parent.Controls[1] is Panel panel)
            {
                panel.Visible = true;
            }

            foreach (Button itm in groupButton)
            {
                if (itm.Name != activeButton.Name)
                {
                    SetButtonColors(itm, defaultBackgroundColor, defaultForegroundColor);

                    if (itm.Parent.Controls[1] is Panel panelItem)
                    {
                        panelItem.Visible = false;
                    }
                }
            }
        }

    }
}
