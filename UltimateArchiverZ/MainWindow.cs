using System;
using Gtk;

public partial class MainWindow : Gtk.Window {
	// filenames separated by space
	private String fileNames;

    private Gtk.NodeStore store;

    private Gtk.NodeStore Store {
        get {
            if (store == null) {
                store = new Gtk.NodeStore(typeof(UltimateArchiverZ.NodeView.TreeNode));
                //store.AddNode(new UltimateArchiverZ.NodeView.TreeNode("The Beatles", 5))
            }

            return store;
        }
    }

	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		Build();

        listOfFilesNodeView.AppendColumn("Name", new CellRendererText(), "text", 0);
        listOfFilesNodeView.AppendColumn("Size", new CellRendererText(), "int", 1);
        listOfFilesNodeView.NodeStore = Store;
        listOfFilesNodeView.ShowAll();
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
			//table1.NRows = (uint) fileChooserDialog.Filenames.Length + 1;
			uint i = 1;
			foreach (string filename in fileChooserDialog.Filenames) {
				fileNames += "\"" + filename + "\"" + " "; // also fixes spaces
				string name = System.IO.Path.GetFileName(filename);
                //Gtk.Label label = new Label(name);
                //table1.Attach(label, 0, 1, i , i + 1);
                //label.Show();

                long size = new System.IO.FileInfo(filename).Length;

                store.AddNode(new UltimateArchiverZ.NodeView.TreeNode(name, size));
                //listOfFIlesNodeView.NodeStore.AddNode(new UltimateArchiverZ.NodeView.TreeNode("ime", 5));

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
