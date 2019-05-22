namespace BekraHayrNesterCtfTools
{
    partial class cumledenwordlist
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cumledenwordlist));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bekraHayrNesterV01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordlistOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.richTextBox2);
            this.groupPanel1.Controls.Add(this.richTextBox1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(743, 316);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(3, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 292);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox2.Location = new System.Drawing.Point(364, 9);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(370, 292);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bekraHayrNesterV01ToolStripMenuItem,
            this.wordlistOluşturToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 48);
            // 
            // bekraHayrNesterV01ToolStripMenuItem
            // 
            this.bekraHayrNesterV01ToolStripMenuItem.Enabled = false;
            this.bekraHayrNesterV01ToolStripMenuItem.Name = "bekraHayrNesterV01ToolStripMenuItem";
            this.bekraHayrNesterV01ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.bekraHayrNesterV01ToolStripMenuItem.Text = "Bekra Hayr Nester V 0.1";
            // 
            // wordlistOluşturToolStripMenuItem
            // 
            this.wordlistOluşturToolStripMenuItem.Name = "wordlistOluşturToolStripMenuItem";
            this.wordlistOluşturToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.wordlistOluşturToolStripMenuItem.Text = "Wordlist Oluştur";
            this.wordlistOluşturToolStripMenuItem.Click += new System.EventHandler(this.wordlistOluşturToolStripMenuItem_Click);
            // 
            // cumledenwordlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 316);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cumledenwordlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bekraHayrNesterV01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordlistOluşturToolStripMenuItem;
    }
}