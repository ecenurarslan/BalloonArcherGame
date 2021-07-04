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

namespace Archer.Library.Concrete
{
    internal class KirmiziBalon : Balon
    {
        public KirmiziBalon(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Image = Image.FromFile(@"Gorseller\red.png");
        }


        //kirmizi balon puanı sıfırladıgı icin vurulmaması durumunda oyunun bitmemesi adına
        //yere degme fonksiyonu override edildi. artik tavanı degene kadar iniyor
        protected override bool AsagiHareketEttir()
        {
            if (Top == HareketAlaniBoyutlari.Height) return true;
            var yeniTop = Top + HareketMesafesi;
            var tasacakMi = yeniTop > HareketAlaniBoyutlari.Height;
            Top = tasacakMi ? HareketAlaniBoyutlari.Height : yeniTop;

            return Top == HareketAlaniBoyutlari.Height;
        }
    }
}
