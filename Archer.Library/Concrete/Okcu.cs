/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:    1
**				ÖĞRENCİ ADI............:    Ece Nur Arslan
**				ÖĞRENCİ NUMARASI.......:    B171210061
**              DERSİN ALINDIĞI GRUP...:    1A
****************************************************************************/

using Archer.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archer.Library.Concrete
{
    internal class Okcu : Cisim
    {
        public Okcu(int panelYuksekligi, Size hareketAlaniBoyutlari, string archer) : base(hareketAlaniBoyutlari)
        {
            //kullanıcının sectigi okcunun okunu ayarlamak icin
            if(archer == "centaur")
            {
                Image = Image.FromFile(@"Gorseller\centaur.png");
            }
            else Image = Image.FromFile(@"Gorseller\cupid.png");

            Size = new System.Drawing.Size(156, 130);
            //SizeMode = PictureBoxSizeMode.StretchImage;
            Middle = panelYuksekligi/2;
            HareketMesafesi = Height/3;
        }
    }
}
