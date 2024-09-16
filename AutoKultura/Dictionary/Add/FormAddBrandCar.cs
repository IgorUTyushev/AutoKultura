using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;

namespace AutoKultura.Add
{
    public partial class FormAddBrandCar : Form
    {
        public FormAddBrandCar()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    BrandCarRepository brandCar = new(dbContext);

                    int t = await brandCar.Add(new Guid(), TbName.Text);
                    if (t > 0)
                        new formMessage($"Марка машины \"{TbName.Text}\" добавлена", "Добавление марки машины", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Добавление модели машины", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Добавление модели машины").Show();}
        }
    }
}
