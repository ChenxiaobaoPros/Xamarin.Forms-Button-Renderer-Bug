﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace MyApp.Droid {
	[Activity(Label = "MyApp", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity {
		protected override void OnCreate(Bundle bundle) {
			ToolbarResource = Resource.Layout.toolbar;
			TabLayoutResource = Resource.Layout.tabs;

			base.OnCreate(bundle);
			Forms.Init(this, bundle);
			LoadApplication(new App());
		}
	}
}

