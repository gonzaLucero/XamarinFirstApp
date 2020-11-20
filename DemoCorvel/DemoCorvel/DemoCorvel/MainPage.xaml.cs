using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoCorvel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            myLabel.Text = string.Format("Presioné {0} veces", count);
            this.DisplayAlert("Hola", "Mundo!", "Aceptar");
        }
    }
}
