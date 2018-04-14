using System;
namespace UltimateArchiverZ {
    public class SplitIntoVolumesOptionCommand : CommandWithOptions {
        private int volumeSize;
        private string unit;

        public SplitIntoVolumesOptionCommand(Command command, int volumeSize, 
                                             string unit) : base(command) {
            this.volumeSize = volumeSize;
            this.unit = unit;
        }

        public override string MyOptionString {
            get {
                return "-v" + volumeSize + unit[0]; 
            }
        }
    }
}
