using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;


namespace AutoKultura.Add
{
    public partial class FormAddModelCar : Form
    {
        public FormAddModelCar()
        {
            InitializeComponent();         
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using (AutoKulturaDbContext dbContext = new())
            {
                BrandCarRepository brandCarRep = new(dbContext);
                CmbBrandCar.DataSource = null;
                CmbBrandCar.DataSource = await brandCarRep.Get();
                CmbBrandCar.DisplayMember = "Name";
                CmbBrandCar.ValueMember = "Id";
            }
            using (AutoKulturaDbContext dbContext = new())
            {
                BodyWorkRepository bodyWorkRep = new(dbContext);
                CmbBodyWork.DataSource = null;
                CmbBodyWork.DataSource = await bodyWorkRep.Get();
                CmbBodyWork.DisplayMember = "Name";
                CmbBodyWork.ValueMember = "Id";
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CmbBrandCar.SelectedItem is BrandCarEntity brandCar && CmbBodyWork.SelectedItem is BodyworkEntity bodyWork)     
                try
                {
                    using AutoKulturaDbContext dbContext = new();
                    {
                    
                        ModelCarRepository modelCarRep = new(dbContext);

                        int t = await modelCarRep.Add(Guid.NewGuid(), TbName.Text, brandCar, bodyWork);
                        if (t > 0)
                            new formMessage($"Модель машины \"{TbName.Text}\" добавлена", "Добавление модели машины", true).Show();
                        else
                            new formMessage("Ошибка! Заполните все поля", "Добавление модели машины", false).Show();
                    }

                }
                catch (Exception ex) { new formMessage(ex.Message, "Добавление модели машины").Show(); }

            else
                new formMessage("Не выбраны модель или тип кузова", "Добавление модели машины", false).Show();
        }
    }
}
