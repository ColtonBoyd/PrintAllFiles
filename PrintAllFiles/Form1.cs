using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintAllFiles
{
    public partial class Form1 : Form
    {

        private static List<string> SourceList = new List<string>();

        private static string DirectoryName = "";

        public Form1()
        {
            InitializeComponent();
            chkMultiThread.Checked = true;
        }


        private void btnPopulate_Click(object sender, EventArgs e)
        {
            btnPopulate.Enabled = false;
            Task.Factory.StartNew(() => PopulateList());
        }

        private void PopulateList()
        {
            List<Task> taskCeption = new List<Task>();
            List<ListOfFoldersFromThread> FolderList = new List<ListOfFoldersFromThread>();


            List<string> Directories = null;


            foreach (var dir in SourceList)
            {
                DirectoryName = dir;



                if (chkMultiThread.Checked)
                {
                    Directories = Directory.GetDirectories(dir).ToList();
                    double DirectoriesCount = 0;
                    double DivisionNumber = 20.0;
                    //////////////////////////This needs to be changed
                    if (Directories.Count() < 20){
                        DirectoriesCount = Directories.Count();
                        DivisionNumber = 1;
                    }

                    if (Directories.Count() > 60)
                    {
                        DirectoriesCount = (Directories.Count() / DivisionNumber) + .5;
                        DirectoriesCount = Math.Round(DirectoriesCount);

                    }




                    taskCeption.Add(Task.Factory.StartNew(() => FolderList.Add(new ListOfFoldersFromThread() { Folders = new List<Folder> { new Folder() { FolderName = dir, Files = Directory.GetFiles(dir).ToList() } } })));
                    Task.WaitAll(taskCeption.ToArray());

                    for (int i = 1; i < DirectoriesCount; i++)
                        FolderList.Add(new ListOfFoldersFromThread() { Folders = new List<Folder>() });

                    int IncrementThreads = 0;
                    for (int i = 0; i < DirectoriesCount; i++)
                    {
                        var w = Directories.Skip((int)DivisionNumber * i).Take((int)DivisionNumber).ToList();
                        taskCeption.Add(Task.Factory.StartNew(() => BreakUpSearch(w, IncrementThreads++, FolderList)));
                    }



                    Task.WaitAll(taskCeption.ToArray());



                }
                else
                {


                    List<string> ShortNamesFileList = new List<string>();
                    if (chkHidePath.Checked)
                    {

                        foreach (var item in Directory.EnumerateDirectories(dir))
                            ShortNamesFileList.Add(item.Substring(item.LastIndexOf("\\") + 1));

                        FolderList[0].Folders = new List<Folder>() { new Folder() { FolderName = dir, Files = ShortNamesFileList } };
                    }
                    else
                    {
                        foreach (var item in Directory.EnumerateDirectories(dir))
                            FolderList[0].Folders = new List<Folder>() { new Folder() { FolderName = item, Files = null } };

                    }


                }

            }

            lstBoxFileList.Invoke(new MethodInvoker(delegate
                {
                    var lstBoxFileListDataSource = PrintList(FolderList).GroupBy(x => x).Select(y => y.First()).OrderBy(x => x).ToList();
                    lstBoxFileListDataSource.Add(lstBoxFileListDataSource.Count() + "");
                    lstBoxFileList.DataSource = lstBoxFileListDataSource;

                }));

        }

        private void BreakUpSearch(List<string> xx, int i, List<ListOfFoldersFromThread> fileList)
        {

            List<Folder> getFolder = new List<Folder>();
            List<Folder> TempFileList = new List<Folder>();
            for (int o = 0; o < xx.Count; o++)
            {
                getFolder = PopulateListRec(xx[o], TempFileList);
                fileList[i].Folders.AddRange(getFolder.ToList());
                getFolder.Clear();
                TempFileList.Clear();
            }

        }

        private List<String> PrintList(List<ListOfFoldersFromThread> list)
        {
            string prevFolderName = DirectoryName;
            List<string> FilesWritten = new List<string>();
            List<string> FilesToWrite= new List<string>();
            if (!Directory.Exists("Folder"))
            {
                Directory.CreateDirectory("Folder");
            }

            foreach (var ThreadResponse in list)
            {


                string FileName = "";
                foreach (var item in ThreadResponse.Folders)
                {

                    if (chkMultipleFolders.Checked)
                    {

                        if (item.Files == null)
                        {
                            prevFolderName = item.FolderName;
                        }
                        else
                        {



                            if (!prevFolderName.Equals("") && !prevFolderName.Equals(DirectoryName) &&
                            item.FolderName.Substring(DirectoryName.Count() + 1).Contains(prevFolderName.Substring(DirectoryName.Count() + 1)))
                            {


                                FileName = prevFolderName.Substring(DirectoryName.Count() + 1);
                                while (FileName.Contains("\\"))
                                    FileName = FileName.Substring(0, FileName.IndexOf("\\"));

                                FileName = "Folder/" + FileName + ".txt";

                                item.Files.Insert(0, item.FolderName.Substring(item.FolderName.LastIndexOf("\\") + 1) + "\n");
                                item.Files.Add("\n\n");
                                File.AppendAllLines(FileName, item.Files);
                                prevFolderName = "";
                            }
                            else
                            {
                                FileName = "Folder/" + item.FolderName.Substring(item.FolderName.LastIndexOf("\\") + 1) + ".txt";
                                if (string.IsNullOrEmpty(FileName) || FileName.Trim().Equals(".txt"))
                                    FileName = "Folder/" + item.FolderName.Substring(item.FolderName.LastIndexOf("\\") + 1) + "base.txt";



                                File.WriteAllLines(FileName, item.Files);

                            }


                            FilesWritten.Add("File created \"" + FileName + "\"");



                        }
                    }
                    else
                    {
                        if (item.Files != null)
                        {
                            FileName = item.FolderName.Substring(item.FolderName.LastIndexOf("\\") + 1);
                            string Directory = DirectoryName.Substring(DirectoryName.LastIndexOf("\\") + 1);
                            item.Files.Insert(0, FileName);
                            item.Files.Add("\n\n\n");
                            FilesToWrite.AddRange(item.Files);
                            FilesWritten.Add("\"" + FileName + "\" Appended");

                        }
                    }
                }


            }
            if (FilesToWrite.Count!=0)
            File.AppendAllLines("Folder/Output.txt", FilesToWrite);
            return FilesWritten;
        }


        private static List<Folder> PopulateListRec(string path, List<Folder> TempFileList)
        {


            try
            {

                {
                    List<string> File = Directory.GetFiles(path).ToList();
                    if (File.Count > 0)
                    {
                        for (int i = 0; i < File.Count; i++)
                            File[i] = "\t\t" + File[i];
                        TempFileList.Add(new Folder() { FolderName = path, Files = File });
                    }
                }

                //Check for more directories in the directory. If found add them to the list and recursivly call this method again with the new path found.
                foreach (string Directory in Directory.GetDirectories(path))
                {

                    try
                    {
                        TempFileList.Add(new Folder() { FolderName = path, Files = null });
                        PopulateListRec(Directory, TempFileList);
                    }
                    catch (Exception) { }

                }

                return TempFileList;


            }
            catch (System.Exception)
            {
                //MessageBox.Show(ex.Message);


            }
            return null;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "Select Directory"
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                SourceList.Add(fbd.SelectedPath);
                lstBoxSources.Items.Add(fbd.SelectedPath);
            }
        }

        private void btnClearFile_Click(object sender, EventArgs e)
        {

        }

        private void btnClearSources_Click(object sender, EventArgs e)
        {

        }

        private void lstBoxFileList_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                Arguments = lstBoxFileList.SelectedItem.ToString().Trim(),
                FileName = "explorer.exe"
            };
            System.Diagnostics.Process.Start(startInfo);

        }



        private void getMeOutaHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearSourceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear Source Folder List?", "Clear File List", MessageBoxButtons.YesNo) == DialogResult.Yes)
                lstBoxSources.Items.Clear();
        }

        private void clearOutputListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Clear File List?", "Clear File List", MessageBoxButtons.YesNo) == DialogResult.Yes)
                lstBoxFileList.Items.Clear();
        }

        private void viewOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                Arguments = AppDomain.CurrentDomain.BaseDirectory,
                FileName = "explorer.exe"
            };
            System.Diagnostics.Process.Start(startInfo);
        }
    }

    public class Folder
    {
        public string FolderName { get; set; }
        public List<string> Files { get; set; }


    }


    public class ListOfFoldersFromThread
    {
        public List<Folder> Folders { get; set; }


    }
}
