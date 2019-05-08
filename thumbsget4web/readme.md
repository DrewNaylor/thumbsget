# thumbsget4web

This is a port of thumbsget to a webpage that uses JavaScript to show the thumbnails in the preview box.

For now, it won't look very good until some CSS styling is done.

At some point, this will probably be installed on my website so that people can use it without having to download the HTML file first.

## Limitations

thumbsget4web has a limitation where it can't actually save thumbnails directly with a "Save thumbnail" button, so the user has to manually save the thumbnails, either by right-clicking on the preview image or by right-clicking on the image in a new tab, then clicking "Save image as" or similar. This limitation is imposed by most web browsers ignoring the `download` attribute for the `anchor` tag if going across domains for security purposes.

Screenshot:

![](../docs/images/thumbsget4web-screenshot-with-preview.png?raw=true)
