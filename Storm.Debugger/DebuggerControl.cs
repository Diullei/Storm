using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;

namespace Storm.Debugger
{
    public partial class DebuggerControl : UserControl
    {
        public DebuggerControl()
        {
            InitializeComponent();
        }

        public string Instruction
        {
            get { return txtInstruction.Text; }
            set { txtInstruction.Text = value; }
        }

        public string Code
        {
            get { return txtDebug.Text; }
            set
            {
                txtDebug.Text = value;
            }
        }

        public void InspectObject(object obj)
        {
            this.objectInspector.InspectObject(obj);
        }

        public void BreakPoint(int start, int end, int lineStart, int colStart, int lineEnd, int colEnd)
        {
            var offset = start;
            var length = (end - start);
            var marker = new TextMarker(offset, length, TextMarkerType.SolidBlock, Color.Yellow);
            txtDebug.Document.MarkerStrategy.AddMarker(marker);
        }
    }
}
