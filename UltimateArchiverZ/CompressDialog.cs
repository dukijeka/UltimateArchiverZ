using System;
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

            if (folderChooserDialog.Run() == (int)Gtk.ResponseType.Accept) {
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

            Command commandToReturn;


            //MainWindow parent = (MainWindow)Parent;

            // for now
            commandToReturn = new BasicCommand(fileName, FileNames);

            // if password protection option is turend on
            if (passowrdCheckbox.Active) {
                string password = passwordEntry.Text;
                commandToReturn = 
                    new PasswordProtectOptionCommand(commandToReturn, password);
            }

            // if splitting into volumes option is turned on
            if (splitCheckbox.Active) {
                int size; 
                Int32.TryParse(splitSizeEntry.Text, out size);

                string unit = splitSizeComboBox.ActiveText;

                commandToReturn = 
                    new SplitIntoVolumesOptionCommand(commandToReturn, size, unit);

            }


            return commandToReturn;
        }

        private void CreateFileName() {
            fileName = fileNameEntry.Text;

            while (fileName.Contains(".")) {
                fileName = fileName.Remove(fileName.Length - 1);
            }

            fileName = folderNameEntry.Text + fileName + ".7z";
            fileName = "\"" + fileName + "\""; // fix spaces
        }

        protected void OnPasswordCheckboxChecked(object sender, EventArgs e) {
            if (passowrdCheckbox.Active) {
                passwordEntry.Sensitive = true;
            } else {
                passwordEntry.Sensitive = false;
            }
        }

        protected void OnSplitChecked(object sender, EventArgs e) {
            if (splitCheckbox.Active) {
                splitSizeEntry.Sensitive = true;
                splitSizeComboBox.Sensitive = true;
            } else {
                splitSizeEntry.Sensitive = false;
                splitSizeComboBox.Sensitive = false;
            }
        }
    }
}
