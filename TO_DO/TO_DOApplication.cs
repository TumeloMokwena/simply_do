using System;

using Android.App;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;
using TO_DO.ViewModels;

namespace TO_DO
{
    [Application]
    public class TO_DOApplication : MvxAppCompatApplication<MvxAppCompatSetup<App>, App>
    {
        public TO_DOApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}