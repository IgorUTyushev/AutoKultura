using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;

namespace AutoKultura.Add
{
    public partial class FormAddPymentMethod : Form
    {
        public FormAddPymentMethod()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                
                    PymentMethodRepository pymentMethod = new(dbContext);

                    int t = await pymentMethod.Add(new Guid(), TbName.Text, CbDefault.Checked);
                    if (t > 0)
                        new formMessage($"Способ оплаты \"{TbName.Text}\" добавлен", "Добавление способа оплаты", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Добавление способа оплаты", false).Show();
                

            }
            catch (Exception ex) { new formMessage(ex.Message, "Добавление способа оплаты").Show(); }
        }
    }
}
