using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using UIKit;

using ControlsDemo.iOS;


[assembly: ResolutionGroupName("com_hsoftmobile")]
[assembly: ExportEffect(typeof(EffectRedSlider), "EffectRedSlider")]
[assembly: ExportEffect(typeof(EffectSliderGraphics), "EffectSliderGraphics")]
namespace ControlsDemo.iOS
{
	public class EffectRedSlider: PlatformEffect
	{
		protected override void OnAttached()
		{
			//
			var slider = (UISlider) Control;
			slider.ThumbTintColor = UIColor.Red;
			slider.MinimumTrackTintColor = UIColor.Magenta;
			slider.MaximumTrackTintColor = UIColor.Purple;
			//slider.SetMinTrackImage();
			//slider.SetMaxTrackImage();
			//slider.SetThumbImage();
		}

		protected override void OnDetached()
		{
			//
		}
	}

	public class EffectSliderGraphics : PlatformEffect
	{
		protected override void OnAttached()
		{
			var slider = Control as UISlider;
			var thumb = UIImage.FromBundle("burger_ocean.png");
			slider.SetThumbImage(thumb, UIControlState.Normal);
			slider.SetThumbImage(thumb, UIControlState.Highlighted);
		}

		protected override void OnDetached()
		{
			//
		}
	}
}
