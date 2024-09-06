/*
 * Developer: Simulated Reality Soft.
 * Programmer: Diego Calveyra.
 * License: GNU General Public License v3.0.
 *
 */
namespace USBDDFix
{
	partial class Acerca
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelDiskpartGui = new System.Windows.Forms.Label();
			this.label_srs = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_github_link = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelDiskpartGui
			// 
			this.labelDiskpartGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
			this.labelDiskpartGui.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDiskpartGui.ForeColor = System.Drawing.Color.White;
			this.labelDiskpartGui.Location = new System.Drawing.Point(0, -1);
			this.labelDiskpartGui.Name = "labelDiskpartGui";
			this.labelDiskpartGui.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.labelDiskpartGui.Size = new System.Drawing.Size(179, 46);
			this.labelDiskpartGui.TabIndex = 0;
			this.labelDiskpartGui.Text = "USBDDFix";
			this.labelDiskpartGui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_srs
			// 
			this.label_srs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
			this.label_srs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_srs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
			this.label_srs.Location = new System.Drawing.Point(0, 45);
			this.label_srs.Name = "label_srs";
			this.label_srs.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.label_srs.Size = new System.Drawing.Size(252, 25);
			this.label_srs.TabIndex = 1;
			this.label_srs.Text = "Simulated Reality Soft";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
			this.label1.Location = new System.Drawing.Point(0, 82);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.label1.Size = new System.Drawing.Size(282, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "Programmer: Diego Calveyra.\r\nLicense: GNU General Public License v3.0.\r\n";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 122);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.label2.Size = new System.Drawing.Size(282, 52);
			this.label2.TabIndex = 2;
			this.label2.Text = "This software is free and open source, if you paid for it, request a refund.\r\nYou" +
			" can find the source code here:";
			// 
			// label_github_link
			// 
			this.label_github_link.BackColor = System.Drawing.Color.Transparent;
			this.label_github_link.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label_github_link.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_github_link.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label_github_link.Location = new System.Drawing.Point(0, 174);
			this.label_github_link.Name = "label_github_link";
			this.label_github_link.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.label_github_link.Size = new System.Drawing.Size(282, 22);
			this.label_github_link.TabIndex = 3;
			this.label_github_link.Text = "github.com/SimulatedRealitySoft/USBDDFixer";
			this.label_github_link.Click += new System.EventHandler(this.Label_github_linkClick);
			this.label_github_link.MouseEnter += new System.EventHandler(this.Label_github_linkEnter);
			this.label_github_link.MouseLeave += new System.EventHandler(this.Label_github_linkLeave);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
			this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(176, -1);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
			this.label4.Size = new System.Drawing.Size(76, 46);
			this.label4.TabIndex = 0;
			this.label4.Text = "v1.2";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Acerca
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.ClientSize = new System.Drawing.Size(284, 213);
			this.Controls.Add(this.label_github_link);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label_srs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelDiskpartGui);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Acerca";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Acerca";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_github_link;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_srs;
		private System.Windows.Forms.Label labelDiskpartGui;
	}
}
