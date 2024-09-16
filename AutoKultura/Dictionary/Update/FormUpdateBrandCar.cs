using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;

namespace AutoKultura.Update
{
    public partial class FormUpdateBrandCar : Form
    {
        private readonly BrandCarEntity brandCarEntity;

        public FormUpdateBrandCar(BrandCarEntity brandCarEntity)
        {
            InitializeComponent();
            this.brandCarEntity = brandCarEntity;
            TbName.Text = brandCarEntity.Name;
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    BrandCarRepository brandCar = new(dbContext);

                    int t = await brandCar.Update(brandCarEntity.Id, TbName.Text);
                    if (t > 0)
                        new formMessage($"Марка машины \"{brandCarEntity.Name}\" изменена", "Изменение марки машины", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Изменение марки машины", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Изменение марки машины").Show(); }
        }
    }
}
