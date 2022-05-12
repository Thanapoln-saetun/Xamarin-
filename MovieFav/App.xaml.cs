using MovieFav.Services;
using MovieFav.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("mttregular.otf", Alias = "mttregular")]
[assembly: ExportFont("msregular.otf", Alias = "msregular")]
[assembly: ExportFont("moregular.otf", Alias = "moregular")]
[assembly: ExportFont("mrregular.otf", Alias = "mrregular")]

namespace MovieFav
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            DependencyService.Register<IDataStore<Models.Movie>, MovieDataStore>();
            MainPage = new AppShell()
            {
                BackgroundColor = Color.Black,  
            };
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));


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
