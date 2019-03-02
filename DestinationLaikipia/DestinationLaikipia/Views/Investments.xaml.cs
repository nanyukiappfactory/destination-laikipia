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
	public partial class Investments : ContentPage
	{
		public Investments ()
		{
			InitializeComponent ();
		}

        private void Invest_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var invest = e.SelectedItem as Investment;
            Navigation.PushAsync(new InvestmentProfile(invest));
        }

    }
}