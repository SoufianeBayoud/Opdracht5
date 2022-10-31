namespace Oefening1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redCTRLRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueCtrlBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redCTRLRToolStripMenuItem,
            this.greenCtrlGToolStripMenuItem,
            this.blueCtrlBToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // redCTRLRToolStripMenuItem
            // 
            this.redCTRLRToolStripMenuItem.Name = "redCTRLRToolStripMenuItem";
            this.redCTRLRToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.redCTRLRToolStripMenuItem.Text = "Red Ctrl+R";
            this.redCTRLRToolStripMenuItem.Click += new System.EventHandler(this.redCTRLRToolStripMenuItem_Click);
            // 
            // greenCtrlGToolStripMenuItem
            // 
            this.greenCtrlGToolStripMenuItem.Name = "greenCtrlGToolStripMenuItem";
            this.greenCtrlGToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.greenCtrlGToolStripMenuItem.Text = "Green Ctrl+G";
            this.greenCtrlGToolStripMenuItem.Click += new System.EventHandler(this.greenCtrlGToolStripMenuItem_Click);
            // 
            // blueCtrlBToolStripMenuItem
            // 
            this.blueCtrlBToolStripMenuItem.Name = "blueCtrlBToolStripMenuItem";
            this.blueCtrlBToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.blueCtrlBToolStripMenuItem.Text = "Blue Ctrl+B";
            this.blueCtrlBToolStripMenuItem.Click += new System.EventHandler(this.blueCtrlBToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallCtrlSToolStripMenuItem,
            this.normalCtrlNToolStripMenuItem,
            this.largeCtrlLToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // smallCtrlSToolStripMenuItem
            // 
            this.smallCtrlSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallCtrlSToolStripMenuItem.Name = "smallCtrlSToolStripMenuItem";
            this.smallCtrlSToolStripMenuItem.Size = new System.Drawing.Size(230, 42);
            this.smallCtrlSToolStripMenuItem.Text = "Small   Ctrl+S";
            this.smallCtrlSToolStripMenuItem.Click += new System.EventHandler(this.smallCtrlSToolStripMenuItem_Click);
            // 
            // normalCtrlNToolStripMenuItem
            // 
            this.normalCtrlNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.normalCtrlNToolStripMenuItem.Name = "normalCtrlNToolStripMenuItem";
            this.normalCtrlNToolStripMenuItem.Size = new System.Drawing.Size(230, 42);
            this.normalCtrlNToolStripMenuItem.Text = "Normal  Ctrl+N";
            this.normalCtrlNToolStripMenuItem.Click += new System.EventHandler(this.normalCtrlNToolStripMenuItem_Click);
            // 
            // largeCtrlLToolStripMenuItem
            // 
            this.largeCtrlLToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.largeCtrlLToolStripMenuItem.Name = "largeCtrlLToolStripMenuItem";
            this.largeCtrlLToolStripMenuItem.Size = new System.Drawing.Size(230, 42);
            this.largeCtrlLToolStripMenuItem.Text = "Large Ctrl+L";
            this.largeCtrlLToolStripMenuItem.Click += new System.EventHandler(this.largeCtrlLToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(427, 245);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "How sharper than a serpent\'s tooth it is to have a buggy program!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 269);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem redCTRLRToolStripMenuItem;
        private ToolStripMenuItem greenCtrlGToolStripMenuItem;
        private ToolStripMenuItem blueCtrlBToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem smallCtrlSToolStripMenuItem;
        private ToolStripMenuItem normalCtrlNToolStripMenuItem;
        private ToolStripMenuItem largeCtrlLToolStripMenuItem;
        private TextBox textBox1;
    }
}