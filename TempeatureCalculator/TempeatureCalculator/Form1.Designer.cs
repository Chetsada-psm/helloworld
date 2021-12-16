namespace TempeatureCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonConvertC = new System.Windows.Forms.Button();
            this.ConvertF = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "F";
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(23, 68);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(140, 23);
            this.textBoxF.TabIndex = 10;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(23, 39);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(140, 23);
            this.textBoxC.TabIndex = 9;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // buttonConvertC
            // 
            this.buttonConvertC.Location = new System.Drawing.Point(212, 38);
            this.buttonConvertC.Name = "buttonConvertC";
            this.buttonConvertC.Size = new System.Drawing.Size(91, 23);
            this.buttonConvertC.TabIndex = 7;
            this.buttonConvertC.Text = "ConvertC";
            this.buttonConvertC.UseVisualStyleBackColor = true;
            this.buttonConvertC.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // ConvertF
            // 
            this.ConvertF.Location = new System.Drawing.Point(212, 72);
            this.ConvertF.Name = "ConvertF";
            this.ConvertF.Size = new System.Drawing.Size(91, 23);
            this.ConvertF.TabIndex = 13;
            this.ConvertF.Text = "ConvertF";
            this.ConvertF.UseVisualStyleBackColor = true;
            this.ConvertF.Click += new System.EventHandler(this.ConvertF_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(309, 38);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(95, 57);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 127);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.ConvertF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.buttonConvertC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label4;
        private TextBox textBoxF;
        private TextBox textBoxC;
        private Button buttonConvertC;
        private Button ConvertF;
        private Button buttonClear;
    }
}