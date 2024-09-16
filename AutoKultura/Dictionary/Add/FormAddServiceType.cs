using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;


namespace AutoKultura.Add
{
    public partial class FormAddServiceType : Form
    {
        public FormAddServiceType()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {

                    ServiceTypeRepository serviceType = new(dbContext);


                    int t = await serviceType.Add(Guid.NewGuid(), TbName.Text);
                    if (t > 0)
                        new formMessage($"Вид работ \"{TbName.Text}\" добавлен", "Добавление работы", true).Show();                    
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Добавление работы", false).Show();
                }

            }   
            catch (Exception ex) { new formMessage(ex.Message, "Добавление работы").Show(); }
        }
    }
}
