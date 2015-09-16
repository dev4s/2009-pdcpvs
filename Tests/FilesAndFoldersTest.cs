using System;
using System.IO;
using FilesAndFoldersDLL;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class FilesAndFoldersTests
    {
        [Test]
        public void TestFolderFolderTest()
        {
            var folder = FilesAndFolders.SubFolders(@"..\..\Tests\FolderTest");
            Assert.That(folder.Count, Is.EqualTo(4));
            Assert.That(folder[0].ToString(), Is.StringEnding("Folder1"));
			Assert.That(folder[1].ToString(), Is.StringEnding("Folder2"));
			Assert.That(folder[2].ToString(), Is.StringEnding("Folder3"));
			Assert.That(folder[3].ToString(), Is.StringEnding(@"Folder1\Folder1.1"));
        }

        [Test]
        public void TestFolderHasOneSubFolder()
        {
            var folder = FilesAndFolders.SubFolders(@"..\..\Tests\FolderTest\Folder1");
            Assert.IsNotEmpty(folder, "Folder jest pusty!");
            Assert.That(folder.Count, Is.EqualTo(1));
			Assert.That(folder[0].ToString(), Is.StringEnding("Folder1.1"));
        }

        [Test]
        public void TestFolderIsEmpty()
        {
            var folder = FilesAndFolders.SubFolders(@"..\..\Tests\FolderTest\Folder2");
            Assert.IsEmpty(folder, "Folder nie jest pusty!");
            Assert.That(folder.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestTakingFilesFromEmptyFolder()
        {
            var folder = FilesAndFolders.SubFolders(@"..\..\Tests\FolderTest\Folder3");
            var files = FilesAndFolders.FilesFromFolders(folder);
            Assert.IsEmpty(files, "Folder nie jest pusty!");
            Assert.That(files.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestTakingFilesFromFolderTest()
        {
            var folder = FilesAndFolders.SubFolders(@"..\..\Tests\FolderTest");
            var files = FilesAndFolders.FilesFromFolders(folder);
            Assert.IsNotEmpty(files, "Nie pobrał plików!");
            Assert.That(files.Count, Is.EqualTo(2));
			Assert.That(files[1].ToString(), Is.StringEnding("TextFile1.txt"));
			Assert.That(files[0].ToString(), Is.StringEnding("TextFile2.txt"));
        }

        [Test]
        public void TestExcludedFolder()
        {
            var folders = FilesAndFolders.SubFolders(@"C:\Documents and Settings");
            Assert.IsNull(folders, "Jest dostęp!");
        }

        [Test]
        [Ignore("Too much time!")]
        public void TestAllExcludedFolders()
        {
            //ok. 2min.
            var before = DateTime.Now;
            var folders = FilesAndFolders.SubFolders(@"C:\");
            var after = DateTime.Now;
            System.Windows.Forms.MessageBox.Show(string.Format("Czas trwania: {0}\nIlość folderów: {1}",
                                                               after - before,
                                                               folders.Count));
        }

        [Test]
        public void TestDeletingFilesAndFolders()
        {
            var file = new FileInfo(@"..\..\Tests\DeleteMe!.txt");
            var folder = new DirectoryInfo(@"..\..\Tests\DeleteMe!");

            Assert.That(FilesAndFolders.Delete(file.FullName), Is.True, "Nie skasowano pliku!");
            Assert.That(FilesAndFolders.Delete(folder.FullName), Is.True, "Nie skasowano katalogu!");

            Assert.That(file.Exists, Is.False, "Plik istnieje, a nie powinnien!");
            Assert.That(folder.Exists, Is.False, "Folder istnieje, a nie powinnien!");

            file.Create();
            folder.Create();
        }
    }
}