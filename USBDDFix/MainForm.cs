/*
 * Developer: Simulated Reality Soft.
 * Programmer: Diego Calveyra.
 * License: GNU General Public License v3.0.
 *
 */
using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;


namespace USBDDFix
{
    public partial class MainForm : Form
    {
        private List<string> diskIndices = new List<string>(); // Lista para almacenar los índices de los discos
        
		static string lang = string.Empty;
    	static string filePath = Path.Combine(Path.GetTempPath(), "usbddfix_lang.txt"); // preferencias del idioma
    	
    	static string theme = string.Empty;
		static string themePath = Path.Combine(Path.GetTempPath(), "usbddfix_theme.txt"); // preferencias del tema
		
        public MainForm()
        {
            InitializeComponent();
            setupUserLang();
            InitializeLang();
            setupUserTheme();

            // Agregar opciones de sistema de archivos
            cb_formato.Items.Add("FAT32");
            cb_formato.Items.Add("NTFS");

            // Desactivar el botón btn_empezar al inicio
            btn_empezar.Enabled = false;

            this.Load += MainForm_Load;
        }
        
        private void setupUserLang(){
        	try
            {
                if (File.Exists(filePath))
                {
                    lang = File.ReadAllText(filePath);
                    InitializeLang();
                }
                else
                {
                	// Idioma por defecto
                    lang = "en"; 
                    File.WriteAllText(filePath, lang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading preferences: "  + ex.ToString());
            }
        
        }
        
        private void InitializeLang(){
        	
        	if (lang.Equals("en"))
        	{
        		lang = "en"; 
                File.WriteAllText(filePath, lang);
                
        		optionsToolStripMenuItem.Text = "Options";
        		abooutToolStripMenuItem.Text = "About";
        		themeToolStripMenuItem.Text = "Theme";
        		lightToolStripMenuItem.Text = "Light";
        		darkToolStripMenuItem.Text = "Dark";
        		
        		label_unidad.Text = "Device";
        		label_formato.Text = "Format";
        		label_letra.Text = "Assign letter";
        		label_result.Text = "Result";
        		
        		btn_analizar.Text = "Analyze";
        		btn_letrasDiscos.Text = "Refresh";
        		btn_empezar.Text = "Start";
        		
        		string texto_log = textbox_log.Text;
            	if (!string.IsNullOrWhiteSpace(texto_log) && texto_log.StartsWith("#"))
    			{
            		textbox_log.Clear();
           			textbox_log.AppendText("#################################################" + "\n");
					textbox_log.AppendText("# USBDDFix v1.2." + "\n");
					textbox_log.AppendText("# Developed by Simulated Reality Soft." + "\n");
					textbox_log.AppendText("#" + "\n");
					textbox_log.AppendText("# Thanks for using this software." + "\n");
					textbox_log.AppendText("#################################################");
           			
           		}
        	} 
        	else
        	{
        		lang = "es"; 
                File.WriteAllText(filePath, lang);
                
        		optionsToolStripMenuItem.Text = "Opciones";
        		abooutToolStripMenuItem.Text = "Acerca";
        		themeToolStripMenuItem.Text = "Tema";
        		lightToolStripMenuItem.Text = "Claro";
        		darkToolStripMenuItem.Text = "Oscuro";
        		
        		label_unidad.Text = "Dispositivo";
        		label_formato.Text = "Formato";
        		label_letra.Text = "Asignar letra";
        		label_result.Text = "Resultado";
        		
        		btn_analizar.Text = "Analizar";
        		btn_letrasDiscos.Text = "Actualizar";
        		btn_empezar.Text = "Empezar";
        		
        		string texto_log = textbox_log.Text;
            	if (!string.IsNullOrWhiteSpace(texto_log) && texto_log.StartsWith("#"))
    			{
            		textbox_log.Clear();
           			textbox_log.AppendText("#################################################" + "\n");
					textbox_log.AppendText("# USBDDFix v1.2." + "\n");
					textbox_log.AppendText("# Desarrollado por Simulated Reality Soft." + "\n");
					textbox_log.AppendText("#" + "\n");
					textbox_log.AppendText("# Gracias por usar este software." + "\n");
					textbox_log.AppendText("#################################################");
           			
           		}
       
        	}
        }
        
        private void setupUserTheme(){
        	try
            {
                if (File.Exists(themePath))
                {
                    theme = File.ReadAllText(themePath);
                    
                    if (theme.Equals("Light")){
                    	
                    	theme = "Light"; 
                    	File.WriteAllText(themePath, theme);
                    	LightTheme();
                    	
                    } else {
                    	
                    	theme = "Dark"; 
                    	File.WriteAllText(themePath, theme);
                    	DarkTheme();
                    	
                    }
                }
                else
                {
                	theme = "Light"; 
                    File.WriteAllText(themePath, theme);
                    LightTheme();
                }
            }
            catch (Exception ex)
            {
            	MessageBox.Show("Error loading preferences:" + ex.ToString());
            }
        
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LetterFindAsync();
        }

        private async void btnListarDiscos_Click(object sender, EventArgs e)
		{
    		// Mostrar el ProgressBar
    		progressBar.Style = ProgressBarStyle.Marquee;
			progressBar.MarqueeAnimationSpeed = 30;
			
    		await Task.Run(() => ListDisks());

   			// Ocultar el ProgressBar
   			progressBar.Style = ProgressBarStyle.Blocks;
			progressBar.MarqueeAnimationSpeed = 0;
			
			textbox_log.AppendText("[+] Process done." + "\n");
		}

        private void ListDisks()
        {
            // Limpiar el ComboBox antes de agregar nuevos elementos
            comboBoxDiscos.Invoke((MethodInvoker)delegate { comboBoxDiscos.Items.Clear(); });
            diskIndices.Clear();
            textbox_log.Clear();
            textbox_log.AppendText("[+] Analyzing devices..." + "\n");

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

                int index = 0; // Contador para el índice de disco
                foreach (ManagementObject disk in searcher.Get())
                {
                    // Agregar el ID del dispositivo y el modelo al ComboBox
                    string diskModel = disk["Model"].ToString();
                    string diskInfo = "Device " + index.ToString() + ": " + disk["Model"];
                    diskIndices.Add(index.ToString()); // Almacenar el índice del disco
                    comboBoxDiscos.Invoke((MethodInvoker)delegate { comboBoxDiscos.Items.Add(diskInfo); });
                    index++; // Incrementar el índice
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error listing devices:" + ex.Message);
            }
        }

        private async void comboBoxDiscos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar el disco seleccionado en el TextBox
            string selectedDisk = comboBoxDiscos.SelectedItem.ToString();
            textbox_log.AppendText("[+] Selected " + selectedDisk + "\n");

            // Obtener el índice del disco seleccionado
            int selectedIndex = comboBoxDiscos.SelectedIndex;

            // Asegúrate de que el índice esté dentro de los límites
            if (selectedIndex >= 0 && selectedIndex < diskIndices.Count)
            {
                // Aquí no es necesario ejecutar un comando, ya que se ejecutará más tarde
            }

            // Activar el botón btn_empezar si ambos ComboBoxes tienen selección
            btn_empezar.Enabled = cb_formato.SelectedItem != null && comboBoxDiscos.SelectedItem != null && cb_letra.SelectedItem != null;
        }

        private void cb_formato_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Activar el botón btn_empezar si ambos ComboBoxes tienen selección
            btn_empezar.Enabled = cb_formato.SelectedItem != null && comboBoxDiscos.SelectedItem != null && cb_letra.SelectedItem != null;
            
            // limpieza del log
            string texto_log = textbox_log.Text;
            if (!string.IsNullOrWhiteSpace(texto_log) && texto_log.StartsWith("#"))
    		{
            	textbox_log.Clear();
            	
            	string selectedFormat = cb_formato.SelectedItem.ToString();
           		textbox_log.AppendText("[+] Chosen file system: " + selectedFormat + "\n");
            } else 
            {            
            	string selectedFormat = cb_formato.SelectedItem.ToString();
           		textbox_log.AppendText("[+] Chosen file system: " + selectedFormat + "\n");
            }
        }

        private void cb_letra_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Activar el botón btn_empezar si ambos ComboBoxes tienen selección
            btn_empezar.Enabled = cb_formato.SelectedItem != null && comboBoxDiscos.SelectedItem != null && cb_letra.SelectedItem != null;
            
            // limpieza del log
            string texto_log = textbox_log.Text;
            if (!string.IsNullOrWhiteSpace(texto_log) && texto_log.StartsWith("#"))
    		{
            	textbox_log.Clear();
            	
            	string selectedLetter = cb_letra.SelectedItem.ToString();
           		textbox_log.AppendText("[+] Assigned letter: " + selectedLetter + "\n");
            } else 
            {            
            	string selectedLetter = cb_letra.SelectedItem.ToString();
            	textbox_log.AppendText("[+] Assigned letter: " + selectedLetter + "\n");
            }
        }

        private void ExecuteDiskPartCommands(string[] commands)
        {
            // Crear un archivo temporal para los comandos de diskpart
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllLines(tempFilePath, commands);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "diskpart",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using (var writer = process.StandardInput)
                {
                    if (writer.BaseStream.CanWrite)
                    {
                        writer.WriteLine("script=" + tempFilePath);
                    }
                }

                // Leer la salida estándar
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Mostrar la salida en el TextBox
                textbox_log.Invoke((MethodInvoker)delegate {
                    textbox_log.AppendText(output + Environment.NewLine);
                });
            }

            // Eliminar el archivo temporal
            File.Delete(tempFilePath);
        }

 	private async Task ExecuteDiskPartCommandsAsync()
	{
 		textbox_log.AppendText("[+] Process started..." + "\n");
 	
 		progressBar.Style = ProgressBarStyle.Marquee;
		progressBar.MarqueeAnimationSpeed = 30;
 	
		// Desactivar botones para no interrumpir el proceso
 		btn_empezar.Enabled = false;
 		btn_analizar.Enabled = false;
 		btn_letrasDiscos.Enabled = false;
 		comboBoxDiscos.Enabled = false;
 		cb_formato.Enabled = false;
 		cb_letra.Enabled = false;
 		
    	// Obtener el sistema de archivos seleccionado
    	string fileSystem = cb_formato.SelectedItem.ToString().ToLower();

   		// Crear un array de comandos
   		string[] commands = new string[]
    	{
        	"select disk " + comboBoxDiscos.SelectedIndex,
       		"clean",
        	"create partition primary",
        	"select partition 1",
        	"format fs=" + fileSystem + " quick",
        	"assign letter=" + cb_letra.SelectedItem.ToString().TrimEnd(':')
    	};

    	// Guardar los comandos en un archivo de texto
    	string commandsFilePath = Path.Combine(Path.GetTempPath(), "diskpart_commands.txt");
    	File.WriteAllLines(commandsFilePath, commands);

    	// Ejecutar DiskPart con el archivo de comandos
    	ProcessStartInfo startInfo = new ProcessStartInfo
    	{
        	FileName = "diskpart",
        	Arguments = "/S \"" + commandsFilePath + "\"", // Usar el archivo de comandos
        	RedirectStandardOutput = true, // Redirigir la salida estándar
        	RedirectStandardError = true, // Redirigir la salida de error
        	UseShellExecute = false,
        	CreateNoWindow = true // Asegura de que no se cree una ventana
    	};

    	using (Process process = Process.Start(startInfo))
    	{
        	// Leer la salida estándar
        	string output = await process.StandardOutput.ReadToEndAsync();
        	string errorOutput = await process.StandardError.ReadToEndAsync(); // Leer la salida de error
        	process.WaitForExit();


    	}

    	// Eliminar el archivo de comandos
    	File.Delete(commandsFilePath);
    
    	progressBar.Style = ProgressBarStyle.Blocks;
		progressBar.MarqueeAnimationSpeed = 0;
    
   		textbox_log.AppendText("[!] Process done.");
   	
 		btn_empezar.Enabled = true;
 		btn_analizar.Enabled = true;
 		btn_letrasDiscos.Enabled = true;
 		comboBoxDiscos.Enabled = true;
 		cb_formato.Enabled = true;
 		cb_letra.Enabled = true;
 	
 		if (LangCheck().Equals("en")){
 			MessageBox.Show("The repair process has just finished successfully");
 		} else {
 			MessageBox.Show("El proceso de reparacion acaba de terminar correctamente");
 		}
	}

    private async void btn_empezar_Click(object sender, EventArgs e)
	{
    	// Mostrar el diálogo de confirmación
    	if (LangCheck().Equals("en")){
    		DialogResult result = MessageBox.Show("Are you sure you want to wipe and format the selected device", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
    		if (result == DialogResult.Yes)
    		{
        		await ExecuteDiskPartCommandsAsync();
   			}
    	} else{
    		DialogResult result = MessageBox.Show("¿Estás seguro de que deseas limpiar y formatear el dispositivo seleccionado?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
    		if (result == DialogResult.Yes)
    		{
        		await ExecuteDiskPartCommandsAsync();
   			}
    	}
	}

        private async void btn_letrasDiscos_Click(object sender, EventArgs e)
        {
    		// Mostrar el ProgressBar
    		progressBar.Style = ProgressBarStyle.Marquee;
			progressBar.MarqueeAnimationSpeed = 30;

    		await Task.Run(() => ListAvailableDriveLetters()); 

   			// Ocultar el ProgressBar
   			progressBar.Style = ProgressBarStyle.Blocks;
			progressBar.MarqueeAnimationSpeed = 0;        	
 
        }

        private void ListAvailableDriveLetters()
        {
            // Limpiar el ComboBox antes de agregar nuevos elementos
            cb_letra.Invoke((MethodInvoker)delegate { cb_letra.Items.Clear(); });

            // Obtener todas las letras de unidad ocupadas
            var occupiedLetters = DriveInfo.GetDrives()
                .Where(d => d.IsReady) // Solo considerar unidades listas
                .Select(d => d.Name[0]) // Obtener la letra de la unidad
                .ToList();

            // Listar letras de unidad disponibles (A-Z)
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                if (!occupiedLetters.Contains(letter))
                {
                    cb_letra.Invoke((MethodInvoker)delegate { cb_letra.Items.Add(letter + ":"); });
                }
            }
        }

        private async Task LetterFindAsync()
        {
    		// Mostrar el ProgressBar
    		progressBar.Style = ProgressBarStyle.Marquee;
			progressBar.MarqueeAnimationSpeed = 30;

    		await Task.Run(() => ListAvailableDriveLetters()); 

   			// Ocultar el ProgressBar
   			progressBar.Style = ProgressBarStyle.Blocks;
			progressBar.MarqueeAnimationSpeed = 0;
			
        }
        
        void DarkTheme(){
        	theme = "Dark"; 
            File.WriteAllText(themePath, theme);
        	
        	Color menu_strip = System.Drawing.ColorTranslator.FromHtml("#1f1f1f");
			Color menu_strip_text = System.Drawing.ColorTranslator.FromHtml("#ffffff");
			Color window_background = System.Drawing.ColorTranslator.FromHtml("#0b0b0b");
			Color btn_border = System.Drawing.ColorTranslator.FromHtml("#313131");
			
			menuStrip.BackColor = menu_strip;
			optionsToolStripMenuItem.ForeColor = menu_strip_text;
			abooutToolStripMenuItem.ForeColor = menu_strip_text;
			this.BackColor = window_background;
			
			label_unidad.ForeColor = menu_strip_text;
			label_result.ForeColor = menu_strip_text;
			label_formato.ForeColor = menu_strip_text;
			label_letra.ForeColor = menu_strip_text;
			
			comboBoxDiscos.ForeColor = menu_strip_text;
			comboBoxDiscos.BackColor = menu_strip;
			
			cb_letra.ForeColor = menu_strip_text;
			cb_letra.BackColor = menu_strip;
			
			cb_formato.ForeColor = menu_strip_text;
			cb_formato.BackColor = menu_strip;
			
			btn_analizar.BackColor = menu_strip;
			btn_analizar.ForeColor = menu_strip_text;
			btn_analizar.FlatStyle = FlatStyle.Flat;
			btn_analizar.FlatAppearance.BorderColor = btn_border;
			
			btn_letrasDiscos.BackColor = menu_strip;
			btn_letrasDiscos.ForeColor = menu_strip_text;
			btn_letrasDiscos.FlatStyle = FlatStyle.Flat;
			btn_letrasDiscos.FlatAppearance.BorderColor = btn_border;
			
			btn_empezar.BackColor = menu_strip;
			btn_empezar.ForeColor = menu_strip_text;
			btn_empezar.FlatStyle = FlatStyle.Flat;
			btn_empezar.FlatAppearance.BorderColor = btn_border;

			themeToolStripMenuItem.BackColor = menu_strip;
			themeToolStripMenuItem.ForeColor = menu_strip_text;
			
			lightToolStripMenuItem.BackColor = menu_strip;
			lightToolStripMenuItem.ForeColor = menu_strip_text;
			
			darkToolStripMenuItem.BackColor = menu_strip;
			darkToolStripMenuItem.ForeColor = menu_strip_text;
        }
        
        string LangCheck(){
        	string lang_is;
        	if (lang.Equals("en")){
        		lang_is = "en";
        	} else {
        		lang_is = "es";
        	}
        	
        	return lang_is;
        }
        
        void LightTheme(){
        	
        	theme = "Light"; 
            File.WriteAllText(themePath, theme);
        	
        	Color btn_border_light = System.Drawing.ColorTranslator.FromHtml("#000000");
			
			menuStrip.BackColor = SystemColors.Control;
			optionsToolStripMenuItem.ForeColor = Color.Black;
			abooutToolStripMenuItem.ForeColor = Color.Black;
			this.BackColor = SystemColors.Control;
			
			label_unidad.ForeColor = Color.Black;
			label_result.ForeColor = Color.Black;
			label_formato.ForeColor = Color.Black;
			label_letra.ForeColor = Color.Black;
			
			comboBoxDiscos.ForeColor = Color.Black;
			comboBoxDiscos.BackColor = SystemColors.Control;
			
			cb_letra.ForeColor = Color.Black;
			cb_letra.BackColor = SystemColors.Control;
			
			cb_formato.ForeColor = Color.Black;
			cb_formato.BackColor = SystemColors.Control;
			
			btn_analizar.BackColor = SystemColors.Control;
			btn_analizar.ForeColor = Color.Black;
			btn_analizar.FlatStyle = FlatStyle.System;
			btn_analizar.FlatAppearance.BorderColor = btn_border_light;
			
			btn_letrasDiscos.BackColor = SystemColors.Control;
			btn_letrasDiscos.ForeColor = Color.Black;
			btn_letrasDiscos.FlatStyle = FlatStyle.System;
			btn_letrasDiscos.FlatAppearance.BorderColor = btn_border_light;
			
			btn_empezar.BackColor = SystemColors.Control;
			btn_empezar.ForeColor = Color.Black;
			btn_empezar.FlatStyle = FlatStyle.System;
			btn_empezar.FlatAppearance.BorderColor = btn_border_light;

			themeToolStripMenuItem.BackColor = SystemColors.Control;
			themeToolStripMenuItem.ForeColor = Color.Black;
			
			lightToolStripMenuItem.BackColor = SystemColors.Control;
			lightToolStripMenuItem.ForeColor = Color.Black;
			
			darkToolStripMenuItem.BackColor = SystemColors.Control;
			darkToolStripMenuItem.ForeColor = Color.Black;
        }
		
		
		void DarkToolStripMenuItemClick(object sender, EventArgs e)
		{
			DarkTheme();
		}
		
		void LightToolStripMenuItemClick(object sender, EventArgs e)
		{
			LightTheme();
		}
		
		
		void AbooutToolStripMenuItemClick(object sender, EventArgs e)
		{
			// Crear una instancia del formulario AcercaDeForm
			Acerca acerca = new Acerca();
    
    		// Mostrar el formulario como un diálogo modal
    		acerca.ShowDialog();			
		}
		
		void EnglishToolStripMenuItemClick(object sender, EventArgs e)
		{	
			lang = "en";
			InitializeLang();
		}
		
		void SpanishToolStripMenuItemClick(object sender, EventArgs e)
		{
			lang = "es";
			InitializeLang();
		}
		
    }
}
