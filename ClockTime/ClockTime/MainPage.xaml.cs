using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClockTime
{
    public partial class MainPage : ContentPage
    {
        bool time = false;
        DateTime dt = DateTime.Now;
        public MainPage()
        {
            InitializeComponent();

            timeLabel.Text = DateTime.Now.ToString("T");
            dateLabel.Text = DateTime.Now.ToString("D");

            Device.StartTimer(TimeSpan.FromSeconds(1), HandleFunc);
        }

        void BtnRelogio_Clicked(object sender, EventArgs e)
        {
            time = !time;
            btnRelogio.Text = time ? "Stop" : "Start";
            }

  
bool HandleFunc()
        {
            if (time)
            {
                timeLabel.Text = DateTime.Now.ToString("T");
            }

            return true;
        }
    }
}
