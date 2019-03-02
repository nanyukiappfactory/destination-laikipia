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
	public partial class InvestmentProfile : ContentPage
	{
        public InvestmentProfile(Investment investment)
        {
            InitializeComponent();

            LblDonorName.Text = investment.CompanyName;
            LblBloodGroup.Text = investment.Email;
            LblCountry.Text = investment.Description;
        }
	}
}