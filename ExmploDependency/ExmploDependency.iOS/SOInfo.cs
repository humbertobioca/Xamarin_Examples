using System;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExmploDependency.iOS.SOInfo))]

namespace ExmploDependency.iOS
{
    public class SOInfo : ISOInfo
    {
        public string GetInfo(){
            UIDevice device = new UIDevice();
            return device.Model;
        }
    }
}
