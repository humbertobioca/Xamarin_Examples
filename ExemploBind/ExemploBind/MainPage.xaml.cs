using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploBind
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Label lblNovo = new Label();
            lblNovo.TextColor = Color.Red;
            lblNovo.HorizontalOptions = LayoutOptions.Center;

            lblNovo.BindingContext = slider;
            lblNovo.SetBinding(Label.TextProperty, "Value");

            BoxView bx = new BoxView();
            bx.Color = Color.Green;

            bx.SetBinding(BoxView.OpacityProperty, new Binding
            {
                Source = slider,
                Path = "Value"
            });


            stack.Children.Add(lblNovo);
            stack.Children.Add(bx);
        }
    }
}
