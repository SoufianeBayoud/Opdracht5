namespace Oefening2
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
            this.btn_childmdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_childmdi
            // 
            this.btn_childmdi.Location = new System.Drawing.Point(291, 174);
            this.btn_childmdi.Name = "btn_childmdi";
            this.btn_childmdi.Size = new System.Drawing.Size(230, 73);
            this.btn_childmdi.TabIndex = 1;
            this.btn_childmdi.Text = "ChildMdi";
            this.btn_childmdi.UseVisualStyleBackColor = true;
            this.btn_childmdi.Click += new System.EventHandler(this.btn_childmdi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_childmdi);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_childmdi;
    }
}