using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;


namespace AutoKultura.Update
{
    public partial class FormUpdateMaterial : Form
    {
        private readonly ViewMaterial viewMaterial;

        public FormUpdateMaterial(ViewMaterial viewMaterial)
        {
            InitializeComponent();
            this.viewMaterial = viewMaterial;
            TbName.Text = viewMaterial.NameMaterial;
            TbPrice.Text = viewMaterial.Price.ToString();
            TbCount.Text = viewMaterial.Count.ToString();
            FillCmb();
        }

        private async void FillCmb()
        {
            using AutoKulturaDbContext dbContext = new();
            {
                MeasureUnitRepository measureUnit = new(dbContext);
                CmbMeasureUnits.DataSource = null;
                List <MeasureUnitEntity> list = await measureUnit.Get();
                CmbMeasureUnits.DataSource = list;
                CmbMeasureUnits.DisplayMember = "Name";
                CmbMeasureUnits.ValueMember = "Id";

                CmbMeasureUnits.SelectedItem = list.FirstOrDefault(mu => mu.Id == viewMaterial.IdMeasureUnite);
            }
        }


        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CmbMeasureUnits.SelectedItem is MeasureUnitEntity measureUnit)
                try
                {
                    using AutoKulturaDbContext dbContext = new();
                    {

                        MaterialRepository material = new(dbContext);


                        int t = await material.Update(viewMaterial.IdMaterial, TbName.Text, measureUnit, Convert.ToDecimal(TbPrice.Text), Convert.ToDecimal(TbCount.Text));
                        if (t > 0)
                            new formMessage($"Материал \"{viewMaterial.NameMaterial}\" изменен", "Изменение материала", true).Show();
                        else
                            new formMessage($"Ошибка! Заполните все поля", "Изменение материала", false).Show();
                    }

                }
                catch (Exception ex) { new formMessage(ex.Message, "Обновление материала").Show(); }

            else
                new formMessage($"Не выбрана единица измерения", "Изменение материала", false).Show();
        }

        private void TbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' &&
                    (e.KeyChar != ',' || TbPrice.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void TbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
