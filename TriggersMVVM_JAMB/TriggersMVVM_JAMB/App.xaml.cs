using System;
using TriggersMVVM_JAMB.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_JAMB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaCategoria();
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
