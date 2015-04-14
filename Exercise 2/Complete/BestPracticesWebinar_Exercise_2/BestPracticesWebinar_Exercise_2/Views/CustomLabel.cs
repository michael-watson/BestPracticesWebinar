using System;

using Xamarin.Forms;

namespace BestPracticesWebinar_Exercise_2
{
	public class CustomLabel : Label
	{
		public CustomLabel(){
			//TODO: Step 1 - Set properties for Label
			TextColor = Color.Blue;
			FontSize = Device.OnPlatform (
				Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
				Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
				Device.GetNamedSize (NamedSize.Medium, typeof(Label))
			);
			FontFamily = Device.OnPlatform (
				iOS:      "MarkerFelt-Thin",
				Android:  "Droid Sans Mono",
				WinPhone: "Comic Sans MS"
			);
			MinimumHeightRequest = 20;
		}
	}
}