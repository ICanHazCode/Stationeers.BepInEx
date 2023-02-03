# Stationeers Visual Studio BepInex Plugin Template #

A project template to get started on building your own BepInEx-based Stationeers plugin.



This requires BepInEx 5.4 or better.

## BepInEx ##
![Github All Releases](https://img.shields.io/github/downloads/bepinex/bepinex/total.svg)
[![GitHub release](https://img.shields.io/github/release/bepinex/bepinex.svg)](https://github.com/BepInEx/BepInEx/releases/latest)
[![BepInEx Discord](https://user-images.githubusercontent.com/7288322/34429117-c74dbd12-ecb8-11e7-896d-46369cd0de5b.png)](https://discord.gg/MpFEDAg)

[Get it here!](https://github.com/BepInEx/BepInEx/releases/latest)

---

### BepInEx Install Instructions ###
* Get the latest release above.
* Download the appropriate zip file, x64 for Windows, unix for Linux/Mac.
* In Steam right click on Stationeers, hover the mouse over "Manage" then, click on "Browse Local Files".
* Copy/extract the contents of the zip folder into your Stationeers directory.
* You should end up with a BepInEx folder inside your Stationeers directory like: ![picture alt](https://i.imgur.com/PpS9gCl.png)
* Run the game once. Then exit. This will initilize BepInEx creating some new folders.
* Navigate to the BepInEx folder in your Stationeers directory.
* You should have "plugins" and "patchers" folders inside that directory like: ![picture alt](https://i.imgur.com/JRwmSie.png)
* To tell BepInEx to look in our workshop folders we need to make a symbolic link to that folder. A symbolic link is like a advanced shortcut. You only need to do this **once** to get **all** BepInEx workshop mods to work. 
* Goto [Stationeers.BepInEx](https://github.com/ICanHazCode/Stationeers.BepInEx) and download either `setlinks.ps1`(Windows) or `setlinks.sh`(Mac/Linux)
* For Mac: To make things easier to do [Create a keyboard shortcut](https://www.maketecheasier.com/launch-terminal-current-folder-mac/)
* Linux Ubuntu after 15.04, and any Linux using the latest nautilus should have the functionalty already installed.
* Copy `setlinks.ps1`(Windows) `setlinks.sh`(Linux/Mac) to the BepInEx folder.
* For Windows: Right-Click on `setlinks.ps1` and `Run With PowerShell`(Windows). This will ask you to run as Administrator as the commands require elevated permissions.
* For Linux: `Right-Click > Open in Terminal` and type `sudo chmod +x setlinks.sh` then hit enter. It may ask you to enter in your password because it's an administrative command.
* For Mac: In the BepInEx Folder window, use the keyboard shortcut you setup earlier. Then type `sudo chmod u+x setlinks.sh` and hit enter. It may ask you to enter in your password because it's an administrative command.
* For Mac/Linux: Now type `./setlinks.sh` and hit enter. You may need to enter in your password for it to run.
* The links should be setup now. Check the patchers and plugins folders in BepInEx for the folder `workshop`.

