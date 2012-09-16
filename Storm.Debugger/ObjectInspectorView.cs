using System.Reflection;
using System.Windows.Forms;
using CommonTools.TreeList;

namespace Storm.Debugger
{
    public partial class ObjectInspectorView : UserControl
    {
        public ObjectInspectorView()
        {
            InitializeComponent();
        }

        public void InspectObject(object obj)
        {
            this._objectInspectorViewTree.InspectObject(obj);
        }
    }

    public class ObjectInspectorViewTree : TreeListView
    {
        public enum ColumnType
        {
            Name = 0,
            Value = 1,
            Type = 2,
        }

        private Node _root;

        public void InspectObject(object obj)
        {
            this.Nodes.Remove(_root);
            _root = new Node();

            BeginUpdate();

            _root[(int)ColumnType.Name] = obj;
            _root.Nodes.Clear();

            foreach (var pi in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if(pi.Name == "Debugger")
                    continue;

                AddProperty(obj, pi, _root);
            }
            _root.Expand();

            this.Nodes.Add(_root);

            EndUpdate();
        }

        static void AddProperty(object obj, PropertyInfo property, Node node)
        {
            var value = property.GetValue(obj);

            var n = new Node();
            n[(int)ColumnType.Name] = property.Name.StartsWith("private_") ? property.Name.Substring(8) : property.Name;
            n[(int) ColumnType.Value] = value;
            n[(int)ColumnType.Type] = value != null ?  value.GetType().ToString() : "...";

            node.Nodes.Add(n);

            n.Expand();
        }
    }
}
