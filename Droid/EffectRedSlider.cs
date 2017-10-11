using Android.Graphics;
using Android.Widget;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using ControlsDemo.Droid;

[assembly: ResolutionGroupName("EffectsSlider")]
[assembly: ExportEffect(typeof(EffectRedSlider), "EffectRedSlider")]
namespace ControlsDemo.Droid
{
	public class EffectRedSlider: PlatformEffect
	{
		public EffectRedSlider()
		{
		}

		protected override void OnAttached()
		{
			var seekBar = (SeekBar) Control;
			var colorFilter = new PorterDuffColorFilter(Xamarin.Forms.Color.Red.ToAndroid(), PorterDuff.Mode.SrcIn);
			seekBar.ProgressDrawable.SetColorFilter(colorFilter);
			seekBar.Thumb.SetColorFilter(colorFilter);
		}

		protected override void OnDetached()
		{}
	}
}
