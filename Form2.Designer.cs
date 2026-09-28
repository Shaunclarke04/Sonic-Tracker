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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            radBtnSettingsProgDispPercent = new RadioButton();
            radBtnSettingsProgDispFraction = new RadioButton();
            progDisplayPanel = new Panel();
            lblSonic1 = new Label();
            lblProgInfo = new Label();
            label1 = new Label();
            btnCheckUpdate = new Button();
            btnResetSaveData = new Button();
            panel1 = new Panel();
            tbSearchDelay = new TextBox();
            lblDelayInfo = new Label();
            label2 = new Label();
            progDisplayPanel.SuspendLayout();
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
            // progDisplayPanel
            // 
            progDisplayPanel.BorderStyle = BorderStyle.Fixed3D;
            progDisplayPanel.Controls.Add(lblSonic1);
            progDisplayPanel.Controls.Add(lblProgInfo);
            progDisplayPanel.Controls.Add(radBtnSettingsProgDispFraction);
            progDisplayPanel.Controls.Add(radBtnSettingsProgDispPercent);
            progDisplayPanel.Location = new Point(9, 41);
            progDisplayPanel.Name = "progDisplayPanel";
            progDisplayPanel.Size = new Size(160, 83);
            progDisplayPanel.TabIndex = 2;
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
            // lblProgInfo
            // 
            lblProgInfo.AutoSize = true;
            lblProgInfo.Font = new Font("Webdings", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            lblProgInfo.Location = new Point(127, 1);
            lblProgInfo.Name = "lblProgInfo";
            lblProgInfo.Size = new Size(26, 19);
            lblProgInfo.TabIndex = 4;
            lblProgInfo.Text = "i";
            lblProgInfo.TextAlign = ContentAlignment.MiddleCenter;
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
            // btnCheckUpdate
            // 
            btnCheckUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckUpdate.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckUpdate.Location = new Point(9, 141);
            btnCheckUpdate.Name = "btnCheckUpdate";
            btnCheckUpdate.Size = new Size(147, 35);
            btnCheckUpdate.TabIndex = 4;
            btnCheckUpdate.Text = "Check for Updates";
            btnCheckUpdate.UseVisualStyleBackColor = true;
            btnCheckUpdate.Click += btnCheckUpdate_Click;
            // 
            // btnResetSaveData
            // 
            btnResetSaveData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnResetSaveData.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetSaveData.Location = new Point(169, 141);
            btnResetSaveData.Name = "btnResetSaveData";
            btnResetSaveData.Size = new Size(145, 35);
            btnResetSaveData.TabIndex = 5;
            btnResetSaveData.Text = "Reset Save Data";
            btnResetSaveData.UseVisualStyleBackColor = true;
            btnResetSaveData.Click += btnResetSaveData_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tbSearchDelay);
            panel1.Controls.Add(lblDelayInfo);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(175, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 65);
            panel1.TabIndex = 4;
            // 
            // tbSearchDelay
            // 
            tbSearchDelay.Location = new Point(3, 32);
            tbSearchDelay.Name = "tbSearchDelay";
            tbSearchDelay.Size = new Size(124, 23);
            tbSearchDelay.TabIndex = 4;
            tbSearchDelay.TextChanged += tbSearchDelay_TextChanged;
            // 
            // lblDelayInfo
            // 
            lblDelayInfo.AutoSize = true;
            lblDelayInfo.BackColor = Color.Transparent;
            lblDelayInfo.Font = new Font("Webdings", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            lblDelayInfo.Location = new Point(101, 1);
            lblDelayInfo.Name = "lblDelayInfo";
            lblDelayInfo.Size = new Size(26, 19);
            lblDelayInfo.TabIndex = 5;
            lblDelayInfo.Text = "i";
            lblDelayInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Medium", 12F);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(0, 1);
            label2.Margin = new Padding(0, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 3;
            label2.Text = "Search Delay";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 188);
            Controls.Add(panel1);
            Controls.Add(btnResetSaveData);
            Controls.Add(btnCheckUpdate);
            Controls.Add(label1);
            Controls.Add(progDisplayPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Sonic Tracker Settings";
            KeyDown += Form2_KeyDown;
            progDisplayPanel.ResumeLayout(false);
            progDisplayPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radBtnSettingsProgDispPercent;
        private RadioButton radBtnSettingsProgDispFraction;
        private Panel progDisplayPanel;
        private Label lblSonic1;
        private Label label1;
        private Button btnCheckUpdate;
        private Button btnResetSaveData;
        private Panel panel1;
        private TextBox tbSearchDelay;
        private Label label2;
        private Label lblProgInfo;
        private Label lblDelayInfo;
    }
}