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
            progBarSonic3DBlast = new ProgressBar();
            clbSonic3DBlast = new CheckedListBox();
            lblSonic3DBlast = new Label();
            progBarSonicBlast = new ProgressBar();
            clbSonicBlast = new CheckedListBox();
            lblSonicBlast = new Label();
            progBarTailsAdventure = new ProgressBar();
            clbTailsAdventure = new CheckedListBox();
            lblTailsAdventure = new Label();
            progBarKnucklesChaotix = new ProgressBar();
            clbKnucklesChaotix = new CheckedListBox();
            lblKnucklesChaotix = new Label();
            progBarSonicAndTails2 = new ProgressBar();
            clbSonicAndTails2 = new CheckedListBox();
            lblSonicAndTails2 = new Label();
            progBarSonicAndTails = new ProgressBar();
            clbSonicAndTails = new CheckedListBox();
            lblSonicAndTails = new Label();
            progBarSonic3AndKnuckles = new ProgressBar();
            clbSonic3AndKnuckles = new CheckedListBox();
            lblSonic3AndKnuckles = new Label();
            progBarSonicCD = new ProgressBar();
            clbSonicCD = new CheckedListBox();
            lblSonicCD = new Label();
            flpSearchResults = new FlowLayoutPanel();
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
            lblTitle.Location = new Point(42, 0);
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
            clbSonicTheHedgehog1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbSonicTheHedgehog1.CheckOnClick = true;
            clbSonicTheHedgehog1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicTheHedgehog1.FormattingEnabled = true;
            clbSonicTheHedgehog1.HorizontalScrollbar = true;
            clbSonicTheHedgehog1.Items.AddRange(new object[] { "Green Hill Zone (Act 1)", "Green Hill Zone (Act 4)", "Green Hill Zone (Act 3)", "Marble Zone (Act 1)", "Marble Zone (Act 2)", "Marble Zone (Act 3)", "Spring Yard Zone (Act 1)", "Spring Yard Zone (Act 2)", "Spring Yard Zone (Act 3)", "Labrynth Zone (Act 1)", "Labrynth Zone (Act 2)", "Labrynth Zone (Act 3)", "Star Light Zone (Act 1)", "Star Light Zone (Act 2)", "Star Light Zone (Act 3)", "Scrap Brain Zone (Act 1)", "Scrap Brain Zone (Act 2)", "Scrap Brain Zone (Act 3)", "Final Boss" });
            clbSonicTheHedgehog1.Location = new Point(12, 35);
            clbSonicTheHedgehog1.Name = "clbSonicTheHedgehog1";
            clbSonicTheHedgehog1.Size = new Size(353, 92);
            clbSonicTheHedgehog1.TabIndex = 3;
            clbSonicTheHedgehog1.SelectedIndexChanged += clbSonicTheHedgehog1_SelectedIndexChanged;
            // 
            // lblSonic2
            // 
            lblSonic2.AutoSize = true;
            lblSonic2.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonic2.Location = new Point(12, 159);
            lblSonic2.Margin = new Padding(0, 0, 3, 0);
            lblSonic2.Name = "lblSonic2";
            lblSonic2.Size = new Size(271, 29);
            lblSonic2.TabIndex = 4;
            lblSonic2.Text = "Sonic the Hedgehog 2";
            // 
            // clbSonicTheHedgehog2
            // 
            clbSonicTheHedgehog2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbSonicTheHedgehog2.CheckOnClick = true;
            clbSonicTheHedgehog2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicTheHedgehog2.FormattingEnabled = true;
            clbSonicTheHedgehog2.HorizontalScrollbar = true;
            clbSonicTheHedgehog2.Items.AddRange(new object[] { "Emerald Hill Zone (Act 1)", "Emerald Hill Zone (Act 2)", "Chemical Plant Zone (Act 1)", "Chemical Plant Zone (Act 2)", "Aquatic Ruin Zone (Act 1)", "Aquatic Ruin Zone (Act 2)", "Casino Night Zone (Act 1)", "Casino Night Zone (Act 2)", "Hill Top Zone (Act 1)", "Hill Top Zone (Act 2)", "Mystic Cave Zone (Act 1)", "Mystic Cave Zone (Act 2)", "Oil Ocean Zone (Act 1)", "Oil Ocean Zone (Act 2)", "Metropolis Zone (Act 1)", "Metropolis Zone (Act 2)", "Metropolis Zone (Act 3)", "Sky Chase Zone", "Wing Fortress Zone", "Death Egg Zone" });
            clbSonicTheHedgehog2.Location = new Point(12, 191);
            clbSonicTheHedgehog2.Name = "clbSonicTheHedgehog2";
            clbSonicTheHedgehog2.Size = new Size(353, 92);
            clbSonicTheHedgehog2.TabIndex = 5;
            clbSonicTheHedgehog2.SelectedIndexChanged += clbSonicTheHedgehog2_SelectedIndexChanged;
            // 
            // progBarSonicTheHedgehog1
            // 
            progBarSonicTheHedgehog1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarSonicTheHedgehog1.Location = new Point(12, 133);
            progBarSonicTheHedgehog1.Name = "progBarSonicTheHedgehog1";
            progBarSonicTheHedgehog1.Size = new Size(353, 23);
            progBarSonicTheHedgehog1.TabIndex = 6;
            // 
            // progBarSonicTheHedgehog2
            // 
            progBarSonicTheHedgehog2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarSonicTheHedgehog2.Location = new Point(12, 289);
            progBarSonicTheHedgehog2.Name = "progBarSonicTheHedgehog2";
            progBarSonicTheHedgehog2.Size = new Size(353, 23);
            progBarSonicTheHedgehog2.TabIndex = 7;
            // 
            // PanelContent
            // 
            PanelContent.AutoScroll = true;
            PanelContent.AutoScrollMinSize = new Size(0, 2000);
            PanelContent.Controls.Add(progBarSonic3DBlast);
            PanelContent.Controls.Add(clbSonic3DBlast);
            PanelContent.Controls.Add(lblSonic3DBlast);
            PanelContent.Controls.Add(progBarSonicBlast);
            PanelContent.Controls.Add(clbSonicBlast);
            PanelContent.Controls.Add(lblSonicBlast);
            PanelContent.Controls.Add(progBarTailsAdventure);
            PanelContent.Controls.Add(clbTailsAdventure);
            PanelContent.Controls.Add(lblTailsAdventure);
            PanelContent.Controls.Add(progBarKnucklesChaotix);
            PanelContent.Controls.Add(clbKnucklesChaotix);
            PanelContent.Controls.Add(lblKnucklesChaotix);
            PanelContent.Controls.Add(progBarSonicAndTails2);
            PanelContent.Controls.Add(clbSonicAndTails2);
            PanelContent.Controls.Add(lblSonicAndTails2);
            PanelContent.Controls.Add(progBarSonicAndTails);
            PanelContent.Controls.Add(clbSonicAndTails);
            PanelContent.Controls.Add(lblSonicAndTails);
            PanelContent.Controls.Add(progBarSonic3AndKnuckles);
            PanelContent.Controls.Add(clbSonic3AndKnuckles);
            PanelContent.Controls.Add(lblSonic3AndKnuckles);
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
            PanelContent.Size = new Size(394, 469);
            PanelContent.TabIndex = 8;
            // 
            // progBarSonic3DBlast
            // 
            progBarSonic3DBlast.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarSonic3DBlast.Location = new Point(12, 1653);
            progBarSonic3DBlast.Name = "progBarSonic3DBlast";
            progBarSonic3DBlast.Size = new Size(353, 23);
            progBarSonic3DBlast.TabIndex = 31;
            // 
            // clbSonic3DBlast
            // 
            clbSonic3DBlast.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbSonic3DBlast.CheckOnClick = true;
            clbSonic3DBlast.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonic3DBlast.FormattingEnabled = true;
            clbSonic3DBlast.HorizontalScrollbar = true;
            clbSonic3DBlast.Items.AddRange(new object[] { "Green Grove Zone (Act 1)", "Green Grove Zone (Act 2)", "Green Grove Zone (Act 3)", "Rusty Ruin Zone (Act 1)", "Rusty Ruin Zone (Act 2)", "Rusty Ruin Zone (Act 3)", "Spring Stadium Zone (Act 1)", "Spring Stadium Zone (Act 2)", "Spring Stadium Zone (Act 3)", "Diamond Dust Zone (Act 1)", "Diamond Dust Zone (Act 2)", "Diamond Dust Zone (Act 3)", "Volcano Valley Zone (Act 1)", "Volcano Valley Zone (Act 2)", "Volcano Valley Zone (Act 3)", "Gene Gadget Zone (Act 1)", "Gene Gadget Zone (Act 2)", "Gene Gadget Zone (Act 3)", "Panic Puppet Zone (Act 1)", "Panic Puppet Zone (Act 2)", "Panic Puppet Zone (Act 3)", "The Final Fight" });
            clbSonic3DBlast.Location = new Point(12, 1555);
            clbSonic3DBlast.Name = "clbSonic3DBlast";
            clbSonic3DBlast.Size = new Size(353, 92);
            clbSonic3DBlast.TabIndex = 30;
            clbSonic3DBlast.SelectedIndexChanged += clbSonic3DBlast_SelectedIndexChanged;
            // 
            // lblSonic3DBlast
            // 
            lblSonic3DBlast.AutoSize = true;
            lblSonic3DBlast.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonic3DBlast.Location = new Point(12, 1494);
            lblSonic3DBlast.Margin = new Padding(0, 0, 3, 0);
            lblSonic3DBlast.Name = "lblSonic3DBlast";
            lblSonic3DBlast.Size = new Size(359, 58);
            lblSonic3DBlast.TabIndex = 29;
            lblSonic3DBlast.Text = "Sonic 3D Blast (EU/US)\r\nSonic 3D: Flickies' Island (JP)\r\n";
            // 
            // progBarSonicBlast
            // 
            progBarSonicBlast.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarSonicBlast.Location = new Point(12, 1468);
            progBarSonicBlast.Name = "progBarSonicBlast";
            progBarSonicBlast.Size = new Size(353, 23);
            progBarSonicBlast.TabIndex = 28;
            // 
            // clbSonicBlast
            // 
            clbSonicBlast.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbSonicBlast.CheckOnClick = true;
            clbSonicBlast.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicBlast.FormattingEnabled = true;
            clbSonicBlast.HorizontalScrollbar = true;
            clbSonicBlast.Items.AddRange(new object[] { "Green Hill Zone (Act 1)", "Green Hill Zone (Act 2)", "Green Hill Zone (Act 3)", "Yellow Desert Zone (Act 1)", "Yellow Desert Zone (Act 2)", "Yellow Desert Zone (Act 3)", "Red Volcano Zone (Act 1)", "Red Volcano Zone (Act 2)", "Red Volcano Zone (Act 3)", "Blue Marine Zone (Act 1)", "Blue Marine Zone (Act 2)", "Blue Marine Zone (Act 3)", "Silver Castle Zone (Act 1)", "Silver Castle Zone (Act 2)", "Silver Castle Zone (Act 3)", "Final Boss" });
            clbSonicBlast.Location = new Point(12, 1370);
            clbSonicBlast.Name = "clbSonicBlast";
            clbSonicBlast.Size = new Size(353, 92);
            clbSonicBlast.TabIndex = 27;
            clbSonicBlast.SelectedIndexChanged += clbSonicBlast_SelectedIndexChanged;
            // 
            // lblSonicBlast
            // 
            lblSonicBlast.AutoSize = true;
            lblSonicBlast.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonicBlast.Location = new Point(12, 1309);
            lblSonicBlast.Margin = new Padding(0, 0, 3, 0);
            lblSonicBlast.Name = "lblSonicBlast";
            lblSonicBlast.Size = new Size(244, 58);
            lblSonicBlast.TabIndex = 26;
            lblSonicBlast.Text = "Sonic Blast (EU/US)\r\nG Sonic (JP)";
            // 
            // progBarTailsAdventure
            // 
            progBarTailsAdventure.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarTailsAdventure.Location = new Point(12, 1283);
            progBarTailsAdventure.Name = "progBarTailsAdventure";
            progBarTailsAdventure.Size = new Size(353, 23);
            progBarTailsAdventure.TabIndex = 25;
            // 
            // clbTailsAdventure
            // 
            clbTailsAdventure.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbTailsAdventure.CheckOnClick = true;
            clbTailsAdventure.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbTailsAdventure.FormattingEnabled = true;
            clbTailsAdventure.HorizontalScrollbar = true;
            clbTailsAdventure.Items.AddRange(new object[] { "Poloy Forest", "Volcanic Tunnel", "Polly Mountain 1", "Lake Rocky", "Cavern Island", "Green Island", "Lake Crystal", "Polly Mountain 2", "Caron Forest", "Coco Island", "Battle Fortress 1", "Battle Fortress 2" });
            clbTailsAdventure.Location = new Point(12, 1185);
            clbTailsAdventure.Name = "clbTailsAdventure";
            clbTailsAdventure.Size = new Size(353, 92);
            clbTailsAdventure.TabIndex = 24;
            clbTailsAdventure.SelectedIndexChanged += clbTailsAdventure_SelectedIndexChanged;
            // 
            // lblTailsAdventure
            // 
            lblTailsAdventure.AutoSize = true;
            lblTailsAdventure.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTailsAdventure.Location = new Point(12, 1153);
            lblTailsAdventure.Margin = new Padding(0, 0, 3, 0);
            lblTailsAdventure.Name = "lblTailsAdventure";
            lblTailsAdventure.Size = new Size(194, 29);
            lblTailsAdventure.TabIndex = 23;
            lblTailsAdventure.Text = "Tails Adventure";
            // 
            // progBarKnucklesChaotix
            // 
            progBarKnucklesChaotix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarKnucklesChaotix.Location = new Point(12, 1127);
            progBarKnucklesChaotix.Name = "progBarKnucklesChaotix";
            progBarKnucklesChaotix.Size = new Size(353, 23);
            progBarKnucklesChaotix.TabIndex = 22;
            // 
            // clbKnucklesChaotix
            // 
            clbKnucklesChaotix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbKnucklesChaotix.CheckOnClick = true;
            clbKnucklesChaotix.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbKnucklesChaotix.FormattingEnabled = true;
            clbKnucklesChaotix.HorizontalScrollbar = true;
            clbKnucklesChaotix.Items.AddRange(new object[] { "Botanic Base (Level 1)", "Botanic Base (Level 2)", "Botanic Base (Level 3)", "Botanic Base (Level 4)", "Botanic Base (Level 5)", "Speed Slider (Level 1)", "Speed Slider (Level 2)", "Speed Slider (Level 3)", "Speed Slider (Level 4)", "Speed Slider (Level 5)", "Amazing Arena (Level 1)", "Amazing Arena (Level 2)", "Amazing Arena (Level 3)", "Amazing Arena (Level 4)", "Amazing Arena (Level 5)", "Marina Madness (Level 1)", "Marina Madness (Level 2)", "Marina Madness (Level 3)", "Marina Madness (Level 4)", "Marina Madness (Level 5)", "Techno Tower (Level 1)", "Techno Tower (Level 2)", "Techno Tower (Level 3)", "Techno Tower (Level 4)", "Techno Tower (Level 5)", "Metal Sonic", "Metal Sonic Kai" });
            clbKnucklesChaotix.Location = new Point(12, 1029);
            clbKnucklesChaotix.Name = "clbKnucklesChaotix";
            clbKnucklesChaotix.Size = new Size(353, 92);
            clbKnucklesChaotix.TabIndex = 21;
            clbKnucklesChaotix.SelectedIndexChanged += clbKnucklesChaotix_SelectedIndexChanged;
            // 
            // lblKnucklesChaotix
            // 
            lblKnucklesChaotix.AutoSize = true;
            lblKnucklesChaotix.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKnucklesChaotix.Location = new Point(12, 997);
            lblKnucklesChaotix.Margin = new Padding(0, 0, 3, 0);
            lblKnucklesChaotix.Name = "lblKnucklesChaotix";
            lblKnucklesChaotix.Size = new Size(215, 29);
            lblKnucklesChaotix.TabIndex = 20;
            lblKnucklesChaotix.Text = "Knuckles Chaotix";
            // 
            // progBarSonicAndTails2
            // 
            progBarSonicAndTails2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarSonicAndTails2.Location = new Point(12, 971);
            progBarSonicAndTails2.Name = "progBarSonicAndTails2";
            progBarSonicAndTails2.Size = new Size(353, 23);
            progBarSonicAndTails2.TabIndex = 19;
            // 
            // clbSonicAndTails2
            // 
            clbSonicAndTails2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbSonicAndTails2.CheckOnClick = true;
            clbSonicAndTails2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicAndTails2.FormattingEnabled = true;
            clbSonicAndTails2.HorizontalScrollbar = true;
            clbSonicAndTails2.Items.AddRange(new object[] { "Great Turquoise Zone (Act 1)", "Great Turquoise Zone (Act 2)", "Great Turquoise Zone (Act 3)", "Sunset Park Zone (Act 1)", "Sunset Park Zone (Act 2)", "Sunset Park Zone (Act 3)", "Meta Junglira Zone (Act 1)", "Meta Junglira Zone (Act 2)", "Meta Junglira Zone (Act 3)", "Robotnik Winter Zone (Act 1)", "Robotnik Winter Zone (Act 2)", "Robotnik Winter Zone (Act 3)", "Tidal Plant Zone (Act 1)", "Tidal Plant Zone (Act 2)", "Tidal Plant Zone (Act 3)", "Atomic Destroyer Zone (Act 1)", "Atomic Destroyer Zone (Act 2)", "Atomic Destroyer Zone (Act 3)" });
            clbSonicAndTails2.Location = new Point(12, 873);
            clbSonicAndTails2.Name = "clbSonicAndTails2";
            clbSonicAndTails2.Size = new Size(353, 92);
            clbSonicAndTails2.TabIndex = 18;
            // 
            // lblSonicAndTails2
            // 
            lblSonicAndTails2.AutoSize = true;
            lblSonicAndTails2.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonicAndTails2.Location = new Point(12, 812);
            lblSonicAndTails2.Margin = new Padding(0, 0, 3, 0);
            lblSonicAndTails2.Name = "lblSonicAndTails2";
            lblSonicAndTails2.Size = new Size(346, 58);
            lblSonicAndTails2.TabIndex = 17;
            lblSonicAndTails2.Text = "Sonic Triple Trouble (EU/US)\r\nSonic && Tails 2 (JP)\r\n";
            // 
            // progBarSonicAndTails
            // 
            progBarSonicAndTails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarSonicAndTails.ForeColor = SystemColors.InactiveBorder;
            progBarSonicAndTails.Location = new Point(12, 630);
            progBarSonicAndTails.Name = "progBarSonicAndTails";
            progBarSonicAndTails.Size = new Size(353, 23);
            progBarSonicAndTails.TabIndex = 16;
            // 
            // clbSonicAndTails
            // 
            clbSonicAndTails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbSonicAndTails.CheckOnClick = true;
            clbSonicAndTails.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicAndTails.FormattingEnabled = true;
            clbSonicAndTails.HorizontalScrollbar = true;
            clbSonicAndTails.Items.AddRange(new object[] { "Turquoise Hill Zone (Act 1)", "Turquoise Hill Zone (Act 2)", "Turquoise Hill Zone (Act 3)", "Gigapolis Zone (Act 1)", "Gigapolis Zone (Act 2)", "Gigapolis Zone (Act 3)", "Sleeping Egg Zone (Act 1)", "Sleeping Egg Zone (Act 2)", "Sleeping Egg Zone (Act 3)", "Mecha Green Hill Zone (Act 1)", "Mecha Green Hill Zone (Act 2)", "Mecha Green Hill Zone (Act 3)", "Aqua Planet Zone (Act 1)", "Aqua Planet Zone (Act 2)", "Aqua Planet Zone (Act 3)", "Electric Egg Zone (Act 1)", "Electric Egg Zone (Act 2)", "Electric Egg Zone (Act 3)" });
            clbSonicAndTails.Location = new Point(12, 532);
            clbSonicAndTails.Name = "clbSonicAndTails";
            clbSonicAndTails.Size = new Size(353, 92);
            clbSonicAndTails.TabIndex = 15;
            clbSonicAndTails.SelectedIndexChanged += clbSonicAndTails_SelectedIndexChanged;
            // 
            // lblSonicAndTails
            // 
            lblSonicAndTails.AutoSize = true;
            lblSonicAndTails.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonicAndTails.Location = new Point(12, 471);
            lblSonicAndTails.Margin = new Padding(0, 0, 3, 0);
            lblSonicAndTails.Name = "lblSonicAndTails";
            lblSonicAndTails.Size = new Size(258, 58);
            lblSonicAndTails.TabIndex = 14;
            lblSonicAndTails.Text = "Sonic Chaos (EU/US)\r\nSonic && Tails (JP)";
            // 
            // progBarSonic3AndKnuckles
            // 
            progBarSonic3AndKnuckles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarSonic3AndKnuckles.Location = new Point(15, 786);
            progBarSonic3AndKnuckles.Name = "progBarSonic3AndKnuckles";
            progBarSonic3AndKnuckles.Size = new Size(350, 23);
            progBarSonic3AndKnuckles.TabIndex = 13;
            // 
            // clbSonic3AndKnuckles
            // 
            clbSonic3AndKnuckles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbSonic3AndKnuckles.CheckOnClick = true;
            clbSonic3AndKnuckles.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonic3AndKnuckles.FormattingEnabled = true;
            clbSonic3AndKnuckles.HorizontalScrollbar = true;
            clbSonic3AndKnuckles.Items.AddRange(new object[] { "Angel Island Zone (Act 1) - Sonic 3", "Angel Island Zone (Act 2) - Sonic 3", "Hydrocity Zone (Act 1) - Sonic 3", "Hydrocity Zone (Act 2) - Sonic 3", "Marble Garden Zone (Act 1) - Sonic 3", "Marble Garden Zone (Act 2) - Sonic 3", "Carnival Night Zone (Act 1) - Sonic 3", "Carnival Night Zone (Act 2) - Sonic 3", "IceCap Zone (Act 1) - Sonic 3", "IceCap Zone (Act 2) - Sonic 3", "Launch Base Zone (Act 1) - Sonic 3", "Launch Base Zone (Act 2) - Sonic 3", "Mushroom Hill Zone (Act 1) - Sonic & Knuckles", "Mushroom Hill Zone (Act 2) - Sonic & Knuckles", "Flying Battery Zone (Act 1) - Sonic & Knuckles", "Flying Battery Zone (Act 2) - Sonic & Knuckles", "Sandopolis Zone (Act 1) - Sonic & Knuckles", "Sandopolis Zone (Act 2) - Sonic & Knuckles", "Lava Reef Zone (Act 1) - Sonic & Knuckles", "Lava Reef Zone (Act 2) - Sonic & Knuckles", "Hidden Palace Zone - Sonic & Knuckles", "Sky Sanctuary Zone - Sonic & Knuckles", "Death Egg Zone (Act 1) - Sonic & Knuckles", "Death Egg Zone (Act 2) - Sonic & Knuckles", "The Doomsday Zone - Sonic & Knuckles" });
            clbSonic3AndKnuckles.Location = new Point(12, 688);
            clbSonic3AndKnuckles.Name = "clbSonic3AndKnuckles";
            clbSonic3AndKnuckles.Size = new Size(353, 92);
            clbSonic3AndKnuckles.TabIndex = 12;
            clbSonic3AndKnuckles.SelectedIndexChanged += clbSonic3AndKnuckles_SelectedIndexChanged;
            // 
            // lblSonic3AndKnuckles
            // 
            lblSonic3AndKnuckles.AutoSize = true;
            lblSonic3AndKnuckles.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonic3AndKnuckles.Location = new Point(12, 656);
            lblSonic3AndKnuckles.Margin = new Padding(0, 0, 3, 0);
            lblSonic3AndKnuckles.Name = "lblSonic3AndKnuckles";
            lblSonic3AndKnuckles.Size = new Size(236, 29);
            lblSonic3AndKnuckles.TabIndex = 11;
            lblSonic3AndKnuckles.Text = "Sonic 3 && Knuckles";
            // 
            // progBarSonicCD
            // 
            progBarSonicCD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progBarSonicCD.Location = new Point(12, 445);
            progBarSonicCD.Name = "progBarSonicCD";
            progBarSonicCD.Size = new Size(353, 23);
            progBarSonicCD.TabIndex = 10;
            // 
            // clbSonicCD
            // 
            clbSonicCD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbSonicCD.CheckOnClick = true;
            clbSonicCD.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbSonicCD.FormattingEnabled = true;
            clbSonicCD.HorizontalScrollbar = true;
            clbSonicCD.Items.AddRange(new object[] { "Palmtree Panic (Present)", "Palmtree Panic (Good Future)", "Palmtree Panic (Bad Future)", "Collision Chaos (Present)", "Collision Chaos (Good Future)", "Collision Chaos (Bad Future)", "Tidal Tempest (Present)", "Tidal Tempest (Good Future)", "Tidal Tempest (Bad Future)", "Quartz Quadrant (Present)", "Quartz Quadrant (Good Future)", "Quartz Quadrant (Bad Future)", "Wacky Workbench (Present)", "Wacky Workbench (Good Future)", "Wacky Workbench (Bad Future)", "Stardust Speedway (Present)", "Stardust Speedway (Good Future)", "Stardust Speedway (Bad Future)", "Metallic Madness (Present)", "Metallic Madness (Good Future)", "Metallic Madness (Bad Future)", "Final Fever" });
            clbSonicCD.Location = new Point(12, 347);
            clbSonicCD.Name = "clbSonicCD";
            clbSonicCD.Size = new Size(353, 92);
            clbSonicCD.TabIndex = 9;
            clbSonicCD.SelectedIndexChanged += clbSonicCD_SelectedIndexChanged;
            // 
            // lblSonicCD
            // 
            lblSonicCD.AutoSize = true;
            lblSonicCD.Font = new Font("Roboto Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonicCD.Location = new Point(12, 315);
            lblSonicCD.Margin = new Padding(0, 0, 3, 0);
            lblSonicCD.Name = "lblSonicCD";
            lblSonicCD.Size = new Size(119, 29);
            lblSonicCD.TabIndex = 8;
            lblSonicCD.Text = "Sonic CD";
            // 
            // flpSearchResults
            // 
            flpSearchResults.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpSearchResults.AutoSize = true;
            flpSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpSearchResults.Location = new Point(15, 90);
            flpSearchResults.MinimumSize = new Size(350, 0);
            flpSearchResults.Name = "flpSearchResults";
            flpSearchResults.Size = new Size(350, 0);
            flpSearchResults.TabIndex = 11;
            flpSearchResults.Visible = false;
            // 
            // PanelHeader
            // 
            PanelHeader.Controls.Add(tbSearch);
            PanelHeader.Controls.Add(lblTitle);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(394, 90);
            PanelHeader.TabIndex = 9;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.Location = new Point(12, 58);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search";
            tbSearch.Size = new Size(362, 23);
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
            PanelFooter.Size = new Size(394, 132);
            PanelFooter.TabIndex = 8;
            // 
            // linkLabel3
            // 
            linkLabel3.Anchor = AnchorStyles.Bottom;
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(135, 109);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(129, 15);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "View Source On Github";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(249, 87);
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
            label1.Size = new Size(394, 87);
            label1.TabIndex = 0;
            label1.Text = "Not affiliated with Sega or Sonic.\r\n\r\nSonic The Hedgehog is a trademark of SegaSammy\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            ClientSize = new Size(394, 691);
            Controls.Add(flpSearchResults);
            Controls.Add(PanelContent);
            Controls.Add(PanelFooter);
            Controls.Add(PanelHeader);
            MinimumSize = new Size(410, 500);
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
        private ProgressBar progBarSonic3AndKnuckles;
        private CheckedListBox clbSonic3AndKnuckles;
        private Label lblSonic3AndKnuckles;
        private ProgressBar progBarSonicAndTails;
        private CheckedListBox clbSonicAndTails;
        private Label lblSonicAndTails;
        private ProgressBar progBarSonicAndTails2;
        private CheckedListBox clbSonicAndTails2;
        private Label lblSonicAndTails2;
        private ProgressBar progBarKnucklesChaotix;
        private CheckedListBox clbKnucklesChaotix;
        private Label lblKnucklesChaotix;
        private ProgressBar progBarTailsAdventure;
        private CheckedListBox clbTailsAdventure;
        private Label lblTailsAdventure;
        private ProgressBar progBarSonicBlast;
        private CheckedListBox clbSonicBlast;
        private Label lblSonicBlast;
        private ProgressBar progBarSonic3DBlast;
        private CheckedListBox clbSonic3DBlast;
        private Label lblSonic3DBlast;
    }
}
