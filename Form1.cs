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
                lblSonic3AndKnuckles
            };

            //update UI based on saved settings
            FinalizeLoad();
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

        //update progress bars based on checked items in the checked list boxes
        public void updateProgessBars(CheckedListBox listBox, ProgressBar progressBar)
        {
            int totalItems = listBox.Items.Count;
            int checkedItems = listBox.CheckedItems.Count;
            progressBar.Value = totalItems > 0 ? (checkedItems * 100) / totalItems : 0;
        }
        public void FinalizeLoad()
        {
            //load checked items from settings
            LoadCheckedItems(clbSonicTheHedgehog1, Properties.Settings.Default.SonicTheHedgehog1CheckedItems);
            LoadCheckedItems(clbSonicTheHedgehog2, Properties.Settings.Default.SonicTheHedgehog2CheckedItems);
            LoadCheckedItems(clbSonicCD, Properties.Settings.Default.SonicCDCheckedItems);
            LoadCheckedItems(clbSonic3AndKnuckles, Properties.Settings.Default.Sonic3AndKnucklesCheckedItems);

            //update progress bars
            updateProgessBars(clbSonicTheHedgehog1, progBarSonicTheHedgehog1);
            updateProgessBars(clbSonicTheHedgehog2, progBarSonicTheHedgehog2);
            updateProgessBars(clbSonicCD, progBarSonicCD);
            updateProgessBars(clbSonic3AndKnuckles, progBarSonic3AndKnuckles);
        }

        //save checked items to settings when a checked list box item is changed
        private void clbSonicTheHedgehog1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicTheHedgehog1.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicTheHedgehog1CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            updateProgessBars(clbSonicTheHedgehog1, progBarSonicTheHedgehog1);
        }

        private void clbSonicTheHedgehog2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicTheHedgehog2.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicTheHedgehog2CheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            updateProgessBars(clbSonicTheHedgehog2, progBarSonicTheHedgehog2);
        }

        private void clbSonicCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonicCD.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.SonicCDCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            updateProgessBars(clbSonicCD, progBarSonicCD);
        }

        private void clbSonic3AndKnuckles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = clbSonic3AndKnuckles.CheckedIndices.Cast<int>().ToArray();
            Properties.Settings.Default.Sonic3AndKnucklesCheckedItems = string.Join(",", checkedItems);
            Properties.Settings.Default.Save();
            updateProgessBars(clbSonic3AndKnuckles, progBarSonic3AndKnuckles);
        }
    }
}
    