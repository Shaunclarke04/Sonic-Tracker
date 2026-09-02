using System;

namespace SonicTracker;
public partial class Form1
{
    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        System.Diagnostics.Process.Start(
       new System.Diagnostics.ProcessStartInfo
       {
           FileName = "https://www.shaunclarke.co.uk",
           UseShellExecute = true
       });
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        System.Diagnostics.Process.Start(
       new System.Diagnostics.ProcessStartInfo
       {
           FileName = "https://www.sonicthehedgehog.com",
           UseShellExecute = true
       });
    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        System.Diagnostics.Process.Start(
       new System.Diagnostics.ProcessStartInfo
       {
           FileName = "https://github.com/Shaunclarke04/Sonic-Tracker",
           UseShellExecute = true
       });
    }
}