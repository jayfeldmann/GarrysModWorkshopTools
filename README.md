# Garrys Mod Workshop Tools
GUI Tool for creating, publishing and updating GMA's for Garrys Mod

DOWNLOAD:
https://github.com/jayfeldmann/GarrysModWorkshopTools/releases

REMOVING:
The Program uses a .config file to store the last entered Garrys Mod location
for convenience. This file is not encrypted, you can read it and if you want
to remove the Program completely, you have to remove the correct folder from your
appdata Folder.

The config can be found in: .../AppData/Local/Gmod_Workshop_Tool/CUSTOMID/user.config

How to use:

CREATING A GMA FILE
1. Enter a name for your addon (since this will be the filename, don't use spaces)
2. Enter the path of your uncompressed addon folder (just the folder with all your addon contents) with the "Open addon folder" button.
3. Enter a path for the GMA to be output with the "GMA Location" button.
4. Select (if not found by the program) the root folder of your Garrys Mod installation. (Since the software works with Garrys Mod gma packing and uploading software, this is necessary to locate them)
5. Click "Create GMA File" to create a GMA file in the "GMA Location" folder

UPLOADING A NEW ADDON
1. Unckeck "Update addon?"
2. Select an Icon for your addon. This is the first picture being shown in the Steam Workshop (Not necessary).
3. Select the compressed GMA addon file.
4. Click "Upload Addon" and let the program do the rest for you.
5. Finalise your Workshop release inside of steam.

UPDATING AN EXISTING ADDON
1. Check "Update addon?"
2. Enter the Workshop ID of your addon.
2b. If you wish to, check "Changes?" and enter a changenote message (Not necessary).
3. Select an Icon (Not necessary).
4. Select the updated GMA addon file.
5. Click "Update Addon".
6. Finalise your Workshop release inside of steam.

Patchnotes:

V. 1.1
- Added Error handling to prevent unwanted crashes.
- Added user settings. Garrys Mod location will be saved.
- Added Output Textbox to remove annoying Message Boxes.
- Misc quality of live improvements.

V. 1.0
- The software is able to create a GMA file with given folders
- GMA's can be published directly to Steam Workshop
- Existing Workshop items can be updated
- Icons of existing Workshop Items can be updated
