# thumbsget
Gets the maxresdefault thumbnail for YouTube videos from original video URL. Not associated with YouTube or Google.
After getting the thumbnail URL, it'll open in the default browser. I want to also allow the thumbnail to be previewed in the main window and just have a save button so that opening the browser isn't required.


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
