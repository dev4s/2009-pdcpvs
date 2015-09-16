using System;
using FilesAndFoldersDLL;
using System.Windows.Forms;

namespace PDCPVS
{
    public partial class Pdcpvs : Form
    {
        public Pdcpvs()
        {
            InitializeComponent(); 
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //Wyświetla 'Dialog' z możliwością wyboru katalogu
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
            textBoxProjectsPath.Text = folderBrowserDialog.SelectedPath;

            buttonSearch.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Czyści poprzednie wyniki - przydatne przy kolejnym wyszukiwaniu
            resultBox.Items.Clear();
            TextBoxProjectsPathText = textBoxProjectsPath.Text;
            EnabledPropertyFromControlsOnMainForm = TurnOffEnableProperty(Controls);
            TurnOnProgressBarPanel();
            StartThreads();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Czy chcesz skasować wszystkie pliki i katalogi? (Operacja jest nieodwracalna [zostanie zaimplementowana w następnej iteracji])",
                    "Czy na pewno?", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            //TODO: wątek!
            for (int i = resultBox.Items.Count - 1; i >= 0; i--)
            {
                if (FilesAndFolders.Delete((string)resultBox.Items[i]))
                {
                    resultBox.Items.RemoveAt(i);
                }
            }
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Czy chcesz skasować wybrane pliki i katalogi? (Operacja jest nieodwracalna [zostanie zaimplementowana w następnej iteracji])",
                    "Czy na pewno?", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            //TODO: wątek!
            for (int i = _checkedItemsOnResultBox.Count - 1; i >= 0; i--)
            {
                FilesAndFolders.Delete((string)resultBox.Items[_checkedItemsOnResultBox[i]]);
                resultBox.Items.RemoveAt(_checkedItemsOnResultBox[i]);
                _checkedItemsOnResultBox.Remove(i);
            }
        }

        private void resultBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)_checkedItemsOnResultBox.Add(e.Index);
            else _checkedItemsOnResultBox.Remove(e.Index);

            buttonDeleteSelected.Enabled = _checkedItemsOnResultBox.Count != 0;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}