using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControlsDemo
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		async void GoToPage(ContentPage page)
		{
			await Navigation.PushAsync(page);
		}

		void Btn_Slider_Clicked(object sender, System.EventArgs e)
		{
			GoToPage( new SliderPage() );
		}
	}
}
