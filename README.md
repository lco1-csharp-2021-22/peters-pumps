# Peter's Pumps

This is based on a (very) old AS Level paper. There are several moving parts for the requirements of this assignment, as laid out in points 1-6 in the PDF. In addition: 
a GUI thrown on top and (optionally) saving to a file.  

(In these old days, you were given this specification and allowed to take in code into the exam. You were then asked questions, for which your prepared work might have been useful.) 

The tough bit here is the visualisation of the output via a GUI app (think back to the WinForms OOPDraw work) perhaps use "simple" line drawing to mimic the 7-segment LEDs (see links attached for assistance) or some other visual analogy.

You could choose to use either one form/windows split into multiple sections for the pump and output console or, better, in completely separate windows. You are free to use whichever graphics library you wish - WinForms, WPF or even [Avalonia](https://avaloniaui.net/).   

Your solution should have multiple projects:
- a class library containing the useful objects and the calculations/logic 
- a unit test project to test the various aspects of the classes  
- a GUI application to contain the window that uses the objects  
- (optionally) a Console App that mimics the GUI functionality from the command line

Some things to consider:
- handling events to mimic the actions in the GUI 
- storing data in a text file / JSON / Database (?!) to be able to save and load sessions 
- sketch/wireframe the possible windows 
- how to test it is working 

### Possibly useful links

- [Drawing a line in C# WinForms](http://stackoverflow.com/questions/5278149/draw-line-in-c-sharp)
- [More general C# drawing](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/graphics-and-drawing-in-windows-forms?view=netframeworkdesktop-4.8)
- [WPF Hello World](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-wpf?view=vs-2022)
- [Mac UI](https://docs.microsoft.com/en-us/xamarin/mac/get-started/hello-mac)
