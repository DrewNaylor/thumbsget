# thumbsget4web

This is a port of thumbsget to a webpage that uses JavaScript to show the thumbnails in the preview box.

For now, it won't look very good until some CSS styling is done.

thumbsget4web is installed on my website and you can use it here: https://drew-naylor.com/projects/thumbsget4web/thumbsget4web.html

## Limitations

thumbsget4web has a limitation where it can't actually save thumbnails directly with a "Save thumbnail" button, so the user has to manually save the thumbnails, either by right-clicking on the preview image or by right-clicking on the image in a new tab, then clicking "Save image as" or similar. This limitation is imposed by most web browsers ignoring the `download` attribute for the `anchor` tag if going across domains for security purposes.


## Screenshot

![](../docs/images/thumbsget4web-screenshot-with-preview.png?raw=true)


## Recent updates

### Version 0.1.1.0 - July 4, 2019:

- Added:
  - Now the hqdefault thumbnail can be used instead of maxresdefault in case there's no maxresdefault thumbnail available for a particular video.
- Changed:
  - The noscript tag has been updated to mention that there's a Mac version of thumbsget and that the Windows version can be run on Linux with .Net 4.6.1 installed, which can be done with winetricks.
- Fixed:
  - Clicking "View thumbnail in new tab" works in thumbsget4web even if the textbox is blank. This shouldn't happen so that it's consistent with the desktop versions. (Fixed in c55f9dd. See [#4](https://github.com/DrewNaylor/thumbsget/issues/4) for more details.)
