using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FilesAndFoldersDLL;

namespace PDCPVS
{
    public partial class Pdcpvs
    {
        /// <summary>
        /// Startuje wątki.
        /// </summary>
        private void StartThreads()
        {
            //Jako pierwszy zostaje uruchomiony wątek czyszcący, następnie zostaje on zablokowany.
            //Po wykonaniu drugiego wątku, wątek czyszczący wykona czynności końcowe
            var cleaningThread = new Thread(CleaningMethod);
            cleaningThread.Start();
        }

        private void CleaningMethod()
        {
            var searchThread = new Thread(SearchingMethod);
            searchThread.Start();

            //Wątek Cleaning zostaje wstrzymany na czas trwania wątku searchThread
            searchThread.Join();

            //Czynności czyszczące
            TurnOnAllControlsOnMainForm(EnabledPropertyFromControlsOnMainForm);
            UpdateSomeControlsOnMainForm();
        }

        private void SearchingMethod()
        {
            UpdateLabelOnForm("Zbieranie informacji o podkatalogach...");
            List<DirectoryInfo> folders = null;

            try
            {
                folders = FilesAndFolders.SubFolders(TextBoxProjectsPathText);
            }
            catch (Exception exception)
            {
                ErrorForm.ShowError(exception.ToString());
                Close();
            }

            if (folders == null) return;

            UpdateLabelOnForm("Zbieranie informacji o plikach...");
            var files = FilesAndFolders.FilesFromFolders(folders);

            UpdateProgressBarStyle(ProgressBarStyle.Blocks);
            UpdateProgressBarMaximumValue(files.Count + folders.Count);

            UpdateLabelOnForm("Szukam... Proszę czekać!");

            Find(files, folders);
        }
    }
}
