using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PDCPVS
{
    public partial class Pdcpvs
    {
        #region Akcesory
        private IList<bool> EnabledPropertyFromControlsOnMainForm { get; set; }
        private string TextBoxProjectsPathText { get; set; }
        private readonly IList<int> _checkedItemsOnResultBox = new List<int>();
        #endregion

        /// <summary>
        /// Wyłącza wszystkie kontrolki na formie.
        /// Zapisuje ich stan przed wyłączeniem
        /// </summary>
        /// <param name="controls">Lista kontrolek</param>
        public static IList<bool> TurnOffEnableProperty(Control.ControlCollection controls)
        {
            var enabledPropertyFromControls = new List<bool>();

            for (var i = 0; i < controls.Count; i++)
            {
                enabledPropertyFromControls.Add(controls[i].Enabled);
                controls[i].Enabled = false;
            }

            return enabledPropertyFromControls;
        }

        /// <summary>
        /// Włącza Panel z ProgressBar'em
        /// </summary>
        private void TurnOnProgressBarPanel()
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Value = 0;
            panelWithProgressBar.Visible = true;
            progressBar.Visible = true;
            labelInformation.Visible = true;
            panelWithProgressBar.Enabled = true;
            progressBar.Enabled = true;
            labelInformation.Enabled = true;
        }

        /// <summary>
        /// Ustawia kontrolkom ich wlaściwość Enabled.
        /// </summary>
        /// <param name="previousProperties">Lista z wartościami Enabled dla kontrolek.</param>
        private void TurnOnAllControlsOnMainForm(IList<bool> previousProperties)
        {
            for (var i = 0; i < previousProperties.Count; i++)
            {
                UpdateControlsOnFormEnableProperty(previousProperties[i], i);
            }
        }

        /// <summary>
        /// Przeszukuje pliki i foldery.
        /// </summary>
        /// <param name="files">pliki</param>
        /// <param name="folders">foldery</param>
        private void Find(IEnumerable<FileInfo> files, IEnumerable<DirectoryInfo> folders)
        {
            foreach (var file in files)
            {
                CheckingCheckBox(checkBoxFileSuo, ".suo", file);
                CheckingCheckBox(checkBoxFileUser, ".user", file);
                CheckingCheckBox(checkBoxFilePdb, ".pdb", file);
                CheckingCheckBox(checkBoxFileApplication, ".application", file);

				//TODO: temporary
            	CheckingCheckBox(new CheckBox() {Checked = true}, ".tmp", file);
                UpdateProgressBarIncrementValue();
            }

            foreach (var folder in folders)
            {
                CheckingCheckBox(checkBoxFolderBin, "\\BIN".ToLower(), folder);
                CheckingCheckBox(checkBoxFolderObj, "\\OBJ".ToLower(), folder);
                CheckingCheckBox(checkBoxFolderResharper, "\\_Resharper".ToLower(), folder);
                CheckingCheckBox(checkBoxFolderSvn, "\\.SVN".ToLower(), folder);
                CheckingCheckBox(checkBoxFolderPublish, "\\publish".ToLower(), folder);
                UpdateProgressBarIncrementValue();
            }
        }

        /// <summary>
        /// Sprawdza wartość Checked CheckBox'a i wartość tekstu w checkString dla danego folderu lub pliku.
        /// </summary>
        /// <param name="checkBox">CheckBox na formie</param>
        /// <param name="checkString">Sprawdzana wartość</param>
        /// <param name="fileSystemInfo">Plik lub Folder (FileInfo, DirectoryInfo)</param>
        private void CheckingCheckBox(CheckBox checkBox, string checkString, FileSystemInfo fileSystemInfo)
        {
            //TODO: Regex!
            if (checkBox.Checked && fileSystemInfo.FullName.ToLower().Contains(checkString))
            {
                UpdateResultBox(fileSystemInfo.FullName);
            }
        }
    }
}