namespace Oefening22
{
    partial class GemiddeldeMDI
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
            this.btn_newbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_Gemiddelde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_newbutton
            // 
            this.btn_newbutton.Location = new System.Drawing.Point(315, 127);
            this.btn_newbutton.Name = "btn_newbutton";
            this.btn_newbutton.Size = new System.Drawing.Size(143, 44);
            this.btn_newbutton.TabIndex = 0;
            this.btn_newbutton.Text = "Nieuw Getal";
            this.btn_newbutton.UseVisualStyleBackColor = true;
            this.btn_newbutton.Click += new System.EventHandler(this.btn_newbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(181, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(76, 199);
            this.listBox1.TabIndex = 1;
            // 
            // tb_Gemiddelde
            // 
            this.tb_Gemiddelde.Location = new System.Drawing.Point(512, 127);
            this.tb_Gemiddelde.Name = "tb_Gemiddelde";
            this.tb_Gemiddelde.ReadOnly = true;
            this.tb_Gemiddelde.Size = new System.Drawing.Size(100, 23);
            this.tb_Gemiddelde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gemiddelde";
            // 
            // GemiddeldeMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Gemiddelde);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_newbutton);
            this.Name = "GemiddeldeMDI";
            this.Text = "GemiddeldeMDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_newbutton;
        private ListBox listBox1;
        private TextBox tb_Gemiddelde;
        private Label label1;
    }
}