using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExemploBD.Droid.BdPath))]
namespace ExemploBD.Droid
{
    public class BdPath : IDatabasePath
    {
        public string GetPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "bancoDados.db3");
        }
    }
}
