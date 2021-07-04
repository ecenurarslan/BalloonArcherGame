using Archer.Library.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archer.Desktop
{
    public partial class Form1 : Form
    {
        private Oyun _oyun;
        public Form1(string username, int mevcutPuan, string archer)
        {
            InitializeComponent();
            //this.BackgroundImage = Image.FromFile(@"Gorseller\background.png");
            _oyun = new Oyun(okcuPanel, balonPanel, username, mevcutPuan, archer);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
            _oyun.PuanDegisti += Oyun_PuanDegisti;
            _oyun.OkSayisiDegisti += Oyun_OkSayisiDegisti;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;

                case Keys.Up:
                    _oyun.OkcuHareket(Library.Enum.Yon.Yukari);
                    break;

                case Keys.Down:
                    _oyun.OkcuHareket(Library.Enum.Yon.Asagi);
                    break;

                case Keys.Space:
                    _oyun.OkAt();
                    break;
            }
        }

        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            timeLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }


        private void Oyun_PuanDegisti(object sender, EventArgs e)
        {
            puanLabel.Text = _oyun.Puan.ToString(); 
        }

        private void Oyun_OkSayisiDegisti(object sender, EventArgs e)
        {
            if (_oyun.Level == 2)
            {
                okSayisiLabel.Text = _oyun.OkSayisi.ToString();
            }
            /*else
            {
                okSayisiLabel.Visible = true;
                kalanOkLabel.Visible = true;
            }*/ 
            
            
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
