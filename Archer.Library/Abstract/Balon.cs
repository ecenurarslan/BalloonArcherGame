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



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Archer.Library.Concrete;

namespace Archer.Library.Abstract
{
    internal class Balon : Cisim
    {
        private static readonly Random Random = new Random();
      
         public Balon(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
         {
             Size = new System.Drawing.Size(86, 110);
             //SizeMode = PictureBoxSizeMode.StretchImage;

            HareketMesafesi = (int)(Height * .1);
           
            Left = Random.Next(20,hareketAlaniBoyutlari.Width-Width+1);

         }
        
        public Ok VurulduMu(List<Ok> oklar)
        {
             //oklar listesindeki her ok için vurulma durumu kontrolu
            foreach (var ok in oklar)
            {
                var vurulduMu = ok.Right >= Left && ok.Left < Right && ok.Top > Top && ok.Bottom < Bottom;
                if (vurulduMu) return ok; 
            }

            return null;
        }

    }
}
