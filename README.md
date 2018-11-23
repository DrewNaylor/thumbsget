# thumbsget
Gets the maxresdefault thumbnail for YouTube videos from original video URL. Not associated with YouTube or Google.

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

After getting the thumbnail URL, it'll open in the default browser. As of November 23, 2018, you can also preview and save the thumbnail directly from thumbsget.

Project build status: [![Build status](https://ci.appveyor.com/api/projects/status/7ojww314fwhcyyhd?svg=true)](https://ci.appveyor.com/project/DrewNaylor/thumbsget)

Master branch build status: [![Build status](https://ci.appveyor.com/api/projects/status/7ojww314fwhcyyhd/branch/master?svg=true)](https://ci.appveyor.com/project/DrewNaylor/thumbsget/branch/master)

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
