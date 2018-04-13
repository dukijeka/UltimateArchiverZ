﻿using System;
namespace UltimateArchiverZ {
	public partial class CompressDialog : Gtk.Dialog {

		public Compressor ThisCompressor { get; set; }

		private Command command;
		private string fileName;
		public string FileNames { get; set; }

		public CompressDialog() {
			this.Build();
		}

		protected void OnClickCancel(object sender, EventArgs e) {
			this.Destroy();
		}

		protected void onBrowseClicked(object sender, EventArgs e) {
			Gtk.FileChooserDialog folderChooserDialog = new Gtk.FileChooserDialog("Choose the root folder",
			this,
			Gtk.FileChooserAction.SelectFolder,
			"Cancel", Gtk.ResponseType.Cancel,
			"Open", Gtk.ResponseType.Accept);

			if (folderChooserDialog.Run() == (int) Gtk.ResponseType.Accept) {
				folderNameEntry.Text = folderChooserDialog.Filename + "/";
			}

			folderChooserDialog.Destroy();
		}

		protected void OnCompressClicked(object sender, EventArgs e) {
			command = CreateCommand();
			ThisCompressor = new Compressor(command);
			ThisCompressor.Compress();
			this.Destroy();
		}

		private Command CreateCommand() {
			CreateFileName();

			// for now
			MainWindow parent = (MainWindow)Parent;
			return new BasicCommand(fileName, FileNames);
		}

		private void CreateFileName() {
			fileName = fileNameEntry.Text;

			while (fileName.Contains(".")) {
				fileName = fileName.Remove(fileName.Length - 1);
			}

			fileName = folderNameEntry.Text + fileName + ".7z";
			fileName = "\"" + fileName + "\""; // fix spaces
		}
	}
}
