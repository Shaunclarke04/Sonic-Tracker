# SonicTracker

### Not affiliated with SEGA or Sonic Team. This is a fan-made project.

Track your progress in Sonic games with SonicTracker! This tool tracks which stages you've completed in various Sonic Games

## Currently Supported Games

- Sonic the Hedgehog
- Sonic the Hedgehog 2
- Sonic CD
- Sonic Chaos // Sonic & Tails
- Sonic 3 & Knuckles
- Sonic Triple Trouble // Sonic & Tails 2
- Knuckles' Chaotix
- Tails Adventure
- Sonic Blast // G Sonic 
- Sonic 3D Blast // Sonic 3D: Flickies' Island
- Sonic The Hedgehog Pocket Adventure (listed as Sonic Pocket Adventure)
- Sonic Adventure
- Sonic Adventure 2
- Sonic Advance
- Sonic Advance 2
- Sonic Heroes
- Sonic Advance 3
- Sonic Rush
- Shadow The Hedgehog (not sure about how to track this one, i currently list stages - see [Act list changes](#act-list-changes))
- Sonic The Hedgehog // Sonic '06
- Sonic and the Secret Rings
- Sonic Rush Adventure
- Sonic Unleashed (both versions are seperate game lists, PlayStation versioning is used internally; lists are kinda messy - see [Act list changes](#act-list-changes))

### more games coming soon

## More Features

- Dynamic progress bar with Percentage/Fractional readout of completed stages in each game; configurable in settings
- data is automatically saved when settings are changed or when acts are checked/unchecked
- Locally saved data in `%appdata%/../local/SonicTracker`
- Quickly search for and jump to any game
- Resizable and responsive UI
- automatic updates (on full release)

## Act List Changes

If anything in an Act List is incorrect or could be better organised, please submit an Issue or Pull Request and provide sources for the corrected list.

Please note: After an update to an existing app list, save data for the old list will need to be manually removed from the save file to avoid sync issues.
To do this, press Win + R, type `%appdata%/../local/SonicTracker`, then open the subsequent folders until you find user.config. Open this file in a text editor and search for the game's title (for example, `<setting name="SonicCDCheckedItems" serializeAs="String">`). Below that line, replace `<value>x,y,z</value>` with `<value />`, save the file, and restart the program and recheck all your completed acts.

## Build Instructions

1. Download and run the [Visual Studio Community installer](https://visualstudio.microsoft.com/) from Microsoft

2. Under Desktop & Mobile, select `.NET Desktop Development` and click install

3. Open Visual Studio, Sign into your Microsoft account and run through the first time setup wizard

4. click `Clone a Repository` and paste in the GitHub link: https://github.com/Shaunclarke04/Sonic-Tracker

5. Choose a location to clone to that you can find again but isnt in the way (like your user folder)

6. Click Clone and wait for the app to download

7. go to Build > Build Solution and wait for the process to finish. This may take a while for the first build.

8. go to the location you chose in step 5 and go to `\bin\Debug\net10.0-windows`, right click SonicTracker.exe and choose one of the following options:
   
   1. Pin to Start (to have the app in your start menu)
   
   2. Pin to Taskbar (to have the app on your taskbar)
   
   3. Create Shortcut (to create a shortcut which can be dragged to your desktop or another location)

9. Run the app, make some changes and relaunch to make sure the data saves.

###### Please Note: Windows SmartScreen may prevent the app from running depending on your system security settings. This is to be expected as this is a new app in active development which hasnt yet been added to microsofts database. simply click "more info" and then "run anyway". You should only need to do this once.