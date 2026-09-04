using System.DirectoryServices;
using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;

namespace SonicTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Initialize the list of searchable labels
            searchableLabels = new List<Label>
            {
                lblSonic1,
                lblSonic2,
                lblSonicCD,
                lblSonic3AndKnuckles,
                lblSonicAndTails,
                lblSonicAndTails2,
                lblKnucklesChaotix,
                lblTailsAdventure,
                lblSonicBlast,
                lblSonic3DBlast
            };

            //update UI based on saved settings
            FinalizeLoad();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sonic Tracker v0.1\n\nDeveloped by: Shaun Clarke\n\nThis application is a personal project and is not affiliated with or endorsed by SEGA, Sonic Team or any other company.\n\nAll rights to the Sonic the Hedgehog franchise and its characters are owned by SEGA.\n\nSee footer links for more details", "About Sonic Tracker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Label> searchableLabels;
        //initialise search results flow layout panel
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            flpSearchResults.Visible = tbSearch.Text != "";
            flpSearchResults.Controls.Clear();

            string search = tbSearch.Text.Trim();

            if (string.IsNullOrEmpty(search))
                return;

            //check each label for a match and create a button for each match
            foreach (Label label in searchableLabels)
            {
                if (label.Text.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    Button result = new Button
                    {
                        Text = label.Text,
                        AutoSize = true
                    };

                    //jump to label and hide search results when result is clicked
                    result.Click += (s, e) =>
                    {
                        label.Focus();

                        if (label.Parent is ScrollableControl scrollableParent)
                        {
                            scrollableParent.AutoScrollPosition = new Point(0, label.Top);
                        }
                        flpSearchResults.Visible = false;
                    };

                    //add result button to search results flow layout panel
                    flpSearchResults.Controls.Add(result);
                }
            }
        }

        //load checked items from settings into the checked list boxes
        private void LoadCheckedItems(CheckedListBox listBox, string checkedItems)
        {
            if (!string.IsNullOrEmpty(checkedItems))
            {
                var indices = checkedItems.Split(',').Select(int.Parse).ToArray();

                foreach (var index in indices)
                {
                    if (index >= 0 && index < listBox.Items.Count)
                    {
                        listBox.SetItemChecked(index, true);
                    }
                }
            }

        }
        
        //update progress bars and labels based on checked items in the checked list boxes
        private void UpdateProgress(
            CheckedListBox clb,
            ProgressBar progBar,
            Label label,
            string gameTitle)
        {
            string progressReadout;
            updateProgessBars(clb, progBar);

            //check user preference for progress display and update label accordingly
            if (Properties.Settings.Default.PreferredFraction)
                progressReadout = clb.CheckedItems.Count.ToString() + "/" + clb.Items.Count.ToString();
            else
                progressReadout = progBar.Value.ToString() + "%";

            //update label text with game title and progress readout
            label.Text = gameTitle + " - " + progressReadout;
        }


        //update progress bars based on checked items in the checked list boxes
        public void updateProgessBars(CheckedListBox listBox, ProgressBar progressBar)
        {
            int totalItems = listBox.Items.Count;
            int checkedItems = listBox.CheckedItems.Count;
            progressBar.Value = totalItems > 0 ? (checkedItems * 100) / totalItems : 0;
        }

        //load progress and checked items from settings when the form is loaded
        public void FinalizeLoad()
        {
            //load checked items from settings
            LoadCheckedItems(clbSonicTheHedgehog1, Properties.Settings.Default.SonicTheHedgehog1CheckedItems);
            LoadCheckedItems(clbSonicTheHedgehog2, Properties.Settings.Default.SonicTheHedgehog2CheckedItems);
            LoadCheckedItems(clbSonicCD, Properties.Settings.Default.SonicCDCheckedItems);
            LoadCheckedItems(clbSonic3AndKnuckles, Properties.Settings.Default.Sonic3AndKnucklesCheckedItems);
            LoadCheckedItems(clbSonicAndTails, Properties.Settings.Default.SonicAndTailsCheckedItems);
            LoadCheckedItems(clbSonicAndTails2, Properties.Settings.Default.SonicAndTails2CheckedItems);
            LoadCheckedItems(clbKnucklesChaotix, Properties.Settings.Default.KnucklesChaotixCheckedItems);
            LoadCheckedItems(clbTailsAdventure, Properties.Settings.Default.TailsAdventureCheckedItems);
            LoadCheckedItems(clbSonicBlast, Properties.Settings.Default.SonicBlastCheckedItems);
            LoadCheckedItems(clbSonic3DBlast, Properties.Settings.Default.Sonic3DBlastCheckedItems);

            //update progress 
            UpdateProgress(clbSonicTheHedgehog1, progBarSonicTheHedgehog1, lblSonic1, "Sonic the Hedgehog");
            UpdateProgress(clbSonicTheHedgehog2, progBarSonicTheHedgehog2, lblSonic2, "Sonic the Hedgehog 2");
            UpdateProgress(clbSonicCD, progBarSonicCD, lblSonicCD, "Sonic CD");
            UpdateProgress(clbSonic3AndKnuckles, progBarSonic3AndKnuckles, lblSonic3AndKnuckles, "Sonic 3 and Knuckles");
            UpdateProgress(clbSonicAndTails, progBarSonicAndTails, lblSonicAndTails, "Sonic and Tails");
            UpdateProgress(clbSonicAndTails2, progBarSonicAndTails2, lblSonicAndTails2, "Sonic and Tails 2");
            UpdateProgress(clbKnucklesChaotix, progBarKnucklesChaotix, lblKnucklesChaotix, "Knuckles Chaotix");
            UpdateProgress(clbTailsAdventure, progBarTailsAdventure, lblTailsAdventure, "Tails Adventure");
            UpdateProgress(clbSonicBlast, progBarSonicBlast, lblSonicBlast, "Sonic Blast");
            UpdateProgress(clbSonic3DBlast, progBarSonic3DBlast, lblSonic3DBlast, "Sonic 3D Blast");
        }

        //save checked items to settings when a checked list box item is changed
        private void clbSonicTheHedgehog1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicTheHedgehog1.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicTheHedgehog1CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicTheHedgehog1, progBarSonicTheHedgehog1, lblSonic1, "Sonic the Hedgehog");
        }

        private void clbSonicTheHedgehog2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicTheHedgehog2.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicTheHedgehog2CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicTheHedgehog2, progBarSonicTheHedgehog2, lblSonic2, "Sonic the Hedgehog 2");
        }

        private void clbSonicCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicCD.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicCDCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicCD, progBarSonicCD, lblSonicCD, "Sonic CD");
        }

        private void clbSonic3AndKnuckles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonic3AndKnuckles.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.Sonic3AndKnucklesCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonic3AndKnuckles, progBarSonic3AndKnuckles, lblSonic3AndKnuckles, "Sonic 3 & Knuckles");
        }
        private void clbSonicAndTails_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicAndTails.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicAndTailsCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicAndTails, progBarSonicAndTails, lblSonicAndTails, "Sonic & Tails");
        }
        private void clbSonicAndTails2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicAndTails2.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicAndTails2CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicAndTails2, progBarSonicAndTails2, lblSonicAndTails2, "Sonic & Tails 2");
        }
        private void clbKnucklesChaotix_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbKnucklesChaotix.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.KnucklesChaotixCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbKnucklesChaotix, progBarKnucklesChaotix, lblKnucklesChaotix, "Knuckles Chaotix");
        }
        private void clbTailsAdventure_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbTailsAdventure.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.TailsAdventureCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbTailsAdventure, progBarTailsAdventure, lblTailsAdventure, "Tails Adventure");
        }
        private void clbSonicBlast_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicBlast.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicBlastCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicBlast, progBarSonicBlast, lblSonicBlast, "Sonic Blast");
        }
        private void clbSonic3DBlast_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonic3DBlast.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.Sonic3DBlastCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonic3DBlast, progBarSonic3DBlast, lblSonic3DBlast, "Sonic 3D Blast");
        }
    }
}