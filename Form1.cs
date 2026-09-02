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

            searchableLabels = new List<Label>
            {
                lblSonic1,
                lblSonic2,
                lblSonicCD
            };

            FinalizeLoad();
        }

        public List<Label> searchableLabels;
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            flpSearchResults.Visible = tbSearch.Text != "";
            flpSearchResults.Controls.Clear();

            string search = tbSearch.Text.Trim();

            if (string.IsNullOrEmpty(search))
                return;

            foreach (Label label in searchableLabels)
            {
                if (label.Text.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    Button result = new Button
                    {
                        Text = label.Text,
                        AutoSize = true
                    };

                    result.Click += (s, e) =>
                    {
                        label.Focus();

                        if (label.Parent is ScrollableControl scrollableParent)
                        {
                            scrollableParent.AutoScrollPosition = new Point(0, label.Top);
                        }
                        flpSearchResults.Visible = false;
                    };

                    flpSearchResults.Controls.Add(result);
                }
            }
        }

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

        public void updateProgessBars(CheckedListBox listBox, ProgressBar progressBar)
        {
            int totalItems = listBox.Items.Count;
            int checkedItems = listBox.CheckedItems.Count;
            progressBar.Value = totalItems > 0 ? (checkedItems * 100) / totalItems : 0;
        }
        public void FinalizeLoad()
        {
            LoadCheckedItems(clbSonicTheHedgehog1, Properties.Settings.Default.SonicTheHedgehog1CheckedItems);
            updateProgessBars(clbSonicTheHedgehog1, progBarSonicTheHedgehog1);
            LoadCheckedItems(clbSonicTheHedgehog2, Properties.Settings.Default.SonicTheHedgehog2CheckedItems);
            updateProgessBars(clbSonicTheHedgehog2, progBarSonicTheHedgehog2);
            LoadCheckedItems(clbSonicCD, Properties.Settings.Default.SonicCDCheckedItems);
            updateProgessBars(clbSonicCD, progBarSonicCD);
        }

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
    }
}
    