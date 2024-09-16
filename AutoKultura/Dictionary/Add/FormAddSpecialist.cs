using AutoKultura.DataAccess.SqlServer.Repositories;
using AutoKultura.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKultura.Add
{
    public partial class FormAddSpecialist : Form
    {
        public FormAddSpecialist()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    SpecialistRepository spec= new(dbContext);

                    int t = await spec.Add(new Guid(), TbName.Text, TbPhone.Text);
                    if (t > 0)
                        new formMessage($"Мастер \"{TbName.Text}\" добавлен", "Добавление мастера", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Добавление мастера", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Добавление мастера").Show(); }
        }
    }
}
