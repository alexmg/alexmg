Title: "Improved WSDL error handling in WSCF.blue"
Published: 2009-09-28 04:29:37
RedirectFrom: improved-wsdl-error-handling-in-wscfblue
Tags:
  - web-services
  - wscf
---
I finally got around to making one of those improvements to [WSCF.blue](http://wscfblue.codeplex.com/) that has been calling out for my attention for a while. It was to improve the error handling when the WSDL selected for **Client-side proxy** or **Service-side stub** code generation contains errors that will cause the process to fail.

Previously, you would receive an exception and stack trace that unfortunately did not provide the details required to determine what was actually wrong with your WSDL. Now when these errors are encountered a message box will inform you of the problem and direct your attention to the new **WSCF.blue** pane in the **Output** window where you can see all the error details.

![WSDL errors in the Output window.](/posts/images/Output-window.png)

As you can see in the screen capture above the error messages are very descriptive and informative, and in fact are the same as those returned from **svcutil.exe**. I am sure you always get your WSDL correct first go (especially with the help of WSCF.blue), but just in case your having one of those days, this should help you out.
