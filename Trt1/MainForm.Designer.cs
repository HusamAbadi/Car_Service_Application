namespace Trt1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadFileTab = new System.Windows.Forms.ToolStripMenuItem();
            this.worksheetTab = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentTab = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTab = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTab = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileTab,
            this.worksheetTab,
            this.paymentTab,
            this.aboutTab,
            this.exitTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(484, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadFileTab
            // 
            this.loadFileTab.Name = "loadFileTab";
            this.loadFileTab.Size = new System.Drawing.Size(75, 19);
            this.loadFileTab.Text = "&Load File...";
            this.loadFileTab.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // worksheetTab
            // 
            this.worksheetTab.Enabled = false;
            this.worksheetTab.Name = "worksheetTab";
            this.worksheetTab.Size = new System.Drawing.Size(84, 19);
            this.worksheetTab.Text = "&Worksheet...";
            this.worksheetTab.Click += new System.EventHandler(this.worksheetToolStripMenuItem_Click);
            // 
            // paymentTab
            // 
            this.paymentTab.Enabled = false;
            this.paymentTab.Name = "paymentTab";
            this.paymentTab.Size = new System.Drawing.Size(66, 19);
            this.paymentTab.Text = "Payment";
            this.paymentTab.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // aboutTab
            // 
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(52, 19);
            this.aboutTab.Text = "&About";
            this.aboutTab.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitTab
            // 
            this.exitTab.Name = "exitTab";
            this.exitTab.Size = new System.Drawing.Size(38, 19);
            this.exitTab.Text = "E&xit";
            this.exitTab.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripTextBox toolStripTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadFileTab;
        private ToolStripMenuItem worksheetTab;
        private ToolStripMenuItem paymentTab;
        private ToolStripMenuItem aboutTab;
        private ToolStripMenuItem exitTab;
    }
}