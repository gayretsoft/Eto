using System;
using MonoTouch.UIKit;
using Eto.Forms;
using Eto.Drawing;
using Eto.Platform.iOS.Drawing;

namespace Eto.Platform.iOS.Forms.Controls
{
	public class ImageViewHandler : IosControl<UIImageView, ImageView>, IImageView
	{
		Image image;

		public ImageViewHandler ()
		{
		}

		public override UIImageView CreateControl ()
		{
			return new UIImageView();
		}

		protected override void Initialize ()
		{
			base.Initialize ();
			Control.ContentMode = UIViewContentMode.ScaleAspectFit;
		}

		public Eto.Drawing.Image Image {
			get { return image; }
			set {
				image = value;
				Control.Image = value.ToUI ();
			}
		}
	}
}

