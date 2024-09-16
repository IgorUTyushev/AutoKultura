using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;

namespace AutoKultura.Update
{
    public partial class FormUpdateSpecialist : Form
    {
        private readonly SpecialistEntity specialistEntity;

        public FormUpdateSpecialist(SpecialistEntity specialistEntity)
        {
            InitializeComponent();
            this.specialistEntity = specialistEntity;
            TbName.Text = specialistEntity.Name;
            TbPhone.Text = specialistEntity.Phone;
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    SpecialistRepository spec= new(dbContext);

                    int t = await spec.Update(specialistEntity.Id, TbName.Text, TbPhone.Text);
                    if (t > 0)
                        new formMessage($"Мастер \"{specialistEntity.Name}\" Изменен", "Изменение мастера", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Изменение мастера", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Изменение типа кузова").Show(); }
        }
    }
}
