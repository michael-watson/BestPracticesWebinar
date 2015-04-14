using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BestPracticesWebinar_Exercise_1
{
	public class HopListViewPage : ContentPage
	{
		public HopDatabases hopDatabase = new HopDatabases();

		ListView hopsListView;

		public HopListViewPage()
		{
			List<Hops> hopsAvailable = hopDatabase.GetHops();

			hopsListView = new ListView() {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				ItemsSource = hopsAvailable,
				ItemTemplate = new DataTemplate(() => {
					//TODO: Step 1a - Provide Objects for DataTemplate
//					Label hopName = new Label();
//					hopName.SetBinding(Label.TextProperty,
//						new Binding("HopName", BindingMode.OneWay, null, null, "{0}"));
//					hopName.HorizontalOptions = LayoutOptions.Start;
//					hopName.VerticalOptions = LayoutOptions.CenterAndExpand;
//
//					Label aaPercentageLow = new Label();
//					aaPercentageLow.SetBinding (Label.TextProperty,
//						new Binding("AALow", BindingMode.OneWay, null, null, "{0}%"));
//					aaPercentageLow.HorizontalOptions = LayoutOptions.EndAndExpand;
//					aaPercentageLow.VerticalOptions = LayoutOptions.CenterAndExpand;

					return new ViewCell {
						View = new StackLayout {
							Orientation = StackOrientation.Horizontal,
							VerticalOptions = LayoutOptions.CenterAndExpand,
							Padding = new Thickness(5, 0, 10, 5),
							Spacing = 0,
							Children = {
								//TODO: Step 1b - Provide Objects to return ViewCell to DataTemplate
//								hopName,
//								aaPercentageLow
							}
						}
					};
				})
			};

			Content = hopsListView;
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			//TODO: Step 2 - Provide ItemSelected event for ListView
//			hopsListView.ItemSelected += HandleItemSelected;
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();

			//Always important to remove event handlers
			hopsListView.ItemSelected -= HandleItemSelected;
		}

		void HandleItemSelected(object sender, SelectedItemChangedEventArgs e) 
		{
			Hops selected = hopsListView.SelectedItem as Hops;
			DisplayAlert("Hop Selected",selected.HopName + " was selected","Ok","Cancel");
		}
	}
}