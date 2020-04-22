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
using Gmod_Workshop_Tool.Properties;

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
        bool hasName = false;

        string[] commonGmadLocations;
               

        public Main_Form()
        {
            InitializeComponent();
            commonGmadLocations = setCommonLocations();
            //creates temp gmad.exe file from resources to
            //Checks if gmod is installed in the standard path/sets gmod root directory
            if (!LoadSettings())
            {
                WriteToOutBox("Scanning common gmod locations...");
                CheckForCommonGmadLocations(commonGmadLocations);
            }
            else
            {
                gmodRoot = Settings.Default["GmodFolder"].ToString();
                txb_rootDir.Text = gmodRoot;
                root = true;
                WriteToOutBox("Settings Loaded.");
            }
        }

        
        private bool LoadSettings()
        {
            var folderPath = Settings.Default["GmodFolder"].ToString();
            if (!ValidateGmodFolder(folderPath))
            {
                return false;
            }
            
            if (!String.IsNullOrWhiteSpace(folderPath))
            {
                gmodRoot=folderPath;
                return true;
            }
            return false;
        }

        private void SaveSettings(string setting, string value)
        {
            Settings.Default[setting] = value;
            Settings.Default.Save();
        }
        //A list for common used locations for the Garrys Mod installation
        private string[] setCommonLocations()
        {
            List<string> locations = new List<string>();

            locations.Add(@"C:\Program Files (x86)\Steam\steamapps\common\GarrysMod");
            locations.Add(@"C:\Program Files\Steam\steamapps\common\GarrysMod");

            return locations.ToArray();
        }

        private void CheckForCommonGmadLocations(string[] locations)
        {
            foreach (var loc in locations)
            {
                if (Directory.Exists(loc))
                {
                    txb_rootDir.Text = loc;
                    gmodRoot = loc;
                    root = true;
                    return;
                }
            }

            txb_rootDir.Text="Gmod root folder not found...";
            WriteToOutBox("Garrys Mod could not be found, please enter Gmod Location.");
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
                if (!ValidateGmodFolder(fbd.SelectedPath))
                {
                    txb_rootDir.Text = "No valid directory.";
                    WriteToOutBox("Gmod Folder could not be Validated. \ngmad.exe could not be found.");
                    return;
                }
                gmodRoot = fbd.SelectedPath;
                txb_rootDir.Text = gmodRoot;
                
                root = true;
                SaveSettings("GmodFolder", gmodRoot);
            }
        }

        private bool ValidateGmodFolder(string folderPath)
        {
            if (File.Exists(folderPath + @"\bin\gmad.exe")) {
                WriteToOutBox("Valid Gmod directory loaded.");
                return true;
            }
            return false;
        }

        //Create GMA File based on files from the directories
        private void btn_createGma_Click(object sender, EventArgs e)
        {
            if (!hasName){
                WriteToOutBox("It seems you haven't entered a Name for your Addon.");
                return;
            }

            if (Directory.Exists(gmodRoot)&& Directory.Exists(modPath)&& Directory.Exists(gmaPath))
            {
                try
                {
                    System.Diagnostics.Process.Start(gmodRoot + @"\bin\gmad.exe", "create -folder " + modPath + " -out " + gmaPath + ".gma");
                }
                catch (Exception ex)
                {
                    WriteToOutBox($"Error found during GMA creation: {ex}");
                }
                
            }
            else
            {
                WriteToOutBox("Check your directories! Something seems off...");
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
                    try
                    {
                        System.Diagnostics.Process.Start(gmodRoot + @"\bin\gmpublish.exe", "create -addon " + gmaUpdatePath + " -icon " + iconPath);
                    }
                    catch (Exception ex)
                    {
                        WriteToOutBox($"Error during update: {ex}");
                    }
                    
                }
                else
                {
                    try
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
                    catch (Exception ex)
                    {
                        WriteToOutBox($"Error during update: {ex}");

                    }
                }
            }
            else
            {
                WriteToOutBox("Please enter Gmod Root folder!");
            }
            
        }

        //updates existing addons icon
        private void btn_updateIcon_Click(object sender, EventArgs e)
        {
            if (root)
            {
                if (cbx_update.Checked)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(gmodRoot + @"\bin\gmpublish.exe", "update -icon " + iconPath + " -id " + txb_wsId.Text);
                    }
                    catch (Exception ex)
                    {
                        WriteToOutBox($"Error during update: {ex}");

                    }
                    
                }
            }
            else
            {
                WriteToOutBox("Please enter Gmod Root folder!");
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
            {
                modPath = file;
                txb_folderLocation.Text = modPath;
            }
        }

        private void txb_AddonName_TextChanged(object sender, EventArgs e)
        {
            hasName = true;
        }

        private void WriteToOutBox(string s)
        {
            outTextBox.AppendText(s+"\n");
        }
    }
}
