// I download the image from https://www.flickr.com/photos/cameralabs/12382975864/in/photostream/
// This image contains a location info.

using ImageMagick;

using var image = new MagickImage("images/flickr.jpg");

var exifProfile = image.GetExifProfile();
var iptcProfile = image.GetIptcProfile();
var xmpProfile = image.GetXmpProfile();

if(exifProfile != null) image.RemoveProfile(exifProfile);
if(iptcProfile != null) image.RemoveProfile(iptcProfile);
if(xmpProfile != null) image.RemoveProfile(xmpProfile);

await image.WriteAsync("images/flickr-without-metadata.jpg");