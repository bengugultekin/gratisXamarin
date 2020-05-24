using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using gratisXamarin.Views;
using gratisXamarin.Models;

namespace gratisXamarin.ViewModels
{
    public class UrunModel : BindableObject
    {
        private Page page;

        public UrunModel(Page page)
        {
            this.page = page;
            AddItems();
        }

        


        private void AddItems()
        {

            
            UrunItem urunItem = new UrunItem()
            {
                ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v6805097966330446824/products/10315475_01.jpg&height=300&width=300",
                UrunAdi = string.Format("HZR 3 Katlı Lastikli Medikal Yüz Maskesi 50'li"),
                UrunFiyati = string.Format("50,00 TL")
            };
            Items.Add(urunItem);

            UrunItem urunItem1 = new UrunItem()
            {
                ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v4901216926988382390/products/10034429_02.jpg&height=300&width=300",
                UrunAdi = string.Format("Life In Hindistan Cevizi Yağı 330 ml"),
                UrunFiyati = string.Format("42,00 TL")
            };
            Items.Add(urunItem1);

            UrunItem urunItem2 = new UrunItem()
            {
                ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v6385028666002545066/products/10128827_01.jpg&height=940&width=940",
                UrunAdi = string.Format("Beaulis Drag It Inkpen Keçe Uçlu Dipliner"),
                UrunFiyati = string.Format("21,00 TL")
            };
            Items.Add(urunItem2);
            UrunItem urunItem3 = new UrunItem()
            {
                ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v7621149558194319414/products/10173668_01.jpg&height=940&width=940",
                UrunAdi = string.Format("Loreal Paris Rouge Signature Likit Mat Ruj 106 I Speak up"),
                UrunFiyati = string.Format("79,75 TL")
            };
            Items.Add(urunItem3);
            UrunItem urunItem4 = new UrunItem()
            {
                ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v8687552266745074588/products/10078644_01.jpg&height=300&width=300",
                UrunAdi = string.Format("Rimmel London 60 Seconds Super Shine Oje 315 Queen Of Tarts"),
                UrunFiyati = string.Format("10,00 TL")
            };
            Items.Add(urunItem4);
            UrunItem urunItem5 = new UrunItem()
            {
                ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v2895812668346414086/products/10001019_01.jpg&height=300&width=300",
                UrunAdi = string.Format("Flormar Dipliner Black-Classic Likit"),
                UrunFiyati = string.Format("40,00 TL")
            };
            Items.Add(urunItem5);
            UrunItem urunItem6 = new UrunItem()
            {
                ImageSource = "https://www.gratis.com/lionesse-takma-tirnak-a-76/urun/10001856?sku=10001856",
                UrunAdi = string.Format("Lionesse Takma Tırnak A-76"),
                UrunFiyati = string.Format("26,00 TL")
            };
            Items.Add(urunItem6);
            UrunItem urunItem7 = new UrunItem()
            {
                ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v7225426011322643837/products/10022713_01.jpg&height=300&width=300",
                UrunAdi = string.Format("Loreal Paris Infaillible 34H Matte Fondöten 12 Natural Rose"),
                UrunFiyati = string.Format("36,00 TL")
            };
            Items.Add(urunItem7);
            


            /*for (int i = 0; i < 20; i++)
            {
                UrunItem urunItem = new UrunItem()
                {
                    ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v2869345890956149577/products/10284748_01.jpg&height=300&width=300",
                    UrunAdi = string.Format("UrunIsmi {0}", i),
                    UrunAciklamasi = string.Format("UrunDetayi {0}", i),
                    UrunFiyati = string.Format("UrunFiyati {0}", i)
                };

                Items.Add(urunItem);
            }*/
        }

        private ObservableCollection<UrunItem> _items = new ObservableCollection<UrunItem>();
        public ObservableCollection<UrunItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }
    }
}
