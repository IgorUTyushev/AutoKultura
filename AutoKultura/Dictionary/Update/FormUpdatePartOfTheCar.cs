using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;


namespace AutoKultura.Add
{
    public partial class FormUpdatePartOfTheCar : Form
    {
        private readonly ViewPartOfTheCar viewpartOfTheCar;

        public FormUpdatePartOfTheCar(ViewPartOfTheCar viewpartOfTheCar)
        {
            InitializeComponent();
            this.viewpartOfTheCar = viewpartOfTheCar;
            TbName.Text = viewpartOfTheCar.NamePartOfTheCar;
            TbPrice.Text = viewpartOfTheCar.Price.ToString();


        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using AutoKulturaDbContext dbContext = new();
            {
                ServiceTypeRepository serviceTypeRep = new(dbContext);
                CmbServiceType.DataSource = null;
                List<ServiceTypeEntity> list = await serviceTypeRep.Get();
                CmbServiceType.DataSource = list;
                CmbServiceType.DisplayMember = "Title";
                CmbServiceType.ValueMember = "Id";

                CmbServiceType.SelectedItem = list.FirstOrDefault(st=> st.Id == viewpartOfTheCar.ServiseTypeId);
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CmbServiceType.SelectedItem is ServiceTypeEntity serviceType)
                try
                {
                    using AutoKulturaDbContext dbContext = new();
                    {

                        PartOfTheCarRepository partOfTheCarRep = new(dbContext);

                        int t = await partOfTheCarRep.Update(viewpartOfTheCar.Id, TbName.Text, serviceType.Id, Convert.ToDecimal(TbPrice.Text));
                        if (t > 0)
                            new formMessage($"Деталь кузова \"{TbName.Text}\" для работ \"{CmbServiceType.Text}\" изменена", "Изменение Детали машины", true).Show();
                        else
                            new formMessage($"Ошибка! Заполните все поля", "Изменение Детали машины", false).Show();
                    }

                }
                catch (Exception ex) {new formMessage(ex.Message, "Изменение Детали машины").Show(); }

            else
                new formMessage($"Не выбрана проводимая работа", "Изменение Детали машины", false).Show();
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
