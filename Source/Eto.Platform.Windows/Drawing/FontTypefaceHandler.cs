using Eto.Drawing;
using sd = System.Drawing;

namespace Eto.Platform.Windows.Drawing
{
	public class FontTypefaceHandler : WidgetHandler<sd.FontStyle, FontTypeface>, IFontTypeface
	{
		public FontTypefaceHandler (sd.FontStyle style)
		{
			this.Control = style;
			Name = this.FontStyle.ToString ().Replace (',', ' ');
		}

		public string Name { get; set; }

		public FontStyle FontStyle
		{
			get { return Control.ToEtoStyle (); }
		}
	}
}
