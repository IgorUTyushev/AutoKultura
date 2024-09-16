using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;
using System.Net.Mail;


namespace AutoKultura.Add
{
    public partial class FormAddMaterial : Form
    {
        public FormAddMaterial()
        {
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using AutoKulturaDbContext dbContext = new();
            {
                MeasureUnitRepository measureUnit = new(dbContext);
                CmbMeasureUnits.DataSource = null;
                CmbMeasureUnits.DataSource = await measureUnit.Get();
                CmbMeasureUnits.DisplayMember = "Name";
                CmbMeasureUnits.ValueMember = "Id";
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CmbMeasureUnits.SelectedItem is MeasureUnitEntity measureUnit)
                try
                {
                    using AutoKulturaDbContext dbContext = new();
                    {

                        MaterialRepository material = new(dbContext);

                        decimal counMaterial = 0;
                        if (TbCount.Text != "")
                        {
                            counMaterial = Convert.ToDecimal(TbCount.Text);
                        }

                        int result = await material.Add(Guid.NewGuid(), TbName.Text, measureUnit, Convert.ToDecimal(TbPrice.Text), counMaterial);

                        if (result > 0)
                            new formMessage($"Материал \"{TbName.Text}\" добавлен", "Добавление материала", true).Show();
                        else
                            new formMessage("Ошибка! Заполните все поля", "Добавление материала", false).Show();
                    }

                }
                catch (Exception ex) { new formMessage(ex.Message, "Добавление материала").Show(); }

            else
                new formMessage("Не выбрана единица измерения", "Добавление материала", false).Show();
        }

        private void TbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
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
    }
}
