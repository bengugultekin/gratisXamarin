using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gratisXamarin.Models;

namespace gratisXamarin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Anasayfa, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Anasayfa:
                        MenuPages.Add(id, new NavigationPage(new Anasayfa()));
                        break;
                    case (int)MenuItemType.Makyaj:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.CiltBakim:
                        MenuPages.Add(id, new NavigationPage(new CiltBakım()));
                        break;
                    case (int)MenuItemType.SacBakim:
                        MenuPages.Add(id, new NavigationPage(new SacBakim()));
                        break;
                    case (int)MenuItemType.SaglikHijyen:
                        MenuPages.Add(id, new NavigationPage(new SaglikHijyen()));
                        break;
                    case (int)MenuItemType.ParfumDeodorant:
                        MenuPages.Add(id, new NavigationPage(new ParfumDeodorant()));
                        break;
                    case (int)MenuItemType.ErkekBakım:
                        MenuPages.Add(id, new NavigationPage(new ErkekBakim()));
                        break;
                    case (int)MenuItemType.EvYasam:
                        MenuPages.Add(id, new NavigationPage(new EvYasam()));
                        break;
                    case (int)MenuItemType.AnneBebek:
                        MenuPages.Add(id, new NavigationPage(new AnneBebek()));
                        break;
                    case (int)MenuItemType.OUTLET:
                        MenuPages.Add(id, new NavigationPage(new OUTLET()));
                        break;
                    case (int)MenuItemType.Trendler:
                        MenuPages.Add(id, new NavigationPage(new Trendler()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}