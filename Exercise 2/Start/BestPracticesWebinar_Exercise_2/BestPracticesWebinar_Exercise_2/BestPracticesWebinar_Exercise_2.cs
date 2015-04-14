using System;

using Xamarin.Forms;

namespace BestPracticesWebinar_Exercise_2
{
	public class App : Application
	{
		//Create variables for ScreenHeight and ScreenWidth
		//Check the AppDelegate.cs (iOS) and MainActivity.cs (Android) files for implementation

		public static int ScreenHeight;
		public static int ScreenWidth;

		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Padding = Device.OnPlatform(20,0,0),
				Content = new ApplicationGrid()
			};
		}
	}
}