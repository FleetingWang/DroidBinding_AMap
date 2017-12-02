using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Autonavi.AE.Search
{
    public class NativeSearchEngine: Java.Lang.Object
    {
        public NativeSearchEngine(IntPtr handle, JniHandleOwnership transfer):base(handle, transfer)
        {

        }
    }
}