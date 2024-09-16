using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;

namespace AutoKultura.Add
{
    public partial class FormAddMeasureUnit : Form
    {
        public FormAddMeasureUnit()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    MeasureUnitRepository measureUnit = new(dbContext);

                    int t = await measureUnit.Add(new Guid(), TbName.Text);
                    if (t > 0)
                        new formMessage($"Единица измерения \"{TbName.Text}\" добавлена", "Добавление единицы измерения", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Добавление единицы измерения", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Добавление единицы измерения").Show(); }
        }
    }
}
