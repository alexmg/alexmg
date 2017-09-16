Title: "WSCF.blue V1 Final Released"
Published: 2009-09-30 04:23:18
RedirectFrom: wscfblue-v1-final-released
Tags:
  - web-services
  - wscf
---
[![image](/posts/images/WSCF-logo-thumb.png "image")](/posts/images/WSCF-logo.png)

The team is very pleased to announce that [WSCF.blue](http://wscfblue.codeplex.com/) has achieved the important V1 milestone. Thank you to everyone who provided feedback in the form of suggestions and bug reports. This input has really helped us improve the stability of WSCF.blue and increase the available feature set. It has also given us many other good ideas that will no doubt be rolled into future releases.

The primary feature set for [WSCF.blue V1](http://wscfblue.codeplex.com/Release/ProjectReleases.aspx?ReleaseId=33783#ReleaseFiles) includes the following:

-   A **WSDL Wizard** that allows the developer to step through the creation of a WSDL from one or more XSDs.
-   A **Data Contract Generator** (similar to XSD.exe, XSDObjectGen.exe and SvcUtil.exe) that generates the .NET equivalent of the XSD types.
-   A **Service/Endpoint Stub (SVC) Generator** and
-   A **Client Proxy Generator**.
-   A **Generate Data Contract Code** feature that supports the selection of multiple XSD/WSDL source files. ([More Information](http://alexmg.com/post/2009/09/01/Data-contract-generation-is-now-available-in-WSCFblue.aspx))
-   A **Paste XML as Schema** option that generates a schema for a block of XML in the clipboard. ([More Information](http://alexmg.com/post/2009/09/21/Paste-XML-as-Schema-in-WSCFblue.aspx))
-   Support for **C\#** and **VB.NET** code generation.
-   You can choose if operation methods on your service class will throw a *NotImplementedException*, call an implementation method in a partial class, or will be defined as abstract methods. ([More Information](http://alexmg.com/post/2009/08/08/Controlling-your-Service-method-implementation-in-WSCFblue.aspx))
-   Force the SOAP actions (*Action* and *ReplyAction*) applied to each operation contract follow the standard WCF format: *\<namespace\>/\<service\>/\<operation\>[Response]*
-   Errors found in your WSDL are reported in a WSCF.blue pane in the Output window. ([More Information](http://alexmg.com/post/2009/09/28/Improved-WSDL-error-handling-in-WSCFblue.aspx))

Like many other open source projects, I have found WSCF ([classic](http://www.codeplex.com/WSCFclassic) and [blue](http://wscfblue.codeplex.com/) versions) to be invaluable over the years. It feels good to give something back to the .NET open source community that has provided me with such a wide range of free and quality software to choose from. Thanks to WSCF.blue contract-first web service development in WCF for .NET developers is easily achievable. Please keep the feedback coming in and enjoy the release.
