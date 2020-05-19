using gratisXamarin.ViewModels;
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
        UrunModel urunModel;
        public Anasayfa()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
            {
                "https://www.gratis.com/file/general/pldus1a1b_insert_1105.jpg",
                "https://www.gratis.com//file/general/bedavakargo_1824_1805.jpg",
                "https://www.gratis.com/file/general/60indirim_generic_1702.jpg",
                "https://www.gratis.com/file/general/genel_rbayram_1105.png",
                "https://www.gratis.com/file/general/maxipuan_31may_1105.jpg",
                "https://www.gratis.com/file/general/solingen_1824_1805.jpg",
                "https://www.gratis.com/file/general/sac_rbayram_1105.png",
                "https://www.gratis.com/file/general/oyuncak_konsept_1805.jpg"
            };

            indirimkampanyalaricarousel.ItemsSource = CarouselItems;
            urunModel = new UrunModel(this);
            BindingContext = urunModel;
        }
    }
}