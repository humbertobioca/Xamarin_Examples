using System;
using System.Reflection;
using OpenTK;
using Xamarin.Forms;

namespace ColorsExamples
{
    public class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            StackLayout stack = new StackLayout
            {
                Spacing = 10,
                Padding = 20
            };
            ScrollView scroll = new ScrollView{};

            foreach(FieldInfo item in typeof(Color).GetRuntimeFields()){
                if (item.IsPublic && item.IsStatic && item.FieldType == typeof(Color)){

                    Color cor = (Color)item.GetValue(null);

                    BoxView box = new BoxView { 
                    
                        Color = cor
                    };

                    Frame frame = new Frame
                    {

                        Padding = 10
                    };

                    StackLayout layoutInterno = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal
                    };

                    Label labelCor = new Label
                    {
                        Text = item.Name,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    };
                    Label infoCor = new Label
                    {
                        Text = String.Format("#{0:X2}{1:X2}{2:X2}", (int)cor.R * 255, (int)cor.G * 255, (int)cor.B * 255),
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                        HorizontalOptions = LayoutOptions.EndAndExpand
                    };

                    layoutInterno.Children.Add(box);
                    layoutInterno.Children.Add(labelCor);
                    layoutInterno.Children.Add(infoCor);

                    frame.Content = layoutInterno;

                    stack.Children.Add(frame);
                }
            }
            scroll.Content = stack;
            this.Content = scroll;
            this.Padding = 10;
    }
    }
}