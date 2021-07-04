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
using Archer.Library.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archer.Library.Abstract
{
    internal abstract class Cisim : PictureBox, IHareketEden
    {
        public Size HareketAlaniBoyutlari { get; }

        public int HareketMesafesi { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        protected Cisim(Size hareketAlaniBoyutlari)
        {
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
        }

        //gelen yon komutuna gore hareket ettirme fonklara yonlendirir
        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari:
                    return YukariHareketEttir();
                    break;
                case Yon.Asagi:
                    return AsagiHareketEttir();
                    break;
                case Yon.Sag:
                    return SagaHareketEttir();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }
        }

        //cismin kordinatlarını taşıyarak hareket ettirir
        private bool YukariHareketEttir()
        {
            if (Top == 0) return true;
            var yeniTop = Top - HareketMesafesi;
            var tasacakMi = yeniTop < 0;
            Top = tasacakMi ? 0 : yeniTop;

            return Top == 0;
        }

        //cismin kordinatlarını taşıyarak hareket ettirir
        protected virtual bool AsagiHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height) return true;
            var yeniBottom = Bottom + HareketMesafesi;
            var tasacakMi = yeniBottom > HareketAlaniBoyutlari.Height;
            Bottom = tasacakMi ? HareketAlaniBoyutlari.Height : yeniBottom;
            
            return Bottom == HareketAlaniBoyutlari.Height;
        }

        //cismin kordinatlarını taşıyarak hareket ettirir
        private bool SagaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;
            var yeniRight = Right + HareketMesafesi;
            var tasacakMi = yeniRight > HareketAlaniBoyutlari.Width;
            Right = tasacakMi ? HareketAlaniBoyutlari.Width : yeniRight;
           /* Left = right - Width;*/

            return Right == HareketAlaniBoyutlari.Width;

            /*var yeniRight = Right - HareketMesafesi;
            var tasacakMi = yeniRight < 0;
            Right = tasacakMi ? 0 : yeniRight;

            return Right == 0;*/
        }
    }
}