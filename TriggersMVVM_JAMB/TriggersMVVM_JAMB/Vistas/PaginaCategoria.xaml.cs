using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggersMVVM_JAMB.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_JAMB.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCategoria : ContentPage
    {
        public PaginaCategoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}