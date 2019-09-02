namespace med_enc
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.فائلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نئیبیماریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نیئبیماریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تفصیلاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فائلToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(894, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // فائلToolStripMenuItem
            // 
            this.فائلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نئیبیماریToolStripMenuItem,
            this.نیئبیماریToolStripMenuItem,
            this.تفصیلاتToolStripMenuItem});
            this.فائلToolStripMenuItem.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.فائلToolStripMenuItem.Name = "فائلToolStripMenuItem";
            this.فائلToolStripMenuItem.Size = new System.Drawing.Size(44, 31);
            this.فائلToolStripMenuItem.Text = "فائل";
            // 
            // نئیبیماریToolStripMenuItem
            // 
            this.نئیبیماریToolStripMenuItem.Name = "نئیبیماریToolStripMenuItem";
            this.نئیبیماریToolStripMenuItem.Size = new System.Drawing.Size(125, 32);
            this.نئیبیماریToolStripMenuItem.Text = "نئی بیماری";
            this.نئیبیماریToolStripMenuItem.Click += new System.EventHandler(this.نئیبیماریToolStripMenuItem_Click);
            // 
            // نیئبیماریToolStripMenuItem
            // 
            this.نیئبیماریToolStripMenuItem.Name = "نیئبیماریToolStripMenuItem";
            this.نیئبیماریToolStripMenuItem.Size = new System.Drawing.Size(125, 32);
            this.نیئبیماریToolStripMenuItem.Text = "نئی کیٹیگری";
            this.نیئبیماریToolStripMenuItem.Click += new System.EventHandler(this.نیئبیماریToolStripMenuItem_Click);
            // 
            // تفصیلاتToolStripMenuItem
            // 
            this.تفصیلاتToolStripMenuItem.Name = "تفصیلاتToolStripMenuItem";
            this.تفصیلاتToolStripMenuItem.Size = new System.Drawing.Size(125, 32);
            this.تفصیلاتToolStripMenuItem.Text = "تفصیلات";
            this.تفصیلاتToolStripMenuItem.Click += new System.EventHandler(this.تفصیلاتToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(894, 680);
            this.ClientSize = new System.Drawing.Size(892, 675);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem فائلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نئیبیماریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نیئبیماریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تفصیلاتToolStripMenuItem;
    }
}



