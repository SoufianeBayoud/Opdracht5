namespace Oefening22
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
            this.btn_ChildMDI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ChildMDI
            // 
            this.btn_ChildMDI.Location = new System.Drawing.Point(303, 160);
            this.btn_ChildMDI.Name = "btn_ChildMDI";
            this.btn_ChildMDI.Size = new System.Drawing.Size(121, 38);
            this.btn_ChildMDI.TabIndex = 1;
            this.btn_ChildMDI.Text = "Go to Child";
            this.btn_ChildMDI.UseVisualStyleBackColor = true;
            this.btn_ChildMDI.Click += new System.EventHandler(this.btn_ChildMDI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ChildMDI);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_ChildMDI;
    }
}