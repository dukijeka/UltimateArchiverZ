
// This file has been generated by the GUI designer. Do not modify.
namespace UltimateArchiverZ
{
	public partial class CompressDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label2;

		private global::Gtk.Entry folderNameEntry;

		private global::Gtk.Button button40;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label3;

		private global::Gtk.Entry fileNameEntry;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget UltimateArchiverZ.CompressDialog
			this.Name = "UltimateArchiverZ.CompressDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child UltimateArchiverZ.CompressDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Root Folder:");
			this.hbox1.Add(this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.folderNameEntry = new global::Gtk.Entry();
			this.folderNameEntry.CanFocus = true;
			this.folderNameEntry.Name = "folderNameEntry";
			this.folderNameEntry.IsEditable = true;
			this.folderNameEntry.InvisibleChar = '•';
			this.hbox1.Add(this.folderNameEntry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.folderNameEntry]));
			w3.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button40 = new global::Gtk.Button();
			this.button40.CanFocus = true;
			this.button40.Name = "button40";
			this.button40.UseUnderline = true;
			this.button40.Label = global::Mono.Unix.Catalog.GetString("Browse");
			this.hbox1.Add(this.button40);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button40]));
			w4.Position = 2;
			w4.Expand = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Archive Name: ");
			this.hbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fileNameEntry = new global::Gtk.Entry();
			this.fileNameEntry.CanFocus = true;
			this.fileNameEntry.Name = "fileNameEntry";
			this.fileNameEntry.IsEditable = true;
			this.fileNameEntry.InvisibleChar = '•';
			this.hbox2.Add(this.fileNameEntry);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.fileNameEntry]));
			w7.Position = 1;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w9.Position = 0;
			// Internal child UltimateArchiverZ.CompressDialog.ActionArea
			global::Gtk.HButtonBox w10 = this.ActionArea;
			w10.Name = "dialog1_ActionArea";
			w10.Spacing = 10;
			w10.BorderWidth = ((uint)(5));
			w10.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonCancel]));
			w11.Expand = false;
			w11.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString("Compress");
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonOk]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 596;
			this.DefaultHeight = 439;
			this.Show();
			this.button40.Clicked += new global::System.EventHandler(this.onBrowseClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.OnClickCancel);
			this.buttonOk.Clicked += new global::System.EventHandler(this.OnCompressClicked);
		}
	}
}
