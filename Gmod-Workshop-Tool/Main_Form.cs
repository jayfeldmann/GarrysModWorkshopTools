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
using System.Reflection;

namespace Gmod_Workshop_Tool
{
    public partial class Main_Form : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        string tempExeName = Path.Combine(Directory.GetCurrentDirectory(), "A3E5.exe");
        string modPath = "";
        string gmaPath = "";
        string gmodRoot = "";
        string iconPath = "";
        string gmaUpdatePath = "";
        bool root = false;
               

        public Main_Form()
        {
            InitializeComponent();

            //creates temp gmad.exe file from resources to
                //Checks if gmod is installed in the standard path/sets gmod root directory
                if (Directory.Exists(@"C:\Program Files (x86)\Steam\steamapps\common\GarrysMod"))
                {
                    txb_rootDir.Text = @"C:\Program Files (x86)\Steam\steamapps\common\GarrysMod";
                    gmodRoot = @"C:\Program Files (x86)\Steam\steamapps\common\GarrysMod";
                    root = true;
                }//Check on 32 bit systems
                else if (Directory.Exists(@"C:\Program Files\Steam\steamapps\common\GarrysMod"))
                {
                    txb_rootDir.Text = @"C:\Program Files\Steam\steamapps\common\GarrysMod";
                    gmodRoot = @"C:\Program Files\Steam\steamapps\common\GarrysMod";
                    root = true;
                }
                else
                {
                    txb_rootDir.Text = "Gmod root folder not found...";
                }
        }
        //Select path of uncompiled addon
        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                modPath = fbd.SelectedPath;
                txb_folderLocation.Text = fbd.SelectedPath;
            }
        }
        //Select the GMA output path
        private void btn_gmaOutLoc_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                gmaPath = fbd.SelectedPath + @"\" + txb_AddonName.Text;
                txb_gmaOutLoc.Text = gmaPath + ".gma";
                gmaUpdatePath = gmaPath + ".gma";
                txb_updateGmaLocation.Text = gmaPath + ".gma";
            }
        }
        //Select the root directory of Gmod
        private void btn_rootDir_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                gmodRoot = fbd.SelectedPath;
                txb_rootDir.Text = gmodRoot;
                root = true;
            }
        }
        //Create GMA File based on files from the directories
        private void btn_createGma_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(gmodRoot)&& Directory.Exists(modPath)&& Directory.Exists(gmaPath))
            {
                System.Diagnostics.Process.Start(gmodRoot + @"\bin\gmad.exe", "create -folder " + modPath + " -out " + gmaPath + ".gma");
            }
            else
            {
                MessageBox.Show("Check your directories! Something seems off...");
            }
        }
        //Select the Icon used for the Workshop
        private void btn_openIcon_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                iconPath = ofd.FileName;
                txb_iconPath.Text = iconPath;
                btn_updateIcon.Enabled = true;

            }
        }
        //Selects the COMPILED GMA LOCATION; for upload/update purposes
        private void btn_updateGmaLocation_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                gmaUpdatePath = ofd.FileName;
                txb_updateGmaLocation.Text = gmaUpdatePath;
            }
        }
        //Switches between upload and update mode
        //UPLOAD: uploads new addon to workshop
        //UPDATE: updates already existing addon in the workshop
        private void cbx_update_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_update.Checked)
            {
                txb_wsId.Enabled = true;
                btn_updateAddon.Text = "Update Addon";
            }
            else
            {
                txb_wsId.Enabled = false;
                btn_updateAddon.Text = "Upload Addon";
            }
        }
        //Decides if user wants to include changenotes
        private void cbx_changeNotes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_changeNotes.Checked)
            {
                txb_changeNotes.Enabled = true;
            }
            else
            {
                txb_changeNotes.Enabled = false;
            }
        }
        //Updates existing addon in workshop
        private void btn_updateAddon_Click(object sender, EventArgs e)
        {
            if (root)
            {
                if (cbx_update.Checked == false)
                {
                    System.Diagnostics.Process.Start(gmodRoot + @"\bin\gmpublish.exe", "create -addon " + gmaUpdatePath + " -icon " + iconPath);
                }
                else
                {
                    if (cbx_changeNotes.Checked)
                    {
                        System.Diagnostics.Process.Start(gmodRoot + @"\bin\gmpublish.exe", "update -addon " + gmaUpdatePath + " -id " + txb_wsId.Text + " -changes " + txb_changeNotes.Text);
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(gmodRoot + @"\bin\gmpublish.exe", "update -addon " + gmaUpdatePath + " -id " + txb_wsId.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter Gmod Root folder!");
            }
            
        }
        //updates existing addons icon
        private void btn_updateIcon_Click(object sender, EventArgs e)
        {
            if (root)
            {
                if (cbx_update.Checked)
                {
                    System.Diagnostics.Process.Start(gmodRoot + @"\bin\gmpublish.exe", "update -icon " + iconPath + " -id " + txb_wsId.Text);
                }
            }
            else
            {
                MessageBox.Show("Please enter Gmod Root folder!");
            }
        }
        //Drag and Drop Open Folder Location
        private void txb_folderLocation_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void txb_folderLocation_DragDrop(object sender, DragEventArgs e)
        {
           string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                modPath = file;
                txb_folderLocation.Text = modPath;
        }
    }
}
