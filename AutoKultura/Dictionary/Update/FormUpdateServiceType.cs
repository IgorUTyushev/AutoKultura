using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;


namespace AutoKultura.Update
{
    public partial class FormUpdateServiceType : Form
    {
        private readonly ServiceTypeEntity serviceTypeEntity;

        public FormUpdateServiceType(ServiceTypeEntity viewServiceType)
        {
            InitializeComponent();
            this.serviceTypeEntity = viewServiceType;
            TbName.Text = viewServiceType.Title;
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (AutoKulturaDbContext dbContext = new())
                {

                    ServiceTypeRepository serviceType = new(dbContext);


                    int t = await serviceType.Update(serviceTypeEntity.Id, TbName.Text);
                    if (t > 0)
                        new formMessage($"Вид работ \"{serviceTypeEntity.Title}\" изменен", "Изменение работы", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Изменение работы", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Изменение работы").Show(); }
        }   
    }
}
