using System;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExemploBD
{
    public partial class App : Application
    {
        static SQLiteConnection _bd;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static SQLiteConnection BD{
            get {
                if (_bd == null){
                    string path = DependencyService.Get<IDatabasePath>().GetPath();
                    _bd = new SQLiteConnection(path);
                    _bd.CreateTable<Aluno>();
                }
                return _bd;
            }
        }
    }
}
