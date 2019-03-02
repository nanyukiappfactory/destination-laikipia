using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DestinationLaikipia.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dashboard : ContentPage
	{
		public Dashboard ()
		{
			InitializeComponent ();

            Dashborad_Images();

            Wildlife_TapGesture();
			Accommodation_TapGesture();
			Events_TapGesture();
            Shopping_Center_TapGesture();
            Investments_TapGesture();
            CarHire_TapGesture();
		}

        // Displays the images on the Dashboard page
        public void Dashborad_Images()
        {
            dashboard_wildlife_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.rhino.webp");
            dashboard_shopping_center_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.shopping_mall.webp");
            dashboard_investments_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.money.webp");
            dashboard_accommodation_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.hotel.webp");
            dashboard_events_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.people.webp");
            dashboard_carhire_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.car_image.webp");
        }

		// Code that navigates to wildlife page when icon is tapped
		public void Wildlife_TapGesture()
		{          
			var wildlife_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            wildlife_tap.Tapped += (s, e) =>
			{
                // Page navigation
                Navigation.PushAsync(new Wildlife());
			};
			dashboard_wildlife_image.GestureRecognizers.Add(wildlife_tap);
		}

		// Code that navigates to accommodation page when image is tapped
		public void Accommodation_TapGesture()
		{
			var accommodation_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            accommodation_tap.Tapped += (s, e) =>
			{
                // Page navigation
                Navigation.PushAsync(new Accommodation());
			};
			dashboard_accommodation_image.GestureRecognizers.Add(accommodation_tap);
		}

		// Code that navigates to events page when image is tapped
		public void Events_TapGesture()
		{
			var events_tap = new TapGestureRecognizer();
			
            //Tap Gesture Event
            events_tap.Tapped += (s, e) =>
			{
				// Page navigation
				Navigation.PushAsync(new Events());
			};
			dashboard_events_image.GestureRecognizers.Add(events_tap);
		}

        // Code that navigates to shopping center page when image is tapped
        public void Shopping_Center_TapGesture()
        {
            var wildlife_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            wildlife_tap.Tapped += (s, e) =>
            {
                // Page navigation
                Navigation.PushAsync(new ShoppingCenter());
            };
            dashboard_shopping_center_image.GestureRecognizers.Add(wildlife_tap);
        }

        // Code that navigates to investments page when image is tapped
        public void Investments_TapGesture()
        {
            var investments_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            investments_tap.Tapped += (s, e) =>
            {
                // Page navigation
                Navigation.PushAsync(new Investments());
            };
            dashboard_investments_image.GestureRecognizers.Add(investments_tap);
        }

        // Code that navigates to car hire page when image is tapped
        public void CarHire_TapGesture()
        {
            var carhire_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            carhire_tap.Tapped += (s, e) =>
            {
                // Page navigation
                Navigation.PushAsync(new CarHire());
            };
            dashboard_carhire_image.GestureRecognizers.Add(carhire_tap);
        }
    }
}