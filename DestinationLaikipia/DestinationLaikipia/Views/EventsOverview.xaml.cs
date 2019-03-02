using DestinationLaikipia.Model;
using DestinationLaikipia.ViewModels;
using Plugin.Messaging;
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
	public partial class EventsOverview : ContentPage
	{
        private string _phoneNumber = "0711581009";
        private string _email = "karis.njoroge@gmail.com";

		public EventsOverview ()
		{
			InitializeComponent ();
            BindingContext = new EventsOverviewVM();

            events_front_detail_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
        }

        //Infaltes when an email icon is called and goes to the menu
        private void TapEmail_Tapped(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                // Send simple e-mail to single receiver without attachments, bcc, cc etc.
                emailMessenger.SendEmail(_email, "Add a subject", "Write Email Body");
            }
        }

        //Infaltes when a phone icon is called and goes to the menu
        private void TapPhone_Tapped(object sender, EventArgs e)
        {
            // Make Phone Call
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall(_phoneNumber);
        }

    }
}