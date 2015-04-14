using System;

using Xamarin.Forms;

namespace BestPracticesWebinar_Exercise_1
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new HopListViewPage();

			//TODO: Step 5 - Return Page with Shared ListView
//			MainPage = new PageWithSharedList ();
		}
	}
} 