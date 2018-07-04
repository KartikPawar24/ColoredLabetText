using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColoredLabetText
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void RedBtn_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = "You Clicked Red Button";
            MainLabel.TextColor = Color.Red;
        }

        private void Blue_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = "You Clicked Blue Button";
            MainLabel.TextColor = Color.Blue;
        }

        private void Green_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = "You Clicked Green Button";
            MainLabel.TextColor = Color.Green;
        }

        private void Yellow_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = "You Clicked Yellow Button";
            MainLabel.TextColor = Color.Yellow;
        }
    }
}
