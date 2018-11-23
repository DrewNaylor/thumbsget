# thumbsget
Gets the maxresdefault thumbnail for YouTube videos from original video URL. Not associated with YouTube or Google.

After getting the thumbnail URL, it'll open in the default browser. As of November 23, 2018, you can also preview and save the thumbnail directly from the main thumbsget window.

Project build status: [![Build status](https://ci.appveyor.com/api/projects/status/7ojww314fwhcyyhd?svg=true)](https://ci.appveyor.com/project/DrewNaylor/thumbsget)

Master branch build status: [![Build status](https://ci.appveyor.com/api/projects/status/7ojww314fwhcyyhd/branch/master?svg=true)](https://ci.appveyor.com/project/DrewNaylor/thumbsget/branch/master)

License notice:
```
thumbsget - Gets the maxresdefault thumbnail for YouTube videos from
original video URL. Not associated With YouTube or Google/Alphabet.
Copyright (C) 2018 Drew Naylor
YouTube and all related words are copyright
and trademark Google/Alphabet. Explained more in About window.
Google/Alphabet is not affiliated with either the thumbsget project or Drew Naylor
and does not endorse this software.
Any other companies mentioned own their respective copyrights/trademarks.
(Note that the copyright years include the years left out by the hyphen.)

This file is part of thumbsget.

thumbsget is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

thumbsget is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with thumbsget.  If not, see <http://www.gnu.org/licenses/>.
```

Currently, thumbsget replaces the following things in a URL:
- "www." with nothing
- "m." with nothing
- "?feature=youtu.be" with nothing
- "&feature=youtu.be" with nothing
- "youtube.com/watch?v=" with "i.ytimg.com/vi/"
- "youtu.be/" with "i.ytimg.com/vi/"
- "watch" with nothing
- "&v=" with nothing
- "youtube.com/" with "i.ytimg.com/vi/"

I'd like to have it be able to also get rid of playlist info (including the video's index) and the current time position as well, but I haven't figured that out yet without hardcoding anything, using advanced regex, or having the user paste text into a textbox/manually remove text from a URL.

thumbsget doesn't support getting thumbnails from YouTube Studio/Creator Studio links yet, either.

Screenshot:

![](/docs/images/thumbsget-with-thumbnail-in-firefox-and-preview.png?raw=true)

# System Requirements

## System Requirements for running thumbsget

To run thumbsget, your computer requires the following:

- [Microsoft .Net 4.6.1 Framework](https://www.microsoft.com/en-us/download/details.aspx?id=49981)

  - Ignore the ad on that page, scroll down, and click the orange Download button. Note that this is the web installer and it'll download its components after it's opened. May take a while to download.

- Windows versions: Windows 7 SP1, 8.1, 10.
  - Windows 8.0 is untested although it might work.
  - thumbsget has only been officially tested with Windows 10 as of November 23, 2018.

- Architectures: x86 (32-bit) and x64 (64-bit.)

- Hardware requirements: At least a 1.2 GHz CPU; 1 GB of RAM or more.

- Disk space:

  - 32-bit: 3 GB space free.
  - 64-bit: 3 GB space free.

- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in thumbsget due to Visual Studio building problems. There may also be a warning message on first start about Windows Defender SmartScreen saying it "prevented an unrecognized app from starting. Running this app might put your PC at risk." You can click the "More info" link, then the "Run anyway" button if you want to use it, though this may not be allowed on corporate networks.

- Disk space, RAM, and CPU frequency requirements are based on the .Net Framework 4.6.1 requirements. thumbsget itself is quite small, about 27 KB as of November 23, 2018.

## Building thumbsget from Source: System Requirements and Guide

In addition to the requirements for simply running thumbsget, your computer requires the following software to build it from source code:

- [Microsoft Build Tools 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48159)
  - If [Visual Studio 2015 Community](https://www.visualstudio.com/vs/older-downloads/) is installed, Microsoft Build Tools 2015 is not required for building thumbsget.

If you want to try the latest changes from the master branch, you can download the latest build's [artifacts from AppVeyor](https://ci.appveyor.com/project/DrewNaylor/thumbsget/branch/master/artifacts). When the download has completed, extract the archive, then open the `Debug` folder. In this folder, double-click on `thumbsget.exe`.

***

If you don't want to download from AppVeyor to build thumbsget, here's how to do it manually:

1. First, clone the Git repository by running: <code>git clone https://github.com/DrewNaylor/thumbsget.git</code> or [download the Zip file for the master branch](https://github.com/DrewNaylor/thumbsget/archive/master.zip) and remember where you saved your files.

2. Next, open the command prompt from the Start menu (`cmd.exe`) and type or copy/paste `cd C:\Program Files (x86)\MSBuild\14.0\Bin\` if you have a 64-bit Windows install or `cd C:\Program Files\MSBuild\14.0\Bin\` if you have a 32-bit Windows install. Press the Enter or Return key when it's pasted. Don't run `cmd.exe` from the Git Shell or else the next step won't work.

3. Third, type `msbuild.exe`, press the spacebar, and drag the `thumbsget.vbproj` into the command prompt window and press the Enter or Return key.

4. And finally, once the project is done being built, you'll find the `thumbsget.exe` file in `thumbsget\thumbsget\bin\Debug` wherever you saved the files to earlier along with a config file, a PDB file, and an XML file.

## How to Modify the Source Code

In order to play around with the source code, it's recommended to install [Visual Studio 2015 Community](https://www.visualstudio.com/vs/older-downloads/) in addition to the software to run UXL Launcher. To poke around in the code, simply double-click the `thumbsget.sln` file in the root of the Git repository.
