using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using BestPracticesWebinar_Exercise_2;
using BestPracticesWebinar_Exercise_2.Android;

//TODO: Step 6 - Export Custom Renderer
//[assembly: ExportRenderer (typeof(CustomThemedEntry), typeof (CustomEntryRenderer))]

namespace BestPracticesWebinar_Exercise_2.Android
{
	//TODO: Step 5 - Create Custom Renderer
//	public class CustomEntryRenderer : EntryRenderer
//	{
//		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
//		{
//			base.OnElementChanged (e);
//			if (e.OldElement == null) {   // perform initial setup
//				// lets get a reference to the native control
//				var nativeTextField = (global::Android.Widget.EditText) Control;
//				// do whatever you want to the UITextField here!
//				nativeTextField.Gravity = global::Android.Views.GravityFlags.Center;
//				nativeTextField.SetTextColor(global::Android.Graphics.Color.White);
//			}
//		}
//	}
}