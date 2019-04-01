using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Window : Form
    {
        private FolderBrowserDialog dialog = new FolderBrowserDialog();
        private string directory;

        public Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                directory       = dialog.SelectedPath;
                Visualizer.Text = directory;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DivideAccordingToExtension();
        }
        //For each extension if there are almost two files of each type, create a folder and move them in
        private List<string> SelectAllFilesInFolder(string folder)
        {
            List<string> toReturn = null;

            if (Directory.Exists(folder))
               toReturn = Directory.GetFiles(folder).ToList();

            return toReturn;
        }

        private void DivideAccordingToExtension()
        {
            List<string> extensions = new List<string>();
            List<string> allFiles = SelectAllFilesInFolder(directory);
           
            //Get all extensione type
            foreach (string file in allFiles)
            {
                string ext = Path.GetExtension(file);

                if (!extensions.Contains(ext))
                    extensions.Add(ext);
            }

            List<DirectoryInfo> dir = new List<DirectoryInfo>();
            //Create directory according the extensions
            foreach (string ext in extensions)
            {
                //TODO: check if directory already exist
                DirectoryInfo d =  Directory.CreateDirectory(Path.Combine(directory,ext));
                dir.Add(d);
            }

            //Do private in class
            string currentExt;
            foreach (DirectoryInfo folder in dir)
            {
                foreach (string file in allFiles)
                {
                    currentExt = Path.GetExtension(file);
                    if (currentExt == folder.Name)
                    {
                        int index = file.LastIndexOf("\\") + 1;
                        string name = file.Substring(index);
                        File.Move(file,Path.Combine(directory,folder.Name,name));
                    }
                }
            }

            extensions.Clear();
            allFiles.Clear();
            dir.Clear();
        }

       
    }
}

//string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
//string[] unwantedExtensions = { "exe", "txt", "ccp" }; // you can extend it  
//StringCollection col = new StringCollection();  
//foreach (string file in files )  
//{  
//   string ext = Path.GetExtension(file);  
//   if ( ! unwantedExtensions.Contains<string>(ext ) )  
//   {  
//      col.Add(file );  
//   }  
//}  
