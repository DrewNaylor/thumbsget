# thumbsget4mac

This is an official port of thumbsget to macOS using Visual Studio for Mac's Cocoa C# template.

It's very similar to thumbsget, except that the About window is shown using the one in the macOS menu bar instead of a button on the form. As of May 8, 2019, it has feature parity with the Windows version of thumbsget.

It requires at least macOS 10.13 High Sierra, and is being developed using Visual Studio Community 2019 for Mac along with Xcode 10.1. Previous versions of Xcode can be downloaded from the "other downloads" section on the Apple developer website, and they didn't seem to require payment.

Please be aware that it may use more memory and storage than the Windows version due to using Mono, .Net, Xamarin.Mac, and other related stuff, and having those things be either compiled or linked into the binary.


To open this project in Visual Studio, please use `./thumbsget4mac/thumbsget4mac.sln` 


Screenshot:

![](../docs/images/thumbsget4mac-with-preview-and-thumbnail-in-firefox.png?raw=true)
