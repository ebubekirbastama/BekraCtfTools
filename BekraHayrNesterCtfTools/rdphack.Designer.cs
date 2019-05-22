namespace BekraHayrNesterCtfTools
{
    partial class rdphack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rdphack));
            this.rdp = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bekraHayrNesterV01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverNameYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bruteForceBaşlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdp
            // 
            this.rdp.ContextMenuStrip = this.contextMenuStrip1;
            this.rdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(0, 0);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(901, 496);
            this.rdp.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bekraHayrNesterV01ToolStripMenuItem,
            this.serverNameYükleToolStripMenuItem,
            this.userNameYükleToolStripMenuItem,
            this.şifreYükleToolStripMenuItem,
            this.bruteForceBaşlaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 114);
            // 
            // bekraHayrNesterV01ToolStripMenuItem
            // 
            this.bekraHayrNesterV01ToolStripMenuItem.Enabled = false;
            this.bekraHayrNesterV01ToolStripMenuItem.Name = "bekraHayrNesterV01ToolStripMenuItem";
            this.bekraHayrNesterV01ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.bekraHayrNesterV01ToolStripMenuItem.Text = "Bekra Hayr Nester V 0.1";
            // 
            // serverNameYükleToolStripMenuItem
            // 
            this.serverNameYükleToolStripMenuItem.Name = "serverNameYükleToolStripMenuItem";
            this.serverNameYükleToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.serverNameYükleToolStripMenuItem.Text = "Server Name Yükle";
            this.serverNameYükleToolStripMenuItem.Click += new System.EventHandler(this.serverNameYükleToolStripMenuItem_Click);
            // 
            // userNameYükleToolStripMenuItem
            // 
            this.userNameYükleToolStripMenuItem.Name = "userNameYükleToolStripMenuItem";
            this.userNameYükleToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.userNameYükleToolStripMenuItem.Text = "User Name Yükle";
            this.userNameYükleToolStripMenuItem.Click += new System.EventHandler(this.userNameYükleToolStripMenuItem_Click);
            // 
            // şifreYükleToolStripMenuItem
            // 
            this.şifreYükleToolStripMenuItem.Name = "şifreYükleToolStripMenuItem";
            this.şifreYükleToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.şifreYükleToolStripMenuItem.Text = "Şifre Yükle";
            this.şifreYükleToolStripMenuItem.Click += new System.EventHandler(this.şifreYükleToolStripMenuItem_Click);
            // 
            // bruteForceBaşlaToolStripMenuItem
            // 
            this.bruteForceBaşlaToolStripMenuItem.Name = "bruteForceBaşlaToolStripMenuItem";
            this.bruteForceBaşlaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.bruteForceBaşlaToolStripMenuItem.Text = "Brute-Force Başla";
            this.bruteForceBaşlaToolStripMenuItem.Click += new System.EventHandler(this.bruteForceBaşlaToolStripMenuItem_Click);
            // 
            // rdphack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 496);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.rdp);
            this.Name = "rdphack";
            this.Text = "rdphack";
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting rdp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bekraHayrNesterV01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverNameYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userNameYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bruteForceBaşlaToolStripMenuItem;
    }
}