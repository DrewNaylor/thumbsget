# thumbsget
Gets the maxresdefault thumbnail for YouTube videos from original video URL. Not associated with YouTube or Google.

After getting the thumbnail URL, it'll open in the default browser. I want to also allow the thumbnail to be previewed in the main window and just have a save button so that opening the browser isn't required.

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
