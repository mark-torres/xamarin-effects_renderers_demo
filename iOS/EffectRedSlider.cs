using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using UIKit;

using ControlsDemo.iOS;

[assembly: ResolutionGroupName("EffectsSlider")]
[assembly: ExportEffect(typeof(EffectRedSlider), "EffectRedSlider")]
namespace ControlsDemo.iOS
{
	public class EffectRedSlider: PlatformEffect
	{
		public EffectRedSlider()
		{
		}

		protected override void OnAttached()
		{
			//
			var slider = (UISlider) Control;
			slider.ThumbTintColor = UIColor.Red;
			slider.MinimumTrackTintColor = UIColor.Magenta;
			slider.MaximumTrackTintColor = UIColor.Purple;
		}

		protected override void OnDetached()
		{
			//
		}
	}
}
