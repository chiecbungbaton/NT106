using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace Lab2
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();

        }        
        private void browse_Click(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                DriveInfo drif = new DriveInfo(drive);
                TreeNode node = new TreeNode(drive);
                node.Tag = drive;
                if (drif.IsReady == true)
                    node.Nodes.Add("...");
                treeView.Nodes.Add(node);
            }
            browse.Enabled = false;
        }
        private void openFolder(TreeNode parentNode, string path)
        {
            try
            {
                string[] subFolders = Directory.GetDirectories(path);
                foreach (string subfolder in subFolders)
                {
                    if (Path.GetFileName(subfolder).StartsWith('$')) 
                        continue;
                    TreeNode folderNode = parentNode.Nodes.Add(subfolder);
                    openFolder(folderNode, subfolder);
                }
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    TreeNode node = new TreeNode();
                    node.Text = file;
                    parentNode.Nodes.Add(node);
                }
            }
            catch { }
        }
        private int preventOpenfile(string path)
        {
            int countFile = 0;
            try
            {
                string[] prPath = Directory.GetFiles(path);
                foreach (var filecanopen in prPath)
                {
                    FileInfo inf = new FileInfo(filecanopen);
                    if (inf.Extension == ".txt" || inf.Extension == ".jpg" || inf.Extension == ".jpeg" || inf.Extension == ".JPG" || inf.Extension == ".JPEG" || inf.Extension == ".png" || inf.Extension == ".PNG")
                        countFile++;                    
                    if (Directory.GetDirectories(path).Count() != 0)
                        countFile++;
                }
            }
            catch { }
            return countFile;
        }
        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "...")
            {
                e.Node.Nodes.Clear();
                string pathFolder = e.Node.Tag.ToString();
                string[] folders = Directory.GetDirectories(pathFolder);
                foreach (var folder in folders)
                {
                    try
                    {
                        DirectoryInfo folderinf = new DirectoryInfo(folder);
                        if (Path.GetFileName(folder).StartsWith('$'))
                            continue;
                        if (preventOpenfile(folder) == 0)
                            continue;
                        var node = new TreeNode(folderinf.Name);
                        node.Tag = folderinf;
                        e.Node.Nodes.Add(node);
                        if (folderinf.GetDirectories().Count() > 0 || folderinf.GetFiles().Count() > 0) 
                            node.Nodes.Add("...");
                    }
                    catch { }
                }
                string pathFile = e.Node.Tag.ToString();
                string[] files = Directory.GetFiles(pathFile);
                foreach (var file in files)
                {

                    FileInfo fileinf = new FileInfo(file);
                    if (fileinf.Attributes == FileAttributes.Hidden) 
                        continue;
                    if (fileinf.Extension != ".txt" && fileinf.Extension != ".jpg" && fileinf.Extension != ".JPG" && fileinf.Extension != ".jpeg" && fileinf.Extension != ".JPEG" && fileinf.Extension != ".png" && fileinf.Extension != ".PNG")
                        continue;
                    var node = new TreeNode(fileinf.Name);
                    node.Tag = fileinf;
                    e.Node.Nodes.Add(node);
                }

            }
        }        
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            if (!File.Exists(path)) return;
            FileInfo fileInfo = new FileInfo(path);
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            if (fileInfo.Extension == ".txt")
                richTextBox.Text = sr.ReadToEnd();
            else
            {
                Image img = Image.FromFile(path);
                pictureBox.Image = img;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}

    

