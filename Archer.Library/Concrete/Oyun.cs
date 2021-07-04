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

using Archer.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archer.Library.Enum;
using System.Windows.Forms;
using System.Drawing;
using Archer.Library.Abstract;
using System.Globalization;
using System.IO;

namespace Archer.Library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar
        private Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private Timer _hareketTimer = new Timer { Interval = 100 };
        private Timer _puanTimer = new Timer { Interval = 100 };
        private Timer _okSayisiTimer = new Timer { Interval = 100 };
        private Timer _balonOlusturmaTimer = new Timer { Interval = 3000 };
        private TimeSpan _gecenSure;
        private int _puan;
        private string _archer;
        private string _username;
        private int _okSayisi;
        private readonly Panel _okcuPanel;
        private readonly Panel _balonPanel;
        private Okcu _okcu;
        private readonly List<Ok> _oklar = new List<Ok>();
        private readonly List<YesilBalon> _yesilBalonlar = new List<YesilBalon>();
        private readonly List<SariBalon> _sariBalonlar = new List<SariBalon>();
        private readonly List<KirmiziBalon> _kirmiziBalonlar = new List<KirmiziBalon>();
       
        #endregion


        #region Olaylar
        public event EventHandler GecenSureDegisti;
        public event EventHandler PuanDegisti;
        public event EventHandler OkSayisiDegisti;
        #endregion

        #region Ozellikler
        public bool DevamEdiyorMu { get; private set; }
        public int Level { get; private set; }
        public int YesilBalonSayisi { get; private set; }
        public int SariBalonSayisi { get; private set; }
        public int KirmiziBalonSayisi { get; private set; }
        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;
                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }
        

        public int Puan 
        { 
            get => _puan; 
            private set
            {
                _puan = value;
                PuanDegisti?.Invoke(this, EventArgs.Empty); 
            }
        }

        public int OkSayisi
        {
            get => _okSayisi;
            private set
            {
                _okSayisi = value;
                OkSayisiDegisti?.Invoke(this, EventArgs.Empty);
            }
        }



        
        #endregion

        #region Metotlar

        public Oyun(Panel okcuPanel, Panel balonPanel, string username, int mevcutPuan, string archer)
        {
            _okcuPanel = okcuPanel;
            _balonPanel = balonPanel;
            _puan = mevcutPuan;
            _username = username;
            _archer = archer;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _puanTimer.Tick += PuanTimer_Tick;
            _okSayisiTimer.Tick += OkSayisiTimer_Tick;
            _balonOlusturmaTimer.Tick += BalonOlusturmaTimer_Tick;  
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
           
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            OklariHareketEttir();
            YesilBalonlariHareketEttir();
            SariBalonlariHareketEttir();
            KirmiziBalonlariHareketEttir();
            YesilBalonVurulunca();
            SariBalonVurulunca();
            KirmiziBalonVurulunca();

        }
        
        private void PuanTimer_Tick(object sender, EventArgs e)
        {
            Puan = this.Puan;

        }

        private void OkSayisiTimer_Tick(object sender, EventArgs e)
        {   

            OkSayisi = this.OkSayisi;

        }

        private void YesilBalonVurulunca()
        {
            //yesil balonlar icinde gezer vurulanı cikarir
            for (var i = _yesilBalonlar.Count - 1; i >= 0; i--)
            {
                var balon = _yesilBalonlar[i];
                var vuranOk = balon.VurulduMu(_oklar);
                if (vuranOk is null) continue;
                _yesilBalonlar.Remove(balon);
                _balonPanel.Controls.Remove(balon);
                Puan = Puan + 5; 
                _oklar.Remove(vuranOk);
                _balonPanel.Controls.Remove(vuranOk);

            }
        }


        private void SariBalonVurulunca()
        {
            //sari balonlar icinde gezer vurulanı cikarir
            for (var i = _sariBalonlar.Count - 1; i >= 0; i--)
            {
                var balon = _sariBalonlar[i];
                var vuranOk = balon.VurulduMu(_oklar);
                if (vuranOk is null) continue;
                _sariBalonlar.Remove(balon);
                _balonPanel.Controls.Remove(balon);
                Puan = Puan + 15;
                _oklar.Remove(vuranOk);
                _balonPanel.Controls.Remove(vuranOk);

            }
        }

       
        private void KirmiziBalonVurulunca()
        {
            //kirmizi balonlar icinde gezer vurulanı cikarir
            for (var i = _kirmiziBalonlar.Count - 1; i >= 0; i--)
            {
                var balon = _kirmiziBalonlar[i];
                
                var vuranOk = balon.VurulduMu(_oklar);
                if (vuranOk is null) continue;
                _kirmiziBalonlar.Remove(balon);
                _balonPanel.Controls.Remove(balon);
                Puan = 0;
                _oklar.Remove(vuranOk);
                _balonPanel.Controls.Remove(vuranOk);

            }
        }

        private void BalonOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            //ilk levelde buraya girer
            if (Level == 0)
            {
                if (YesilBalonSayisi < 20) 
                {
                    YesilBalonOlustur();
                    YesilBalonSayisi++;
                }

                else
                {
                    //level geregi tamamlanınca leveli arttırır
                    Level = 1;
                    YesilBalonSayisi = 0;
                }

            }

            if (Level == 1) //ikinci levelde buraya girer
            {
                _hareketTimer.Interval = 75;
                if (SariBalonSayisi <= YesilBalonSayisi * 3 / 10 || Puan < 200)  
                {
                    Random rastgele = new Random();
                    int renkSecici = rastgele.Next(0, 2);
                    if (renkSecici == 0)
                    {
                        YesilBalonOlustur();
                        YesilBalonSayisi++;
                    }

                    else
                    {
                        SariBalonOlustur();
                        SariBalonSayisi++;
                    }

                }

                else
                {
                    Level = 2;
                    YesilBalonSayisi = 0;
                    SariBalonSayisi = 0;
                }

            }

            if (Level == 2) // ucuncu levelde buraya girer
            {
                _hareketTimer.Interval = 50;

                //sarı - yesil balon oranının gerekliliğini saglar
                if (SariBalonSayisi > YesilBalonSayisi * 2 / 10 && KirmiziBalonSayisi > YesilBalonSayisi * 2 / 10 && YesilBalonSayisi >= 20)
                {
                    if((_sariBalonlar != null) && !(_sariBalonlar.Any()) & !(_yesilBalonlar == null) && !(_yesilBalonlar.Any()) & !(_kirmiziBalonlar == null) && !(_kirmiziBalonlar.Any()))
                    Bitir();
                    return;
                }

                bool olusturulmadi = true;


                while (olusturulmadi) // rand fonksiyonu yuzunden balon olusturulamamama ihtimaline karsı olusturana kadar dener
                {

                    Random rastgele = new Random();
                    int renkSecici = rastgele.Next(0, 2);
                    

                    if (SariBalonSayisi <= YesilBalonSayisi * 2 / 10 || renkSecici == 0) //oran sartını saglamak icin
                    {
                        int renkSec = rastgele.Next(0, 2);
                        if (renkSec == 0)
                        {
                            YesilBalonOlustur();
                            YesilBalonSayisi++;
                            olusturulmadi = false;
                            return;
                        }

                        else
                        {
                            SariBalonOlustur();
                            SariBalonSayisi++;
                            olusturulmadi = false;
                            return;
                        }
           
                    }

                    if (KirmiziBalonSayisi <= YesilBalonSayisi * 2 / 10 || renkSecici == 1) //oran sartini saglamak icin
                    {
                        int renkSec = rastgele.Next(0, 2);
                        if (renkSec == 0)
                        {
                            KirmiziBalonOlustur();
                            KirmiziBalonSayisi++;
                            olusturulmadi = false;
                            return;
                        }

                        else
                        {
                            YesilBalonOlustur();
                            YesilBalonSayisi++;
                            olusturulmadi = false;
                            return;
                        }

                    }



                }



            }

        }

        private void YesilBalonlariHareketEttir()
        {
            //her balonu carpmadiysa hareket ettirir
            foreach (var balon in _yesilBalonlar)
            {
                var carptiMi = balon.HareketEttir(Yon.Asagi);
                if (!carptiMi) continue;
                Bitir();
                break;
            }
        }

        private void SariBalonlariHareketEttir()
        {
            foreach (var balon in _sariBalonlar)
            {
                var carptiMi = balon.HareketEttir(Yon.Asagi);
                if (!carptiMi) continue;
                Bitir();
                break;
            }
        }

        private void KirmiziBalonlariHareketEttir()
        {
            foreach (var balon in _kirmiziBalonlar)
            {
                var carptiMi = balon.HareketEttir(Yon.Asagi);
                if (!carptiMi) continue;
                //Bitir();
                _kirmiziBalonlar.Remove(balon);
                _balonPanel.Controls.Remove(balon);
                break;
            }
        }


        private void OklariHareketEttir()
        {
            //her oku carpmadiysa hareket ettirir
            for (int i = _oklar.Count - 1; i >= 0; i--)
            {
                var ok = _oklar[i];
                var carptiMi = ok.HareketEttir(Yon.Sag);
                if (carptiMi)
                {
                    _oklar.Remove(ok);
                    _balonPanel.Controls.Remove(ok);
                }
            }

        }

        public void Baslat()
        {
            //oyunu baslatir
            Level = 0;
            OkSayisi = 51;
            if (DevamEdiyorMu) return;
            DevamEdiyorMu = true;
            ZamanlayicilariBaslat();
            OkcuOlustur();

        }

        private void YesilBalonOlustur()
        {
            var yesilBalon = new YesilBalon(_balonPanel.Size);
            _yesilBalonlar.Add(yesilBalon);
            _balonPanel.Controls.Add(yesilBalon);


        }

        private void SariBalonOlustur()
        {
            var sariBalon = new SariBalon(_balonPanel.Size);
            _sariBalonlar.Add(sariBalon);
            _balonPanel.Controls.Add(sariBalon);


        }

        private void KirmiziBalonOlustur()
        {
            var kirmiziBalon = new KirmiziBalon(_balonPanel.Size);
            _kirmiziBalonlar.Add(kirmiziBalon);
            _balonPanel.Controls.Add(kirmiziBalon);


        }
        
        private void ZamanlayicilariBaslat()
        {
            _gecenSureTimer.Start();
            _hareketTimer.Start();
            _balonOlusturmaTimer.Start();
            _puanTimer.Start(); 
        }

        private void ZamanlayicilariDurdur()
        {
            _gecenSureTimer.Stop();
            _balonOlusturmaTimer.Stop();
            _hareketTimer.Stop();
            _puanTimer.Stop();
        }

        private void OkcuOlustur()
        {
            _okcu = new Okcu(_okcuPanel.Height, _okcuPanel.Size, _archer);
            _okcuPanel.Controls.Add(_okcu);

        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;
            DevamEdiyorMu = false;
            ZamanlayicilariDurdur();
            string yeni = _username + " " + Puan  +" "+ _archer;
            string line;
            string eski = "";

            //username ile baslayan satiri al dosyayi tarayip. eski' e al

            System.IO.StreamReader file = new System.IO.StreamReader(@"Kayitlar\kayit.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(_username + " "))
                {
                    eski = line;
                }
            }
            file.Close();
            string text = File.ReadAllText(@"Kayitlar\kayit.txt");
            text = text.Replace(eski, yeni);

            System.IO.StreamWriter file2 = new System.IO.StreamWriter(@"Kayitlar\kayit.txt");
            file2.Write(text);
            file2.Close();

               

            MessageBox.Show("GAME OVER");

        }

        public void OkcuHareket(Yon yon)
        {
            //oyun durmuşsa çalışmasın diye
            if (!DevamEdiyorMu) return;
            _okcu.HareketEttir(yon);
        }

        public void OkAt()
        {
            //oyun durmuşsa çalışmasın diye
            if (!DevamEdiyorMu) return;
            if (Level == 2 && OkSayisi > 0)
            {
                OkSayisi--;
                var ok = new Ok(_balonPanel.Size, _okcu.Middle, _archer);
                _balonPanel.Controls.Add(ok);
                _oklar.Add(ok);
            }

            if(Level != 2)
            {
                var ok = new Ok(_balonPanel.Size, _okcu.Middle, _archer);
                _balonPanel.Controls.Add(ok);
                _oklar.Add(ok);
            }
           
        }

        #endregion
    }
}
