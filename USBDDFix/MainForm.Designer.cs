/*
 * Developer: Simulated Reality Soft.
 * Programmer: Diego Calveyra.
 * License: GNU General Public License v3.0.
 *
 */
namespace USBDDFix
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label_unidad = new System.Windows.Forms.Label();
			this.textbox_log = new System.Windows.Forms.TextBox();
			this.label_result = new System.Windows.Forms.Label();
			this.label_formato = new System.Windows.Forms.Label();
			this.btn_analizar = new System.Windows.Forms.Button();
			this.comboBoxDiscos = new System.Windows.Forms.ComboBox();
			this.btn_empezar = new System.Windows.Forms.Button();
			this.cb_formato = new System.Windows.Forms.ComboBox();
			this.label_letra = new System.Windows.Forms.Label();
			this.cb_letra = new System.Windows.Forms.ComboBox();
			this.btn_letrasDiscos = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abooutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_unidad
			// 
			this.label_unidad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_unidad.Location = new System.Drawing.Point(12, 26);
			this.label_unidad.Name = "label_unidad";
			this.label_unidad.Size = new System.Drawing.Size(100, 17);
			this.label_unidad.TabIndex = 1;
			this.label_unidad.Text = "Dispositivo";
			this.label_unidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textbox_log
			// 
			this.textbox_log.BackColor = System.Drawing.Color.Black;
			this.textbox_log.ForeColor = System.Drawing.Color.Lime;
			this.textbox_log.Location = new System.Drawing.Point(12, 187);
			this.textbox_log.Multiline = true;
			this.textbox_log.Name = "textbox_log";
			this.textbox_log.ReadOnly = true;
			this.textbox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textbox_log.Size = new System.Drawing.Size(367, 85);
			this.textbox_log.TabIndex = 2;
			this.textbox_log.Text = resources.GetString("textbox_log.Text");
			// 
			// label_result
			// 
			this.label_result.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_result.Location = new System.Drawing.Point(12, 163);
			this.label_result.Name = "label_result";
			this.label_result.Size = new System.Drawing.Size(88, 21);
			this.label_result.TabIndex = 3;
			this.label_result.Text = "Resultado";
			this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_formato
			// 
			this.label_formato.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_formato.Location = new System.Drawing.Point(12, 82);
			this.label_formato.Name = "label_formato";
			this.label_formato.Size = new System.Drawing.Size(100, 17);
			this.label_formato.TabIndex = 5;
			this.label_formato.Text = "Formato";
			this.label_formato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_analizar
			// 
			this.btn_analizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_analizar.Location = new System.Drawing.Point(312, 45);
			this.btn_analizar.Name = "btn_analizar";
			this.btn_analizar.Size = new System.Drawing.Size(67, 21);
			this.btn_analizar.TabIndex = 6;
			this.btn_analizar.Text = "Analizar";
			this.btn_analizar.UseVisualStyleBackColor = true;
			this.btn_analizar.Click += new System.EventHandler(this.btnListarDiscos_Click);
			// 
			// comboBoxDiscos
			// 
			this.comboBoxDiscos.BackColor = System.Drawing.SystemColors.Window;
			this.comboBoxDiscos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDiscos.FormattingEnabled = true;
			this.comboBoxDiscos.Location = new System.Drawing.Point(12, 46);
			this.comboBoxDiscos.Name = "comboBoxDiscos";
			this.comboBoxDiscos.Size = new System.Drawing.Size(283, 21);
			this.comboBoxDiscos.TabIndex = 7;
			this.comboBoxDiscos.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscos_SelectedIndexChanged);
			// 
			// btn_empezar
			// 
			this.btn_empezar.Enabled = false;
			this.btn_empezar.Location = new System.Drawing.Point(312, 163);
			this.btn_empezar.Name = "btn_empezar";
			this.btn_empezar.Size = new System.Drawing.Size(67, 21);
			this.btn_empezar.TabIndex = 8;
			this.btn_empezar.Text = "Empezar";
			this.btn_empezar.UseVisualStyleBackColor = true;
			this.btn_empezar.Click += new System.EventHandler(this.btn_empezar_Click);
			// 
			// cb_formato
			// 
			this.cb_formato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_formato.FormattingEnabled = true;
			this.cb_formato.Location = new System.Drawing.Point(12, 102);
			this.cb_formato.Name = "cb_formato";
			this.cb_formato.Size = new System.Drawing.Size(126, 21);
			this.cb_formato.TabIndex = 9;
			this.cb_formato.SelectedIndexChanged += new System.EventHandler(this.cb_formato_SelectedIndexChanged);
			// 
			// label_letra
			// 
			this.label_letra.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_letra.Location = new System.Drawing.Point(166, 82);
			this.label_letra.Name = "label_letra";
			this.label_letra.Size = new System.Drawing.Size(100, 17);
			this.label_letra.TabIndex = 10;
			this.label_letra.Text = "Asignar letra";
			this.label_letra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cb_letra
			// 
			this.cb_letra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_letra.FormattingEnabled = true;
			this.cb_letra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cb_letra.Location = new System.Drawing.Point(166, 103);
			this.cb_letra.Name = "cb_letra";
			this.cb_letra.Size = new System.Drawing.Size(129, 21);
			this.cb_letra.TabIndex = 11;
			this.cb_letra.SelectedIndexChanged += new System.EventHandler(this.cb_letra_SelectedIndexChanged);
			// 
			// btn_letrasDiscos
			// 
			this.btn_letrasDiscos.Location = new System.Drawing.Point(312, 103);
			this.btn_letrasDiscos.Name = "btn_letrasDiscos";
			this.btn_letrasDiscos.Size = new System.Drawing.Size(67, 21);
			this.btn_letrasDiscos.TabIndex = 12;
			this.btn_letrasDiscos.Text = "Actualizar";
			this.btn_letrasDiscos.UseVisualStyleBackColor = true;
			this.btn_letrasDiscos.Click += new System.EventHandler(this.btn_letrasDiscos_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(97, 163);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(198, 21);
			this.progressBar.TabIndex = 13;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.optionsToolStripMenuItem,
									this.abooutToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(391, 24);
			this.menuStrip.TabIndex = 15;
			this.menuStrip.Text = "menuStrip2";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.themeToolStripMenuItem,
									this.lToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// themeToolStripMenuItem
			// 
			this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.lightToolStripMenuItem,
									this.darkToolStripMenuItem});
			this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
			this.themeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.themeToolStripMenuItem.Text = "Theme";
			// 
			// lightToolStripMenuItem
			// 
			this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
			this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.lightToolStripMenuItem.Text = "Light";
			this.lightToolStripMenuItem.Click += new System.EventHandler(this.LightToolStripMenuItemClick);
			// 
			// darkToolStripMenuItem
			// 
			this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
			this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.darkToolStripMenuItem.Text = "Dark";
			this.darkToolStripMenuItem.Click += new System.EventHandler(this.DarkToolStripMenuItemClick);
			// 
			// lToolStripMenuItem
			// 
			this.lToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.englishToolStripMenuItem,
									this.spanishToolStripMenuItem});
			this.lToolStripMenuItem.Name = "lToolStripMenuItem";
			this.lToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.lToolStripMenuItem.Text = "language";
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.englishToolStripMenuItem.Text = "English";
			this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItemClick);
			// 
			// spanishToolStripMenuItem
			// 
			this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
			this.spanishToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.spanishToolStripMenuItem.Text = "Español";
			this.spanishToolStripMenuItem.Click += new System.EventHandler(this.SpanishToolStripMenuItemClick);
			// 
			// abooutToolStripMenuItem
			// 
			this.abooutToolStripMenuItem.Name = "abooutToolStripMenuItem";
			this.abooutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.abooutToolStripMenuItem.Text = "about";
			this.abooutToolStripMenuItem.Click += new System.EventHandler(this.AbooutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(391, 278);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.btn_letrasDiscos);
			this.Controls.Add(this.cb_letra);
			this.Controls.Add(this.label_letra);
			this.Controls.Add(this.cb_formato);
			this.Controls.Add(this.btn_empezar);
			this.Controls.Add(this.comboBoxDiscos);
			this.Controls.Add(this.btn_analizar);
			this.Controls.Add(this.label_formato);
			this.Controls.Add(this.label_result);
			this.Controls.Add(this.textbox_log);
			this.Controls.Add(this.label_unidad);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "USBDDFix";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abooutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button btn_letrasDiscos;
		private System.Windows.Forms.Label label_letra;
		private System.Windows.Forms.ComboBox cb_letra;
		private System.Windows.Forms.ComboBox cb_formato;
		private System.Windows.Forms.Button btn_empezar;
		private System.Windows.Forms.ComboBox comboBoxDiscos;
		private System.Windows.Forms.Button btn_analizar;
		private System.Windows.Forms.Label label_formato;
		private System.Windows.Forms.Label label_result;
		private System.Windows.Forms.TextBox textbox_log;
		private System.Windows.Forms.Label label_unidad;
		
	}
}
