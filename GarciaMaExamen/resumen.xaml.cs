using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GarciaMaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resumen : ContentPage
    {
        public resumen(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtUsuario.Text = usuario;

        }



        private void btnVer_Clicked(object sender, EventArgs e)
        {
            txtFinal.Text = txtFinal.Text;
        }
    }
}