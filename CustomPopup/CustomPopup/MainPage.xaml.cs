using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace CustomPopup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //para mostrar resultado usar Navigation.ShowPopupAsync
         var result = Navigation.ShowPopupAsync(new MyPopUp() {  IsLightDismissEnabled = false }); //IsLightDismissEnabled evita que se cierre el popup al hacer tap fuera del popup
        }
    }
}
