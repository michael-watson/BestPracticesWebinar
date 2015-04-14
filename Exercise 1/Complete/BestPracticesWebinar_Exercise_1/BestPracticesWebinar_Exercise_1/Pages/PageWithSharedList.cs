using System;

using Xamarin.Forms;

namespace BestPracticesWebinar_Exercise_1
{
	public class PageWithSharedList : ContentPage
	{
		HopListView hopListView;

		public PageWithSharedList()
		{
			//TODO: Step 3b - Create Shared ListView in ContentPage
			hopListView = new HopListView();

			//TODO: Step 3c - Set Content of Page to hopListView
			Content = hopListView;
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			//TODO: Step 4 - Provide ItemSelected event for ListView
			hopListView.ItemSelected += HandleItemSelected;
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();

			//Always important to remove event handlers
			hopListView.ItemSelected -= HandleItemSelected;
		}

		void HandleItemSelected(object sender, SelectedItemChangedEventArgs e) 
		{
			Hops selected = hopListView.SelectedItem as Hops;
			DisplayAlert("Hop Selected",selected.HopName + " was selected","Ok","Cancel");
		}
	}
}