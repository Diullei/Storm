using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace Storm.Debugger
{
    public partial class Console : Form, IDebugger
    {
        private static CodeRunner _runner;
        private static bool _stop;

        public Console()
        {
            InitializeComponent();
            debugControl.Visible = false;
            txtSource.Visible = true;
            txtSource.Dock = DockStyle.Fill;

            btnStop.Enabled = false;
            btnNext.Enabled = false;

            btnStart.Click+=btnStart_Click;
            btnNext.Click+=btnNext_Click;
            btnStop.Click+=btnStop_Click;

            this.KeyDown += Console_KeyDown;
        }

        void Console_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.F5)
            {
                StartDebugger();
            }
            else if (e.KeyData == Keys.F3)
            {
                Back();
            }
            else if (e.KeyData == Keys.F10)
            {
                GoToNext();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartDebugger();
        }

        private bool _endDebug;

        public void BreakPoint(int start, int end, int lineStart, int colStart, int lineEnd, int colEnd)
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    debugControl.Code = txtSource.Text;
                    debugControl.BreakPoint(start, end, lineStart, colStart, lineEnd, colEnd);
                    debugControl.Instruction = txtSource.Text.Substring(start, (end - start));
                }));
            }

            _stop = true;
            while(_stop)
            {
                Thread.Sleep(200);
            }
        }

        public void BreakPoint(JsObject instance)
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                                                  {
                                                      debugControl.InspectObject(instance);
                                                  }));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoToNext();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void StartDebugger()
        {
            if (string.IsNullOrWhiteSpace(txtSource.Text))
            {
                MessageBox.Show("You must provide same code to be compiled.");
                return;
            }

            try
            {
                new Esprima.NET.Esprima().Parse(txtSource.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            _endDebug = false;
            btnStart.Enabled = false;
            btnNext.Enabled = true;
            btnStop.Enabled = false;
            txtSource.Visible = false;
            debugControl.Visible = true;
            _runner = new CodeRunner(this, txtSource.Text);
            _runner.OnFinish += _runner_OnFinish;
            var appThrd = new Thread(arg => _runner.Run()) {IsBackground = true};
            appThrd.Start(this);
        }

        void _runner_OnFinish(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    _endDebug = true;
                    btnStop.Enabled = true;
                    btnNext.Enabled = false;
                    debugControl.Code = txtSource.Text;
                }));
            }
        }

        private void GoToNext()
        {
            if (_endDebug)
            {
                btnStop.Enabled = true;
                btnNext.Enabled = false;
            }
            _stop = false;
        }

        private void Back()
        {
            debugControl.Visible = false;
            txtSource.Visible = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
