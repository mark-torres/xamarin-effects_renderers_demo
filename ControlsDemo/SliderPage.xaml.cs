using System;
//using System.Collections.Generic;

using Xamarin.Forms;

namespace ControlsDemo
{
	public partial class SliderPage : ContentPage
	{
		public SliderPage()
		{
			InitializeComponent();

			// add the effect
			slider2.Effects.Add( Effect.Resolve("com_hsoftmobile.EffectRedSlider") );
			slider3.Effects.Add( Effect.Resolve("com_hsoftmobile.EffectSliderGraphics") );
		}

		void Slider1_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			var newValue = e.NewValue;
			var slider = (Slider) sender;
			if(slider != null) {
				newValue = Math.Round(e.NewValue);
				slider.Value = newValue;
			}
			labelSlider1.Text = String.Format("Current value: {0}", newValue);
		}

		void Slider2_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			var newValue = e.NewValue;
			var slider = (Slider) sender;
			if(slider != null) {
				newValue = Math.Round(e.NewValue);
				slider.Value = newValue;
			}
			labelSlider2.Text = String.Format("Current value: {0}", newValue);
		}

		void Slider3_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			var newValue = e.NewValue;
			var slider = (Slider) sender;
			if(slider != null) {
				newValue = Math.Round(e.NewValue);
				slider.Value = newValue;
			}
			labelSlider3.Text = String.Format("Current value: {0}", newValue);
		}
	}
}
