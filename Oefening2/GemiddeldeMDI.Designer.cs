namespace Oefening2
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
            this.btn_NewValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Values = new System.Windows.Forms.ListBox();
            this.tb_Gemiddelde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_NewValue
            // 
            this.btn_NewValue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_NewValue.Location = new System.Drawing.Point(325, 124);
            this.btn_NewValue.Name = "btn_NewValue";
            this.btn_NewValue.Size = new System.Drawing.Size(117, 47);
            this.btn_NewValue.TabIndex = 0;
            this.btn_NewValue.Text = "Nieuw Getal";
            this.btn_NewValue.UseVisualStyleBackColor = true;
            this.btn_NewValue.Click += new System.EventHandler(this.btn_NewValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gemiddelde";
            // 
            // listBox_Values
            // 
            this.listBox_Values.FormattingEnabled = true;
            this.listBox_Values.ItemHeight = 15;
            this.listBox_Values.Location = new System.Drawing.Point(171, 124);
            this.listBox_Values.Name = "listBox_Values";
            this.listBox_Values.Size = new System.Drawing.Size(91, 154);
            this.listBox_Values.TabIndex = 2;
            // 
            // tb_Gemiddelde
            // 
            this.tb_Gemiddelde.Location = new System.Drawing.Point(513, 124);
            this.tb_Gemiddelde.Name = "tb_Gemiddelde";
            this.tb_Gemiddelde.Size = new System.Drawing.Size(100, 23);
            this.tb_Gemiddelde.TabIndex = 3;
            // 
            // GemiddeldeMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Gemiddelde);
            this.Controls.Add(this.listBox_Values);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NewValue);
            this.Name = "GemiddeldeMDI";
            this.Text = "GemiddeldeMDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_NewValue;
        private Label label1;
        private ListBox listBox_Values;
        private TextBox tb_Gemiddelde;
    }
}