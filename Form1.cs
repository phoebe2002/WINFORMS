using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsLab
{
    public partial class Form1 : Form
    {
        string zipFilePath = "C:\\Users\\nyamutswat\\source\\repos\\WinFormsLab\\WinFormsLab\\locKeys.zip";
        public Form1()
        {
            InitializeComponent();
        }

       // onresize

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DetailsTab_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //code from tutorial
      

            OpenFileDialog fileDiaog = new OpenFileDialog();
            fileDiaog.Filter = "Zip Files(*.zip)|*.zip";
            if(fileDiaog.ShowDialog() == DialogResult.OK )
            {
                // DetailsTab.Text = fileDiaog.FileName;
                using (ZipArchive zip = ZipFile.OpenRead(fileDiaog.FileName))
                {
                    treeView1.Nodes.Clear();
                    foreach (ZipArchiveEntry entry in zip.Entries)
                    {
                        treeView1.Nodes.Add(entry.Name);
                    }
                }    
                    
            }

        }

        private void groupEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
