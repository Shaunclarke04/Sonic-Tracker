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

            //Define the list of searchable labels
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
                lblSonic3DBlast,
                lblSonicPocketAdventure,
                lblSonicAdventure,
                lblSonicAdventure2,
                lblSonicAdvance,
                lblSonicAdvance2,
                lblSonicHeroes,
                lblSonicAdvance3,
                lblSonicRush,
                lblShadowTheHedgehog,
                lblSonic06,
                lblSonicSecretRings,
                lblSonicRushAdventure,
                lblSonicUnleashedPS2,
                lblSonicUnleashedPS3,
                lblSonicBlackNight,
                lblSonic4E1,
                lblSonicColors,
                lblSonicGenerations,
                lblSonic4E2,
                lblSonicLostWorld,
                lblSonicBoomLyric,
                lblSonicBoomShatteredCrystal,
                lblSonicBoomFireIce,
                lblSonicMania,
                lblSonicForces,
                lblSonicColorsUltimate,
                lblSonicFrontiers,
                lblSonicSuperstars,
                lblSonicDreamTeam,
                lblSonicShadowGenerations
            };

            //update UI based on saved settings
            FinalizeLoad();
        }
        //Initialize the list of searchable labels
        public List<Label> searchableLabels;

        //open settings form when the settings button is clicked
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        //display information about the application when the info button is clicked
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sonic Tracker v0.1\n\nDeveloped by: Shaun Clarke\n\nThis application is a personal project and is not affiliated with or endorsed by SEGA, Sonic Team or any other company.\n\nAll rights to the Sonic the Hedgehog franchise and its characters are owned by SEGA.\n\nSee footer links for more details", "About Sonic Tracker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
        private void UpdateProgress(CheckedListBox clb, ProgressBar progBar, Label label, string gameTitle)
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
            LoadCheckedItems(clbSonicPocketAdventure, Properties.Settings.Default.SonicPocketAdventureCheckedItems);
            LoadCheckedItems(clbSonicAdventure, Properties.Settings.Default.SonicAdventureCheckedItems);
            LoadCheckedItems(clbSonicAdventure2, Properties.Settings.Default.SonicAdventure2CheckedItems);
            LoadCheckedItems(clbSonicAdvance, Properties.Settings.Default.SonicAdvanceCheckedItems);
            LoadCheckedItems(clbSonicAdvance2, Properties.Settings.Default.SonicAdvance2CheckedItems);
            LoadCheckedItems(clbSonicHeroes, Properties.Settings.Default.SonicHeroesCheckedItems);
            LoadCheckedItems(clbSonicAdvance3, Properties.Settings.Default.SonicAdvance3CheckedItems);
            LoadCheckedItems(clbSonicRush, Properties.Settings.Default.SonicRushCheckedItems);
            LoadCheckedItems(clbShadowTheHedgehog, Properties.Settings.Default.ShadowTheHedgehogCheckedItems);
            LoadCheckedItems(clbSonic06, Properties.Settings.Default.Sonic06CheckedItems);
            LoadCheckedItems(clbSonicSecretRings, Properties.Settings.Default.SonicSecretRingsCheckedItems);
            LoadCheckedItems(clbSonicRushAdventure, Properties.Settings.Default.SonicRushAdventureCheckedItems);
            LoadCheckedItems(clbSonicUnleashedPS2, Properties.Settings.Default.SonicUnleashedPS2CheckedItems);
            LoadCheckedItems(clbSonicUnleashedPS3, Properties.Settings.Default.SonicUnleashedPS3CheckedItems);
            LoadCheckedItems(clbSonicBlackNight, Properties.Settings.Default.SonicBlackNightCheckedItems);
            LoadCheckedItems(clbSonic4E1, Properties.Settings.Default.Sonic4E1CheckedItems);
            LoadCheckedItems(clbSonicColors, Properties.Settings.Default.SonicColorsCheckedItems);
            LoadCheckedItems(clbSonicGenerations, Properties.Settings.Default.SonicGenerationsCheckedItems);
            LoadCheckedItems(clbSonic4E2, Properties.Settings.Default.Sonic4E2CheckedItems);
            LoadCheckedItems(clbSonicLostWorld, Properties.Settings.Default.SonicLostWorldCheckedItems);
            LoadCheckedItems(clbSonicBoomLyric, Properties.Settings.Default.SonicBoomLyricCheckedItems);
            LoadCheckedItems(clbSonicBoomShatteredCrystal, Properties.Settings.Default.SonicBoomShatteredCrystalCheckedItems);
            LoadCheckedItems(clbSonicBoomFireIce, Properties.Settings.Default.SonicBoomFireIceCheckedItems);
            LoadCheckedItems(clbSonicMania, Properties.Settings.Default.SonicManiaCheckedItems);
            LoadCheckedItems(clbSonicForces, Properties.Settings.Default.SonicForcesCheckedItems);
            LoadCheckedItems(clbSonicColorsUltimate, Properties.Settings.Default.SonicColorsUltimateCheckedItems);
            LoadCheckedItems(clbSonicFrontiers, Properties.Settings.Default.SonicFrontiersCheckedItems);
            LoadCheckedItems(clbSonicSuperstars, Properties.Settings.Default.SonicSuperstarsCheckedItems);
            LoadCheckedItems(clbSonicDreamTeam, Properties.Settings.Default.SonicDreamTeamCheckedItems);
            LoadCheckedItems(clbSonicShadowGenerations, Properties.Settings.Default.SonicShadowGenerationsCheckedItems);

            //update progress 
            UpdateProgress(clbSonicTheHedgehog1, progBarSonicTheHedgehog1, lblSonic1, "Sonic the Hedgehog");
            UpdateProgress(clbSonicTheHedgehog2, progBarSonicTheHedgehog2, lblSonic2, "Sonic the Hedgehog 2");
            UpdateProgress(clbSonicCD, progBarSonicCD, lblSonicCD, "Sonic CD");
            UpdateProgress(clbSonic3AndKnuckles, progBarSonic3AndKnuckles, lblSonic3AndKnuckles, "Sonic 3 and Knuckles");
            UpdateProgress(clbSonicAndTails, progBarSonicAndTails, lblSonicAndTails, "Sonic Chaos (EU/US)\nSonic && Tails (JP)");
            UpdateProgress(clbSonicAndTails2, progBarSonicAndTails2, lblSonicAndTails2, "Sonic Triple Trouble (EU/US)\nSonic && Tails 2 (JP)");
            UpdateProgress(clbKnucklesChaotix, progBarKnucklesChaotix, lblKnucklesChaotix, "Knuckles Chaotix");
            UpdateProgress(clbTailsAdventure, progBarTailsAdventure, lblTailsAdventure, "Tails Adventure");
            UpdateProgress(clbSonicBlast, progBarSonicBlast, lblSonicBlast, "Sonic Blast (EU/US)\nG Sonic (JP)");
            UpdateProgress(clbSonic3DBlast, progBarSonic3DBlast, lblSonic3DBlast, "Sonic 3D Blast (EU/US)\nSonic 3D: Flickies' Island (JP)");
            UpdateProgress(clbSonicPocketAdventure, progBarSonicPocketAdventure, lblSonicPocketAdventure, "Sonic Pocket Adventure");
            UpdateProgress(clbSonicAdventure, progBarSonicAdventure, lblSonicAdventure, "Sonic Adventure");
            UpdateProgress(clbSonicAdventure2, progBarSonicAdventure2, lblSonicAdventure2, "Sonic Adventure 2");
            UpdateProgress(clbSonicAdvance, progBarSonicAdvance, lblSonicAdvance, "Sonic Advance");
            UpdateProgress(clbSonicAdvance2, progBarSonicAdvance2, lblSonicAdvance2, "Sonic Advance 2");
            UpdateProgress(clbSonicHeroes, progBarSonicHeroes, lblSonicHeroes, "Sonic Heroes");
            UpdateProgress(clbSonicAdvance3, progBarSonicAdvance3, lblSonicAdvance3, "Sonic Advance 3");
            UpdateProgress(clbSonicRush, progBarSonicRush, lblSonicRush, "Sonic Rush");
            UpdateProgress(clbShadowTheHedgehog, progBarShadowTheHedgehog, lblShadowTheHedgehog, "Shadow The Hedgehog");
            UpdateProgress(clbSonic06, progBarSonic06, lblSonic06, "Sonic the Hedgehog // Sonic '06");
            UpdateProgress(clbSonicSecretRings, progBarSonicSecretRings, lblSonicSecretRings, "Sonic and the Secret Rings");
            UpdateProgress(clbSonicRushAdventure, progBarSonicRushAdventure, lblSonicRushAdventure, "Sonic Rush Adventure");
            UpdateProgress(clbSonicUnleashedPS2, progBarSonicUnleashedPS2, lblSonicUnleashedPS2, "Sonic Unleashed (EU/US) (PS2/Wii)\nSonic World Adventure (JP)");
            UpdateProgress(clbSonicUnleashedPS3, progBarSonicUnleashedPS3, lblSonicUnleashedPS3, "Sonic Unleashed (EU/US) (PS3/X360)\nSonic World Adventure (JP)");
            UpdateProgress(clbSonicBlackNight, progBarSonicBlackNight, lblSonicBlackNight, "Sonic and the Black Knight");
            UpdateProgress(clbSonic4E1, progBarSonic4E1, lblSonic4E1, "Sonic the Hedgehog 4: Episode I");
            UpdateProgress(clbSonicColors, progBarSonicColors, lblSonicColors, "Sonic Colors");
            UpdateProgress(clbSonicGenerations, progBarSonicGenerations, lblSonicGenerations, "Sonic Generations");
            UpdateProgress(clbSonic4E2, progBarSonic4E2, lblSonic4E2, "Sonic the Hedgehog 4: Episode II");
            UpdateProgress(clbSonicLostWorld, progBarSonicLostWorld, lblSonicLostWorld, "Sonic Lost World");
            UpdateProgress(clbSonicBoomLyric, progBarSonicBoomLyric, lblSonicBoomLyric, "Sonic Boom: Rise of Lyric (EU/US)\nSonic Toon: Ancient Treasure (JP)");
            UpdateProgress(clbSonicBoomShatteredCrystal, progBarSonicBoomShatteredCrystal, lblSonicBoomShatteredCrystal, "Sonic Boom: Shattered Crystal (EU/US)\nSonic Toon: Island Adventure (JP)");
            UpdateProgress(clbSonicBoomFireIce, progBarSonicBoomFireIce, lblSonicBoomFireIce, "Sonic Boom: Fire && Ice (EU/US)\nSonic Toon: Fire && Ice (JP)");
            UpdateProgress(clbSonicMania, progBarSonicMania, lblSonicMania, "Sonic Mania");
            UpdateProgress(clbSonicForces, progBarSonicForces, lblSonicForces, "Sonic Forces");
            UpdateProgress(clbSonicColorsUltimate, progBarSonicColorsUltimate, lblSonicColorsUltimate, "Sonic Colors: Ultimate");
            UpdateProgress(clbSonicFrontiers, progBarSonicFrontiers, lblSonicFrontiers, "Sonic Frontiers");
            UpdateProgress(clbSonicSuperstars, progBarSonicSuperstars, lblSonicSuperstars, "Sonic Superstars");
            UpdateProgress(clbSonicDreamTeam, progBarSonicDreamTeam, lblSonicDreamTeam, "Sonic Dream Team");
            UpdateProgress(clbSonicShadowGenerations, progBarSonicShadowGenerations, lblSonicShadowGenerations, "Sonic X Shadow Generations");
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
            UpdateProgress(clbSonicAndTails, progBarSonicAndTails, lblSonicAndTails, "Sonic Chaos (EU/US)\nSonic && Tails (JP)");
        }
        private void clbSonicAndTails2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicAndTails2.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicAndTails2CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicAndTails2, progBarSonicAndTails2, lblSonicAndTails2, "Sonic Triple Trouble (EU/US)\nSonic && Tails 2 (JP)");
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
            UpdateProgress(clbSonicBlast, progBarSonicBlast, lblSonicBlast, "Sonic Blast (EU/US)\nG Sonic (JP)");
        }
        private void clbSonic3DBlast_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonic3DBlast.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.Sonic3DBlastCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonic3DBlast, progBarSonic3DBlast, lblSonic3DBlast, "Sonic 3D Blast (EU/US)\nSonic 3D: Flickies' Island (JP)");
        }
        private void clbSonicPocketAdventure_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicPocketAdventure.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicPocketAdventureCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicPocketAdventure, progBarSonicPocketAdventure, lblSonicPocketAdventure, "Sonic Pocket Adventure");
        }
        private void clbSonicAdventure_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicAdventure.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicAdventureCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicAdventure, progBarSonicAdventure, lblSonicAdventure, "Sonic Adventure");
        }
        private void clbSonicAdventure2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicAdventure2.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicAdventure2CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicAdventure2, progBarSonicAdventure2, lblSonicAdventure2, "Sonic Adventure 2");
        }
        private void clbSonicAdvance_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicAdvance.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicAdvanceCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicAdvance, progBarSonicAdvance, lblSonicAdvance, "Sonic Advance");
        }
        private void clbSonicAdvance2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicAdvance2.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicAdvance2CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicAdvance2, progBarSonicAdvance2, lblSonicAdvance2, "Sonic Advance 2");
        }
        private void clbSonicHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicHeroes.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicHeroesCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicHeroes, progBarSonicHeroes, lblSonicHeroes, "Sonic Heroes");
        }
        private void clbSonicAdvance3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicAdvance3.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicAdvance3CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicAdvance3, progBarSonicAdvance3, lblSonicAdvance3, "Sonic Advance 3");
        }
        private void clbSonicRush_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicRush.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicRushCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicRush, progBarSonicRush, lblSonicRush, "Sonic Rush");
        }
        private void clbShadowTheHedgehog_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbShadowTheHedgehog.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.ShadowTheHedgehogCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbShadowTheHedgehog, progBarShadowTheHedgehog, lblShadowTheHedgehog, "Shadow The Hedgehog");
        }
        private void clbSonic06_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonic06.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.Sonic06CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonic06, progBarSonic06, lblSonic06, "Sonic the Hedgehog // Sonic '06");
        }
        private void clbSonicSecretRings_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicSecretRings.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicSecretRingsCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicSecretRings, progBarSonicSecretRings, lblSonicSecretRings, "Sonic and the Secret Rings");
        }
        private void clbSonicRushAdventure_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicRushAdventure.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicRushAdventureCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicRushAdventure, progBarSonicRushAdventure, lblSonicRushAdventure, "Sonic Rush Adventure");
        }
        private void clbSonicUnleashedPS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicUnleashedPS2.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicUnleashedPS2CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicUnleashedPS2, progBarSonicUnleashedPS2, lblSonicUnleashedPS2, "Sonic Unleashed (EU/US) (PS2/Wii)\nSonic World Adventure (JP)");
        }
        private void clbSonicUnleashedPS3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicUnleashedPS3.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicUnleashedPS3CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicUnleashedPS3, progBarSonicUnleashedPS3, lblSonicUnleashedPS3, "Sonic Unleashed (EU/US) (PS3/X360)\nSonic World Adventure (JP)");
        }
        private void clbSonicBlackNight_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicBlackNight.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicBlackNightCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicBlackNight, progBarSonicBlackNight, lblSonicBlackNight, "Sonic and the Black Knight");
        }
        private void clbSonic4E1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonic4E1.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.Sonic4E1CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonic4E1, progBarSonic4E1, lblSonic4E1, "Sonic the Hedgehog 4: Episode I");
        }
        private void clbSonicColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicColors.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicColorsCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicColors, progBarSonicColors, lblSonicColors, "Sonic Colors");
        }
        private void clbSonicGenerations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicGenerations.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicGenerationsCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicGenerations, progBarSonicGenerations, lblSonicGenerations, "Sonic Generations");
        }
        private void clbSonic4E2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonic4E2.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.Sonic4E2CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonic4E2, progBarSonic4E2, lblSonic4E2, "Sonic the Hedgehog 4: Episode II");
        }
        private void clbSonicLostWorld_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicLostWorld.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicLostWorldCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicLostWorld, progBarSonicLostWorld, lblSonicLostWorld, "Sonic Lost World");
        }
        private void clbSonicBoomLyric_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicBoomLyric.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicBoomLyricCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicBoomLyric, progBarSonicBoomLyric, lblSonicBoomLyric, "Sonic Boom: Rise of Lyric (EU/US)\nSonic Toon: Ancient Treasure (JP)");
        }
        private void clbSonicBoomShatteredCrystal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicBoomShatteredCrystal.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicBoomShatteredCrystalCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicBoomShatteredCrystal, progBarSonicBoomShatteredCrystal, lblSonicBoomShatteredCrystal, "Sonic Boom: Shattered Crystal (EU/US)\nSonic Toon: Island Adventure (JP)");
        }
        private void clbSonicBoomFireIce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicBoomFireIce.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicBoomFireIceCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicBoomFireIce, progBarSonicBoomFireIce, lblSonicBoomFireIce, "Sonic Boom: Fire && Ice (EU/US)\nSonic Toon: Fire && Ice (JP)");
        }
        private void clbSonicMania_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicMania.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicManiaCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicMania, progBarSonicMania, lblSonicMania, "Sonic Mania");
        }
        private void clbSonicForces_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicForces.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicForcesCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicForces, progBarSonicForces, lblSonicForces, "Sonic Forces");
        }
        private void clbSonicColorsUltimate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicColorsUltimate.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicColorsUltimateCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicColorsUltimate, progBarSonicColorsUltimate, lblSonicColorsUltimate, "Sonic Colors: Ultimate");
        }
        private void clbSonicFrontiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicFrontiers.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicFrontiersCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicFrontiers, progBarSonicFrontiers, lblSonicFrontiers, "Sonic Frontiers");
        }
        private void clbSonicSuperstars_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicSuperstars.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicSuperstarsCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicSuperstars, progBarSonicSuperstars, lblSonicSuperstars, "Sonic Superstars");
        }
        private void clbSonicDreamTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicDreamTeam.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicDreamTeamCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicDreamTeam, progBarSonicDreamTeam, lblSonicDreamTeam, "Sonic Dream Team");
        }
        private void clbSonicShadowGenerations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicShadowGenerations.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicShadowGenerationsCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            UpdateProgress(clbSonicShadowGenerations, progBarSonicShadowGenerations, lblSonicShadowGenerations, "Sonic X Shadow Generations");
        }
    }
}
