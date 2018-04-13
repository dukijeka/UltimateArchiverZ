using System;
using Gtk;

public partial class MainWindow : Gtk.Window {
	// filenames separated by space
	private String fileNames;

	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnIconActionActivated(System.Object sender, System.EventArgs e) {
		new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.None, "Destination directory cannot be the same as the target directory").Show();
	}

	protected void OnClick(object sender, EventArgs e) {
		new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.None, "Destination directory cannot be the same as the target directory").Show();
	}

	protected void OnToolbarAdd(object sender, EventArgs e) {
		Gtk.FileChooserDialog fileChooserDialog = new Gtk.FileChooserDialog("Choose files to open",
			this,
		    FileChooserAction.Open,
			"Cancel", ResponseType.Cancel,
			"Open", ResponseType.Accept);
		fileChooserDialog.SelectMultiple = true;

		
		if (fileChooserDialog.Run() == (int)ResponseType.Accept) {
			table1.NRows = (uint) fileChooserDialog.Filenames.Length + 1;
			uint i = 1;
			foreach (string filename in fileChooserDialog.Filenames) {
				fileNames += "\"" + filename + "\"" + " "; // also fixes spaces
				string name = System.IO.Path.GetFileName(filename); 
				Gtk.Label label = new Label(name);
				table1.Attach(label, 0, 1, i , i + 1);
				label.Show();

				i++;
			
			}

		}

		fileChooserDialog.Destroy();



	}

	protected void OnToolbarCompress(object sender, EventArgs e) {
		//new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.None, "Compress").Show();
		UltimateArchiverZ.CompressDialog compressDialog = new UltimateArchiverZ.CompressDialog();

		// pass the file names
		compressDialog.FileNames = this.fileNames;

		compressDialog.Show();
	}
}
