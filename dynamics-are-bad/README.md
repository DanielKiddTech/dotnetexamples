# Dynamics are bad

This is a simple .NET 6 console application that has been put together to shown that when **dynamic** types are being used, internal errors are being thrown that are never surfaced.

## How to use

Run the product **dynamics-are-bad** in Visual Studio, when the console loads, enter the number of times you wish to loop, press enter and then enter the number of parallel threads you wish to loop.  This was a crude way to try and simulate a system under stress.

The console will output some data retrieved from a local repository and, if there were any errors, they will also be shown.  The errors are also looked to a local errorlog.txt file, which will be in the debug folder for the solution.

The aim of this repository was to show the following error being logged:

*'System.Dynamic.ExpandoObject' does not contain a definition for 'Description'.    at Microsoft.CSharp.RuntimeBinder.RuntimeBinder.BindProperty(ICSharpBinder payload, ArgumentObject argument, LocalVariableSymbol local, Expr optionalIndexerArguments)*

Which appears to be an internal error when using dynamics that has caused me numerous problems when running in a production environment.