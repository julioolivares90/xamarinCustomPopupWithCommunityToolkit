using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopUp : Popup
    {
        public MyPopUp()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);

            //para retornar algo a la otra page se utiliza Dismiss(aqui objeto que se quiere devolver)
        }
    }
}