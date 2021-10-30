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
    public partial class registro : ContentPage
    {
        public registro(string usuario)
        {

            InitializeComponent();
            lblUsuario.Text = usuario;
            
        }



        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                
                string usuario = txtUsuario.Text;
                

             
                await Navigation.PushAsync(new resumen(usuario));


                await DisplayAlert("Exito", "Datos Guardados correctamente", "oK");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double cuotain = Convert.ToDouble(txtMonto.Text);


               
                double cuotas = ((1800 - cuotain) / 3);
                double cuota = cuotas * 0.05;

                double final = cuotas + cuota;


             

                txtFinal.Text = final.ToString();


            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje De Alerta", ex.Message, "Salir");
            }


        }
    }
}