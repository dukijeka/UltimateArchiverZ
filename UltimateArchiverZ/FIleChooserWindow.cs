using System;
namespace UltimateArchiverZ {
	public partial class FIleChooserWindow : Gtk.Window {
		public FIleChooserWindow() :
				base(Gtk.WindowType.Toplevel) {
			this.Build();
		}
	}
}
