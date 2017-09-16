Title: "ReSharper 4.5.1 Maintenance Release"
Published: 2009-07-26 00:22:15
RedirectFrom: resharper-451-maintenance-release
Tags:
  - resharper
---
![image](/posts/images/ReSharper-logo.png "image")
[JetBrains](http://www.jetbrains.com/index.html) have made a 4.5.1 maintenance release of ReSharper available for [download](http://www.jetbrains.com/resharper/download/?rss). It is a
free upgrade from any 4.x version, and the [Release Notes](http://www.jetbrains.com/resharper/features/releaseNotes451.html) indicate that a large number of bugs have been addressed. Despite [some issues](http://alexmg.com/post/2009/03/17/JetBrains-ReSharper-45-Beta-Uninstalled.aspx) I had with the Beta version I happily found the 4.5 release to be stable. I have been regularly testing the [nightly builds](http://www.jetbrains.net/confluence/display/ReSharper/ReSharper+4.5+Nightly+Builds) and think that 4.5.1 will be a stable and reliable release.

A couple of highlights for me are that the default Naming Style rules have certainly been improved, with more options available for both private and non-private accessible members. Also, method names with an underscore are no longer considered erroneous, which was a problem for auto-generated event handlers in Visual Studio. It was also a problem if your unit test naming convention involves the use of underscores as a separator, like this one [recommended](http://weblogs.asp.net/rosherove/archive/2005/04/03/TestNamingStandards.aspx) by [Roy Osherove](http://weblogs.asp.net/rosherove/default.aspx).
