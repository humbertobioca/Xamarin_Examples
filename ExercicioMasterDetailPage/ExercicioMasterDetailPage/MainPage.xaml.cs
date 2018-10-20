using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExercicioMasterDetailPage
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MasterPage.BtFotos.Clicked += Menu_Clicked;
            MasterPage.BtConfig.Clicked += Menu_Clicked;
            MasterPage.BtCalender.Clicked += Menu_Clicked;
        }

        void Menu_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            switch(bt.StyleId)
            {
                case "fotos":
                    this.Detail = new NavigationPage(new PhotosPage());
                    break;

                case "calendário":
                    this.Detail = new NavigationPage(new CalenderPage());
                    break;

                case "config":
                    this.Detail = new NavigationPage(new ConfigPage());
                    break;

            }
            this.IsPresented = false;
        }

    }
}
