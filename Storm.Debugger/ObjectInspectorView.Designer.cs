using CommonTools.TreeList;

namespace Storm.Debugger
{
    partial class ObjectInspectorView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CommonTools.TreeList.TreeListColumn treeListColumn1 = new CommonTools.TreeList.TreeListColumn("name", "Name");
            CommonTools.TreeList.TreeListColumn treeListColumn2 = new CommonTools.TreeList.TreeListColumn("value", "Value");
            CommonTools.TreeList.TreeListColumn treeListColumn3 = new CommonTools.TreeList.TreeListColumn("type", "Type");
            this._objectInspectorViewTree = new Storm.Debugger.ObjectInspectorViewTree();
            ((System.ComponentModel.ISupportInitialize)(this._objectInspectorViewTree)).BeginInit();
            this.SuspendLayout();
            // 
            // _objectInspectorViewTree
            // 
            this._objectInspectorViewTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            treeListColumn1.AutoSizeMinSize = 0;
            treeListColumn1.Width = 250;
            treeListColumn2.AutoSizeMinSize = 0;
            treeListColumn2.CellFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            treeListColumn2.Width = 200;
            treeListColumn3.AutoSizeMinSize = 0;
            treeListColumn3.HeaderFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeListColumn3.Width = 200;
            this._objectInspectorViewTree.Columns.AddRange(new CommonTools.TreeList.TreeListColumn[] {
            treeListColumn1,
            treeListColumn2,
            treeListColumn3});
            this._objectInspectorViewTree.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._objectInspectorViewTree.Images = null;
            this._objectInspectorViewTree.Location = new System.Drawing.Point(3, 3);
            this._objectInspectorViewTree.Name = "_objectInspectorViewTree";
            this._objectInspectorViewTree.Size = new System.Drawing.Size(433, 286);
            this._objectInspectorViewTree.TabIndex = 0;
            this._objectInspectorViewTree.Text = "treeListView1";
            this._objectInspectorViewTree.ViewOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // ObjectInspectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._objectInspectorViewTree);
            this.Name = "ObjectInspectorView";
            this.Size = new System.Drawing.Size(439, 292);
            ((System.ComponentModel.ISupportInitialize)(this._objectInspectorViewTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ObjectInspectorViewTree _objectInspectorViewTree;
    }
}
