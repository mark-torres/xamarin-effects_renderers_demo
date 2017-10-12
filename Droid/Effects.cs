using Android.Graphics;
using Android.Widget;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using ControlsDemo.Droid;
using Android.Content.Res;

[assembly: ResolutionGroupName("com_hsoftmobile")]
[assembly: ExportEffect(typeof(EffectRedSlider), "EffectRedSlider")]
[assembly: ExportEffect(typeof(EffectSliderGraphics), "EffectSliderGraphics")]
namespace ControlsDemo.Droid
{
	public class EffectRedSlider: PlatformEffect
	{
		protected override void OnAttached()
		{
			var seekBar = Control as SeekBar;
			var colorFilter = new PorterDuffColorFilter(Xamarin.Forms.Color.Red.ToAndroid(), PorterDuff.Mode.SrcIn);
			seekBar.ProgressDrawable.SetColorFilter(colorFilter);
			seekBar.Thumb.SetColorFilter(colorFilter);
			//seekBar.SetThumb();
			//seekBar.SetBackgroundResource();
		}

		protected override void OnDetached()
		{}
	}

	public class EffectSliderGraphics : PlatformEffect
	{
		protected override void OnAttached()
		{
			var seekBar = Control as SeekBar;
			var thumb = Resources.System.GetDrawable("burger_aqua.png");
			seekBar.SetThumb(thumb);
		}

		protected override void OnDetached()
		{
			//throw new System.NotImplementedException();
		}
	}
}
