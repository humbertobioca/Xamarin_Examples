using System;
using Xamarin.Forms;

namespace ButtonExample
{
    public class MainPage : ContentPage
    {
        StackLayout stackFilho;
        Button btnAdicionar, btnRemove;

        public MainPage()
        {
            stackFilho = new StackLayout 
            {
                VerticalOptions = LayoutOptions.Center
            };

            btnAdicionar = new Button
            {
                Text = "Adicionar Log"
            };

            btnRemove = new Button 
            {
                Text = "Remover"
            };

            btnAdicionar.Clicked += BtnAdicionar_Clicked;
            btnRemove.Clicked += BtnAdicionar_Clicked;

            Content = new StackLayout
            {
                Children =
                {
                        btnAdicionar,
                        btnRemove,
                        stackFilho

                }
            };
            this.Padding = 30;
        }

        void BtnAdicionar_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnAdicionar)
            {
                Label labelHora = new Label
                {
                    Text = DateTime.Now.ToLongTimeString(),
                    HorizontalTextAlignment = TextAlignment.Center
                };
                btnRemove.IsEnabled = true;
                stackFilho.Children.Add(labelHora);
            }
            else
            {
                stackFilho.Children.RemoveAt(0);
                btnRemove.IsEnabled = stackFilho.Children.Count > 0;
            }
        }
    }
}
