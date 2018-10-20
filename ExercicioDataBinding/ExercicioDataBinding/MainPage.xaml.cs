using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExercicioDataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void Handle_Completed(object sender, System.EventArgs e)
        {
            webView.Source = ((Entry)sender).Text; 
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.StyleId)
            {
                case "avancar":
                    webView.GoForward();
                    break;
                case "voltar":
                    webView.GoBack();
                    break;
            }
        }
    }
}
