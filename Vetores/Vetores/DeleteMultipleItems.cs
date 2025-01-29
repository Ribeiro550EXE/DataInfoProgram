using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetores
{
    
    public partial class DeleteMultipleItems : Form
    {
        public static DeleteMultipleItems instance;
        public TextBox TB1;
        string lockedPath;
        public DeleteMultipleItems()
        {
            InitializeComponent();
            instance = this;
            TB1 = TXTPATH;
        }
        

        private void BTPLUSPATH_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdd = new FolderBrowserDialog();
            fdd.RootFolder = Environment.SpecialFolder.Desktop;
            fdd.Description = "{Select your folder}";
            fdd.ShowNewFolderButton = false;

            if (fdd.ShowDialog() == DialogResult.OK)
            {
                PathTxt.Text = fdd.SelectedPath;
                string AbCompress = compress(fdd.SelectedPath);
                CompressTEXT.Text = AbCompress;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PattrenTXT.Text = "*";
            MultipleFiles.Items.Clear();
            try
            {
                DirectoryInfo dir_info = new DirectoryInfo(PathTxt.Text);


                foreach (FileInfo file_info in dir_info.GetFiles(PattrenTXT.Text, SearchOption.AllDirectories))
                {
                    //string compressinfo = compress(file_info.FullName);
                    int index = MultipleFiles.Items.Add(file_info);
                    MultipleFiles.SetItemChecked(index, true);
                    int index1 = ListBCOmpress.Items.Add(file_info.FullName);
                    ListBCOmpress.SetItemChecked(index1, true);
                }
                ReadNUMFilesRTB.Text = MultipleFiles.Items.Count + "files found";
                BTFDeleteFile.Enabled = MultipleFiles.CheckedIndices.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTFDeleteMultipleFiles_Click(object sender, EventArgs e)
        {
            string[] filenames = new string[MultipleFiles.CheckedItems.Count];
            MultipleFiles.CheckedItems.CopyTo(filenames, 0);

            foreach (string filename in filenames) 
            { 
                Console.WriteLine(filename);
                try
                {
                    File.Delete(filename);
                    MultipleFiles.Items.Remove(filename);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting file. " + ex.Message);
                    if(MessageBox.Show("Error deleting file" + ex.Message + 
                        Environment.NewLine + Environment.NewLine + 
                        "Continue?" , "Continue?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.No)
                        break;
                }
            }
            ReadNUMFilesRTB.Text = MultipleFiles.Items.Count + "files found";
            BTFDeleteFile.Enabled = MultipleFiles.CheckedIndices.Count > 0;
        }

        private void BTFDeleteFile_Click(object sender, EventArgs e)
        {

        }

        private void BTDELETEFILE_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMultipleItems_Load(object sender, EventArgs e)
        {

        }

        public void LockPath(string path)
        {
            lockedPath = path;
            PathTxt.Text = path;
            PathTxt.Text.Replace(@"\", @"/");
            PathTxt.Enabled = false;
            BTPLUSPATH.Enabled = false;

            
            string AbCompress = compress(path);
            CompressTEXT.Text = AbCompress;

        }
        static string compress(string str)
        {
            if ((str == null) || (str == ""))
            {
                return str;
            }
            StringBuilder SB = new StringBuilder();
            char lastCha = str[0];
            int count = 1;

            Debug.WriteLine(str.Length);

            

            for (int i = 1; i < str.Length; i++) 
            {
                if (str[i] == '/') 
                { 
                    SB.Append(i);
                    lastCha = str[i];
                }
                else
                {
                    SB.Append(lastCha);
                    lastCha = str[i];
                }
            }
            SB.Append(lastCha);
            SB.Append(count);
            string result = SB.ToString();
            
            result = result.Replace("Vetores", "..");
            result = result.Replace("bin", "..");
            result = result.Replace("Debug", "..");
            result = result.Replace("Users", "Us");
            result = result.Replace(Environment.UserName, "N");
            result = result.Replace("DataInfoProgram", "DIP");
            result = result.Replace("Documents", "Doc");

            /*if (result.Length < str.Length)
            {
                return str;
            }*/


            return result;
        }
    }
}
