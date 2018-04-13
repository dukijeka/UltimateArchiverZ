using System;
namespace UltimateArchiverZ {

	// basic command to compress files, without options
	public class BasicCommand : Command {

		/*
		 * File list is a list of files to be commpressed  
		 * separated by space,
		 * For example: fileList = "file1.txt file2.txt file3.jpg"
		*/
		public BasicCommand(String archiveName, String fileList)
			=> this.CommandText = "a " + archiveName + " " + fileList;


		public override String CommandText { get; }

	}
}
