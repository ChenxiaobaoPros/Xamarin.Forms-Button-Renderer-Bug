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

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using MyApp.CustomControls;
using MyApp.Droid.Renderer;

[assembly: ExportRenderer(typeof(CustomButton), typeof(MyButtonRenderer))]
namespace MyApp.Droid.Renderer {
	public class MyButtonRenderer : ButtonRenderer { }
}