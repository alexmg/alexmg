Title: "WSCF.blue V1.0.6 Update"
Published: 2010-02-18 01:20:45
RedirectFrom: wscfblue-v106-update
Tags:
  - web-services
  - wscf
---
There is now a [V1.0.6 update](http://wscfblue.codeplex.com/releases/view/40685) for WSCF.blue that includes fixes for a number of bugs that have been reported since the V1.0.5 release. It has taken some large and complex contracts to uncover some of the more obscure bugs. Below is a list of the bugs that have been fixed:

-   The data contract type filter was not including all the required types in some complex contracts.
-   When adjusting the casing of enumeration members references in `DefaultValue` attributes and constructors were not being updated.
-   When using the **List\<T\>** option along with the **Public properties** option the backing field used for properties was sometimes left as an array instead of a generic list.
-   When using the **List\<T\>** option along with the **Public properties** option the backing field used for properties with an `XmlChoiceIdentifier` attribute was converted to a generic list instead of being left as an array to match the property.
-   Fixed an **Adjust casing** bug related to enumeration values that cannot be used as valid property names. The `XmlEnumAttribute` was being set to the generic *ItemX* property name instead of being left with the value from the original enumeration.

If you have any problems with the update please let us know through the [Issue Tracker](http://wscfblue.codeplex.com/WorkItem/List.aspx). Thanks to everyone who has reported bugs.
