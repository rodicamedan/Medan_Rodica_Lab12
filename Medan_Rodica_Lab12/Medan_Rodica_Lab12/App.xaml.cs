using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Medan_Rodica_Lab12.Services;
using Medan_Rodica_Lab12.Views;
using Medan_Rodica_Lab12.Data;

namespace Medan_Rodica_Lab12
{
    public partial class App : Application
    {
        public 
            
            
            
            
            
            ShoppingListDatabase Database { get; private set; }
        public App()
        {
            InitializeComponent();
            Database = new ShoppingListDatabase(new RestService());
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            MainPage = new NavigationPage(new 
            ListEntryPage());
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
