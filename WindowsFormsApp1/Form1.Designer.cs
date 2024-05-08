namespace WindowsFormsApp1
{
    partial class Form1
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
            this.cmbLanguageSelect = new System.Windows.Forms.ComboBox();
            this.rtxtInput = new System.Windows.Forms.RichTextBox();
            this.rtxtOuput = new System.Windows.Forms.RichTextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLanguageSelect
            // 
            this.cmbLanguageSelect.Enabled = false;
            this.cmbLanguageSelect.FormattingEnabled = true;
            this.cmbLanguageSelect.Location = new System.Drawing.Point(33, 397);
            this.cmbLanguageSelect.Name = "cmbLanguageSelect";
            this.cmbLanguageSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbLanguageSelect.TabIndex = 0;
            // 
            // rtxtInput
            // 
            this.rtxtInput.Location = new System.Drawing.Point(72, 53);
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(238, 226);
            this.rtxtInput.TabIndex = 2;
            this.rtxtInput.Text = "";
            // 
            // rtxtOuput
            // 
            this.rtxtOuput.Location = new System.Drawing.Point(511, 53);
            this.rtxtOuput.Name = "rtxtOuput";
            this.rtxtOuput.Size = new System.Drawing.Size(238, 226);
            this.rtxtOuput.TabIndex = 3;
            this.rtxtOuput.Text = "";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(160, 19);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(617, 19);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(365, 347);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.rtxtOuput);
            this.Controls.Add(this.rtxtInput);
            this.Controls.Add(this.cmbLanguageSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLanguageSelect;
        private System.Windows.Forms.RichTextBox rtxtInput;
        private System.Windows.Forms.RichTextBox rtxtOuput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnConvert;
    }
}

