using System;
using System.Diagnostics;
using System.IO;

namespace UltimateArchiverZ {
	public class Compressor {
		private Command command;

		public Compressor(Command command) {
			this.command = command;
		}

		public void Compress() {
			ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = "/usr/bin/7z", Arguments = command.CommandText};
			Process proc = new Process() { StartInfo = startInfo, };
			proc.StartInfo.UseShellExecute = false;
			//proc.StartInfo.RedirectStandardOutput = true;
			proc.Start();
			//string output = proc.StandardOutput.ReadToEnd();
			proc.WaitForExit();

			//File.WriteAllText("/home/dusan/test/log.txt", output);
		}

	}
}
