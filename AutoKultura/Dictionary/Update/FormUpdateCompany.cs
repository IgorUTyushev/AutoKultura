using AutoKultura.DataAccess.SqlServer;
using AutoKultura.DataAccess.SqlServer.Models;
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

namespace AutoKultura.Update
{
    public partial class FormUpdateCompany : Form
    {
        private readonly CompanyEntity companyEntity;

        public FormUpdateCompany(CompanyEntity companyEntity)
        {
            InitializeComponent();
            this.companyEntity = companyEntity;
            TbName.Text = companyEntity.Name;
            TbPhone.Text = companyEntity.Phone;
            TbEmail.Text = companyEntity.Email;
            RtbAdress.Text = companyEntity.Adress;
            tbMaster.Text = companyEntity.Master;
            TbPath.Text = companyEntity.PathToFilesOrderOnOutfit;
            TbNumberOrderOnOutfit.Text = companyEntity.NumberOrderOnOutfit.ToString();
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using AutoKulturaDbContext dbContext = new();
                {
                    CompanyRepository cr = new(dbContext);

                    int t = await cr.Update(new CompanyEntity
                    {
                        Id = companyEntity.Id,
                        Name = TbName.Text,
                        Phone = TbPhone.Text,
                        Email = TbEmail.Text,
                        Adress = RtbAdress.Text,
                        Master = tbMaster.Text,
                        NumberOrderOnOutfit = Convert.ToInt32(TbNumberOrderOnOutfit.Text),
                        PathToFilesOrderOnOutfit = TbPath.Text
                    });
                    if (t > 0)
                        new formMessage($"Информация о компании \"{companyEntity.Name}\" изменена", "Изменение информации о компании", true).Show();
                    else
                        new formMessage($"Ошибка! Заполните все поля", "Изменение инфомрации о компании", false).Show();
                }

            }
            catch (Exception ex) { new formMessage(ex.Message, "Изменение информации о компании").Show(); }
        }

        private void Button1_Click(object sender, EventArgs e)
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
