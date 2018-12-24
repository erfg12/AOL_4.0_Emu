I'm trying to emulate AOL 4.0 with C# Winforms and Chromium (cefsharp).

Compile with `x64` or `x86` targets as `Any Cpu` will not compile for cefsharp. Right click on the project and Restore Nuget Packages, then close and re-open the project.

CEFSharp requires [VC++ 2015 Redistributable](https://www.microsoft.com/en-us/download/details.aspx?id=52685)

![](https://media.discordapp.net/attachments/376865174570926090/504482148716249128/Capture.PNG)

Here's a compressed animated gif of the dial up, loading animation and MIE badge:

![](https://media.discordapp.net/attachments/376865174570926090/505471134163009536/aol_loading_image.gif?width=969&height=606)
