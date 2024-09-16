using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;


namespace AutoKultura.Add
{
    public partial class FormAddPartOfTheCar : Form
    {
        public FormAddPartOfTheCar()
        {
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using AutoKulturaDbContext dbContext = new();

            ServiceTypeRepository serviceTypeRep = new(dbContext);
            CmbServiceType.DataSource = null;
            CmbServiceType.DataSource = await serviceTypeRep.Get();
            CmbServiceType.DisplayMember = "Title";
            CmbServiceType.ValueMember = "Id";
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CmbServiceType.SelectedItem is ServiceTypeEntity serviceType)
                try
                {
                    using AutoKulturaDbContext dbContext = new();

                    PartOfTheCarRepository partOfTheCarRep = new(dbContext);

                    int t = await partOfTheCarRep.Add(Guid.NewGuid(), TbName.Text, serviceType.Id, Convert.ToDecimal(TbPrice.Text));
                    if (t > 0)
                        new formMessage($"Деталь кузова \"{TbName.Text}\" для работ \"{CmbServiceType.Text}\" добавлена", "Добавление детали автомобиля", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Добавление детали автомобиля", false).Show();
                }
                catch (Exception ex) { new formMessage(ex.Message, "Добавление детали машины").Show(); }

            else
                new formMessage($"Не выбрана проводимая работа", "Добавление детали автомобиля", false).Show();
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
