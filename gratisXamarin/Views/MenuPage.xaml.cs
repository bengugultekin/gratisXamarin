using gratisXamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gratisXamarin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Anasayfa, Title="Anasayfa" },
                new HomeMenuItem {Id = MenuItemType.Makyaj, Title="Makyaj" },
                new HomeMenuItem {Id = MenuItemType.CiltBakim, Title="Cilt Bakım" },
                new HomeMenuItem {Id = MenuItemType.SacBakim, Title="Saç Bakım" },
                new HomeMenuItem {Id = MenuItemType.SaglikHijyen, Title="Sağlık-Hijyen" },
                new HomeMenuItem {Id = MenuItemType.ParfumDeodorant, Title="Parfüm-Deodorant" },
                new HomeMenuItem {Id = MenuItemType.ErkekBakım, Title="Erkek Bakım" },
                new HomeMenuItem {Id = MenuItemType.EvYasam, Title="Ev-Yaşam" },
                new HomeMenuItem {Id = MenuItemType.AnneBebek, Title="Anne-Bebek" },
                new HomeMenuItem {Id = MenuItemType.OUTLET, Title="OUTLET" },
                new HomeMenuItem {Id = MenuItemType.Trendler, Title="Trendler" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}