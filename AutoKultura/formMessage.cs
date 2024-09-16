using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKultura
{
    public partial class formMessage : Form
    {
        readonly System.Windows.Forms.Timer timerHide = new();
        readonly bool closeIt = true;

        public formMessage(string fatalError, string action)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#ef798a");
            lblMessage.Text = "Сделайте скриншот ошибки и отправльте разработчику\n"  + fatalError;
            lblCaption.Text = "Непредвиденная оишбка программы при " + action;
            closeIt = false;
        }
        public formMessage(string message, string caption, bool successfully)
        {
            InitializeComponent();
            timerHide.Interval = 100;
            timerHide.Tick += TimerHide_Tick;

            lblMessage.Text = message;
            lblCaption.Text = caption;

            if (successfully)
            {
                this.BackColor = ColorTranslator.FromHtml("#ccf5ac");
            }
            else
            {
                closeIt = successfully;
                this.BackColor = ColorTranslator.FromHtml("#ef798a");
            }

            if (successfully)
            {
                this.Width = 700;
                this.Height = 100;
                this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - 100);


                timerHide.Start();
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }

        }

        private void TimerHide_Tick(object? sender, EventArgs e)
        {
            if (this.Opacity != 0)
            {
                this.Opacity -= 0.02;
            }
            else
            {
                timerHide.Stop();
                this.Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
            timerHide.Stop();
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            if (closeIt)
                timerHide.Start();
        }

        private void FormMessage_BackColorChanged(object sender, EventArgs e)
        {
            lblCaption.BackColor = this.BackColor;
            lblMessage.BackColor = this.BackColor;
        }
    }
}
