using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;

namespace AutoKultura.Update
{
    public partial class FormUpdateBodyWork : Form
    {
        readonly BodyworkEntity curretnBodyworkEntity;
        public FormUpdateBodyWork(BodyworkEntity bodyworkEntity)
        {
            InitializeComponent();
            curretnBodyworkEntity = bodyworkEntity;
            TbName.Text = bodyworkEntity.Name;
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    BodyWorkRepository bodyWorkRep = new(dbContext);

                    int t = await bodyWorkRep.Update(curretnBodyworkEntity.Id, TbName.Text);
                    if (t > 0)
                        new formMessage($"Тип кузова \"{curretnBodyworkEntity.Name}\" изменен", "Изменение типа кузова",true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Изменение типа кузова", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Изменение типа кузова").Show(); }
        }
    }
}
