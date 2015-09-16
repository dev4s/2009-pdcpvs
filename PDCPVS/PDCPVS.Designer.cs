namespace PDCPVS
{
    partial class Pdcpvs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pdcpvs));
            this.checkBoxFileSuo = new System.Windows.Forms.CheckBox();
            this.checkBoxFileUser = new System.Windows.Forms.CheckBox();
            this.checkBoxFolderBin = new System.Windows.Forms.CheckBox();
            this.checkBoxFolderObj = new System.Windows.Forms.CheckBox();
            this.checkBoxFolderResharper = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProjectsPath = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.checkBoxFilePdb = new System.Windows.Forms.CheckBox();
            this.checkBoxFileApplication = new System.Windows.Forms.CheckBox();
            this.groupBoxFolders = new System.Windows.Forms.GroupBox();
            this.checkBoxFolderPublish = new System.Windows.Forms.CheckBox();
            this.checkBoxFolderSvn = new System.Windows.Forms.CheckBox();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.CheckedListBox();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelWithProgressBar = new System.Windows.Forms.Panel();
            this.labelInformation = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxFolders.SuspendLayout();
            this.groupBoxAll.SuspendLayout();
            this.panelWithProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxFileSuo
            // 
            this.checkBoxFileSuo.AutoSize = true;
            this.checkBoxFileSuo.Checked = true;
            this.checkBoxFileSuo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFileSuo.Location = new System.Drawing.Point(6, 19);
            this.checkBoxFileSuo.Name = "checkBoxFileSuo";
            this.checkBoxFileSuo.Size = new System.Drawing.Size(50, 17);
            this.checkBoxFileSuo.TabIndex = 0;
            this.checkBoxFileSuo.Text = "*.suo";
            this.checkBoxFileSuo.UseVisualStyleBackColor = true;
            // 
            // checkBoxFileUser
            // 
            this.checkBoxFileUser.AutoSize = true;
            this.checkBoxFileUser.Checked = true;
            this.checkBoxFileUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFileUser.Location = new System.Drawing.Point(6, 42);
            this.checkBoxFileUser.Name = "checkBoxFileUser";
            this.checkBoxFileUser.Size = new System.Drawing.Size(53, 17);
            this.checkBoxFileUser.TabIndex = 1;
            this.checkBoxFileUser.Text = "*.user";
            this.checkBoxFileUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxFolderBin
            // 
            this.checkBoxFolderBin.AutoSize = true;
            this.checkBoxFolderBin.Checked = true;
            this.checkBoxFolderBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFolderBin.Location = new System.Drawing.Point(6, 19);
            this.checkBoxFolderBin.Name = "checkBoxFolderBin";
            this.checkBoxFolderBin.Size = new System.Drawing.Size(44, 17);
            this.checkBoxFolderBin.TabIndex = 0;
            this.checkBoxFolderBin.Text = "BIN";
            this.checkBoxFolderBin.UseVisualStyleBackColor = true;
            // 
            // checkBoxFolderObj
            // 
            this.checkBoxFolderObj.AutoSize = true;
            this.checkBoxFolderObj.Checked = true;
            this.checkBoxFolderObj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFolderObj.Location = new System.Drawing.Point(6, 42);
            this.checkBoxFolderObj.Name = "checkBoxFolderObj";
            this.checkBoxFolderObj.Size = new System.Drawing.Size(46, 17);
            this.checkBoxFolderObj.TabIndex = 1;
            this.checkBoxFolderObj.Text = "OBJ";
            this.checkBoxFolderObj.UseVisualStyleBackColor = true;
            // 
            // checkBoxFolderResharper
            // 
            this.checkBoxFolderResharper.AutoSize = true;
            this.checkBoxFolderResharper.Location = new System.Drawing.Point(56, 19);
            this.checkBoxFolderResharper.Name = "checkBoxFolderResharper";
            this.checkBoxFolderResharper.Size = new System.Drawing.Size(81, 17);
            this.checkBoxFolderResharper.TabIndex = 2;
            this.checkBoxFolderResharper.Text = "_Resharper";
            this.checkBoxFolderResharper.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj katalog, gdzie znajdują się Twoje projekty:";
            // 
            // textBoxProjectsPath
            // 
            this.textBoxProjectsPath.Enabled = false;
            this.textBoxProjectsPath.Location = new System.Drawing.Point(12, 25);
            this.textBoxProjectsPath.Name = "textBoxProjectsPath";
            this.textBoxProjectsPath.Size = new System.Drawing.Size(462, 20);
            this.textBoxProjectsPath.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(480, 23);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(82, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Otwórz...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.checkBoxFilePdb);
            this.groupBoxFile.Controls.Add(this.checkBoxFileApplication);
            this.groupBoxFile.Controls.Add(this.checkBoxFileSuo);
            this.groupBoxFile.Controls.Add(this.checkBoxFileUser);
            this.groupBoxFile.Location = new System.Drawing.Point(6, 19);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(151, 65);
            this.groupBoxFile.TabIndex = 8;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Pliki";
            // 
            // checkBoxFilePdb
            // 
            this.checkBoxFilePdb.AutoSize = true;
            this.checkBoxFilePdb.Location = new System.Drawing.Point(63, 42);
            this.checkBoxFilePdb.Name = "checkBoxFilePdb";
            this.checkBoxFilePdb.Size = new System.Drawing.Size(51, 17);
            this.checkBoxFilePdb.TabIndex = 3;
            this.checkBoxFilePdb.Text = "*.pdb";
            this.checkBoxFilePdb.UseVisualStyleBackColor = true;
            // 
            // checkBoxFileApplication
            // 
            this.checkBoxFileApplication.AutoSize = true;
            this.checkBoxFileApplication.Location = new System.Drawing.Point(63, 19);
            this.checkBoxFileApplication.Name = "checkBoxFileApplication";
            this.checkBoxFileApplication.Size = new System.Drawing.Size(84, 17);
            this.checkBoxFileApplication.TabIndex = 2;
            this.checkBoxFileApplication.Text = "*.application";
            this.checkBoxFileApplication.UseVisualStyleBackColor = true;
            // 
            // groupBoxFolders
            // 
            this.groupBoxFolders.Controls.Add(this.checkBoxFolderPublish);
            this.groupBoxFolders.Controls.Add(this.checkBoxFolderSvn);
            this.groupBoxFolders.Controls.Add(this.checkBoxFolderBin);
            this.groupBoxFolders.Controls.Add(this.checkBoxFolderObj);
            this.groupBoxFolders.Controls.Add(this.checkBoxFolderResharper);
            this.groupBoxFolders.Location = new System.Drawing.Point(163, 19);
            this.groupBoxFolders.Name = "groupBoxFolders";
            this.groupBoxFolders.Size = new System.Drawing.Size(205, 65);
            this.groupBoxFolders.TabIndex = 9;
            this.groupBoxFolders.TabStop = false;
            this.groupBoxFolders.Text = "Katalogi";
            // 
            // checkBoxFolderPublish
            // 
            this.checkBoxFolderPublish.AutoSize = true;
            this.checkBoxFolderPublish.Location = new System.Drawing.Point(143, 19);
            this.checkBoxFolderPublish.Name = "checkBoxFolderPublish";
            this.checkBoxFolderPublish.Size = new System.Drawing.Size(59, 17);
            this.checkBoxFolderPublish.TabIndex = 17;
            this.checkBoxFolderPublish.Text = "publish";
            this.checkBoxFolderPublish.UseVisualStyleBackColor = true;
            // 
            // checkBoxFolderSvn
            // 
            this.checkBoxFolderSvn.AutoSize = true;
            this.checkBoxFolderSvn.Location = new System.Drawing.Point(56, 42);
            this.checkBoxFolderSvn.Name = "checkBoxFolderSvn";
            this.checkBoxFolderSvn.Size = new System.Drawing.Size(51, 17);
            this.checkBoxFolderSvn.TabIndex = 16;
            this.checkBoxFolderSvn.Text = ".SVN";
            this.checkBoxFolderSvn.UseVisualStyleBackColor = true;
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.groupBoxFile);
            this.groupBoxAll.Controls.Add(this.groupBoxFolders);
            this.groupBoxAll.Location = new System.Drawing.Point(12, 51);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(374, 90);
            this.groupBoxAll.TabIndex = 10;
            this.groupBoxAll.TabStop = false;
            this.groupBoxAll.Text = "Wybierz elementy do usunięcia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wyniki:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(392, 52);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // resultBox
            // 
            this.resultBox.CheckOnClick = true;
            this.resultBox.Enabled = false;
            this.resultBox.FormattingEnabled = true;
            this.resultBox.HorizontalScrollbar = true;
            this.resultBox.Location = new System.Drawing.Point(12, 160);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(550, 409);
            this.resultBox.TabIndex = 4;
            this.resultBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.resultBox_ItemCheck);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Enabled = false;
            this.buttonDeleteSelected.Location = new System.Drawing.Point(392, 131);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(170, 23);
            this.buttonDeleteSelected.TabIndex = 3;
            this.buttonDeleteSelected.Text = "Skasuj zaznaczone";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(480, 52);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(82, 23);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "O programie";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // panelWithProgressBar
            // 
            this.panelWithProgressBar.Controls.Add(this.labelInformation);
            this.panelWithProgressBar.Controls.Add(this.progressBar);
            this.panelWithProgressBar.Location = new System.Drawing.Point(92, 258);
            this.panelWithProgressBar.Name = "panelWithProgressBar";
            this.panelWithProgressBar.Size = new System.Drawing.Size(391, 65);
            this.panelWithProgressBar.TabIndex = 13;
            this.panelWithProgressBar.Visible = false;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(6, 12);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 13);
            this.labelInformation.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 34);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(379, 24);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 0;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Enabled = false;
            this.buttonDeleteAll.Location = new System.Drawing.Point(392, 102);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(170, 23);
            this.buttonDeleteAll.TabIndex = 15;
            this.buttonDeleteAll.Text = "Skasuj wszystko";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // Pdcpvs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 581);
            this.Controls.Add(this.panelWithProgressBar);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxAll);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxProjectsPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pdcpvs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDCPVS - Program Do Czyszczenia Projektów Visual Studio";
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxFolders.ResumeLayout(false);
            this.groupBoxFolders.PerformLayout();
            this.groupBoxAll.ResumeLayout(false);
            this.panelWithProgressBar.ResumeLayout(false);
            this.panelWithProgressBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFileSuo;
        private System.Windows.Forms.CheckBox checkBoxFileUser;
        private System.Windows.Forms.CheckBox checkBoxFolderBin;
        private System.Windows.Forms.CheckBox checkBoxFolderObj;
        private System.Windows.Forms.CheckBox checkBoxFolderResharper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProjectsPath;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.GroupBox groupBoxFolders;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel panelWithProgressBar;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckedListBox resultBox;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.CheckBox checkBoxFolderSvn;
        private System.Windows.Forms.CheckBox checkBoxFolderPublish;
        private System.Windows.Forms.CheckBox checkBoxFilePdb;
        private System.Windows.Forms.CheckBox checkBoxFileApplication;
    }
}

