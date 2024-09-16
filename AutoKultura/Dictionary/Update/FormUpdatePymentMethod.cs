using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;

namespace AutoKultura.Update
{
    public partial class FormUpdatePymentMethod : Form
    {
        private readonly PymentMethodEntity pymentMethodEntity;

        public FormUpdatePymentMethod(PymentMethodEntity pymentMethod)
        {
            InitializeComponent();
            this.pymentMethodEntity = pymentMethod;

            TbName.Text = pymentMethod.Name;
            CbDefault.Checked = pymentMethodEntity.MethodDefault;
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    PymentMethodRepository pymentMethod = new(dbContext);

                    int t = await pymentMethod.Update(pymentMethodEntity.Id, TbName.Text, CbDefault.Checked);
                    if (t > 0)
                        new formMessage($"Способ оплаты \"{TbName.Text}\" изменен", "Изменение способа оплаты", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Изменение способа оплаты", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Изменение типа кузова").Show(); }
        }
    }
}
