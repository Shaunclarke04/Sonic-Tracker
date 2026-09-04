using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SonicTracker
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            LoadSettings();
        }

        public void LoadSettings()
        {
            //set radio buttons based on saved settings
            radBtnSettingsProgDispPercent.Checked = !Properties.Settings.Default.PreferredFraction;
            radBtnSettingsProgDispFraction.Checked = Properties.Settings.Default.PreferredFraction;
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
    }
}
