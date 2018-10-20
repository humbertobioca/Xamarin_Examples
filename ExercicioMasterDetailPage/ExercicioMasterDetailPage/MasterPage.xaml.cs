using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExercicioMasterDetailPage
{
    public partial class MasterPage : ContentPage
    {
        public Button BtFotos{
            get{
                return btFotos;
            }
        }
        public Button BtCalender
        {
            get
            {
                return btCalender;
            }
        }
        public Button BtConfig
        {
            get
            {
                return btConfig;
            }
        }
        public MasterPage()
        {
            InitializeComponent();
        }
    }
}
