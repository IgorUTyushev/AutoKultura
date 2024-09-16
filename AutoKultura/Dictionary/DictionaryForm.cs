using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.Add;
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.Update;
using AutoKultura.DataAccess.SqlServer.View;

namespace AutoKultura
{
    public partial class DictionaryForm : Form
    {
        AutoKulturaDbContext? dbContext;
        public DictionaryForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbContext = new AutoKulturaDbContext();

            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Фирма", Name = "Firm" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Мастера", Name = "Specialist" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Материалы", Name = "Material" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Единицы измерения материалов", Name = "MeasureUnit" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Работы", Name = "ServiceType" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Деталь автомобиля на которой производятся работы", Name = "PartOfTheCar" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Марка машины", Name = "BrandCar" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Модель машины", Name = "ModelCar" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Тип кузова", Name = "BodyWork" });
            tvTypeDictionary.Nodes.Add(new TreeNode() { Text = "Способ оплаты", Name = "PymentMethod" });
        }

        private void TvTypeDictionary_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || dbContext is null) return;
            ReadDataDictionary();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (tvTypeDictionary.SelectedNode == null || dbContext is null) return;
            switch (tvTypeDictionary.SelectedNode.Name)
            {
                case "Firm":
                    {
                        FormAddCompany formAddCompany = new();
                        formAddCompany.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "Specialist":
                    {
                        FormAddSpecialist formAddSpecialist = new();
                        formAddSpecialist.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "Material":
                    {
                        FormAddMaterial formAddMMaterial = new();
                        formAddMMaterial.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "MeasureUnit":
                    {
                        FormAddMeasureUnit formAddMeasureUnit = new();
                        formAddMeasureUnit.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "ServiceType":
                    {
                        FormAddServiceType formAddServiceType = new();
                        formAddServiceType.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "PartOfTheCar":
                    {
                        FormAddPartOfTheCar formPartOfTheCar = new();
                        formPartOfTheCar.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "BrandCar":
                    {
                        FormAddBrandCar formAddBrandCar = new();
                        formAddBrandCar.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "ModelCar":
                    {
                        FormAddModelCar formAddModelCar = new();
                        formAddModelCar.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "BodyWork":
                    {
                        FormAddBodyWork formAddBodyWork = new();
                        formAddBodyWork.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                case "PymentMethod":
                    {
                        FormAddPymentMethod formAddPymentMethod = new();
                        formAddPymentMethod.ShowDialog();
                        ReadDataDictionary();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private async void ReadDataDictionary()
        {
            if (tvTypeDictionary.SelectedNode == null || dbContext is null) return;

            int selectedRowIndex = -1;
            if (dgvDictionary.SelectedRows.Count > 0)
                selectedRowIndex = dgvDictionary.Rows.IndexOf(dgvDictionary.SelectedRows[0]);

            switch (tvTypeDictionary.SelectedNode.Name)
            {
                case "Firm":
                    {
                        CompanyRepository cr = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await cr.Get();
                        dgvDictionary.Columns["Id"].Visible = false;
                        break;
                    }
                case "Specialist":
                    {
                        SpecialistRepository spec = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await spec.Get();
                        dgvDictionary.Columns["Id"].Visible = false;
                        break;
                    }
                case "Material":
                    {
                        MaterialRepository materials = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await materials.Get();
                        dgvDictionary.Columns["IdMaterial"].Visible = false;
                        dgvDictionary.Columns["IdMeasureUnite"].Visible = false;
                        break;
                    }
                case "MeasureUnit":
                    {
                        MeasureUnitRepository measureUnit = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await measureUnit.Get();
                        dgvDictionary.Columns["Id"].Visible = false;
                        break;
                    }
                case "ServiceType":
                    {
                        ServiceTypeRepository serviceTypeRepository = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await serviceTypeRepository.Get();
                        dgvDictionary.Columns["Id"].Visible = false;
                        break;
                    }
                case "PartOfTheCar":
                    {
                        PartOfTheCarRepository partOfTheCarRepository = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await partOfTheCarRepository.Get();
                        dgvDictionary.Columns["Id"].Visible = false;
                        dgvDictionary.Columns["ServiseTypeId"].Visible = false;
                        break;
                    }
                case "BrandCar":
                    {
                        BrandCarRepository brandCarRepository = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await brandCarRepository.Get();
                        dgvDictionary.Columns["Id"].Visible = false;
                        break;
                    }
                case "ModelCar":
                    {
                        ModelCarRepository modelCarRepository = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await modelCarRepository.Get();
                        dgvDictionary.Columns["IdModelCar"].Visible = false;
                        dgvDictionary.Columns["IdBodyWork"].Visible = false;
                        dgvDictionary.Columns["IdBrandCar"].Visible = false;
                        break;
                    }
                case "BodyWork":
                    {
                        BodyWorkRepository bodyWorkRepository = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await bodyWorkRepository.Get();
                        dgvDictionary.Columns["Id"].Visible = false;
                        break;
                    }
                case "PymentMethod":
                    {
                        PymentMethodRepository pymentMethodRepository = new(dbContext);
                        dgvDictionary.DataSource = null;
                        dgvDictionary.DataSource = await pymentMethodRepository.Get();
                        dgvDictionary.Columns["Id"].Visible = false;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (selectedRowIndex != -1 && dgvDictionary.Rows.Count > 0 && dgvDictionary.Rows.Count > selectedRowIndex)
                dgvDictionary.Rows[selectedRowIndex].Selected = true;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (tvTypeDictionary.SelectedNode == null || dbContext is null) return;
            switch (tvTypeDictionary.SelectedNode.Name)
            {
                case "Firm":
                    {
                        List<CompanyEntity> list = (List<CompanyEntity>)dgvDictionary.DataSource;
                        CompanyEntity selectedItem = list.First(item => item.Id == (Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);

                        FormUpdateCompany formUpdateCompany = new(selectedItem);
                        formUpdateCompany.ShowDialog();
                        break;
                    }
                case "Specialist":
                    {
                        List<SpecialistEntity> list = (List<SpecialistEntity>)dgvDictionary.DataSource;
                        SpecialistEntity selectedItem = list.First(item => item.Id == (Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);

                        FormUpdateSpecialist formUpdateSpecialist = new(selectedItem);
                        formUpdateSpecialist.ShowDialog();
                        break;
                    }
                case "Material":
                    {
                        List<ViewMaterial> list = (List<ViewMaterial>)dgvDictionary.DataSource;
                        ViewMaterial selectedItem = list.First(item => item.IdMaterial == (Guid)dgvDictionary.SelectedRows[0].Cells["IdMaterial"].Value);

                        FormUpdateMaterial formUpdateMaterial = new(selectedItem);
                        formUpdateMaterial.ShowDialog();
                        break;
                    }
                case "MeasureUnit":
                    {
                        List<MeasureUnitEntity> list = (List<MeasureUnitEntity>)dgvDictionary.DataSource;
                        MeasureUnitEntity selectedItem = list.First(item => item.Id == (Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);

                        FormUpdateMeasureUnit formUpdateMeasureUnit = new(selectedItem);
                        formUpdateMeasureUnit.ShowDialog();
                        break;
                    }
                case "ServiceType":
                    {
                        List<ServiceTypeEntity> list = (List<ServiceTypeEntity>)dgvDictionary.DataSource;
                        ServiceTypeEntity selectedItem = list.First(item => item.Id == (Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);

                        FormUpdateServiceType formUpdateServiceType = new(selectedItem);
                        formUpdateServiceType.ShowDialog();
                        break;
                    }
                case "PartOfTheCar":
                    {
                        List<ViewPartOfTheCar> list = (List<ViewPartOfTheCar>)dgvDictionary.DataSource;
                        ViewPartOfTheCar selectedItem = list.First(item => item.Id == (Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);

                        FormUpdatePartOfTheCar formUpdateServiceType = new(selectedItem);
                        formUpdateServiceType.ShowDialog();
                        break;
                    }
                case "BrandCar":
                    {
                        List<BrandCarEntity> listBrandCars = (List<BrandCarEntity>)dgvDictionary.DataSource;
                        BrandCarEntity selectedItem = listBrandCars.First(item => item.Id == (Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);

                        FormUpdateBrandCar formAddBrandCar = new(selectedItem);
                        formAddBrandCar.ShowDialog();
                        break;
                    }
                case "ModelCar":
                    {
                        List<ViewModelCar> list = (List<ViewModelCar>)dgvDictionary.DataSource;
                        ViewModelCar selectedItem = list.First(item => item.IdModelCar == (Guid)dgvDictionary.SelectedRows[0].Cells["IdModelCar"].Value);

                        FormUpdateModelCar formModelCar = new(selectedItem);
                        formModelCar.ShowDialog();
                        break;
                    }
                case "BodyWork":
                    {
                        List<BodyworkEntity> list = (List<BodyworkEntity>)dgvDictionary.DataSource;
                        BodyworkEntity selectedItem = list.First(item => item.Id == (Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);

                        FormUpdateBodyWork formUpdateBodyWork = new(selectedItem);
                        formUpdateBodyWork.ShowDialog();
                        break;
                    }
                case "PymentMethod":
                    {
                        List<PymentMethodEntity> list = (List<PymentMethodEntity>)dgvDictionary.DataSource;
                        PymentMethodEntity selectedItem = list.First(item => item.Id == (Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);

                        FormUpdatePymentMethod formUpdatePymentMethod = new(selectedItem);
                        formUpdatePymentMethod.ShowDialog();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            ReadDataDictionary();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (tvTypeDictionary.SelectedNode == null || dbContext is null) return;
            switch (tvTypeDictionary.SelectedNode.Name)
            {
                case "Firm":
                    {
                        CompanyRepository cr = new(dbContext);
                        await cr.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);
                        break;
                    }
                case "Specialist":
                    {
                        SpecialistRepository spec = new(dbContext);
                        await spec.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);
                        break;
                    }
                case "Material":
                    {
                        MaterialRepository materials = new(dbContext);
                        await materials.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["IdMaterial"].Value);
                        break;
                    }
                case "MeasureUnit":
                    {
                        MeasureUnitRepository measureUnit = new(dbContext);
                        await measureUnit.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);
                        break;
                    }
                case "ServiceType":
                    {
                        ServiceTypeRepository serviceTypeRepository = new(dbContext);
                        await serviceTypeRepository.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["IdServiceType"].Value);
                        break;
                    }
                case "PartOfTheCar":
                    {
                        PartOfTheCarRepository partOfTheCarRepository = new(dbContext);
                        await partOfTheCarRepository.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);
                        break;
                    }
                case "BrandCar":
                    {
                        BrandCarRepository brandCarRepository = new(dbContext);
                        await brandCarRepository.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);
                        break;
                    }
                case "ModelCar":
                    {
                        ModelCarRepository modelCarRepository = new(dbContext);
                        await modelCarRepository.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["IdModelCar"].Value);
                        break;
                    }
                case "BodyWork":
                    {
                        BodyWorkRepository bodyWorkRepository = new(dbContext);
                        await bodyWorkRepository.Delete((Guid)dgvDictionary.SelectedRows[0].Cells["Id"].Value);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            ReadDataDictionary();
        }

        private void TvTypeDictionary_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.IsSelected)
            {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(150, 150, 150)), e.Bounds);
            }
            else
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(52, 52, 52)),e.Bounds);

            TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.TreeView.Font, e.Node.Bounds,Color.White);
        }
    }
}
