using System;
namespace UltimateArchiverZ.NodeView {

    [Gtk.TreeNode(ListOnly = true)]
    public class TreeNode : Gtk.TreeNode {
        public TreeNode(string name, long size) {
            Name = name;
            Size = size;
        }

        [Gtk.TreeNodeValue(Column = 0)]
        public string Name { get; }

        [Gtk.TreeNodeValue(Column = 1)]
        public long Size { get; }
    }
}
