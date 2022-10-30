namespace Oefening22
{
    partial class DialoogVenster
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.btn_value = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waarde";
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(165, 55);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(100, 23);
            this.tb_value.TabIndex = 1;
            this.tb_value.TextChanged += new System.EventHandler(this.tb_value_TextChanged);
            // 
            // btn_value
            // 
            this.btn_value.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_value.Location = new System.Drawing.Point(178, 94);
            this.btn_value.Name = "btn_value";
            this.btn_value.Size = new System.Drawing.Size(75, 23);
            this.btn_value.TabIndex = 2;
            this.btn_value.Text = "OK";
            this.btn_value.UseVisualStyleBackColor = true;
            this.btn_value.Click += new System.EventHandler(this.btn_value_Click);
            // 
            // DialoogVenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 147);
            this.Controls.Add(this.btn_value);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.label1);
            this.Name = "DialoogVenster";
            this.Text = "DialoogVenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_value;
        private Button btn_value;
    }
}