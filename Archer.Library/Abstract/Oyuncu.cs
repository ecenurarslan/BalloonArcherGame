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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archer.Library.Abstract
{
    internal abstract class Oyuncu
    {
        public string UserName { get;  }

        public int MevcutPuan { get;  }

        public string OkcuAdi { get;  }
    }
}
