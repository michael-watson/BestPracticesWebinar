using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BestPracticesWebinar_Exercise_1
{
	//TODO: Step 3a - Create Shared ListView 
	public class HopListView : ListView
	{
//		//Create a new Hop Database
//		public HopDatabases hopDatabase = new HopDatabases();
//
//		public HopListView()
//		{
//			//Get a list of all the hops from the Hop Database
//			List<Hops> hopsAvailable = hopDatabase.GetHops();
//
//			//Create layout options for ListView to expand entire page
//			HorizontalOptions = LayoutOptions.FillAndExpand;
//			VerticalOptions = LayoutOptions.FillAndExpand;
//
//			//Set ItemSource to list of hops
//			ItemsSource = hopsAvailable;
//
//			//Set ItemTemplate
//			ItemTemplate = new DataTemplate(() => {
//				Label hopName = new Label();
//				hopName.SetBinding(Label.TextProperty,
//					new Binding("HopName", BindingMode.OneWay, null, null, "{0}"));
//				hopName.HorizontalOptions = LayoutOptions.Start;
//				hopName.VerticalOptions = LayoutOptions.CenterAndExpand;
//
//				Label aaPercentageLow = new Label();
//				aaPercentageLow.SetBinding(Label.TextProperty,
//					new Binding("AALow", BindingMode.OneWay, null, null, "{0}%"));
//				aaPercentageLow.HorizontalOptions = LayoutOptions.EndAndExpand;
//				aaPercentageLow.VerticalOptions = LayoutOptions.CenterAndExpand;
//
//				//Return ViewCell for DataTemplate. This ViewCell will be a single row in the ListView
//				return new ViewCell {
//					//Use a StackLayout to 
//					View = new StackLayout {
//						Orientation = StackOrientation.Horizontal,
//						VerticalOptions = LayoutOptions.CenterAndExpand,
//						Padding = new Thickness(5, 0, 10, 5),
//						Spacing = 0,
//						Children = {
//							hopName,
//							aaPercentageLow
//						}
//					}
//				};
//			});
//
//		}
	}
}