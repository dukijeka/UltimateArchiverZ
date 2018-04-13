using System;
namespace UltimateArchiverZ {
	public abstract class CommandWithOptions : Command {
		private Command command;

		public CommandWithOptions() { }

		public abstract override String CommandText { get; }
	}
}
