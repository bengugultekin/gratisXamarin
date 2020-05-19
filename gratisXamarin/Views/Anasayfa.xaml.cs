using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gratisXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public Anasayfa()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
            {
                "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/2020_nisan/ensuper-mob-min.jpg",
                "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/2020_mayis/fiba-mob-3-min.jpg"
            };

            indirimkampanyalaricarousel.ItemsSource = CarouselItems;
        }
    }
}