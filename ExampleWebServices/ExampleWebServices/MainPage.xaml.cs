using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExampleWebServices
{
    public partial class MainPage : ContentPage
    {
        WebRequest request;
        public MainPage()
        {
            InitializeComponent();

            Uri uri = new Uri("https://developer.xamarin.com/demo/stock.json");
            request = WebRequest.Create(uri);

            status.Text = "Carregando...";
            request.BeginGetResponse(HandleAsyncCallback, null);
        }

        void HandleAsyncCallback(IAsyncResult ar)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                Stream stream = request.EndGetResponse(ar).GetResponseStream();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ListagemFotos));

                ListagemFotos listagem = (ListagemFotos)serializer.ReadObject(stream);
                listaFotos.ItemsSource = listagem.Fotos;

                status.Text = "OK!";
            }); 
        }
    }
}
