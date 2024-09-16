using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;

namespace AutoKultura.Add
{
    public partial class FormAddBodyWork : Form
    {
        public FormAddBodyWork()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    BodyWorkRepository bodyWorkRep = new(dbContext);

                    int t = await bodyWorkRep.Add(new Guid(), TbName.Text);
                    if (t > 0)
                        new formMessage($"Тип кузова \"{TbName.Text}\" добавлен", "Добавление типа кузова", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Добавление типа кузова", false).Show();
                }

            }
            catch (Exception ex) {new formMessage(ex.Message, "Добавление типа кузова").Show(); }
        }
    }
}
