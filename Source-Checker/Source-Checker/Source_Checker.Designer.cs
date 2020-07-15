namespace Source_Checker
{
    partial class Source_Checker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source_Checker));
            this.Label_Title = new System.Windows.Forms.Label();
            this.Link_GitHub = new System.Windows.Forms.LinkLabel();
            this.Btn_ChooseFolder = new System.Windows.Forms.Button();
            this.TxtBox_Folder = new System.Windows.Forms.TextBox();
            this.List_FilesFound = new System.Windows.Forms.ListBox();
            this.Btn_RemoveSelected = new System.Windows.Forms.Button();
            this.Btn_ScanFiles = new System.Windows.Forms.Button();
            this.Btn_RemoveAllFiles = new System.Windows.Forms.Button();
            this.TxtBox_ScanOutput = new System.Windows.Forms.TextBox();
            this.Btn_ExportFile = new System.Windows.Forms.Button();
            this.Pic_ColorMode = new System.Windows.Forms.PictureBox();
            this.Label_Version = new System.Windows.Forms.Label();
            this.Label_FilesToScan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ColorMode)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Label_Title.Location = new System.Drawing.Point(12, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(893, 132);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "Source Checker";
            // 
            // Link_GitHub
            // 
            this.Link_GitHub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.Link_GitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Link_GitHub.AutoSize = true;
            this.Link_GitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Link_GitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Link_GitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Link_GitHub.Location = new System.Drawing.Point(12, 885);
            this.Link_GitHub.Name = "Link_GitHub";
            this.Link_GitHub.Size = new System.Drawing.Size(275, 17);
            this.Link_GitHub.TabIndex = 2;
            this.Link_GitHub.TabStop = true;
            this.Link_GitHub.Text = "Copyright © 2020-2020 - Made by Krypton";
            this.Link_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Btn_ChooseFolder
            // 
            this.Btn_ChooseFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_ChooseFolder.Location = new System.Drawing.Point(305, 148);
            this.Btn_ChooseFolder.Name = "Btn_ChooseFolder";
            this.Btn_ChooseFolder.Size = new System.Drawing.Size(121, 39);
            this.Btn_ChooseFolder.TabIndex = 3;
            this.Btn_ChooseFolder.Text = "Choose Folder";
            this.Btn_ChooseFolder.UseVisualStyleBackColor = true;
            this.Btn_ChooseFolder.Click += new System.EventHandler(this.Btn_ChooseFolder_Click);
            // 
            // TxtBox_Folder
            // 
            this.TxtBox_Folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBox_Folder.Enabled = false;
            this.TxtBox_Folder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TxtBox_Folder.Location = new System.Drawing.Point(34, 158);
            this.TxtBox_Folder.Name = "TxtBox_Folder";
            this.TxtBox_Folder.Size = new System.Drawing.Size(265, 22);
            this.TxtBox_Folder.TabIndex = 6;
            this.TxtBox_Folder.Text = "No folder selected";
            // 
            // List_FilesFound
            // 
            this.List_FilesFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.List_FilesFound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.List_FilesFound.FormattingEnabled = true;
            this.List_FilesFound.HorizontalScrollbar = true;
            this.List_FilesFound.ItemHeight = 16;
            this.List_FilesFound.Location = new System.Drawing.Point(34, 218);
            this.List_FilesFound.Name = "List_FilesFound";
            this.List_FilesFound.Size = new System.Drawing.Size(392, 612);
            this.List_FilesFound.TabIndex = 7;
            // 
            // Btn_RemoveSelected
            // 
            this.Btn_RemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_RemoveSelected.Enabled = false;
            this.Btn_RemoveSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Btn_RemoveSelected.Location = new System.Drawing.Point(34, 836);
            this.Btn_RemoveSelected.Name = "Btn_RemoveSelected";
            this.Btn_RemoveSelected.Size = new System.Drawing.Size(190, 46);
            this.Btn_RemoveSelected.TabIndex = 8;
            this.Btn_RemoveSelected.Text = "Remove Selected File";
            this.Btn_RemoveSelected.UseVisualStyleBackColor = true;
            this.Btn_RemoveSelected.Click += new System.EventHandler(this.Btn_RemoveSelected_Click);
            // 
            // Btn_ScanFiles
            // 
            this.Btn_ScanFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_ScanFiles.Enabled = false;
            this.Btn_ScanFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Btn_ScanFiles.Location = new System.Drawing.Point(470, 457);
            this.Btn_ScanFiles.Name = "Btn_ScanFiles";
            this.Btn_ScanFiles.Size = new System.Drawing.Size(121, 46);
            this.Btn_ScanFiles.TabIndex = 9;
            this.Btn_ScanFiles.Text = "Scan Files >>";
            this.Btn_ScanFiles.UseVisualStyleBackColor = true;
            this.Btn_ScanFiles.Click += new System.EventHandler(this.Btn_ScanFiles_Click);
            // 
            // Btn_RemoveAllFiles
            // 
            this.Btn_RemoveAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_RemoveAllFiles.Enabled = false;
            this.Btn_RemoveAllFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Btn_RemoveAllFiles.Location = new System.Drawing.Point(236, 836);
            this.Btn_RemoveAllFiles.Name = "Btn_RemoveAllFiles";
            this.Btn_RemoveAllFiles.Size = new System.Drawing.Size(190, 46);
            this.Btn_RemoveAllFiles.TabIndex = 10;
            this.Btn_RemoveAllFiles.Text = "Remove All Files";
            this.Btn_RemoveAllFiles.UseVisualStyleBackColor = true;
            this.Btn_RemoveAllFiles.Click += new System.EventHandler(this.Btn_RemoveAllFiles_Click);
            // 
            // TxtBox_ScanOutput
            // 
            this.TxtBox_ScanOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox_ScanOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TxtBox_ScanOutput.Location = new System.Drawing.Point(632, 218);
            this.TxtBox_ScanOutput.Multiline = true;
            this.TxtBox_ScanOutput.Name = "TxtBox_ScanOutput";
            this.TxtBox_ScanOutput.ReadOnly = true;
            this.TxtBox_ScanOutput.Size = new System.Drawing.Size(880, 612);
            this.TxtBox_ScanOutput.TabIndex = 11;
            this.TxtBox_ScanOutput.WordWrap = false;
            // 
            // Btn_ExportFile
            // 
            this.Btn_ExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ExportFile.Enabled = false;
            this.Btn_ExportFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Btn_ExportFile.Location = new System.Drawing.Point(1322, 836);
            this.Btn_ExportFile.Name = "Btn_ExportFile";
            this.Btn_ExportFile.Size = new System.Drawing.Size(190, 46);
            this.Btn_ExportFile.TabIndex = 12;
            this.Btn_ExportFile.Text = "Export as text file";
            this.Btn_ExportFile.UseVisualStyleBackColor = true;
            this.Btn_ExportFile.Click += new System.EventHandler(this.Btn_ExportFile_Click);
            // 
            // Pic_ColorMode
            // 
            this.Pic_ColorMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_ColorMode.InitialImage = null;
            this.Pic_ColorMode.Location = new System.Drawing.Point(1432, 12);
            this.Pic_ColorMode.Name = "Pic_ColorMode";
            this.Pic_ColorMode.Size = new System.Drawing.Size(80, 80);
            this.Pic_ColorMode.TabIndex = 13;
            this.Pic_ColorMode.TabStop = false;
            this.Pic_ColorMode.Click += new System.EventHandler(this.Pic_ColorMode_Click);
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Label_Version.Location = new System.Drawing.Point(860, 101);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(0, 20);
            this.Label_Version.TabIndex = 14;
            // 
            // Label_FilesToScan
            // 
            this.Label_FilesToScan.AutoSize = true;
            this.Label_FilesToScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Label_FilesToScan.Location = new System.Drawing.Point(34, 196);
            this.Label_FilesToScan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_FilesToScan.Name = "Label_FilesToScan";
            this.Label_FilesToScan.Size = new System.Drawing.Size(135, 17);
            this.Label_FilesToScan.TabIndex = 15;
            this.Label_FilesToScan.Text = "Total files to scan: 0";
            // 
            // Source_Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1524, 906);
            this.Controls.Add(this.Label_FilesToScan);
            this.Controls.Add(this.Label_Version);
            this.Controls.Add(this.Pic_ColorMode);
            this.Controls.Add(this.Btn_ExportFile);
            this.Controls.Add(this.TxtBox_ScanOutput);
            this.Controls.Add(this.Btn_RemoveAllFiles);
            this.Controls.Add(this.Btn_ScanFiles);
            this.Controls.Add(this.Btn_RemoveSelected);
            this.Controls.Add(this.List_FilesFound);
            this.Controls.Add(this.TxtBox_Folder);
            this.Controls.Add(this.Btn_ChooseFolder);
            this.Controls.Add(this.Link_GitHub);
            this.Controls.Add(this.Label_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1542, 905);
            this.Name = "Source_Checker";
            this.Text = "Source Checker";
            this.Load += new System.EventHandler(this.Source_Checker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ColorMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.LinkLabel Link_GitHub;
        private System.Windows.Forms.Button Btn_ChooseFolder;
        private System.Windows.Forms.TextBox TxtBox_Folder;
        private System.Windows.Forms.ListBox List_FilesFound;
        private System.Windows.Forms.Button Btn_RemoveSelected;
        private System.Windows.Forms.Button Btn_ScanFiles;
        private System.Windows.Forms.Button Btn_RemoveAllFiles;
        private System.Windows.Forms.TextBox TxtBox_ScanOutput;
        private System.Windows.Forms.Button Btn_ExportFile;
        private System.Windows.Forms.PictureBox Pic_ColorMode;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.Label Label_FilesToScan;
    }
}

