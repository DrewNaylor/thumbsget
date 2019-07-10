# thumbsget4web

This is a port of thumbsget to a webpage that uses JavaScript to show the thumbnails in the preview box.

For now, it won't look very good until some CSS styling is done.

thumbsget4web is installed on my website and you can use it here: https://drew-naylor.com/projects/thumbsget4web/thumbsget4web.html

## Limitations

thumbsget4web has a limitation where it can't actually save thumbnails directly with a "Save thumbnail" button, so the user has to manually save the thumbnails, either by right-clicking on the preview image or by right-clicking on the image in a new tab, then clicking "Save image as" or similar. This limitation is imposed by most web browsers ignoring the `download` attribute for the `anchor` tag if going across domains for security purposes.

Additionally, thumbsget4web will *not* work in Internet Explorer. This has been tested in IE11, but it's assumed that it won't work in older versions either. The reason is that IE doesn't support one of the JavaScript functions used to determine what to change in the video URL (`includes`, to be specific). This could be fixed by [polyfilling the function](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/includes#Polyfill), but I don't want to do that since barely anyone uses IE anymore.


## Screenshot

![](../docs/images/thumbsget4web-screenshot-with-preview.png?raw=true)


## Recent updates

### Version 0.2.0.0 - July 10, 2019:

Quite a bit of the work in 0.2 was focused on making the UI look better, and in some cases, almost like the desktop version. The thumbnail preview is still below the buttons rather than on the side. This is both because I can't figure out how to make it look nice while moving it over to the right side, and also being an easier way for mobile users to interact with the UI in my opinion. Desktop users might not be bothered with horizontal space being taken up, while it's precious on mobile for anyone who doesn't rotate their device.

- Added:
  - Almost everything looks better as CSS is now being used instead of the default HTML styling. What changes:
    - The text is now using Arial or sans-serif fonts, depending on which is available. They're sized at 13 pixels, so increasing the size may be required, but I don't really know yet.
	- Video URL textbox is now longer to usually match the thumbnail preview image box. Had an issue in mobile Safari where it kinda went over the edge with 100% max width.
	- Buttons should now match the size of the buttons on the Windows version of thumbsget, at least on Windows 10 and in Firefox.
	- There are a few places that the UI is responsive now, and those are the textbox length, the thumbnail preview image box, and the checkbox to use hqdefault.
	- Some margins have been added between the controls to space them out a bit.
  - More meta tags have been added to describe thumbsget4web better, such as description, application name, author, and a few other things.
  - Proper boilerplate text has also been added.
- Changed:
  - Video URL textbox has been moved to its own line below the "Video URL:" label to make it closer to the desktop version in appearance.
  - The description in the About message has been updated to mention both maxres and hq versions of the thumbnails as being what it can get.
- Fixed:
  - On mobile/small screen devices, the thumbnail preview now resizes itself to stay within the edges of the display so you don't have to scroll horizontally to see the rest of the preview. This is also visible when resizing a desktop browser window to be smaller in width than the main UI would be.
  - The thumbnail preview image box now has an alt text attribute that shows up if an image isn't loaded or images are disabled.
  - There was a typo in the "Video URL:" label where its "for" attribute was using a colon instead of an equals sign.

### Version 0.1.2.0 - July 9, 2019:

- Fixed:
  - On mobile/small screen devices, the UI will now be properly sized so that you don't have to zoom in to use it easier. Desktop/large screen devices don't seem to have much of a difference.

### Version 0.1.1.0 - July 4, 2019:

- Added:
  - Now the hqdefault thumbnail can be used instead of maxresdefault in case there's no maxresdefault thumbnail available for a particular video.
- Changed:
  - The noscript tag has been updated to mention that there's a Mac version of thumbsget and that the Windows version can be run on Linux with .Net 4.6.1 installed, which can be done with winetricks.
- Fixed:
  - Clicking "View thumbnail in new tab" works in thumbsget4web even if the textbox is blank. This shouldn't happen so that it's consistent with the desktop versions. (Fixed in c55f9dd. See [#4](https://github.com/DrewNaylor/thumbsget/issues/4) for more details.)
