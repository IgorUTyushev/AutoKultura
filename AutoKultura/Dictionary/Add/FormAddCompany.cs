using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Repositories;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormAddCompany : Form
    {
        public FormAddCompany()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                CompanyRepository cr = new(dbContext);

                int t = await cr.Add(new Guid(), TbName.Text, TbPhone.Text, TbEmail.Text, RtbAdress.Text, Convert.ToInt32(TbNumberOrderOnOutfit.Text), TbPath.Text);
                if (t > 0)
                    new formMessage($"Компания \"{TbName.Text}\" добавлена", "Добавление информации о компании", true).Show();
                else
                    new formMessage($"Ошибка! Заполните все поля", "Добавление информации о компании", false).Show();
            }
            catch (Exception ex) { new formMessage(ex.Message, "Добавление информации о компании").Show(); }
        }

        private void BtnAddPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderForOrderOnOutfit = new();

            if (folderForOrderOnOutfit.ShowDialog() == DialogResult.OK)
            {
                TbPath.Text = folderForOrderOnOutfit.SelectedPath;
            }
        }

        private void TbNumberOrderOnOutfit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
