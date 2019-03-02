using DestinationLaikipia.Model;
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
	public partial class Events : ContentPage
	{
		public Events ()
		{
			InitializeComponent ();

            Events_Image();

            Events_Image_Front_TapGesture();
			Events_One_Front_TapGesture();
			Events_Two_Front_TapGesture();
			Events_Three_Front_TapGesture();
            Events_Four_Front_TapGesture();

        }

        //Displays the Events images in a grid
        public void Events_Image()
        {
            events_front_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
            events_one_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
            events_two_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
            events_three_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
            events_four_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
            events_five_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
            events_six_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
        }

		//Goes to the next page when image is tapped
		public void Events_Image_Front_TapGesture()
		{
			var events_front_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            events_front_tap.Tapped += (s, e) =>
			{
                // Page navigation
                Navigation.PushAsync(new EventsSingleView());
			};
			events_front_image.GestureRecognizers.Add(events_front_tap);
		}

		//Goes to the next page when image is tapped
		public void Events_One_Front_TapGesture()
		{
			var events_one_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            events_one_tap.Tapped += (s, e) =>
			{
                // Page navigation
                Navigation.PushAsync(new EventsSingleView());
			};
			events_one_image.GestureRecognizers.Add(events_one_tap);
		}

		//Goes to the next page when image is tapped
		public void Events_Two_Front_TapGesture()
		{
			var events_two_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            events_two_tap.Tapped += (s, e) =>
			{
                // Page navigation
                Navigation.PushAsync(new EventsSingleView());
			};
			events_two_image.GestureRecognizers.Add(events_two_tap);
		}

		//Goes to the next page when image is tapped
		public void Events_Three_Front_TapGesture()
		{
			var events_three_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            events_three_tap.Tapped += (s, e) =>
			{
                // Page navigation
                Navigation.PushAsync(new EventsSingleView());
			};
			events_three_image.GestureRecognizers.Add(events_three_tap);
		}

        //Goes to the next page when image is tapped
        public void Events_Four_Front_TapGesture()
        {
            var events_four_tap = new TapGestureRecognizer();

            //Tap Gesture Event
            events_four_tap.Tapped += (s, e) =>
            {
                // Page navigation
                Navigation.PushAsync(new EventsSingleView());
            };
            events_four_image.GestureRecognizers.Add(events_four_tap);
        }
    }
}