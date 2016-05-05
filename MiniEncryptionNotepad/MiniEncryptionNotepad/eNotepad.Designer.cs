namespace MiniEncryptionNotepad
{
    partial class eNotepad
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eNotepad));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Mini = new System.Windows.Forms.ToolStripButton();
            this.FreeNotepad = new System.Windows.Forms.NotifyIcon(this.components);
            this.notepad = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Open,
            this.toolStripButton_Save,
            this.toolStripButton_Mini});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(377, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Open
            // 
            this.toolStripButton_Open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Open.Image")));
            this.toolStripButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Open.Name = "toolStripButton_Open";
            this.toolStripButton_Open.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton_Open.Text = "Open";
            this.toolStripButton_Open.Click += new System.EventHandler(this.toolStripButton_Open_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton_Save.Text = "Save";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // toolStripButton_Mini
            // 
            this.toolStripButton_Mini.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Mini.Image")));
            this.toolStripButton_Mini.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Mini.Name = "toolStripButton_Mini";
            this.toolStripButton_Mini.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton_Mini.Text = "Mini";
            this.toolStripButton_Mini.Click += new System.EventHandler(this.toolStripButton_Mini_Click);
            // 
            // FreeNotepad
            // 
            this.FreeNotepad.Text = "FreeNotepad";
            this.FreeNotepad.Visible = true;
            this.FreeNotepad.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FreeNotepad_MouseDoubleClick);
            // 
            // notepad
            // 
            this.notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notepad.Location = new System.Drawing.Point(0, 25);
            this.notepad.Multiline = true;
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(377, 339);
            this.notepad.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 364);
            this.Controls.Add(this.notepad);
            this.Controls.Add(this.toolStrip1);
            this.Name = "eNotepad";
            this.Text = "eNotepad";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Open;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripButton toolStripButton_Mini;
        private System.Windows.Forms.NotifyIcon FreeNotepad;
        private System.Windows.Forms.TextBox notepad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

