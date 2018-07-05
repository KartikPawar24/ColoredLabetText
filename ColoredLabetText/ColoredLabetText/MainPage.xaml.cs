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
            MainLabel.Text = "You clicked Red";
            MainLabel.TextColor = Color.Red;
        }

        private void Blue_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = "You clicked Blue";
            MainLabel.TextColor = Color.Blue;
        }

        private void Green_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = "You clicked Green";
            MainLabel.TextColor = Color.Green;
        }

        private void Yellow_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = "You clicked Yellow";
            MainLabel.TextColor = Color.Yellow;
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = String.Empty;
        }
    }
}
