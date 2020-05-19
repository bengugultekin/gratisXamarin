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
            for (int i = 0; i < 20; i++)
            {
                UrunItem urunItem = new UrunItem()
                {
                    ImageSource = "https://www.gratis.com/ccstore/v1/images/?source=/file/v2869345890956149577/products/10284748_01.jpg&height=300&width=300",
                    UrunAdi = string.Format("UrunIsmi {0}", i),
                    UrunAciklamasi = string.Format("UrunDetayi {0}", i),
                    UrunFiyati = string.Format("UrunFiyati {0}", i)
                };

                Items.Add(urunItem);
            }
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
