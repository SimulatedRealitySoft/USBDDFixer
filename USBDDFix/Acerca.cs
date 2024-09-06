/*
 * Developer: Simulated Reality Soft.
 * Programmer: Diego Calveyra.
 * License: GNU General Public License v3.0.
 *
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace USBDDFix
{
	public partial class Acerca : Form
	{
		public Acerca()
		{
			InitializeComponent();
        
		}
		
		void Label_github_linkClick(object sender, EventArgs e)
		{
			string url = "https://github.com/SimulatedRealitySoft/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });			
		}
		
		void Label_github_linkEnter(object sender, EventArgs e)
		{
			label_github_link.ForeColor = Color.BlueViolet;
		}
		
		void Label_github_linkLeave(object sender, EventArgs e)
		{
			label_github_link.ForeColor = SystemColors.Highlight;
		}
	}
}
