using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;

namespace AutoKultura.Update
{
    public partial class FormUpdateMeasureUnit : Form
    {
        private readonly MeasureUnitEntity measureUnitEntity;

        public FormUpdateMeasureUnit(MeasureUnitEntity measureUnitEntity)
        {
            InitializeComponent();
            this.measureUnitEntity = measureUnitEntity;
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    MeasureUnitRepository measureUnit = new(dbContext);

                    int t = await measureUnit.Update(measureUnitEntity.Id, TbName.Text);
                    if (t > 0)
                        new formMessage($"Единица измерения \"{measureUnitEntity.Name}\" изменена", "Изменение единицы измерения", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Изменение единицы измерения", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Изменение типа кузова").Show(); }
        }
    }
}
