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
            RedMainLabel.Text = "You Clicked Red Button";
            RedMainLabel.TextColor = Color.Red;
            BlueMainLabel.Text = String.Empty;
            GreenMainLabel.Text = String.Empty;
            YellowMainLabel.Text = String.Empty;
        }

        private void Blue_Clicked(object sender, EventArgs e)
        {
            BlueMainLabel.Text = "You Clicked Blue Button";
            BlueMainLabel.TextColor = Color.Blue;
            RedMainLabel.Text = String.Empty;
            GreenMainLabel.Text = String.Empty;
            YellowMainLabel.Text = String.Empty;
        }

        private void Green_Clicked(object sender, EventArgs e)
        {
           GreenMainLabel.Text = "You Clicked Green Button";
            GreenMainLabel.TextColor = Color.Green;
            RedMainLabel.Text = String.Empty;
            BlueMainLabel.Text = String.Empty;
            YellowMainLabel.Text = String.Empty;
        }

        private void Yellow_Clicked(object sender, EventArgs e)
        {
            YellowMainLabel.Text = "You Clicked Yellow Button";
            YellowMainLabel.TextColor = Color.Yellow;
            RedMainLabel.Text = String.Empty;
            BlueMainLabel.Text = String.Empty;
            GreenMainLabel.Text = String.Empty;
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            RedMainLabel.Text = String.Empty;
            BlueMainLabel.Text = String.Empty;
            GreenMainLabel.Text = String.Empty;
            YellowMainLabel.Text = String.Empty;
        }
    }
}
