using System;
namespace UltimateArchiverZ {
	public abstract class Command {

		public Command() { }

		public abstract String CommandText { get; }
	}
}
