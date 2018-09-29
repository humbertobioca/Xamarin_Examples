using System;
using Xamarin.Forms;

namespace TextExemple
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Label texto = new Label();

            texto.VerticalOptions = LayoutOptions.Center;
            texto.HorizontalOptions = LayoutOptions.Center;
            texto.HorizontalTextAlignment = TextAlignment.Center;

            FormattedString colecao = new FormattedString();
            colecao.Spans.Add(new Span
            {
                Text = "Este Curso de "
            });

            colecao.Spans.Add(new Span
            {
                Text = "Desenvolvimento com Xamarin ",
                FontAttributes = FontAttributes.Bold,
                ForegroundColor = Color.Red
            });

            colecao.Spans.Add(new Span
            {
                Text = "é muito bacana!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Italic
            });

            texto.FormattedText = colecao;

            this.Content = texto;
            this.Padding = 30;


        }
    }
}
