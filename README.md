Simple Syncfusion Notifications (Toasts) Module For Oqtane

The base module is the standard output created using the Oqtane Admin Console.

To compile:

1. Clone this repository and Oqtane.Framework to c:\    (https://github.com/oqtane/oqtane.framework)
2. Open the Oqtane.Framework visual studio solution and rebuild all.    Run the solution and install Oqtane per their instructions.
3. Rebuild this module's solution and the 'package' project will copy the require .dll and other resources to the oqtane.framework.    (if you use a different path you must edit the debug.cmd file)
4. Run the module (IIS) and Oqtane will launch and the module should be visible from the admin console.
5. To add the module to the UI, add a page and then add the SyncfusionNotifications module to the page.

This has been tested with Oqtane 5.2.1 - 5.2.3 and Syncfusion 27.1.51 as of 10/10/2024.

Known issues:
 The toasts do not always display on first load of the page.   Refreshing or shift-refreshing will usually cause it to load.
 Toasts are not visible in some areas of the screen - an example is when set to the top right.   This seems like a layering issue.   I have had some success in this sample, setting a toast target to the id of the toast div but in my other projects it does not always work.
