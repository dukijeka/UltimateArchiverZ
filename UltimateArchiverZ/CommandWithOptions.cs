using System;
namespace UltimateArchiverZ {
    public abstract class CommandWithOptions : Command {
        private Command command;

        public CommandWithOptions(Command command) {
            this.command = command;
        }

        public abstract string MyOptionString { get; }

        public override string CommandText {
            get {
                return command.CommandText.Insert(2, this.MyOptionString + " ");
            }
        }
    }
}
