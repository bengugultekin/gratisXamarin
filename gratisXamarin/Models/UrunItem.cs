using System;
using System.Collections.Generic;
using System.Text;

namespace gratisXamarin.Models
{
    public class UrunItem
    {
        private string image;

        public string ImageSource
        {
            get { return image; }
            set { image = value; }
        }

        private string urunAdi;
        
        public string UrunAdi
        {
            get { return urunAdi; }
            set { urunAdi = value; }
        }

        private string urunAciklamasi;

        public string UrunAciklamasi
        {
            get { return urunAciklamasi; }
            set { urunAciklamasi = value; }
        }

        private string urunFiyati;

        public string UrunFiyati
        {
            get { return urunFiyati; }
            set { urunFiyati = value; }
        }
    }
}
