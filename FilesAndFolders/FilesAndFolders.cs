using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;

namespace FilesAndFoldersDLL
{
    public static class FilesAndFolders
    {
        /// <summary>
        /// Zwraca listę podfolderów (nie uporządkowaną) dla danego folderu
        /// </summary>
        /// <param name="folder">Ścieżka katalogu (nie musi być pełna). Metoda
        /// sama sobie stworzy pełną ścieżkę dostępu do folderu.
        /// </param>
        /// <returns></returns>
        public static List<DirectoryInfo> SubFolders(string folder)
        {
            //subFolders będzie zawierał już podfoldery folderu podanego
            //jako parametr metody SubFolder
            var fullFolderPath = new DirectoryInfo(folder).FullName;
            List<DirectoryInfo> subFolders;

            try
            {   
                subFolders = new List<DirectoryInfo>(new DirectoryInfo(fullFolderPath).GetDirectories());
            }
            catch (UnauthorizedAccessException)
            {
                return null;
            }

            //optymalizacyjnie - chociaż nie do końca
            int subFoldersCount = subFolders.Count;
            for (int i = 0; i < subFoldersCount; i++)
            {
                //TODO: Dodać kontrolę dostępności do katalogów
                //dodaje strukturę katalogów na końcu listy
                //jak zwróci null, to kontynuuje, znaczy - nie mamy dostępu do danego folderu
                try
                {
                    subFolders.AddRange(SubFolders(subFolders[i].FullName));
                }
                catch(ArgumentNullException)
                {
                    continue;
                }
            }
            //pełna ścieżka
            FullPath(subFolders);
            return subFolders;
        }

        /// <summary>
        /// Zwraca listę plików w podanych katalogach
        /// </summary>
        /// <param name="folders">Ścieżka do katalogów, w których znajdują się pliki</param>
        /// <returns></returns>
        public static List<FileInfo> FilesFromFolders(List<DirectoryInfo> folders)
        {
            var fileList = new List<FileInfo>();
            for (int i = 0; i < folders.Count; i++)
            {
                //TODO: Dodać kontrolę dostępności do plików
                try
                {
                    fileList.AddRange(folders[i].GetFiles());
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }

            }
            FullPath(fileList);
            return fileList;
        }

        /// <summary>
        /// Tworzy pełną ścieżkę folderów.
        /// </summary>
        /// <param name="folder">Ścieżka folderu</param>
        private static void FullPath(IList<DirectoryInfo> folder)
        {
            for (int i = 0; i < folder.Count; i++)
            {
                string folderName = folder[i].FullName;
                folder.RemoveAt(i);
                folder.Insert(i, new DirectoryInfo(folderName));
            }
        }

        /// <summary>
        /// Tworzy pełną ścieżkę plików.
        /// </summary>
        /// <param name="folder">Ścieżka pliku</param>
        private static void FullPath(IList<FileInfo> folder)
        {
            for (int i = 0; i < folder.Count; i++)
            {
                string folderName = folder[i].FullName;
                folder.RemoveAt(i);
                folder.Insert(i, new FileInfo(folderName));
            }
        }


        /// <summary>
        /// Usuwa plik lub folder. Nie przenosi do kosza!
        /// </summary>
        /// <param name="fileOrFolder">Plik lub Folder</param>
        public static bool Delete(string fileOrFolder)
        {
            //TODO: Usuwanie do kosza!
            var folder = new DirectoryInfo(fileOrFolder);
            var folderIoPermission = new FileIOPermission(FileIOPermissionAccess.Write, folder.FullName);

            try
            {
                folderIoPermission.Demand();
                File.SetAttributes(folder.FullName, FileAttributes.Normal);

                //Przy .SVN robi problemy :)
                foreach (var file in folder.GetFiles())
                {
                    File.SetAttributes(file.FullName, FileAttributes.Normal);
                    file.Delete();
                }
                if (folder.Exists)
                {
                    folder.Delete(true);
                }
            }
            catch (IOException)
            {
                var file = new FileInfo(fileOrFolder);
                var fileIoPermission = new FileIOPermission(FileIOPermissionAccess.Write, file.FullName);

                try
                {
                    if (file.Exists)
                    {
                        fileIoPermission.Demand();
                        File.SetAttributes(file.FullName, FileAttributes.Normal);
                        file.Delete();
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    return false;
                }
            }
            return true;
        }

        ///// <summary>
        ///// Zwraca listę katalogów zabronionych dla wszystkich istniejących dysków.
        ///// Jak na razie tylko dla Windows 7
        ///// </summary>
        ///// <returns></returns>
        //private static List<string> ExcludeFolderList()
        //{
        //    var excludedFoldersWindows7 = new[] { "System Volume Information",
        //                                  "$Recycle.Bin",
        //                                  "Boot",
        //                                  "Documents and Settings",
        //                                  "Recovery",
        //                                  @"ProgramData\Application Data",
        //                                  @"ProgramData\Desktop",
        //                                  @"ProgramData\Documents",
        //                                  @"ProgramData\Favorites",
        //                                  @"ProgramData\Start Menu",
        //                                  @"ProgramData\Templates",
        //                                  @"Users\All Users\Application Data",
        //                                  @"Users\All Users\Desktop",
        //                                  @"Users\All Users\Documents",
        //                                  @"Users\All Users\Favorites",
        //                                  @"Users\All Users\Start Menu",
        //                                  @"Users\All Users\Templates",
        //                                  @"Users\Default\AppData\Local\Application Data",
        //                                  @"Users\Default\AppData\Local\History",
        //                                  @"Users\Default\AppData\Local\Temporary Internet Files",
        //                                  @"Users\Default\Application Data",
        //                                  @"Users\Default\Cookies",
        //                                  @"Users\Default\Documents\My Music",
        //                                  @"Users\Default\Documents\My Pictures",
        //                                  @"Users\Default\Documents\My Videos",
        //                                  @"Users\Default\Local Settings",
        //                                  @"Users\Default\My Documents",
        //                                  @"Users\Default\NetHood",
        //                                  @"Users\Default\PrintHood",
        //                                  @"Users\Default\Recent",
        //                                  @"Users\Default\SendTo",
        //                                  @"Users\Default\Start Menu",
        //                                  @"Users\Default\Templates",
        //                                  @"Users\Default User",
        //                                  @"Users\Public\Documents\My Music",
        //                                  @"Users\Public\Documents\My Pictures",
        //                                  @"Users\Public\Documents\My Videos",
        //                                  string.Format(@"Users\{0}\AppData\Local\Application Data", Environment.UserName),
        //                                  string.Format(@"Users\{0}\AppData\Local\History", Environment.UserName),
        //                                  string.Format(@"Users\{0}\AppData\Local\Temporary Internet Files", Environment.UserName),
        //                                  string.Format(@"Users\{0}\Application Data", Environment.UserName),
        //                                  string.Format(@"Users\{0}\Cookies", Environment.UserName),
        //                                  string.Format(@"Users\{0}\Local Settings", Environment.UserName),
        //                                  string.Format(@"Users\{0}\My Documents", Environment.UserName),
        //                                  string.Format(@"Users\{0}\NetHood", Environment.UserName),
        //                                  string.Format(@"Users\{0}\PrintHood", Environment.UserName),
        //                                  string.Format(@"Users\{0}\Recent", Environment.UserName),
        //                                  string.Format(@"Users\{0}\SendTo", Environment.UserName),
        //                                  string.Format(@"Users\{0}\Start Menu", Environment.UserName),
        //                                  string.Format(@"Users\{0}\Templates", Environment.UserName),
        //                                  };

        //    var fullPathExcludedFolders = new List<string>();
        //    foreach (var drive in DriveInfo.GetDrives())
        //    {
        //        foreach (var folder in excludedFoldersWindows7)
        //        {
        //            fullPathExcludedFolders.Add(drive + folder);
        //        }
        //    }

        //    //tylko na partycji systemowej
        //    fullPathExcludedFolders.Add(string.Format(@"{0}\CSC", Environment.GetEnvironmentVariable("%SystemRoot%")));
        //    fullPathExcludedFolders.Add(string.Format(@"{0}\System32\LogFiles\WMI\RtBackup", Environment.GetEnvironmentVariable("%SystemRoot%")));

        //    return fullPathExcludedFolders;
        //}
    }
}