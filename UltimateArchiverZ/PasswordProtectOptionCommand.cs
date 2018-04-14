using System;
namespace UltimateArchiverZ {
    public class PasswordProtectOptionCommand : CommandWithOptions {

        private string password;

        public PasswordProtectOptionCommand(Command command, string password)
            : base(command) => this.password = password;

        public override string MyOptionString {
            get {
                return "-p" + password;
            }
        }
    }
}
