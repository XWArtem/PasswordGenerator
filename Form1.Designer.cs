namespace PasswordGenerator
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
            Generate = new Button();
            passwordField = new TextBox();
            avoidAmbiguousCheckmark = new CheckBox();
            passLen = new NumericUpDown();
            PassLength = new Label();
            CopyPass = new Button();
            ((System.ComponentModel.ISupportInitialize)passLen).BeginInit();
            SuspendLayout();
            // 
            // Generate
            // 
            Generate.BackColor = SystemColors.GradientActiveCaption;
            Generate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Generate.Location = new Point(180, 450);
            Generate.Margin = new Padding(3, 4, 3, 4);
            Generate.Name = "Generate";
            Generate.Size = new Size(200, 50);
            Generate.TabIndex = 0;
            Generate.Text = "Generate";
            Generate.UseVisualStyleBackColor = false;
            Generate.Click += Generate_Click;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(220, 250);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(360, 27);
            passwordField.TabIndex = 1;
            passwordField.TextAlign = HorizontalAlignment.Center;
            // 
            // avoidAmbiguousCheckmark
            // 
            avoidAmbiguousCheckmark.AutoSize = true;
            avoidAmbiguousCheckmark.Location = new Point(220, 348);
            avoidAmbiguousCheckmark.Name = "avoidAmbiguousCheckmark";
            avoidAmbiguousCheckmark.Size = new Size(227, 24);
            avoidAmbiguousCheckmark.TabIndex = 2;
            avoidAmbiguousCheckmark.Text = "Avoid ambiguous (I,i,l,L,0,o,O)";
            avoidAmbiguousCheckmark.UseVisualStyleBackColor = true;
            avoidAmbiguousCheckmark.CheckedChanged += AvoidAmbiguous_CheckedChanged;
            // 
            // passLen
            // 
            passLen.Location = new Point(220, 303);
            passLen.Maximum = new decimal(new int[] { 36, 0, 0, 0 });
            passLen.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            passLen.Name = "passLen";
            passLen.Size = new Size(60, 27);
            passLen.TabIndex = 3;
            passLen.TextAlign = HorizontalAlignment.Center;
            passLen.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // PassLength
            // 
            PassLength.AutoSize = true;
            PassLength.Location = new Point(286, 310);
            PassLength.Name = "PassLength";
            PassLength.Size = new Size(116, 20);
            PassLength.TabIndex = 4;
            PassLength.Text = "Password length";
            // 
            // CopyPass
            // 
            CopyPass.BackColor = SystemColors.GradientActiveCaption;
            CopyPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CopyPass.Location = new Point(416, 450);
            CopyPass.Margin = new Padding(3, 4, 3, 4);
            CopyPass.Name = "CopyPass";
            CopyPass.Size = new Size(200, 50);
            CopyPass.TabIndex = 5;
            CopyPass.Text = "Copy";
            CopyPass.UseVisualStyleBackColor = false;
            CopyPass.Click += CopyPass_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(CopyPass);
            Controls.Add(PassLength);
            Controls.Add(passLen);
            Controls.Add(avoidAmbiguousCheckmark);
            Controls.Add(passwordField);
            Controls.Add(Generate);
            Name = "Form1";
            Text = "PasswordGenerator";
            ((System.ComponentModel.ISupportInitialize)passLen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Generate;
        private TextBox passwordField;
        private CheckBox avoidAmbiguousCheckmark;
        private NumericUpDown passLen;
        private Label PassLength;
        private Button CopyPass;
    }
}