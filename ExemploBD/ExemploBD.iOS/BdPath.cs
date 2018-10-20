using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExemploBD.iOS.BdPath))]
namespace ExemploBD.iOS
{
    public class BdPath : IDatabasePath
    {
        public string GetPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "dataBase.db3");
        }
    }
}
