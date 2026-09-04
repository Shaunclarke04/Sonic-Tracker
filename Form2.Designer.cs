namespace SonicTracker
{
    partial class Form2
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
            radBtnSettingsProgDispPercent = new RadioButton();
            radBtnSettingsProgDispFraction = new RadioButton();
            panel1 = new Panel();
            lblSonic1 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // radBtnSettingsProgDispPercent
            // 
            radBtnSettingsProgDispPercent.AutoSize = true;
            radBtnSettingsProgDispPercent.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radBtnSettingsProgDispPercent.Location = new Point(3, 33);
            radBtnSettingsProgDispPercent.Name = "radBtnSettingsProgDispPercent";
            radBtnSettingsProgDispPercent.Size = new Size(90, 19);
            radBtnSettingsProgDispPercent.TabIndex = 0;
            radBtnSettingsProgDispPercent.TabStop = true;
            radBtnSettingsProgDispPercent.Text = "Percentage";
            radBtnSettingsProgDispPercent.UseVisualStyleBackColor = true;
            radBtnSettingsProgDispPercent.CheckedChanged += radBtnSettingsProgDispPercent_CheckedChanged;
            // 
            // radBtnSettingsProgDispFraction
            // 
            radBtnSettingsProgDispFraction.AutoSize = true;
            radBtnSettingsProgDispFraction.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radBtnSettingsProgDispFraction.Location = new Point(3, 58);
            radBtnSettingsProgDispFraction.Name = "radBtnSettingsProgDispFraction";
            radBtnSettingsProgDispFraction.Size = new Size(71, 19);
            radBtnSettingsProgDispFraction.TabIndex = 1;
            radBtnSettingsProgDispFraction.TabStop = true;
            radBtnSettingsProgDispFraction.Text = "Fraction";
            radBtnSettingsProgDispFraction.UseVisualStyleBackColor = true;
            radBtnSettingsProgDispFraction.CheckedChanged += radBtnSettingsProgDispFraction_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblSonic1);
            panel1.Controls.Add(radBtnSettingsProgDispFraction);
            panel1.Controls.Add(radBtnSettingsProgDispPercent);
            panel1.Location = new Point(9, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 83);
            panel1.TabIndex = 2;
            // 
            // lblSonic1
            // 
            lblSonic1.AutoSize = true;
            lblSonic1.Font = new Font("Roboto Medium", 12F);
            lblSonic1.ImageAlign = ContentAlignment.TopCenter;
            lblSonic1.Location = new Point(3, 1);
            lblSonic1.Margin = new Padding(0, 0, 3, 0);
            lblSonic1.Name = "lblSonic1";
            lblSonic1.Size = new Size(130, 19);
            lblSonic1.TabIndex = 3;
            lblSonic1.Text = "Progress Display";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(9, 9);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(276, 29);
            label1.TabIndex = 3;
            label1.Text = "Sonic Tracker Settings";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Sonic Tracker Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radBtnSettingsProgDispPercent;
        private RadioButton radBtnSettingsProgDispFraction;
        private Panel panel1;
        private Label lblSonic1;
        private Label label1;
    }
}