using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControlsDemo
{
	public partial class SliderPage : ContentPage
	{
		public SliderPage()
		{
			InitializeComponent();

			// add the effect
			slider2.Effects.Add( Effect.Resolve("EffectsSlider.EffectRedSlider") );
		}

		void Slider1_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			labelSlider1.Text = String.Format("Current value: {0}", e.NewValue);
		}

		void Slider2_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			labelSlider2.Text = String.Format("Current value: {0}", e.NewValue);
		}
	}
}
