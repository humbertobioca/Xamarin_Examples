using System;
using Android.OS;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExmploDependency.Droid.SOInfo))]
namespace ExmploDependency.Droid
{
    public class SOInfo : ISOInfo
    {
        public string GetInfo(){
            return Build.Manufacturer;
        }
    }
}
