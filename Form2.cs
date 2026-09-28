using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SonicTracker
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        public int SearchDelay;

        //tooltips
        System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();
        public Form2(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            LoadSettings();
            KeyPreview = true;
            SetTooltips();
        }

        public void SetTooltips()
        {
            tooltip.SetToolTip(lblProgInfo, "Have your progress for each game shown as a percentage or a fraction");
            tooltip.SetToolTip(lblDelayInfo, "delay between stopping typing and the results loading");
        }

        public void LoadSettings()
        {
            //set radio buttons based on saved settings
            radBtnSettingsProgDispPercent.Checked = !Properties.Settings.Default.PreferredFraction;
            radBtnSettingsProgDispFraction.Checked = Properties.Settings.Default.PreferredFraction;

            //Load SearchDelay from saved settings
            SearchDelay = Properties.Settings.Default.SearchDelay;
            tbSearchDelay.Text = SearchDelay.ToString();

        }
        private void radBtnSettingsProgDispPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnSettingsProgDispPercent.Checked)
            {
                Properties.Settings.Default.PreferredFraction = false;
                Properties.Settings.Default.Save();

                mainForm.FinalizeLoad();
            }
        }

        private void radBtnSettingsProgDispFraction_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnSettingsProgDispFraction.Checked)
            {
                Properties.Settings.Default.PreferredFraction = true;
                Properties.Settings.Default.Save();

                mainForm.FinalizeLoad();
            }
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            mainForm.checkForUpdates();
        }

        private void btnResetSaveData_Click(object sender, EventArgs e)
        {
            mainForm.resetSaveData();
        }

        private void tbSearchDelay_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbSearchDelay.Text, out int delay) || tbSearchDelay.Text == "")
            {
                if (tbSearchDelay.Text == "")
                    delay = 0;
                SearchDelay = delay;
                Properties.Settings.Default.SearchDelay = delay;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show
                    (
                        "Must be an integer",
                        "Error_003",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                tbSearchDelay.Text = SearchDelay.ToString();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Hide();
            }
        }
    }
}
