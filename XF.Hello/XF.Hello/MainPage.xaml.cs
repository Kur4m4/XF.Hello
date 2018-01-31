using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Hello
{
	public partial class MainPage : ContentPage
	{
        ConfigData configData;

        public MainPage()
        {
            InitializeComponent();

            if (configData == null)
                configData = new ConfigData();
        }

        private void EnviarEmail(object sender, EventArgs e)
        {
            if (configData.SwtEmail)
                DisplayAlert("Mensagem", string.Format("E-mail enviado para {0}", configData.Email), "OK");
            else
                DisplayAlert("Mensagem", "E-mail não autorizado", "OK");
        }

        private void BtnConfig_Clicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ConfigPage() { BindingContext = configData });
        }
    }
}
