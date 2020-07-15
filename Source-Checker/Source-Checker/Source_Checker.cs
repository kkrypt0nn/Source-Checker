using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Source_Checker
{
    public partial class Source_Checker : Form
    {

        // Current version of the program
        string version = "v1.1.0";

        // Dark & light mode support
        string mode = "light";

        // Simple list where the path of the files to check will be stored
        List<string> filesToCheck = new List<string>();

        // A list that contains possible mallicious keywords
        string[] maliciousContent = {
            "public static void main(String[] args)",
            "Runtime",
            "ProcessBuilder",
            "HttpURLConnection",
            "URLConnection",
            "Process",
            "isProcessRunning",
            "isProcessRunningTitle",
            "System.getProperty",
            "Socket",
            "new Socket",
            "ServerSocket",
            "ThreadPool",
            "InetAddress",
            "socket.connect",
            "System.getenv",
            "Runtime.getRuntime().exec",
            ".exec"
        };

        public Source_Checker()
        {
            InitializeComponent();
        }

        // Everytime the Form loads it changes the color, dark will be opened as default color
        // The year for the footer is also changed automatically with the current year
        // Put the total files to scan in the label
        private void Source_Checker_Load(object sender, EventArgs e)
        {
            changeColorMode();
            Link_GitHub.Text = $"Copyright © 2020-{(DateTime.Now.Year)} - Made by Krypton";
            Label_Version.Text = version;
            Label_FilesToScan.Text = $"Total files to scan: {List_FilesFound.Items.Count}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open my GitHub link in the default folder
            System.Diagnostics.Process.Start("https://github.com/kkrypt0nn");
        }

        private void Btn_ChooseFolder_Click(object sender, EventArgs e)
        {
            // Open a dialog where you can choose the folder you want to be checked
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            // Puts as default path the desktop
            folderBrowser.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult res = folderBrowser.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrEmpty(folderBrowser.SelectedPath))
            {
                // Get all files ending with .java since we only care of those
                string[] files = Directory.GetFiles(folderBrowser.SelectedPath, "*.java", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    filesToCheck.Add(file);
                    List_FilesFound.Items.Add(file);
                }
            }
            TxtBox_Folder.Text = folderBrowser.SelectedPath;
            // Put the total files to scan in the label
            Label_FilesToScan.Text = $"Total files to scan: {List_FilesFound.Items.Count}";
            // Enable remove files and scan files buttons
            Btn_RemoveSelected.Enabled = true;
            Btn_RemoveAllFiles.Enabled = true;
            Btn_ScanFiles.Enabled = true;
        }

        private void Pic_ColorMode_Click(object sender, EventArgs e)
        {
            changeColorMode();
        }

        private void Btn_RemoveSelected_Click(object sender, EventArgs e)
        {
            // Removes a specific file from the list of files to check
            if (List_FilesFound.SelectedItem.ToString() != null && !string.IsNullOrEmpty(List_FilesFound.SelectedItem.ToString()))
            {
                int deletedIndex = List_FilesFound.SelectedIndex;
                List_FilesFound.Items.Remove(List_FilesFound.SelectedItem.ToString());
                filesToCheck.RemoveAt(deletedIndex);
                List_FilesFound.SelectedIndex = deletedIndex;
                Label_FilesToScan.Text = $"Total files to scan: {List_FilesFound.Items.Count}";
            }
        }

        private void Btn_RemoveAllFiles_Click(object sender, EventArgs e)
        {
            // Disable remove files and scan files buttons
            Btn_RemoveSelected.Enabled = false;
            Btn_RemoveAllFiles.Enabled = false;
            Btn_ScanFiles.Enabled = false;
            TxtBox_Folder.Text = "No folder selected";
            // Clear the list of files and the List of the files to check
            List_FilesFound.Items.Clear();
            filesToCheck.Clear();
            Label_FilesToScan.Text = $"Total files to scan: {List_FilesFound.Items.Count}";
        }

        private void Btn_ScanFiles_Click(object sender, EventArgs e)
        {
            TxtBox_ScanOutput.ScrollBars = ScrollBars.Both;

            // Check if the files to check is not empty
            if (List_FilesFound.Items.Count >= 1 && filesToCheck.Count >= 1)
            {
                // Loop trough all the files to check, read the content of that file and check if the file might contain malicious code
                foreach (var filePath in filesToCheck)
                {
                    foreach (var match in File.ReadLines(filePath).Select((text, index) => new { text, lineNumber = index + 1 }))
                    {
                        foreach (var keyword in maliciousContent)
                        {
                            if (match.text.ToLower().Contains(keyword.ToLower()))
                            {
                                // Add information about the line that could be possibly malicious
                                TxtBox_ScanOutput.AppendText($"{filePath}:{match.lineNumber} | {match.text.Trim()}");
                                TxtBox_ScanOutput.AppendText(Environment.NewLine);
                                TxtBox_ScanOutput.AppendText(Environment.NewLine);
                            }
                        }
                    }
                }
                Btn_ExportFile.Enabled = true;
            }
        }

        private void Btn_ExportFile_Click(object sender, EventArgs e)
        {
            // Save the result of the scan as text file
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File|*.txt";
            saveFile.Title = "Save as Text File";
            saveFile.FileName = $"source-checker-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}";
            DialogResult res = saveFile.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrEmpty(saveFile.FileName) && !string.IsNullOrEmpty(TxtBox_ScanOutput.Text))
            {
                File.WriteAllText(saveFile.FileName, TxtBox_ScanOutput.Text);
            }
        }

        private void changeColorMode()
        {
            switch (mode.ToLower())
            {
                // Dark Mode settings
                case "light":
                    // Change the color of the background of the app
                    this.BackColor = Color.FromArgb(33, 33, 33);

                    // Change the color of all the text
                    Label_Title.ForeColor = Color.FromArgb(207, 207, 207);
                    Label_Version.ForeColor = Color.FromArgb(207, 207, 207);
                    Label_FilesToScan.ForeColor = Color.FromArgb(207, 207, 207);
                    Link_GitHub.ForeColor = Color.FromArgb(207, 207, 207);
                    Link_GitHub.LinkColor = Color.FromArgb(207, 207, 207);

                    // Change the color of all the buttons and the border
                    Btn_ChooseFolder.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_ChooseFolder.TabStop = false;
                    Btn_ChooseFolder.FlatStyle = FlatStyle.Flat;
                    Btn_ChooseFolder.FlatAppearance.BorderSize = 0;
                    Btn_ChooseFolder.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    Btn_RemoveSelected.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_RemoveSelected.TabStop = false;
                    Btn_RemoveSelected.FlatStyle = FlatStyle.Flat;
                    Btn_RemoveSelected.FlatAppearance.BorderSize = 0;
                    Btn_RemoveSelected.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    Btn_RemoveAllFiles.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_RemoveAllFiles.TabStop = false;
                    Btn_RemoveAllFiles.FlatStyle = FlatStyle.Flat;
                    Btn_RemoveAllFiles.FlatAppearance.BorderSize = 0;
                    Btn_RemoveAllFiles.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    Btn_ScanFiles.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_ScanFiles.TabStop = false;
                    Btn_ScanFiles.FlatStyle = FlatStyle.Flat;
                    Btn_ScanFiles.FlatAppearance.BorderSize = 0;
                    Btn_ScanFiles.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    Btn_ExportFile.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_ExportFile.TabStop = false;
                    Btn_ExportFile.FlatStyle = FlatStyle.Flat;
                    Btn_ExportFile.FlatAppearance.BorderSize = 0;
                    Btn_ExportFile.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    // Change the color of all the lists
                    List_FilesFound.BackColor = Color.FromArgb(207, 207, 207);

                    // Change the color of all the text boxes
                    TxtBox_Folder.BackColor = Color.FromArgb(207, 207, 207);
                    TxtBox_ScanOutput.BackColor = Color.FromArgb(207, 207, 207);

                    // Change the change theme picture
                    Pic_ColorMode.Image = Properties.Resources.light_theme;
                    Pic_ColorMode.SizeMode = PictureBoxSizeMode.StretchImage;
                    Pic_ColorMode.Refresh();
                    Pic_ColorMode.Visible = true;

                    // Set current mode to dark theme
                    mode = "dark";
                    break;
                // Light Mode settings
                case "dark":
                    // Change the color of the background of the app
                    this.BackColor = Color.FromArgb(207, 207, 207);

                    // Change the color of all the text
                    Label_Title.ForeColor = Color.FromArgb(33, 33, 33);
                    Label_Version.ForeColor = Color.FromArgb(33, 33, 33);
                    Label_FilesToScan.ForeColor = Color.FromArgb(33, 33, 33);
                    Link_GitHub.ForeColor = Color.FromArgb(33, 33, 33);
                    Link_GitHub.LinkColor = Color.FromArgb(33, 33, 33);

                    // Change the color of all the buttons and the border
                    Btn_ChooseFolder.BackColor = Color.FromArgb(255, 255, 255);
                    Btn_ChooseFolder.TabStop = false;
                    Btn_ChooseFolder.FlatStyle = FlatStyle.Flat;
                    Btn_ChooseFolder.FlatAppearance.BorderSize = 0;
                    Btn_ChooseFolder.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);

                    Btn_RemoveSelected.BackColor = Color.FromArgb(255, 255, 255);
                    Btn_RemoveSelected.TabStop = false;
                    Btn_RemoveSelected.FlatStyle = FlatStyle.Flat;
                    Btn_RemoveSelected.FlatAppearance.BorderSize = 0;
                    Btn_RemoveSelected.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);

                    Btn_RemoveAllFiles.BackColor = Color.FromArgb(255, 255, 255);
                    Btn_RemoveAllFiles.TabStop = false;
                    Btn_RemoveAllFiles.FlatStyle = FlatStyle.Flat;
                    Btn_RemoveAllFiles.FlatAppearance.BorderSize = 0;
                    Btn_RemoveAllFiles.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);

                    Btn_ScanFiles.BackColor = Color.FromArgb(255, 255, 255);
                    Btn_ScanFiles.TabStop = false;
                    Btn_ScanFiles.FlatStyle = FlatStyle.Flat;
                    Btn_ScanFiles.FlatAppearance.BorderSize = 0;
                    Btn_ScanFiles.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);

                    Btn_ExportFile.BackColor = Color.FromArgb(255, 255, 255);
                    Btn_ExportFile.TabStop = false;
                    Btn_ExportFile.FlatStyle = FlatStyle.Flat;
                    Btn_ExportFile.FlatAppearance.BorderSize = 0;
                    Btn_ExportFile.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);

                    // Change the color of all the lists
                    List_FilesFound.BackColor = Color.FromArgb(255, 255, 255);

                    // Change the color of all the text boxes
                    TxtBox_Folder.BackColor = Color.FromArgb(255, 255, 255);
                    TxtBox_ScanOutput.BackColor = Color.FromArgb(255, 255, 255);

                    // Change the change theme picture
                    Pic_ColorMode.Image = Properties.Resources.dark_theme;
                    Pic_ColorMode.SizeMode = PictureBoxSizeMode.StretchImage;
                    Pic_ColorMode.Refresh();
                    Pic_ColorMode.Visible = true;

                    // Set current mode to light theme
                    mode = "light";
                    break;
                // Else, just go back to Dark Mode, because Dark Mode is always better...
                default:
                    // Change the color of the background of the app
                    this.BackColor = Color.FromArgb(33, 33, 33);

                    // Change the color of all the text
                    Label_Title.ForeColor = Color.FromArgb(207, 207, 207);
                    Label_Version.ForeColor = Color.FromArgb(207, 207, 207);
                    Label_FilesToScan.ForeColor = Color.FromArgb(207, 207, 207);
                    Link_GitHub.ForeColor = Color.FromArgb(207, 207, 207);
                    Link_GitHub.LinkColor = Color.FromArgb(207, 207, 207);

                    // Change the color of all the buttons and the border
                    Btn_ChooseFolder.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_ChooseFolder.TabStop = false;
                    Btn_ChooseFolder.FlatStyle = FlatStyle.Flat;
                    Btn_ChooseFolder.FlatAppearance.BorderSize = 0;
                    Btn_ChooseFolder.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    Btn_RemoveSelected.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_RemoveSelected.TabStop = false;
                    Btn_RemoveSelected.FlatStyle = FlatStyle.Flat;
                    Btn_RemoveSelected.FlatAppearance.BorderSize = 0;
                    Btn_RemoveSelected.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    Btn_RemoveAllFiles.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_RemoveAllFiles.TabStop = false;
                    Btn_RemoveAllFiles.FlatStyle = FlatStyle.Flat;
                    Btn_RemoveAllFiles.FlatAppearance.BorderSize = 0;
                    Btn_RemoveAllFiles.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    Btn_ScanFiles.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_ScanFiles.TabStop = false;
                    Btn_ScanFiles.FlatStyle = FlatStyle.Flat;
                    Btn_ScanFiles.FlatAppearance.BorderSize = 0;
                    Btn_ScanFiles.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    Btn_ExportFile.BackColor = Color.FromArgb(207, 207, 207);
                    Btn_ExportFile.TabStop = false;
                    Btn_ExportFile.FlatStyle = FlatStyle.Flat;
                    Btn_ExportFile.FlatAppearance.BorderSize = 0;
                    Btn_ExportFile.FlatAppearance.BorderColor = Color.FromArgb(207, 207, 207);

                    // Change the color of all the lists
                    List_FilesFound.BackColor = Color.FromArgb(207, 207, 207);

                    // Change the color of all the text boxes
                    TxtBox_Folder.BackColor = Color.FromArgb(207, 207, 207);
                    TxtBox_ScanOutput.BackColor = Color.FromArgb(207, 207, 207);

                    // Change the change theme picture
                    Pic_ColorMode.Image = Properties.Resources.light_theme;
                    Pic_ColorMode.SizeMode = PictureBoxSizeMode.StretchImage;
                    Pic_ColorMode.Refresh();
                    Pic_ColorMode.Visible = true;

                    // Set current mode to dark theme
                    mode = "dark";
                    break;
            }
        }
    }
}
