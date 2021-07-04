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

using Archer.Library.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archer.Library.Interface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }
        int HareketMesafesi { get; }


        /// <summary>
        /// Cismi istenen yonde hareket ettirir
        /// </summary>
        /// <param name="yon"> hangi yonde hareket edeceği </param>
        /// <returns> Cisim duvara carparsa true dondurur. </returns>
        bool HareketEttir(Yon yon);
    }
}
