<img src="./joppes_hundarUI.png">

Naviate to the DarkUI folder <br />
Compile the DarkUI app with the reference JoppesLib.dll and the target is windows executable file no console in the background<br />
mcs *.cs -pkg:dotnet -r:JoppesLib.dll -t:winexe<br />
mono Form1.exe <br />
<br />
create a class lib and compile as a library<br />
dotnet new classlib -o backend <br />
mcs -t:library JoppesLib.cs
