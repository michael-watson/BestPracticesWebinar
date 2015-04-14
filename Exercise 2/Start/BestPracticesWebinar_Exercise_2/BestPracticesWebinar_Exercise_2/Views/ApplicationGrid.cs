using System;

using Xamarin.Forms;

namespace BestPracticesWebinar_Exercise_2
{
	public class ApplicationGrid : Grid
	{
		public ApplicationGrid ()
		{
			ColumnDefinitions.Add(new ColumnDefinition () {
				Width = new GridLength(2,GridUnitType.Star)
			});
			ColumnDefinitions.Add(new ColumnDefinition () {
				Width = new GridLength(1,GridUnitType.Star)
			});

			RowDefinitions.Add(new RowDefinition {
				Height = new GridLength((double)(App.ScreenHeight * 0.05))
			});
			RowDefinitions.Add(new RowDefinition {
				Height = new GridLength((double)(App.ScreenHeight * 0.1))
			});
			RowDefinitions.Add(new RowDefinition {
				Height = new GridLength((double)(App.ScreenHeight * 0.1))
			});
			RowDefinitions.Add(new RowDefinition {
				Height = new GridLength((double)(App.ScreenHeight * 0.1))
			});
			RowDefinitions.Add(new RowDefinition {
				Height = new GridLength((double)(App.ScreenHeight * 0.1))
			});

			//TODO: Step 3 - Comment out Forms Objects
			Children.Add (new Label (){ Text = "Product" }, 0, 0);
			Children.Add (new Label (){ Text = "Quantity" }, 1, 0);
			Children.Add (new Label (){ Text = "Cliff Bars" }, 0, 1);
			Children.Add (new Entry (){ Placeholder = "0" }, 1,1);
			Children.Add (new Label (){ Text = "Fruit Snack Packs" }, 0, 2);
			Children.Add (new Entry (){ Placeholder = "0" }, 1,2);
			Children.Add (new Label (){ Text = "Juice Box" }, 0, 3);
			Children.Add (new Entry (){ Placeholder = "0" }, 1,3);
			Children.Add (new Label (){ Text = "Apple" }, 0, 4);
			Children.Add (new Entry (){ Placeholder = "0" }, 1,4);

			//TODO: Step 4 - Utilize Custom Elements 
//			Children.Add (new CustomLabel (){ Text = "Product" }, 0, 0);
//			Children.Add (new CustomLabel (){ Text = "Quantity" }, 1, 0);
//			Children.Add (new CustomLabel (){ Text = "Cliff Bars" }, 0, 1);
//			Children.Add (new CustomThemedEntry (){ Placeholder = "0" }, 1,1);
//			Children.Add (new CustomLabel (){ Text = "Fruit Snack Packs" }, 0, 2);
//			Children.Add (new CustomThemedEntry (){ Placeholder = "0" }, 1,2);
//			Children.Add (new CustomLabel (){ Text = "Juice Box" }, 0, 3);
//			Children.Add (new CustomThemedEntry (){ Placeholder = "0" }, 1,3);
//			Children.Add (new CustomLabel (){ Text = "Apple" }, 0, 4);
//			Children.Add (new CustomThemedEntry (){ Placeholder = "0" }, 1,4);
		}
	}
}