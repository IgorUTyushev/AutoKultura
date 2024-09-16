using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;


namespace AutoKultura.Update
{
    public partial class FormUpdateModelCar : Form
    {
        private readonly ViewModelCar viewModelCar;

        public FormUpdateModelCar(ViewModelCar viewModelCar)
        {
            InitializeComponent();
            this.viewModelCar = viewModelCar;
            TbName.Text = viewModelCar.NameModelCar;
            FillCmb();
        }

        private async void FillCmb()
        {
            using (AutoKulturaDbContext dbContext = new())
            {
                BrandCarRepository brandCarRep = new(dbContext);
                CmbBrandCar.DataSource = null;
                List <BrandCarEntity> list = await brandCarRep.Get();
                CmbBrandCar.DataSource = list;
                CmbBrandCar.DisplayMember = "Name";
                CmbBrandCar.ValueMember = "Id";

                CmbBrandCar.SelectedItem = list.FirstOrDefault(bc => bc.Id == viewModelCar.IdBrandCar);

            }
            using (AutoKulturaDbContext dbContext = new())
            {
                BodyWorkRepository bodyWorkRep = new(dbContext);
                CmbBodyWork.DataSource = null;
                List<BodyworkEntity> list = await bodyWorkRep.Get();
                CmbBodyWork.DataSource = list;
                CmbBodyWork.DisplayMember = "Name";
                CmbBodyWork.ValueMember = "Id";

                CmbBodyWork.SelectedItem = list.FirstOrDefault(bw => bw.Id == viewModelCar.IdBodyWork);

            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CmbBrandCar.SelectedItem is BrandCarEntity brandCar && CmbBodyWork.SelectedItem is BodyworkEntity bodyWork)     
                try
                {
                    using AutoKulturaDbContext dbContext = new();                    
                    
                        ModelCarRepository modelCarRep = new(dbContext);

                        int t = await modelCarRep.Update(viewModelCar.IdModelCar, TbName.Text, brandCar, bodyWork);
                        if (t > 0)
                            new formMessage($"Модель машины \"{viewModelCar.NameModelCar}\" изменена", "Изменение модели машины", true).Show();
                        else
                            new formMessage($"Ошибка! Заполните все поля", "Изменение модели машины", false).Show();                 
                }
                catch (Exception ex) { new formMessage(ex.Message, "Изменение модели машины").Show(); }

            else
                new formMessage($"Не выбрана проводимая работа", "Изменение модели машины", false).Show();
        }
    }
}
