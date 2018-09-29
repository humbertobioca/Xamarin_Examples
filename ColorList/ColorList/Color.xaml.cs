using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ColorList
{
    public partial class Color : ContentView
    {
        public Color()
        {
            get{
                return lblNomeCor.Text;
            }
        }
    }
}
