using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;


namespace AutoKultura
{
    public partial class FormAddServicesAndMaterialOrder : Form
    {
        private readonly Guid _orderId;
        Guid _currentRenderServiceId;

        public FormAddServicesAndMaterialOrder(Guid orderId)
        {
            InitializeComponent();
            this._orderId = orderId;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FillingCmbMaterial();
            FillingCmbRenderService();
            FillingCmbSpecialist();
            await ReadRenderServices();
        }

        private async void FillingCmbSpecialist()
        {
            using AutoKulturaDbContext dbContext = new();

            SpecialistRepository SpecialistRep = new(dbContext);
            var listSpecialist = await SpecialistRep.Get();

            CmbSpecialist.DataSource = null;
            CmbSpecialist.DataSource = listSpecialist;
            CmbSpecialist.DisplayMember = "Name";
            CmbSpecialist.ValueMember = "Id";
        }
        private async void FillingCmbMaterial()
        {
            using AutoKulturaDbContext dbContext = new();

            MaterialRepository materialRep = new(dbContext);
            var listMaterial = await materialRep.Get();

            CmbMaterials.DataSource = null;
            CmbMaterials.DataSource = listMaterial;
            CmbMaterials.DisplayMember = "NameMaterial";
            CmbMaterials.ValueMember = "IdMaterial";
        }

        private async void FillingCmbRenderService()
        {
            using AutoKulturaDbContext dbContext = new();

            ServiceTypeRepository serviceTypeRep = new(dbContext);
            var listServiceType = await serviceTypeRep.Get();

            CmbServiceType.DataSource = null;
            CmbServiceType.DataSource = listServiceType;
            CmbServiceType.DisplayMember = "Title";
            CmbServiceType.ValueMember = "Id";
        }

        private async Task ReadRenderServices()
        {
            using AutoKulturaDbContext dbContext = new();

            RenderServiceRepository renderService = new(dbContext);

            int selectedRowIndex = -1;
            if (dgvRenderServices.SelectedRows.Count > 0)
                selectedRowIndex = dgvRenderServices.Rows.IndexOf(dgvRenderServices.SelectedRows[0]);

            //dgvRenderService.DataSource = null;
            var result = await renderService.GetByIdOrder(_orderId);
            dgvRenderServices.DataSource = result;
            dgvRenderServices.Columns["Id"].Visible = false;
            dgvRenderServices.Columns["IdOrder"].Visible = false;

            if (selectedRowIndex != -1 && dgvRenderServices.SelectedRows.Count > 0 && dgvRenderServices.Rows.Count > selectedRowIndex)
                dgvRenderServices.Rows[selectedRowIndex].Selected = true;
        }

        private async Task ReadSpecialist()
        {
            using AutoKulturaDbContext dbContext = new();

            LinqSpecialistForRenderServiceslRepository SpecialistExecutingWork = new(dbContext);

            int selectedRowIndex = -1;
            if (dgvSpecialist.SelectedRows.Count > 0)
                selectedRowIndex = dgvSpecialist.Rows.IndexOf(dgvSpecialist.SelectedRows[0]);

            //dgvRenderService.DataSource = null;
            var result = await SpecialistExecutingWork.GetSpecialistByIdRenderServices(_currentRenderServiceId);
            dgvSpecialist.DataSource = result;
            dgvSpecialist.Columns["Id"].Visible = false;

            if (selectedRowIndex != -1 && dgvSpecialist.Rows.Count > 0)
                dgvSpecialist.Rows[selectedRowIndex].Selected = true;
        }

        private async Task ReadUsedUpMaterial()
        {
            using AutoKulturaDbContext dbContext = new();

            UsedUpMaterialRepository usedUpMaterialRepository = new(dbContext);

            int selectedRowIndex = -1;
            if (dgvUsedUpMaterial.SelectedRows.Count > 0)
                selectedRowIndex = dgvUsedUpMaterial.Rows.IndexOf(dgvUsedUpMaterial.SelectedRows[0]);

            dgvUsedUpMaterial.DataSource = null;
            dgvUsedUpMaterial.DataSource = await usedUpMaterialRepository.GetByIdRenderServices(_currentRenderServiceId);
            dgvUsedUpMaterial.Columns["IdUsedUpMaterial"].Visible = false;

            if (selectedRowIndex != -1 && dgvUsedUpMaterial.Rows.Count > 0)
                dgvUsedUpMaterial.Rows[selectedRowIndex].Selected = true;
        }

        private async void BtnAddRenderService_Click(object sender, EventArgs e)
        {
            if (CmbServiceType.SelectedItem is ServiceTypeEntity serviceType)
                try
                {
                    Guid? partOfTheCarId = null;
                    if (cmbPartOfTheCar.SelectedItem is ViewPartOfTheCar partOfTheCar)
                        partOfTheCarId = partOfTheCar.Id;
                    using AutoKulturaDbContext dbContext = new();

                    RenderServiceRepository renderServiceRepository = new(dbContext);
                    _currentRenderServiceId = Guid.NewGuid();
                    int t = await renderServiceRepository.Add(_currentRenderServiceId, _orderId, serviceType.Id, partOfTheCarId, Convert.ToDecimal(TbPrice.Text));

                    if (t < 1)
                        new formMessage($"Количество обработанных строк {t}", "Добавление работы и детали автомобиля").Show();
                    else
                        await ReadRenderServices();
                }
                catch (Exception ex) { new formMessage(ex.Message, "Добавление работы и детали автомобиля").Show(); }

            else
                new formMessage($"Выберите деталь автомобиля на которой производились работы", "Добавление работы и детали автомобиля", false).Show();
        }

        private async void BtnAddUsedUpMaterial_Click(object sender, EventArgs e)
        {
            if (TbCount.Text == "")
            {
                new formMessage($"Заполните количество израсходованного материала", "Добавление использованного материала", false).Show();
                return;
            }
            if (CmbMaterials.SelectedItem is ViewMaterial material)
                try
                {
                    using AutoKulturaDbContext dbContext = new();

                    UsedUpMaterialRepository usedUpMaterialRepository = new(dbContext);
                    int t = await usedUpMaterialRepository.Add(Guid.NewGuid(), material.IdMaterial, _currentRenderServiceId, Convert.ToDecimal(TbCount.Text));

                    if (t < 1)
                        new formMessage($"Количество обработанных строк {t}", "Добавление использованного материала").Show();
                    else
                        await ReadRenderServices();
                }
                catch (Exception ex)
                {
                    new formMessage(ex.Message, "Добавление использованного материала").Show();
                }

            else
                new formMessage($"Выберите материал", "Добавление использованного материала", false).Show();
        }

        private async void BtnAddSpecialist_Click(object sender, EventArgs e)
        {
            if (CmbSpecialist.SelectedItem is SpecialistEntity specialist)
                try
                {
                    using AutoKulturaDbContext dbContext = new();

                    LinqSpecialistForRenderServiceslRepository linqSpecialistForRenderServiceslRepository = new(dbContext);
                    int t = await linqSpecialistForRenderServiceslRepository.Add(Guid.NewGuid(), specialist.Id, _currentRenderServiceId);

                    if (t < 1)
                        new formMessage($"Количество обработанных строк {t}", "Добавление мастера").Show();
                    else
                        await ReadSpecialist();
                }
                catch (Exception ex) { new formMessage(ex.Message, "Добавление мастера").Show(); }

            else
                new formMessage($"Ошибка! Выберите мастера который выполнял работу", "Добавление мастера", false).Show();
        }

        private void CmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMaterials.SelectedItem is ViewMaterial material)
            {
                LblMeasureUnit.Text = material.NameMeasureUnit;
            }
        }

        private async void DgvRenderServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRenderServices.SelectedRows.Count > 0)
            {
                _currentRenderServiceId = (Guid)dgvRenderServices.SelectedRows[0].Cells["Id"].Value;
                scMaterialAndSpecialist.Enabled = true;
                await ReadUsedUpMaterial();
                await ReadSpecialist();
            }
        }

        private async void УдалитьDELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using AutoKulturaDbContext dbContext = new();

            RenderServiceRepository renderService = new(dbContext);
            await renderService.Delete(_currentRenderServiceId);
            await ReadRenderServices();
        }

        private async void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using AutoKulturaDbContext dbContext = new();

            LinqSpecialistForRenderServiceslRepository linqSpecialistForRenderServiceslRepository = new(dbContext);
            await linqSpecialistForRenderServiceslRepository.Delete((Guid)dgvSpecialist.SelectedRows[0].Cells["id"].Value, _currentRenderServiceId);
            await ReadSpecialist();
        }

        private async void BtnDeleteMaterial_Click(object sender, EventArgs e)
        {
            using AutoKulturaDbContext dbContext = new();

            UsedUpMaterialRepository usedUpMaterialRepository = new(dbContext);
            await usedUpMaterialRepository.Delete((Guid)dgvUsedUpMaterial.SelectedRows[0].Cells["IdUsedUpMaterial"].Value);
            await ReadUsedUpMaterial();
        }

        private async void CmbRenderService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbServiceType.SelectedItem is ServiceTypeEntity serviceType)
                using (AutoKulturaDbContext dbContext = new())
                {
                    PartOfTheCarRepository partOfTheCarRepository = new(dbContext);
                    cmbPartOfTheCar.DataSource = null;
                    cmbPartOfTheCar.DataSource = await partOfTheCarRepository.GetByIdServiceType(serviceType.Id);
                    cmbPartOfTheCar.DisplayMember = "NamePartOfTheCar";
                    cmbPartOfTheCar.ValueMember = "Id";
                }
        }

        private void TbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' &&
                    (e.KeyChar != ',' || TbPrice.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void СправочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DictionaryForm df = new();
            df.ShowDialog();
            FillingCmbMaterial();
            FillingCmbRenderService();
            FillingCmbSpecialist();
        }

        private void CmbPartOfTheCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPartOfTheCar.SelectedItem is ViewPartOfTheCar partOfTheCar)
                TbPrice.Text = partOfTheCar.Price.ToString();
        }

        private void TbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' &&
                    (e.KeyChar != ',' || TbCount.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }
    }
}
