namespace SonicTracker
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
            lblTitle = new Label();
            lblSonic1 = new Label();
            clbSonicTheHedgehog1 = new CheckedListBox();
            lblSonic2 = new Label();
            clbSonicTheHedgehog2 = new CheckedListBox();
            progBarSonicTheHedgehog1 = new ProgressBar();
            progBarSonicTheHedgehog2 = new ProgressBar();
            PanelContent = new Panel();
            flpSearchResults = new FlowLayoutPanel();
            progBarSonicCD = new ProgressBar();
            clbSonicCD = new CheckedListBox();
            lblSonicCD = new Label();
            PanelHeader = new Panel();
            tbSearch = new TextBox();
            PanelFooter = new Panel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            PanelContent.SuspendLayout();
            PanelHeader.SuspendLayout();
            PanelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Roboto Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 58);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SonicTracker";
            // 
            // lblSonic1
            // 
            lblSonic1.AutoSize = true;
            lblSonic1.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonic1.ImageAlign = ContentAlignment.TopCenter;
            lblSonic1.Location = new Point(12, 3);
            lblSonic1.Margin = new Padding(0, 0, 3, 0);
            lblSonic1.Name = "lblSonic1";
            lblSonic1.Size = new Size(249, 29);
            lblSonic1.TabIndex = 2;
            lblSonic1.Text = "Sonic the Hedgehog";
            // 
            // clbSonicTheHedgehog1
            // 
            clbSonicTheHedgehog1.CheckOnClick = true;
            clbSonicTheHedgehog1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicTheHedgehog1.FormattingEnabled = true;
            clbSonicTheHedgehog1.Items.AddRange(new object[] { "Green Hill Zone (Act 1)", "Green Hill Zone (Act 4)", "Green Hill Zone (Act 3)", "Marble Zone (Act 1)", "Marble Zone (Act 2)", "Marble Zone (Act 3)", "Spring Yard Zone (Act 1)", "Spring Yard Zone (Act 2)", "Spring Yard Zone (Act 3)", "Labrynth Zone (Act 1)", "Labrynth Zone (Act 2)", "Labrynth Zone (Act 3)", "Star Light Zone (Act 1)", "Star Light Zone (Act 2)", "Star Light Zone (Act 3)", "Scrap Brain Zone (Act 1)", "Scrap Brain Zone (Act 2)", "Scrap Brain Zone (Act 3)", "Final Boss" });
            clbSonicTheHedgehog1.Location = new Point(12, 35);
            clbSonicTheHedgehog1.Name = "clbSonicTheHedgehog1";
            clbSonicTheHedgehog1.Size = new Size(249, 92);
            clbSonicTheHedgehog1.TabIndex = 3;
            clbSonicTheHedgehog1.SelectedIndexChanged += clbSonicTheHedgehog1_SelectedIndexChanged;
            // 
            // lblSonic2
            // 
            lblSonic2.AutoSize = true;
            lblSonic2.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonic2.Location = new Point(12, 179);
            lblSonic2.Margin = new Padding(0, 0, 3, 0);
            lblSonic2.Name = "lblSonic2";
            lblSonic2.Size = new Size(271, 29);
            lblSonic2.TabIndex = 4;
            lblSonic2.Text = "Sonic the Hedgehog 2";
            // 
            // clbSonicTheHedgehog2
            // 
            clbSonicTheHedgehog2.CheckOnClick = true;
            clbSonicTheHedgehog2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicTheHedgehog2.FormattingEnabled = true;
            clbSonicTheHedgehog2.Items.AddRange(new object[] { "Emerald Hill Zone (Act 1)", "Emerald Hill Zone (Act 2)", "Chemical Plant Zone (Act 1)", "Chemical Plant Zone (Act 2)", "Aquatic Ruin Zone (Act 1)", "Aquatic Ruin Zone (Act 2)", "Casino Night Zone (Act 1)", "Casino Night Zone (Act 2)", "Hill Top Zone (Act 1)", "Hill Top Zone (Act 2)", "Mystic Cave Zone (Act 1)", "Mystic Cave Zone (Act 2)", "Oil Ocean Zone (Act 1)", "Oil Ocean Zone (Act 2)", "Metropolis Zone (Act 1)", "Metropolis Zone (Act 2)", "Metropolis Zone (Act 3)", "Sky Chase Zone", "Wing Fortress Zone", "Death Egg Zone" });
            clbSonicTheHedgehog2.Location = new Point(12, 211);
            clbSonicTheHedgehog2.Name = "clbSonicTheHedgehog2";
            clbSonicTheHedgehog2.Size = new Size(249, 92);
            clbSonicTheHedgehog2.TabIndex = 5;
            clbSonicTheHedgehog2.SelectedIndexChanged += clbSonicTheHedgehog2_SelectedIndexChanged;
            // 
            // progBarSonicTheHedgehog1
            // 
            progBarSonicTheHedgehog1.Location = new Point(12, 133);
            progBarSonicTheHedgehog1.Name = "progBarSonicTheHedgehog1";
            progBarSonicTheHedgehog1.Size = new Size(249, 23);
            progBarSonicTheHedgehog1.TabIndex = 6;
            // 
            // progBarSonicTheHedgehog2
            // 
            progBarSonicTheHedgehog2.Location = new Point(12, 309);
            progBarSonicTheHedgehog2.Name = "progBarSonicTheHedgehog2";
            progBarSonicTheHedgehog2.Size = new Size(249, 23);
            progBarSonicTheHedgehog2.TabIndex = 7;
            // 
            // PanelContent
            // 
            PanelContent.AutoScroll = true;
            PanelContent.AutoScrollMinSize = new Size(0, 2000);
            PanelContent.Controls.Add(progBarSonicCD);
            PanelContent.Controls.Add(clbSonicCD);
            PanelContent.Controls.Add(lblSonicCD);
            PanelContent.Controls.Add(lblSonic1);
            PanelContent.Controls.Add(clbSonicTheHedgehog1);
            PanelContent.Controls.Add(lblSonic2);
            PanelContent.Controls.Add(clbSonicTheHedgehog2);
            PanelContent.Controls.Add(progBarSonicTheHedgehog1);
            PanelContent.Controls.Add(progBarSonicTheHedgehog2);
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(0, 90);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(335, 469);
            PanelContent.TabIndex = 8;
            // 
            // flpSearchResults
            // 
            flpSearchResults.Anchor = AnchorStyles.Top;
            flpSearchResults.AutoSize = true;
            flpSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpSearchResults.Location = new Point(15, 90);
            flpSearchResults.MaximumSize = new Size(300, 0);
            flpSearchResults.MinimumSize = new Size(300, 10);
            flpSearchResults.Name = "flpSearchResults";
            flpSearchResults.Size = new Size(300, 10);
            flpSearchResults.TabIndex = 11;
            flpSearchResults.Visible = false;
            // 
            // progBarSonicCD
            // 
            progBarSonicCD.Location = new Point(12, 493);
            progBarSonicCD.Name = "progBarSonicCD";
            progBarSonicCD.Size = new Size(249, 23);
            progBarSonicCD.TabIndex = 10;
            // 
            // clbSonicCD
            // 
            clbSonicCD.CheckOnClick = true;
            clbSonicCD.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicCD.FormattingEnabled = true;
            clbSonicCD.Items.AddRange(new object[] { "Palmtree Panic (Present)", "Palmtree Panic (Good Future)", "Palmtree Panic (Bad Future)", "Collision Chaos (Present)", "Collision Chaos (Good Future)", "Collision Chaos (Bad Future)", "Tidal Tempest (Present)", "Tidal Tempest (Good Future)", "Tidal Tempest (Bad Future)", "Quartz Quadrant (Present)", "Quartz Quadrant (Good Future)", "Quartz Quadrant (Bad Future)", "Wacky Workbench (Present)", "Wacky Workbench (Good Future)", "Wacky Workbench (Bad Future)", "Stardust Speedway (Present)", "Stardust Speedway (Good Future)", "Stardust Speedway (Bad Future)", "Metallic Madness (Present)", "Metallic Madness (Good Future)", "Metallic Madness (Bad Future)", "Final Fever" });
            clbSonicCD.Location = new Point(12, 395);
            clbSonicCD.Name = "clbSonicCD";
            clbSonicCD.Size = new Size(249, 92);
            clbSonicCD.TabIndex = 9;
            clbSonicCD.SelectedIndexChanged += clbSonicCD_SelectedIndexChanged;
            // 
            // lblSonicCD
            // 
            lblSonicCD.AutoSize = true;
            lblSonicCD.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonicCD.Location = new Point(12, 363);
            lblSonicCD.Margin = new Padding(0, 0, 3, 0);
            lblSonicCD.Name = "lblSonicCD";
            lblSonicCD.Size = new Size(119, 29);
            lblSonicCD.TabIndex = 8;
            lblSonicCD.Text = "Sonic CD";
            // 
            // PanelHeader
            // 
            PanelHeader.Controls.Add(tbSearch);
            PanelHeader.Controls.Add(lblTitle);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(335, 90);
            PanelHeader.TabIndex = 9;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(12, 58);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(303, 23);
            tbSearch.TabIndex = 1;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // PanelFooter
            // 
            PanelFooter.Controls.Add(linkLabel3);
            PanelFooter.Controls.Add(linkLabel2);
            PanelFooter.Controls.Add(label1);
            PanelFooter.Controls.Add(linkLabel1);
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.Location = new Point(0, 559);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(335, 132);
            PanelFooter.TabIndex = 8;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(106, 112);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(129, 15);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "View Source On Github";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(189, 87);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(133, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "sonicthehedgehog.com";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 87);
            label1.TabIndex = 0;
            label1.Text = "Not affiliated with Sega or Sonic.\r\n\r\nSonic The Hedgehog is a trademark of SegaSammy\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 87);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "shaunclarke.co.uk";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 691);
            Controls.Add(flpSearchResults);
            Controls.Add(PanelContent);
            Controls.Add(PanelFooter);
            Controls.Add(PanelHeader);
            Name = "Form1";
            Text = "  Sonic Tracker";
            PanelContent.ResumeLayout(false);
            PanelContent.PerformLayout();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            PanelFooter.ResumeLayout(false);
            PanelFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSonic1;
        private CheckedListBox clbSonicTheHedgehog1;
        private Label lblSonic2;
        private CheckedListBox clbSonicTheHedgehog2;
        private ProgressBar progBarSonicTheHedgehog1;
        private ProgressBar progBarSonicTheHedgehog2;
        private Panel PanelContent;
        private Panel PanelHeader;
        private Panel PanelFooter;
        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private CheckedListBox clbSonicCD;
        private Label lblSonicCD;
        private ProgressBar progBarSonicCD;
        private TextBox tbSearch;
        private FlowLayoutPanel flpSearchResults;
    }
}
