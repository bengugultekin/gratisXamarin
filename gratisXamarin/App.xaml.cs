using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using gratisXamarin.Services;
using gratisXamarin.Views;
using DLToolkit.Forms.Controls;

namespace gratisXamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
