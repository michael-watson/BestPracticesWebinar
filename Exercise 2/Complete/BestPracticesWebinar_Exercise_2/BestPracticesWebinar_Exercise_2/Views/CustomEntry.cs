using System;

using Xamarin.Forms;

namespace BestPracticesWebinar_Exercise_2
{
	public class CustomThemedEntry : Entry
	{
		public CustomThemedEntry ()
		{
			//TODO: Step 2 - Set properties for Entry
			Placeholder = "0";
			BackgroundColor = Color.Gray;
			Keyboard = Keyboard.Numeric;
		}
	}
}